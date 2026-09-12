using System.Reflection;

namespace BmSDK.Framework.Redirection;

/// <summary>
/// A class managing the creation, retrieval, execution and deletion of detours to in-game functions
/// which only apply to UObjects with specific <see cref="ScriptComponent{TClass}"/>s attached.
/// DO NOT INSTANTIATE! USE <see cref="RedirectManager.Local"/> INSTEAD.
/// </summary>
internal sealed class LocalRedirectManager(BindingFlags genericRedirSearchFlags)
{
    private readonly BindingFlags _localRedirSearchFlags =
        BindingFlags.Instance | genericRedirSearchFlags;

    /// <summary>
    /// Maps ScriptComponent types to Lists of CachedLocalRedirector instances.
    /// One object is created per method marked with <see cref="ComponentRedirectAttribute"/>.
    /// This is done to reduce reflection on ScriptComponent attach.
    /// </summary>
    private readonly Dictionary<
        Type,
        List<CachedLocalRedirector>
    > _cachedLocalRedirDefinitionDict = [];

    /// <summary>
    /// Maps pointers to target UObjects and declaring function paths of redirected functions
    /// to LocalRedirectorInfo instances. This allows for per UObject/ScriptComponent function redirects.
    /// </summary>
    private readonly Dictionary<
        (IntPtr ObjPtr, string FuncPath),
        List<LocalRedirectorInfo>
    > _localRedirsDict = [];

    /// <summary>
    /// Maps ScriptComponents to Lists of keys for <see cref="_localRedirsDict"/>.
    /// This is used for cleanup inside of <see cref="GameObject.DetachScriptComponent(IScriptComponent)"/>
    /// </summary>
    private readonly Dictionary<IScriptComponent, List<(IntPtr, string)>> _componentRedirsDict = [];

    /// <summary>
    /// Finds and stores component redirector methods defined on the specified ScriptComponent type.
    /// That's done by searching for methods with the <see cref="ComponentRedirectAttribute"/>.
    /// This method is used to prevent repeated reflection on ScriptComponent attachment.
    /// </summary>
    /// <param name="componentType">The type that contains methods to be registered as local redirectors.
    /// The function doesn't check if the type inherits ScriptComponent. One must do it on the call site.</param>
    /// <param name="targetType">The target in-game type for which redirector methods are being registered.</param>
    /// <exception cref="InvalidOperationException">Thrown if the same ScriptComponent is cached twice.</exception>
    public void CacheRedirectors(Type componentType, Type targetType)
    {
        List<CachedLocalRedirector> redirectors = [];

        foreach (var func in componentType.GetMethods(_localRedirSearchFlags))
        {
            var redirAttr = func.GetCustomAttribute<ComponentRedirectAttribute>();
            if (redirAttr == null)
            {
                continue;
            }

            // Get actual path that will be called by UE3
            var targetFuncPath = StaticInit.GetDeclaringFuncPath(
                targetType,
                redirAttr.TargetMethod
            );

            RedirectManager.QueueConfigureFunction(targetFuncPath);
            redirectors.Add(new CachedLocalRedirector(targetType, targetFuncPath, func));
        }

        if (redirectors.Count == 0)
        {
            return;
        }

        if (!_cachedLocalRedirDefinitionDict.TryAdd(componentType, redirectors))
        {
            throw new InvalidOperationException(
                "Tried to cache a ScriptComponent type's redirectors twice."
            );
        }
    }

    /// <summary>
    /// Registers one function detour for a specific UObject.
    /// </summary>
    /// <param name="component">ScriptComponent that adds the redirectors to the UObject.
    /// The script component must already be attached!</param>
    /// <param name="cachedRedir">The redirect to register</param>
    private void RegisterRedirector(IScriptComponent component, CachedLocalRedirector cachedRedir)
    {
        var key = (component.Owner.Ptr, cachedRedir.FuncPath);

        var info = new LocalRedirectorInfo(
            component,
            cachedRedir.RedirectMethod,
            cachedRedir.Invoker
        );

        // Track redirs per object for easy searches in ProcessInternal
        if (!_localRedirsDict.TryGetValue(key, out var infos))
        {
            infos = [];
            _localRedirsDict[key] = infos;
        }

        infos.Add(info);

        // Track redirs per ScriptComponent instance for cleanup
        if (!_componentRedirsDict.TryGetValue(component, out var keys))
        {
            keys = [];
            _componentRedirsDict[component] = keys;
        }

        keys.Add(key);
    }

