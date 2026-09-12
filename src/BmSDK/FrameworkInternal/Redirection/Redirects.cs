using System.Reflection;

namespace BmSDK.Framework.Redirection;

/// <summary>
/// Defines the API contract for any kind of redirect no matter the backing implementation.
/// This is used to generalize global and local redirects when queuing them in
/// <see cref="RedirectManager.AcquireRedirects(GameObject, string)"/>.
/// </summary>
internal interface IGenericRedirect
{
    /// <summary>
    /// Invoker to the actual custom implementation of the redirected function.
    /// </summary>
    MethodInvoker Invoker { get; }

    /// <summary>
    /// Function called from within the UObject::ProcessInternal() context to execute the redirect.
    /// </summary>
    unsafe void Run(GameObject selfObj, Function funcObj, FFrame* stackPtr, IntPtr Result);
}

/// <summary>
/// Record storing data of a currently registered global redirect necessary to execute it.
/// </summary>
/// <param name="TargetType">Type that the redirect applies to</param>
/// <param name="AllowSubtypes">Whether child classes of <paramref name="TargetType"/>
/// should be redirected too</param>
/// <param name="RedirectMethod">Method to call on redirect</param>
/// <param name="SourceAssembly">Mod which registered this redirect</param>
internal sealed record GlobalRedirectorInfo(
    Type TargetType,
    bool AllowSubtypes,
    MethodInfo RedirectMethod,
    Assembly SourceAssembly
) : IGenericRedirect
{
    public MethodInvoker Invoker { get; } = MethodInvoker.Create(RedirectMethod);

    private Type[]? _paramTypes;

    public Type[] GetParamTypes(Function func)
    {
        _paramTypes ??= RedirectMethod
            .GetParameters()
            .Select(param => param.ParameterType)
            .Skip(func.IsStatic ? 0 : 1)
            .ToArray();

        return _paramTypes;
    }

    public unsafe void Run(GameObject selfObj, Function funcObj, FFrame* stackPtr, nint Result) =>
        RedirectManager.Global.ExecuteRedirector(this, selfObj, funcObj, stackPtr, Result);
}

/// <summary>
/// Record storing data of a currently registered local redirect necessary to execute it.
/// </summary>
/// <param name="Component">The ScriptComponent that declares the redirect</param>
/// <param name="RedirectMethod">Method to call on redirect</param>
/// <param name="Invoker">The cached invoker of the redirect method</param>
internal sealed record LocalRedirectorInfo(
    IScriptComponent Component,
    MethodInfo RedirectMethod,
    MethodInvoker Invoker
) : IGenericRedirect
{
    /// <summary>
    /// Gathers managed parameter types using the redirector
    /// </summary>
    public Type[] ParamTypes { get; } =
        RedirectMethod.GetParameters().Select(param => param.ParameterType).ToArray();

    public unsafe void Run(GameObject selfObj, Function funcObj, FFrame* stackPtr, nint Result) =>
        RedirectManager.Local.ExecuteRedirector(this, selfObj, funcObj, stackPtr, Result);
}

/// <summary>
/// Record storing data necessary to register local redirects when a ScriptComponent is attached.
/// This is used to avoid unnecessary repeated reflection.
/// </summary>
/// <param name="TargetType">Type that the redirect applies to</param>
/// <param name="FuncPath">The UE3 declaration path of the method to redirect.
/// If the method is not defined in <see cref="TargetType"/>, path could lead to super.</param>
/// <param name="RedirectMethod">Method to call on redirect</param>
internal readonly record struct CachedLocalRedirector(
    Type TargetType,
    string FuncPath,
    MethodInfo RedirectMethod
)
{
    public MethodInvoker Invoker { get; } = MethodInvoker.Create(RedirectMethod);
}

/// <summary>
/// Record storing the data necessary to call multiple redirectors recursively.
/// Used in <see cref="RedirectManager.ExecuteRedirector(GameObject, Function, string, FFrame*, nint)"/>.
/// </summary>
/// <param name="TargetObj">Object the method is run on</param>
/// <param name="TargetFunc">Method being redirected</param>
/// <param name="Redirs">Each redirect that still exists for the
/// particular call of <paramref name="TargetFunc"/></param>
internal sealed record RedirectCall(
    GameObject TargetObj,
    Function TargetFunc,
    IGenericRedirect[] Redirs
)
{
    private int _currIndex = 0;

    public IGenericRedirect? NextRedirect() =>
        _currIndex < Redirs.Length ? Redirs[_currIndex++] : null;

    public unsafe void RunOriginal(FFrame* stackPtr, IntPtr result)
    {
        // Copy over args to new buffer for call to original function
        var argsPtr = stackalloc byte[TargetFunc.PropertiesSize];
        stackPtr->CopyParams((IntPtr)argsPtr, intoBuffer: true);

        // Call the actual target function and not an override
        GameFunctions.ProcessEvent(
            TargetObj.Ptr,
            TargetFunc.Ptr,
            (IntPtr)argsPtr,
            IntPtr.Zero
        );

        // Pass out params written by the original back to the caller
        stackPtr->CopyParams((IntPtr)argsPtr, intoBuffer: false);

        // If there is a return value, pass it through
        var returnField = TargetFunc.GetReturnParam();
        if (returnField is not null)
        {
            Buffer.MemoryCopy(
                argsPtr + returnField.Offset,
                result.ToPointer(),
                returnField.ElementSize,
                returnField.ElementSize
            );
        }
    }
}
