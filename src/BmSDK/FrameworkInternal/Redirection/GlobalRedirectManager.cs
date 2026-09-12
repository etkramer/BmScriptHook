using System.Reflection;

namespace BmSDK.Framework.Redirection;

/// <summary>
/// A class managing the creation, retrieval, execution and deletion of detours to in-game functions.
/// The redirectors apply globally and unconditionally to all instances.
/// DO NOT INSTANTIATE! USE <see cref="RedirectManager.Global"/> INSTEAD.
/// </summary>
internal sealed class GlobalRedirectManager(BindingFlags genericRedirSearchFlags)
{
    private readonly BindingFlags _globalRedirSearchFlags =
        BindingFlags.Static | genericRedirSearchFlags;

    /// <summary>
    /// Maps declaring function paths to GlobalRedirectorInfo objects which contain
    /// the target class and the delegate of the detour.
    /// </summary>
    private readonly Dictionary<string, List<GlobalRedirectorInfo>> _globalRedirsDict = [];

    /// <summary>
    /// Registers all functions marked with a <see cref="RedirectAttribute"/> in a given assembly.
    /// </summary>
    public void RegisterRedirectors(Assembly asm)
    {
        foreach (var type in asm.GetTypes())
        {
            foreach (var func in type.GetMethods(_globalRedirSearchFlags))
            {
                foreach (var redirAttr in func.GetCustomAttributes<RedirectAttribute>())
                {
                    RegisterRedirector(redirAttr, func);
                }
            }
        }
    }

    /// <summary>
    /// Registers a delegate as a redirector for the given in-game function.
    /// </summary>
    /// <param name="redirAttr">Attribute containing metadata for registration</param>
    /// <param name="redirectMi">The MethodInfo of the custom detour</param>
    /// <exception cref="ArgumentException">Thrown if the target class does not inherit GameObject.
    /// Only methods of in-game classes may be overriden.</exception>
    /// <exception cref="InvalidOperationException">Thrown if the exact redirect method,
    /// has been attached to the same function path again.</exception>
    private void RegisterRedirector(RedirectAttribute redirAttr, MethodInfo redirectMi)
    {
        var targetType = redirAttr.TargetType;

        // Prevent creation of invalid redirects
        if (!targetType.IsAssignableTo(typeof(GameObject)))
        {
            throw new ArgumentException(
                $"{targetType.FullName} is not a managed type of"
                    + $"an in-game unmanaged type and cannot be redirected."
            );
        }

        // Get the full path of the function (as originally declared).
        var declaringFuncPath = StaticInit.GetDeclaringFuncPath(targetType, redirAttr.TargetMethod);

        // Store the redirect for later use.
        var redirInfo = new GlobalRedirectorInfo(
            targetType,
            redirAttr.AllowSubtypes,
            redirectMi,
            redirectMi.DeclaringType!.Assembly
        );

        // Add new redirect to the target function's redirect list
        if (_globalRedirsDict.TryGetValue(declaringFuncPath, out var redirects))
        {
            // Prevent the same managed function from being used on the same target type
            // as that would likely be a bug
            if (
                redirects.Any(r =>
                    r.RedirectMethod == redirInfo.RedirectMethod
                    && r.TargetType == redirInfo.TargetType
                )
            )
            {
                throw new InvalidOperationException(
                    $"{redirInfo} has already been registered once on {declaringFuncPath}!"
                );
            }
        }
        else
        {
            redirects = [];
            _globalRedirsDict[declaringFuncPath] = redirects;
        }

        RedirectManager.QueueConfigureFunction(declaringFuncPath);
        redirects.Add(redirInfo);
    }

    /// <summary>
    /// Gets any redirections for the given function path if it applies to the given GameObject.
    /// </summary>
    /// <returns>Objects representing the registered global redirects.
    /// The collection may be empty if there are no redircts.</returns>
    public IEnumerable<GlobalRedirectorInfo> GetRedirectors(GameObject obj, string funcPath)
    {
        if (!_globalRedirsDict.TryGetValue(funcPath, out var infos))
        {
            return [];
        }

        var objType = obj.GetType();

        return infos.Where(info =>
        {
            if (info.AllowSubtypes)
            {
                return objType.IsAssignableTo(info.TargetType);
            }
            else
            {
                return objType == info.TargetType;
            }
        });
    }

    /// <summary>
    /// Executes a global redirect from its record instance and the data available in UObject::ProcessInternal().
    /// </summary>
    public unsafe void ExecuteRedirector(
        GlobalRedirectorInfo redirInfo,
        GameObject selfObj,
        Function funcObj,
        FFrame* stackPtr,
        IntPtr Result
    )
    {
        var redirMethod = redirInfo.RedirectMethod;
        var paramTypes = redirInfo.GetParamTypes(funcObj);

        // Marshal args, add self as first arg if needed.
        var argOffset = funcObj.IsStatic ? 0 : 1;
        var args = stackPtr->ParamsToManaged(paramTypes);
        if (argOffset > 0)
        {
            args = args.Prepend(selfObj).ToArray();
        }

        // Execute detour. The invoker writes by-ref args back into this array, so keep hold of it.
        var result = redirInfo.Invoker.Invoke(obj: null, arguments: args);

        // Pass any by-ref args back to the caller
        stackPtr->RefParamsToUnmanaged(paramTypes, args, argOffset);

        // Marshal result back (if non-void)
        if (result != null && redirMethod.ReturnType != typeof(void))
        {
            MarshalUtil.ToUnmanaged(result, Result, redirMethod.ReturnType);
        }
    }

    /// <summary>
    /// Unregisters all global redirectors originating from the specified assembly.
    /// </summary>
    public void UnregisterRedirectors(Assembly asm)
    {
        var emptyKeys = new List<string>();
        foreach (var (funcPath, redirects) in _globalRedirsDict)
        {
            redirects.RemoveAll(r => r.SourceAssembly == asm);
            if (redirects.Count == 0)
            {
                emptyKeys.Add(funcPath);
            }
        }

        foreach (var key in emptyKeys)
        {
            _globalRedirsDict.Remove(key);
        }
    }

    /// <summary>
    /// Clears the backing redirector dictionary, therefore, uninstalling all global redirects.
    /// </summary>
    public void UnregisterAll() => _globalRedirsDict.Clear();
}