    /// <summary>
    /// Registers every redirect defined in the given ScriptComponent to its Owner.
    /// ENSURE THAT The COMPONENT IS ONLY ATTACHED ONCE AT THE CALL SITE.
    /// </summary>
    /// <param name="component">The ScriptComponent of which to register the
    /// local redirectors from. It should already be attached.</param>
    public void RegisterComponentRedirectors(IScriptComponent component)
    {
        // Skip registration if no redirects defined
        if (!_cachedLocalRedirDefinitionDict.TryGetValue(component.GetType(), out var redirs))
        {
            return;
        }

        foreach (var redir in redirs)
        {
            RegisterRedirector(component, redir);
        }
    }

    /// <summary>
    /// Gets any redirections for the given function path if it applies to the given GameObject.
    /// </summary>
    /// <returns>List of object representing the registered local redirect.
    /// The collection is empty if there are non</returns>
    public IEnumerable<LocalRedirectorInfo> GetRedirectors(GameObject obj, string funcPath)
    {
        var key = (obj.Ptr, funcPath);

        if (_localRedirsDict.TryGetValue(key, out var infos))
        {
            return infos;
        }

        return [];
    }

    /// <summary>
    /// Executes a local redirect from its record instance and the data available in UObject::ProcessInternal().
    /// </summary>
    public unsafe void ExecuteRedirector(
        LocalRedirectorInfo localRedirInfo,
        GameObject selfObj,
        Function funcObj,
        FFrame* stackPtr,
        IntPtr Result
    )
    {
        var redirFunc = localRedirInfo.RedirectMethod;

        // Marshal args
        var args = stackPtr->ParamsToManaged(localRedirInfo.ParamTypes);

        // Execute detour
        var result = localRedirInfo.Invoker.Invoke(obj: localRedirInfo.Component, arguments: args);

        // Pass any by-ref args back to the caller
        stackPtr->RefParamsToUnmanaged(localRedirInfo.ParamTypes, args, 0);

        // Marshal result back (if non-void)
        if (result != null && redirFunc.ReturnType != typeof(void))
        {
            MarshalUtil.ToUnmanaged(result, Result, redirFunc.ReturnType);
        }
    }

    /// <summary>
    /// Unregisteres all redirects associated with a ScriptComponent and it's Owner.
    /// Used when ScriptComponents are detached.
    /// </summary>
    public void UnregisterComponentRedirectors(IScriptComponent component)
    {
        if (!_componentRedirsDict.TryGetValue(component, out var keys))
        {
            return;
        }

        foreach (var key in keys)
        {
            var redirects = _localRedirsDict[key].Where(redir => redir.Component != component);
            if (redirects.Any())
            {
                _localRedirsDict[key] = redirects.ToList();
            }
            else
            {
                _localRedirsDict.Remove(key);
            }
        }

        _componentRedirsDict.Remove(component);
    }

    /// <summary>
    /// Clears cached redirector definitions for component types belonging to the specified assembly.
    /// </summary>
    public void ClearCacheForAssembly(Assembly asm)
    {
        var keysToRemove = _cachedLocalRedirDefinitionDict.Keys
            .Where(t => t.Assembly == asm)
            .ToList();

        foreach (var key in keysToRemove)
        {
            _cachedLocalRedirDefinitionDict.Remove(key);
        }
    }

    /// <summary>
    /// Clears the backing redirector dictionaries, therefore, uninstalling all local redirects.
    /// </summary>
    public void UnregisterAll()
    {
        _cachedLocalRedirDefinitionDict.Clear();
        _localRedirsDict.Clear();
        _componentRedirsDict.Clear();
    }
}
