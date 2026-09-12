#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: R3rdPersonCamera<br/>
/// (size = 13044)
/// (flags = 144703646)
/// </summary>
public partial class R3rdPersonCamera : BmSDK.Engine.Camera, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.R3rdPersonCamera", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as R3rdPersonCamera.
    /// </summary>
    public static R3rdPersonCamera DefaultObject => (R3rdPersonCamera)StaticClass().DefaultObject;

    internal R3rdPersonCamera() { }

    /// <summary>
    /// Constructs a new R3rdPersonCamera
    /// </summary>
    public R3rdPersonCamera(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected R3rdPersonCamera(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<R3rdPersonCamera>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: UpdateCameraPosition
    /// </summary>
    public unsafe virtual void UpdateCameraPosition(float DeltaTime, bool ProperReset = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateCameraPosition", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProperReset, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: GetYawAnchorRotation
    /// </summary>
    public unsafe virtual BmSDK.Rotator GetYawAnchorRotation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.GetYawAnchorRotation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetTunnelCameraDirection
    /// </summary>
    public unsafe virtual void GetTunnelCameraDirection(ref System.Numerics.Vector3 InDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.GetTunnelCameraDirection", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDirection, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        InDirection = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: SetOverrideMotionBlur
    /// </summary>
    public unsafe virtual void SetOverrideMotionBlur(float NewMBAmount, float MBTransitionTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetOverrideMotionBlur", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMBAmount, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MBTransitionTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetOverrideFOV
    /// </summary>
    public unsafe virtual void ResetOverrideFOV(float FOVTransitionTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ResetOverrideFOV", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOVTransitionTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetOverrideFOV
    /// </summary>
    public unsafe virtual void SetOverrideFOV(float NewFOV, float FOVTransitionTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetOverrideFOV", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOVTransitionTime, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetTargetActor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Actor GetTargetActor()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.GetTargetActor", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UnlockCamera
    /// </summary>
    public unsafe virtual void UnlockCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UnlockCamera", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LockCamera
    /// </summary>
    public unsafe virtual void LockCamera(float LockedTime = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LockCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LockedTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOffMotionBlur
    /// </summary>
    public unsafe virtual void TurnOffMotionBlur()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.TurnOffMotionBlur", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FillCameraCache
    /// </summary>
    public unsafe override void FillCameraCache(BmSDK.GameObject.FTPOV NewPOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.FillCameraCache", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideClippingObjects
    /// </summary>
    public unsafe virtual void HideClippingObjects(BmSDK.GameObject.FTPOV NewPOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.HideClippingObjects", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPOV, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: UpdateZoomFocus
    /// </summary>
    public unsafe virtual void UpdateZoomFocus(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateZoomFocus", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: SetViewTarget
    /// </summary>
    public unsafe override void SetViewTarget(BmSDK.Engine.Actor NewViewTarget, BmSDK.Engine.Camera.FViewTargetTransitionParams TransitionParams = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetViewTarget", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewViewTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionParams, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: BlendViewTargets
    /// </summary>
    public unsafe override BmSDK.GameObject.FTPOV BlendViewTargets(BmSDK.Engine.Camera.FTViewTarget A, BmSDK.Engine.Camera.FTViewTarget B, float Alpha)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.BlendViewTargets", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Alpha, paramsPtr + 88);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FTPOV>(paramsPtr + 92);
    }

    /// <summary>
    /// Function: SetRasFOV
    /// </summary>
    public unsafe virtual void SetRasFOV(float NewFOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetRasFOV", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelBlockedZoom
    /// </summary>
    public unsafe virtual void CancelBlockedZoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.CancelBlockedZoom", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelAndBlockZoom
    /// </summary>
    public unsafe virtual void CancelAndBlockZoom(float T = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.CancelAndBlockZoom", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CancelZoom
    /// </summary>
    public unsafe virtual void CancelZoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.CancelZoom", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForceZoomCamera
    /// </summary>
    public unsafe virtual void ForceZoomCamera(float OverrideZoomFOV = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ForceZoomCamera", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideZoomFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ToggleCameraZoom
    /// </summary>
    public unsafe virtual void ToggleCameraZoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ToggleCameraZoom", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ToggleAlternativeWalkCamera
    /// </summary>
    public unsafe virtual void ToggleAlternativeWalkCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ToggleAlternativeWalkCamera", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SettingsChanged
    /// </summary>
    public unsafe virtual void SettingsChanged()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SettingsChanged", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraZoomOut
    /// </summary>
    public unsafe virtual void DebugCameraZoomOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraZoomOut", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraZoomIn
    /// </summary>
    public unsafe virtual void DebugCameraZoomIn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraZoomIn", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraBack
    /// </summary>
    public unsafe virtual void DebugCameraBack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraBack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraForward
    /// </summary>
    public unsafe virtual void DebugCameraForward()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraForward", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraRight
    /// </summary>
    public unsafe virtual void DebugCameraRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraRight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraLeft
    /// </summary>
    public unsafe virtual void DebugCameraLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraUp
    /// </summary>
    public unsafe virtual void DebugCameraUp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraUp", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugCameraDown
    /// </summary>
    public unsafe virtual void DebugCameraDown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DebugCameraDown", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetToPlayerCam
    /// </summary>
    public unsafe virtual void ResetToPlayerCam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ResetToPlayerCam", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatEnableCameraDrag
    /// </summary>
    public unsafe virtual void CombatEnableCameraDrag()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.CombatEnableCameraDrag", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatDisableCameraDrag
    /// </summary>
    public unsafe virtual void CombatDisableCameraDrag(float Time = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.CombatDisableCameraDrag", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableCameraDragHardReset
    /// </summary>
    public unsafe virtual void EnableCameraDragHardReset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.EnableCameraDragHardReset", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableCameraDragHardReset
    /// </summary>
    public unsafe virtual void DisableCameraDragHardReset(float Time = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DisableCameraDragHardReset", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableCameraDrag
    /// </summary>
    public unsafe virtual void EnableCameraDrag()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.EnableCameraDrag", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableCameraDrag
    /// </summary>
    public unsafe virtual void DisableCameraDrag(float Time = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DisableCameraDrag", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Time, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: EnableCameraCollision
    /// </summary>
    public unsafe virtual void EnableCameraCollision()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.EnableCameraCollision", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableCameraCollision
    /// </summary>
    public unsafe virtual void DisableCameraCollision(float DisableTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.DisableCameraCollision", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisableTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideCamRefresh
    /// </summary>
    public unsafe virtual void HideCamRefresh()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.HideCamRefresh", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChangeDof
    /// </summary>
    public unsafe virtual void ChangeDof(BmSDK.BmGame.RDOFManager.FDofStruct newDof)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ChangeDof", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(newDof, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetDof
    /// </summary>
    public unsafe virtual void ResetDof()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ResetDof", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ApplyCameraModifiers
    /// </summary>
    public unsafe override void ApplyCameraModifiers(float DeltaTime, ref BmSDK.GameObject.FTPOV OutPOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ApplyCameraModifiers", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutPOV, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutPOV = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FTPOV>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: ApplyModifiers
    /// </summary>
    public unsafe virtual void ApplyModifiers(float DeltaTime, ref BmSDK.GameObject.FTPOV OutPOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ApplyModifiers", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutPOV, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutPOV = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FTPOV>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.Reset", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EndJumpCam
    /// </summary>
    public unsafe virtual void EndJumpCam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.EndJumpCam", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetGlidingCameraSmoothingStrength
    /// </summary>
    public unsafe virtual float GetGlidingCameraSmoothingStrength(BmSDK.FName StateName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.GetGlidingCameraSmoothingStrength", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StateName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: LeaveTunnel
    /// </summary>
    public unsafe virtual void LeaveTunnel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LeaveTunnel", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnterTunnel
    /// </summary>
    public unsafe virtual void EnterTunnel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.EnterTunnel", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ProcessOverLook
    /// </summary>
    public unsafe virtual void ProcessOverLook()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ProcessOverLook", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCombatDistModifier
    /// </summary>
    public unsafe virtual void SetCombatDistModifier(float NewDistModifier)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetCombatDistModifier", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewDistModifier, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCombatFOV
    /// </summary>
    public unsafe virtual void SetCombatFOV(float NewFOV)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetCombatFOV", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewFOV, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCombatCamera
    /// </summary>
    public unsafe virtual void SetCombatCamera(bool setFlag)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetCombatCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(setFlag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RevertCameraTarget
    /// </summary>
    public unsafe virtual void RevertCameraTarget(float BlendTime = default, bool bResetCam = default, bool BlendBatmanRelativePosition = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.RevertCameraTarget", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetCam, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendBatmanRelativePosition, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCameraTarget
    /// </summary>
    public unsafe virtual void SetCameraTarget(BmSDK.Engine.Actor Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetCameraTarget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BlendToCameraTarget
    /// </summary>
    public unsafe virtual void BlendToCameraTarget(BmSDK.Engine.Actor Target, float BlendTime, bool bResetCam = default, BmSDK.Rotator ResetRotation = default, bool BlendBatmanRelativePosition = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.BlendToCameraTarget", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetCam, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlendBatmanRelativePosition, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: UpdateFreeCam
    /// </summary>
    public unsafe virtual void UpdateFreeCam(System.Numerics.Vector3 DesiredCameraPosition, BmSDK.Rotator DesiredCameraRotation, float DesiredCameraFOV, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateFreeCam", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraFOV, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: TransitionInterpolate
    /// </summary>
    public unsafe virtual void TransitionInterpolate(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.TransitionInterpolate", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: ResetCamera
    /// </summary>
    public unsafe virtual void ResetCamera(BmSDK.Rotator ResetRotation = default, bool bResetForBlend = default, bool bResetSmoother = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ResetCamera", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResetRotation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetForBlend, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bResetSmoother, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateViewTarget
    /// </summary>
    public unsafe override void UpdateViewTarget(ref BmSDK.Engine.Camera.FTViewTarget OutVT, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateViewTarget", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutVT, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutVT = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Camera.FTViewTarget>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: UpdateViewTargetCameraActor
    /// </summary>
    public unsafe virtual void UpdateViewTargetCameraActor(ref BmSDK.Engine.Camera.FTViewTarget OutVT, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateViewTargetCameraActor", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutVT, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 44);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        OutVT = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Camera.FTViewTarget>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: UpdateCurrentCamera
    /// </summary>
    public unsafe virtual void UpdateCurrentCamera(System.Numerics.Vector3 DesiredCameraPosition, BmSDK.Rotator DesiredCameraRotation, float DesiredCameraFOV, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateCurrentCamera", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredCameraFOV, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ProcessViewRotation
    /// </summary>
    public unsafe override void ProcessViewRotation(float DeltaTime, ref BmSDK.Rotator out_ViewRotation, ref BmSDK.Rotator out_DeltaRot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ProcessViewRotation", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_ViewRotation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_DeltaRot, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_ViewRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 4);
        out_DeltaRot = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 16);
        return;
    }

    /// <summary>
    /// Function: UpdateCamera
    /// </summary>
    public unsafe override void UpdateCamera(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FollowCameraRotation
    /// </summary>
    public unsafe virtual bool FollowCameraRotation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.FollowCameraRotation", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: LookAround
    /// </summary>
    public unsafe virtual void LookAround(float DeltaTime, BmSDK.Rotator LookInput)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LookAround", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookInput, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitializeFor
    /// </summary>
    public unsafe override void InitializeFor(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.InitializeFor", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SaveFreeCameraConfig
    /// </summary>
    public unsafe virtual void SaveFreeCameraConfig(ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig ConfigToSave)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SaveFreeCameraConfig", true);
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConfigToSave, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ConfigToSave = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: SetFreeCameraConfig
    /// </summary>
    public unsafe virtual void SetFreeCameraConfig(BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig NewConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetFreeCameraConfig", true);
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewConfig, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: StopCameraWander
    /// </summary>
    public unsafe virtual void StopCameraWander()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.StopCameraWander", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartCameraWander
    /// </summary>
    public unsafe virtual void StartCameraWander(BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings NewSettings)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.StartCameraWander", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewSettings, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveAllCameraEmitters
    /// </summary>
    public unsafe virtual void RemoveAllCameraEmitters()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.RemoveAllCameraEmitters", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveCameraEmitter
    /// </summary>
    public unsafe virtual void RemoveCameraEmitter(BmSDK.BmGame.RBMCameraEmitter Emitter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.RemoveCameraEmitter", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Emitter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddCameraEmitter
    /// </summary>
    public unsafe virtual void AddCameraEmitter(BmSDK.BmGame.RBMCameraEmitter Emitter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.AddCameraEmitter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Emitter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopLookAt
    /// </summary>
    public unsafe virtual void StopLookAt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.StopLookAt", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LookAtCommon
    /// </summary>
    public unsafe virtual bool LookAtCommon(BmSDK.BmGame.RGameInfo.CameraLookAtStrength Strength, bool FollowPitch, bool FollowYaw, float Duration, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed, bool bUseOffset, bool bAllowZoom = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LookAtCommon", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowPitch, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowYaw, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseOffset, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowZoom, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: LookAtPosition
    /// </summary>
    public unsafe virtual void LookAtPosition(System.Numerics.Vector3 LookLocation, BmSDK.BmGame.RGameInfo.CameraLookAtStrength Strength = default, bool FollowPitch = default, bool FollowYaw = default, float Duration = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed = default, bool bUseOffset = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LookAtPosition", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowPitch, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowYaw, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseOffset, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LookAtActor
    /// </summary>
    public unsafe virtual void LookAtActor(BmSDK.Engine.Actor LookActor, System.Numerics.Vector3 Offset = default, BmSDK.BmGame.RGameInfo.CameraLookAtStrength Strength = default, bool FollowPitch = default, bool FollowYaw = default, float Duration = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed = default, bool bUseOffset = default, bool bAllowZoom = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LookAtActor", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LookActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Offset, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowPitch, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowYaw, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseOffset, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowZoom, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LookInDirection
    /// </summary>
    public unsafe virtual void LookInDirection(BmSDK.Rotator Direction, BmSDK.BmGame.RGameInfo.CameraLookAtStrength Strength = default, bool FollowPitch = default, bool FollowYaw = default, float Duration = default, BmSDK.BmGame.RGameInfo.CameraLookAtSpeed Speed = default, bool bUseOffset = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.LookInDirection", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowPitch, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FollowYaw, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Duration, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseOffset, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AllowZoomCamera
    /// </summary>
    public unsafe virtual bool AllowZoomCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.AllowZoomCamera", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: UpdateBatarangOutOfRangeFX
    /// </summary>
    public unsafe virtual void UpdateBatarangOutOfRangeFX(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateBatarangOutOfRangeFX", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetBatarangOutOfRangeFX
    /// </summary>
    public unsafe virtual void SetBatarangOutOfRangeFX(float Strength)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.SetBatarangOutOfRangeFX", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Strength, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckLocation
    /// </summary>
    public unsafe virtual void CheckLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.CheckLocation", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: ResetSmoother
    /// </summary>
    public unsafe virtual void ResetSmoother()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.ResetSmoother", true);
        byte* paramsPtr = stackalloc byte[0];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Function: UpdateCameraWander
    /// </summary>
    public unsafe virtual void UpdateCameraWander(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.R3rdPersonCamera.UpdateCameraWander", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return;
    }

    /// <summary>
    /// Struct: FCameraSmoother
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FCameraSmoother
    {
        /// <summary>
        /// FloatProperty: LastSmoothDistance
        /// </summary>
        public unsafe float LastSmoothDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: CurrentSmootherIndex
        /// </summary>
        public unsafe int CurrentSmootherIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: MinSmootherIndex
        /// </summary>
        public unsafe int MinSmootherIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: DirectionDistance
        /// </summary>
        public unsafe float DirectionDistance_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// FloatProperty: DirectionDistance
        /// </summary>
        public unsafe float DirectionDistance_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// FloatProperty: DirectionDistance
        /// </summary>
        public unsafe float DirectionDistance_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
        /// <summary>
        /// FloatProperty: DirectionDistance
        /// </summary>
        public unsafe float DirectionDistance_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FVector3WithTime
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FVector3WithTime
    {
        /// <summary>
        /// FloatProperty: X
        /// </summary>
        public unsafe float X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Y
        /// </summary>
        public unsafe float Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Z
        /// </summary>
        public unsafe float Z
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: W
        /// </summary>
        public unsafe float W
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FCameraLookAtSpeedDescriptor
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FCameraLookAtSpeedDescriptor
    {
        /// <summary>
        /// FloatProperty: DegreesPerSecond
        /// </summary>
        public unsafe float DegreesPerSecond
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: SlowDownAngle
        /// </summary>
        public unsafe float SlowDownAngle
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: AccelerationModifier
        /// </summary>
        public unsafe float AccelerationModifier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: DecelerationModifier
        /// </summary>
        public unsafe float DecelerationModifier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FCameraWanderSettings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FCameraWanderSettings
    {
        /// <summary>
        /// FloatProperty: CameraWanderMagnitude
        /// </summary>
        public unsafe float CameraWanderMagnitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderFOVMagnitude
        /// </summary>
        public unsafe float CameraWanderFOVMagnitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderXMagnitude
        /// </summary>
        public unsafe float CameraWanderXMagnitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderRotationMagnitude
        /// </summary>
        public unsafe float CameraWanderRotationMagnitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderRollMagnitude
        /// </summary>
        public unsafe float CameraWanderRollMagnitude
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderSinComponent1
        /// </summary>
        public unsafe float CameraWanderSinComponent1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderSinComponent2
        /// </summary>
        public unsafe float CameraWanderSinComponent2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderSinComponent3
        /// </summary>
        public unsafe float CameraWanderSinComponent3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: CameraWanderZOffset
        /// </summary>
        public unsafe float CameraWanderZOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: Priority
        /// </summary>
        public unsafe float Priority
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bOnceOnly
        /// </summary>
        public unsafe bool bOnceOnly
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bOneWayWander
        /// </summary>
        public unsafe bool bOneWayWander
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: OneWayTimer
        /// </summary>
        public unsafe float OneWayTimer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: OriginalY
        /// </summary>
        public unsafe float OriginalY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: OriginalZ
        /// </summary>
        public unsafe float OriginalZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: OriginalRoll
        /// </summary>
        public unsafe float OriginalRoll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: OriginalPitch
        /// </summary>
        public unsafe float OriginalPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: OriginalYaw
        /// </summary>
        public unsafe float OriginalYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// BoolProperty: bTurnedInTunnel
    /// </summary>
    public unsafe bool bTurnedInTunnel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bOverrideCameraFOV
    /// </summary>
    public unsafe bool bOverrideCameraFOV
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: LockInPlace
    /// </summary>
    public unsafe bool LockInPlace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bHidePlayer
    /// </summary>
    public unsafe bool bHidePlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bInterpPos
    /// </summary>
    public unsafe bool bInterpPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bDisallowRoll
    /// </summary>
    public unsafe bool bDisallowRoll
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bAffectsControllerRotation
    /// </summary>
    public unsafe bool bAffectsControllerRotation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bTemporarilyDisableCameraDrag
    /// </summary>
    public unsafe bool bTemporarilyDisableCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bStatePermanentlyDragsCamera
    /// </summary>
    public unsafe bool bStatePermanentlyDragsCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bDragOnlyFollowsDeliberateDirection
    /// </summary>
    public unsafe bool bDragOnlyFollowsDeliberateDirection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bStatePermanentlyDisablesCameraDrag
    /// </summary>
    public unsafe bool bStatePermanentlyDisablesCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bUseTightFocusPoints
    /// </summary>
    public unsafe bool bUseTightFocusPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraSmoothing
    /// </summary>
    public unsafe bool bDisableCameraSmoothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bFollowPelvis
    /// </summary>
    public unsafe bool bFollowPelvis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bOnlyFollowPelvisZ
    /// </summary>
    public unsafe bool bOnlyFollowPelvisZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bDisableCameraCollision
    /// </summary>
    public unsafe bool bDisableCameraCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bSwayWithPelvis
    /// </summary>
    public unsafe bool bSwayWithPelvis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bDisableCamerCollisionDuringBlend
    /// </summary>
    public unsafe bool bDisableCamerCollisionDuringBlend
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bCameraDebug
    /// </summary>
    public unsafe bool bCameraDebug
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bCameraDebugCollision
    /// </summary>
    public unsafe bool bCameraDebugCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bDebugPlayerPath
    /// </summary>
    public unsafe bool bDebugPlayerPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bDebugCameraSmoothing
    /// </summary>
    public unsafe bool bDebugCameraSmoothing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bForce3rdPersonCamera
    /// </summary>
    public unsafe bool bForce3rdPersonCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bDontModifySitOffsetWhenLookingUp
    /// </summary>
    public unsafe bool bDontModifySitOffsetWhenLookingUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bUseAbsoluteHeadOffset
    /// </summary>
    public unsafe bool bUseAbsoluteHeadOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bActuallyUsingAbsoluteHeadRot
    /// </summary>
    public unsafe bool bActuallyUsingAbsoluteHeadRot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bInterpingHeadRot
    /// </summary>
    public unsafe bool bInterpingHeadRot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bAlternativeCam
    /// </summary>
    public unsafe bool bAlternativeCam
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bDontClipPlayer
    /// </summary>
    public unsafe bool bDontClipPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bCameraWandering
    /// </summary>
    public unsafe bool bCameraWandering
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bCamOverrideDof
    /// </summary>
    public unsafe bool bCamOverrideDof
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bEnableMotionBlur
    /// </summary>
    public unsafe bool bEnableMotionBlur
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1232); }
    }

    /// <summary>
    /// BoolProperty: bForceZoom
    /// </summary>
    public unsafe bool bForceZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: CameraLocked
    /// </summary>
    public unsafe bool CameraLocked
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: CameraBlendBatmanRelativePosition
    /// </summary>
    public unsafe bool CameraBlendBatmanRelativePosition
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bIsCombatCamera
    /// </summary>
    public unsafe bool bIsCombatCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bIsVenomCamera
    /// </summary>
    public unsafe bool bIsVenomCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: EnableCameraAssist
    /// </summary>
    public unsafe bool EnableCameraAssist
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bForceCameraDragOn
    /// </summary>
    public unsafe bool bForceCameraDragOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bCombatDisableCameraDrag
    /// </summary>
    public unsafe bool bCombatDisableCameraDrag
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bOverrideTransitionIn
    /// </summary>
    public unsafe bool bOverrideTransitionIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: PawnHiddenByCamera
    /// </summary>
    public unsafe bool PawnHiddenByCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: LookAtUsesDefaultOffset
    /// </summary>
    public unsafe bool LookAtUsesDefaultOffset
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: UsePitchForLookAt
    /// </summary>
    public unsafe bool UsePitchForLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: UseYawForLookAt
    /// </summary>
    public unsafe bool UseYawForLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bCeilingRetainOffsetDuringZoom
    /// </summary>
    public unsafe bool bCeilingRetainOffsetDuringZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: DontDrawClosePawns
    /// </summary>
    public unsafe bool DontDrawClosePawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bPauseAndPanCamera
    /// </summary>
    public unsafe bool bPauseAndPanCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bModifyPPForResonatorSreen
    /// </summary>
    public unsafe bool bModifyPPForResonatorSreen
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bUseFullSway
    /// </summary>
    public unsafe bool bUseFullSway
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bRetainOffsetDuringZoom
    /// </summary>
    public unsafe bool bRetainOffsetDuringZoom
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bUseHeadOffsetCheck
    /// </summary>
    public unsafe bool bUseHeadOffsetCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bOverrideCrouchHeadCheck
    /// </summary>
    public unsafe bool bOverrideCrouchHeadCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bBatmanFacesCamera
    /// </summary>
    public unsafe bool bBatmanFacesCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bCustomCameraZoomAllowed
    /// </summary>
    public unsafe bool bCustomCameraZoomAllowed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bDontSaveConfig
    /// </summary>
    public unsafe bool bDontSaveConfig
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: Debug_TurnOffZoomDof
    /// </summary>
    public unsafe bool Debug_TurnOffZoomDof
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// BoolProperty: bForceFollowFullPelvisZ
    /// </summary>
    public unsafe bool bForceFollowFullPelvisZ
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1236); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1236); }
    }

    /// <summary>
    /// StructProperty: CameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1240);

    /// <summary>
    /// FloatProperty: CameraFOVAngle
    /// </summary>
    public unsafe float CameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// FloatProperty: OverrideCameraFOVAngle
    /// </summary>
    public unsafe float OverrideCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// FloatProperty: OverrideCameraFOVTime
    /// </summary>
    public unsafe float OverrideCameraFOVTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// FloatProperty: OverrideCameraFOVTimer
    /// </summary>
    public unsafe float OverrideCameraFOVTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// FloatProperty: LastOverrideCameraFOVAngle
    /// </summary>
    public unsafe float LastOverrideCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// FloatProperty: CurrentOverrideCameraFOVAngle
    /// </summary>
    public unsafe float CurrentOverrideCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// FloatProperty: OverrideMotionBlurBlendTime
    /// </summary>
    public unsafe float OverrideMotionBlurBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// FloatProperty: OverrideMotionBlurAmount
    /// </summary>
    public unsafe float OverrideMotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// FloatProperty: OldMotionBlurBlendTime
    /// </summary>
    public unsafe float OldMotionBlurBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// FloatProperty: OldMotionBlurAmount
    /// </summary>
    public unsafe float OldMotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: bOverrideMotionBlurSettings
    /// </summary>
    public unsafe float bOverrideMotionBlurSettings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1292); }
    }

    /// <summary>
    /// StructProperty: ExtraCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ExtraCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1296);

    /// <summary>
    /// StructProperty: DefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator DefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1308);

    /// <summary>
    /// StructProperty: CameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1320);

    /// <summary>
    /// StructProperty: HeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1332);

    /// <summary>
    /// FloatProperty: ExtraCameraZ
    /// </summary>
    public unsafe float ExtraCameraZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1344); }
    }

    /// <summary>
    /// StructProperty: CurrentHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1348);

    /// <summary>
    /// StructProperty: CurrentExtraCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CurrentExtraCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1360);

    /// <summary>
    /// FloatProperty: CurrentExtraCameraZ
    /// </summary>
    public unsafe float CurrentExtraCameraZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1372); }
    }

    /// <summary>
    /// ObjectProperty: DOFManager
    /// </summary>
    public unsafe BmSDK.BmGame.RDOFManager DOFManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDOFManager>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// FloatProperty: TargetFOV
    /// </summary>
    public unsafe float TargetFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// ArrayProperty: CameraEmitters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMCameraEmitter> CameraEmitters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMCameraEmitter>>(Ptr + 1384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1384); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentCameraPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1396);

    /// <summary>
    /// StructProperty: CurrentCameraRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CurrentCameraRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1408);

    /// <summary>
    /// FloatProperty: CurrentCameraFOVAngle
    /// </summary>
    public unsafe float CurrentCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1424);

    /// <summary>
    /// StructProperty: ActualCameraPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ActualCameraPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1436);

    /// <summary>
    /// StructProperty: ActualCameraRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator ActualCameraRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1448);

    /// <summary>
    /// StructProperty: LastVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1460);

    /// <summary>
    /// FloatProperty: TimeInCurrentState
    /// </summary>
    public unsafe float TimeInCurrentState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1472); }
    }

    /// <summary>
    /// FloatProperty: TransitionTime
    /// </summary>
    public unsafe float TransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1476); }
    }

    /// <summary>
    /// IntProperty: maxPitch
    /// </summary>
    public unsafe int maxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1480); }
    }

    /// <summary>
    /// IntProperty: MinPitch
    /// </summary>
    public unsafe int MinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1484); }
    }

    /// <summary>
    /// IntProperty: MaxYaw
    /// </summary>
    public unsafe int MaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1488); }
    }

    /// <summary>
    /// IntProperty: MinYaw
    /// </summary>
    public unsafe int MinYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1492); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxYaw
    /// </summary>
    public unsafe float CurrentMaxYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1496); }
    }

    /// <summary>
    /// FloatProperty: CurrentMinYaw
    /// </summary>
    public unsafe float CurrentMinYaw
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxPitch
    /// </summary>
    public unsafe float CurrentMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1504); }
    }

    /// <summary>
    /// FloatProperty: CurrentMinPitch
    /// </summary>
    public unsafe float CurrentMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1508); }
    }

    /// <summary>
    /// StructProperty: RotationSpeed
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RotationSpeed
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1512);

    /// <summary>
    /// FloatProperty: YawAccel
    /// </summary>
    public unsafe float YawAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1524); }
    }

    /// <summary>
    /// FloatProperty: PitchAccel
    /// </summary>
    public unsafe float PitchAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1528); }
    }

    /// <summary>
    /// FloatProperty: YawDecel
    /// </summary>
    public unsafe float YawDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1532); }
    }

    /// <summary>
    /// FloatProperty: PitchDecel
    /// </summary>
    public unsafe float PitchDecel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// FloatProperty: CameraCeilingLimit
    /// </summary>
    public unsafe float CameraCeilingLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1540); }
    }

    /// <summary>
    /// FloatProperty: CameraFloorLimit
    /// </summary>
    public unsafe float CameraFloorLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1544); }
    }

    /// <summary>
    /// StructProperty: WalkStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WalkStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1548);

    /// <summary>
    /// FloatProperty: WalkStateCameraFOVAngle
    /// </summary>
    public unsafe float WalkStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1560); }
    }

    /// <summary>
    /// StructProperty: WalkStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator WalkStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1564);

    /// <summary>
    /// StructProperty: DialogueStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DialogueStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1576);

    /// <summary>
    /// FloatProperty: DialogueStateCameraFOVAngle
    /// </summary>
    public unsafe float DialogueStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// StructProperty: DialogueStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator DialogueStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1592);

    /// <summary>
    /// StructProperty: ForensicsScanStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ForensicsScanStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1604);

    /// <summary>
    /// FloatProperty: ForensicsScanStateCameraFOVAngle
    /// </summary>
    public unsafe float ForensicsScanStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// StructProperty: ForensicsScanStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ForensicsScanStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1620);

    /// <summary>
    /// StructProperty: UsingSpotlightStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 UsingSpotlightStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1632);

    /// <summary>
    /// FloatProperty: UsingSpotlightStateCameraFOVAngle
    /// </summary>
    public unsafe float UsingSpotlightStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1644); }
    }

    /// <summary>
    /// StructProperty: UsingSpotlightStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator UsingSpotlightStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1648);

    /// <summary>
    /// StructProperty: ForensicsFilterStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ForensicsFilterStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1660);

    /// <summary>
    /// FloatProperty: ForensicsFilterStateCameraFOVAngle
    /// </summary>
    public unsafe float ForensicsFilterStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1672); }
    }

    /// <summary>
    /// StructProperty: ForensicsFilterStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ForensicsFilterStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1676);

    /// <summary>
    /// StructProperty: RunStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RunStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1688);

    /// <summary>
    /// FloatProperty: RunStateCameraFOVAngle
    /// </summary>
    public unsafe float RunStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// FloatProperty: BoostRunFOVAngle
    /// </summary>
    public unsafe float BoostRunFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1704); }
    }

    /// <summary>
    /// StructProperty: RunStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator RunStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1708);

    /// <summary>
    /// StructProperty: PairedAnimationStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PairedAnimationStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1720);

    /// <summary>
    /// FloatProperty: PairedAnimationStateCameraFOVAngle
    /// </summary>
    public unsafe float PairedAnimationStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// StructProperty: PairedAnimationStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator PairedAnimationStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1736);

    /// <summary>
    /// StructProperty: StealthStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StealthStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1748);

    /// <summary>
    /// FloatProperty: StealthStateCameraFOVAngle
    /// </summary>
    public unsafe float StealthStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// FloatProperty: OverworldStealthStateCameraFOVAngle
    /// </summary>
    public unsafe float OverworldStealthStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// StructProperty: StealthStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator StealthStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1768);

    /// <summary>
    /// StructProperty: TunnelStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TunnelStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1780);

    /// <summary>
    /// FloatProperty: TunnelStateCameraFOVAngle
    /// </summary>
    public unsafe float TunnelStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// StructProperty: TunnelStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator TunnelStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1796);

    /// <summary>
    /// StructProperty: TunnelStateCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TunnelStateCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1808);

    /// <summary>
    /// StructProperty: GrappleDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator GrappleDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1820);

    /// <summary>
    /// StructProperty: FallingStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FallingStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1832);

    /// <summary>
    /// FloatProperty: FallingStateCameraFOVAngle
    /// </summary>
    public unsafe float FallingStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// StructProperty: FallingDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator FallingDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1848);

    /// <summary>
    /// FloatProperty: FallingStateSwingSmoothingStrength
    /// </summary>
    public unsafe float FallingStateSwingSmoothingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// FloatProperty: FallingStateSwingTransitionTime
    /// </summary>
    public unsafe float FallingStateSwingTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// StructProperty: GrappleAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrappleAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1868);

    /// <summary>
    /// FloatProperty: GrappleAimCameraFOVAngle
    /// </summary>
    public unsafe float GrappleAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// StructProperty: GrappleAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator GrappleAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1884);

    /// <summary>
    /// IntProperty: GrappleAimMaxPitch
    /// </summary>
    public unsafe int GrappleAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }
    }

    /// <summary>
    /// IntProperty: GrappleAimMinPitch
    /// </summary>
    public unsafe int GrappleAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// StructProperty: HarpoonAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HarpoonAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1904);

    /// <summary>
    /// FloatProperty: HarpoonAimCameraFOVAngle
    /// </summary>
    public unsafe float HarpoonAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1916); }
    }

    /// <summary>
    /// StructProperty: HarpoonAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator HarpoonAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1920);

    /// <summary>
    /// IntProperty: HarpoonAimMaxPitch
    /// </summary>
    public unsafe int HarpoonAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1932); }
    }

    /// <summary>
    /// IntProperty: HarpoonAimMinPitch
    /// </summary>
    public unsafe int HarpoonAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1936); }
    }

    /// <summary>
    /// StructProperty: MagneticBlastAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MagneticBlastAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1940);

    /// <summary>
    /// FloatProperty: MagneticBlastAimCameraFOVAngle
    /// </summary>
    public unsafe float MagneticBlastAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1952); }
    }

    /// <summary>
    /// StructProperty: MagneticBlastAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator MagneticBlastAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1956);

    /// <summary>
    /// IntProperty: MagneticBlastAimMaxPitch
    /// </summary>
    public unsafe int MagneticBlastAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1968); }
    }

    /// <summary>
    /// IntProperty: MagneticBlastAimMinPitch
    /// </summary>
    public unsafe int MagneticBlastAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1972); }
    }

    /// <summary>
    /// StructProperty: FreezeJammerAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreezeJammerAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1976);

    /// <summary>
    /// FloatProperty: FreezeJammerAimCameraFOVAngle
    /// </summary>
    public unsafe float FreezeJammerAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1988); }
    }

    /// <summary>
    /// StructProperty: FreezeJammerAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator FreezeJammerAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 1992);

    /// <summary>
    /// IntProperty: FreezeJammerAimMaxPitch
    /// </summary>
    public unsafe int FreezeJammerAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2004); }
    }

    /// <summary>
    /// IntProperty: FreezeJammerAimMinPitch
    /// </summary>
    public unsafe int FreezeJammerAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2008); }
    }

    /// <summary>
    /// StructProperty: JokerGunAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 JokerGunAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2012);

    /// <summary>
    /// FloatProperty: JokerGunAimCameraFOVAngle
    /// </summary>
    public unsafe float JokerGunAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2024); }
    }

    /// <summary>
    /// IntProperty: JokerGunAimMaxPitch
    /// </summary>
    public unsafe int JokerGunAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2028); }
    }

    /// <summary>
    /// IntProperty: JokerGunAimMinPitch
    /// </summary>
    public unsafe int JokerGunAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2032); }
    }

    /// <summary>
    /// StructProperty: LineLauncherAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LineLauncherAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2036);

    /// <summary>
    /// FloatProperty: LineLauncherAimCameraFOVAngle
    /// </summary>
    public unsafe float LineLauncherAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2048); }
    }

    /// <summary>
    /// StructProperty: LineLauncherAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LineLauncherAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2052);

    /// <summary>
    /// IntProperty: LineLauncherAimMaxPitch
    /// </summary>
    public unsafe int LineLauncherAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2064); }
    }

    /// <summary>
    /// IntProperty: LineLauncherAimMinPitch
    /// </summary>
    public unsafe int LineLauncherAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2068); }
    }

    /// <summary>
    /// StructProperty: BatarangAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatarangAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2072);

    /// <summary>
    /// FloatProperty: BatarangAimCameraFOVAngle
    /// </summary>
    public unsafe float BatarangAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2084); }
    }

    /// <summary>
    /// StructProperty: BatarangAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator BatarangAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2088);

    /// <summary>
    /// IntProperty: BatarangAimMaxPitch
    /// </summary>
    public unsafe int BatarangAimMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2100); }
    }

    /// <summary>
    /// IntProperty: BatarangAimMinPitch
    /// </summary>
    public unsafe int BatarangAimMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2104); }
    }

    /// <summary>
    /// StructProperty: WallClimbStartCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallClimbStartCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2108);

    /// <summary>
    /// FloatProperty: WallClimbStartCameraFOVAngle
    /// </summary>
    public unsafe float WallClimbStartCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// StructProperty: WallClimbHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallClimbHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2124);

    /// <summary>
    /// StructProperty: PounceCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PounceCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2136);

    /// <summary>
    /// FloatProperty: PounceCameraFOVAngle
    /// </summary>
    public unsafe float PounceCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2148); }
    }

    /// <summary>
    /// StructProperty: PounceHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PounceHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2152);

    /// <summary>
    /// StructProperty: VantageClimbHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 VantageClimbHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2164);

    /// <summary>
    /// StructProperty: BatTrackerAimCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatTrackerAimCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2176);

    /// <summary>
    /// FloatProperty: BatTrackerAimCameraFOVAngle
    /// </summary>
    public unsafe float BatTrackerAimCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2188); }
    }

    /// <summary>
    /// StructProperty: BatTrackerAimDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator BatTrackerAimDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2192);

    /// <summary>
    /// StructProperty: BatTrackerAimTargetOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatTrackerAimTargetOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2204);

    /// <summary>
    /// FloatProperty: CorridorCombatStateCameraFOVAngle
    /// </summary>
    public unsafe float CorridorCombatStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// FloatProperty: HighCombatStateCameraFOVAngle
    /// </summary>
    public unsafe float HighCombatStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// StructProperty: LookStateCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LookStateCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2224);

    /// <summary>
    /// FloatProperty: LookStateCameraFOVAngle
    /// </summary>
    public unsafe float LookStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// StructProperty: LookStateDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LookStateDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2240);

    /// <summary>
    /// IntProperty: LookStateMaxPitch
    /// </summary>
    public unsafe int LookStateMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// IntProperty: LookStateMinPitch
    /// </summary>
    public unsafe int LookStateMinPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// FloatProperty: LookModeScale
    /// </summary>
    public unsafe float LookModeScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// FloatProperty: LookSpringBack
    /// </summary>
    public unsafe float LookSpringBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2264); }
    }

    /// <summary>
    /// FloatProperty: GrappleLookSpringBack
    /// </summary>
    public unsafe float GrappleLookSpringBack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2268); }
    }

    /// <summary>
    /// FloatProperty: GrappleCameraFOVAngle
    /// </summary>
    public unsafe float GrappleCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2272); }
    }

    /// <summary>
    /// FloatProperty: ZoomStateCameraFOVAngle
    /// </summary>
    public unsafe float ZoomStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// StructProperty: CoverRightCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CoverRightCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2280);

    /// <summary>
    /// FloatProperty: CoverRightCameraFOVAngle
    /// </summary>
    public unsafe float CoverRightCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2292); }
    }

    /// <summary>
    /// StructProperty: CoverRightCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CoverRightCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2296);

    /// <summary>
    /// StructProperty: AlcoveCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AlcoveCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2308);

    /// <summary>
    /// FloatProperty: AlcoveCameraFOVAngle
    /// </summary>
    public unsafe float AlcoveCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// StructProperty: AlcoveCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator AlcoveCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2324);

    /// <summary>
    /// StructProperty: AlcoveCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AlcoveCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2336);

    /// <summary>
    /// StructProperty: GlidingCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GlidingCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2348);

    /// <summary>
    /// FloatProperty: GlidingCameraFOVAngle
    /// </summary>
    public unsafe float GlidingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2360); }
    }

    /// <summary>
    /// FloatProperty: GlidingCameraExtraFOVAngle
    /// </summary>
    public unsafe float GlidingCameraExtraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// StructProperty: GlidingCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator GlidingCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2368);

    /// <summary>
    /// FloatProperty: GlideLagStrength
    /// </summary>
    public unsafe float GlideLagStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2380); }
    }

    /// <summary>
    /// FloatProperty: GlideLagBoostStrength
    /// </summary>
    public unsafe float GlideLagBoostStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// FloatProperty: GlideLagStrengthBlendTime
    /// </summary>
    public unsafe float GlideLagStrengthBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2388); }
    }

    /// <summary>
    /// FloatProperty: DiveCameraOrientationTime
    /// </summary>
    public unsafe float DiveCameraOrientationTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2392); }
    }

    /// <summary>
    /// StructProperty: GlideKickOffWallHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GlideKickOffWallHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2396);

    /// <summary>
    /// StructProperty: BoostGlidingCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BoostGlidingCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2408);

    /// <summary>
    /// FloatProperty: BoostGlidingCameraFOVAngle
    /// </summary>
    public unsafe float BoostGlidingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// StructProperty: BoostGlidingCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator BoostGlidingCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2424);

    /// <summary>
    /// StructProperty: PouncingCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PouncingCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2436);

    /// <summary>
    /// StructProperty: SilentPredCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SilentPredCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2448);

    /// <summary>
    /// StructProperty: SilentPredCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SilentPredCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2460);

    /// <summary>
    /// FloatProperty: SilentPredCameraFOVAngle
    /// </summary>
    public unsafe float SilentPredCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// StructProperty: SilentPredDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator SilentPredDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2476);

    /// <summary>
    /// FloatProperty: ZoomSilentPredCameraFOVAngle
    /// </summary>
    public unsafe float ZoomSilentPredCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2488); }
    }

    /// <summary>
    /// StructProperty: ZoomSilentPredCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomSilentPredCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2492);

    /// <summary>
    /// StructProperty: HangCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HangCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2504);

    /// <summary>
    /// FloatProperty: HangCameraFOVAngle
    /// </summary>
    public unsafe float HangCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// StructProperty: HangDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator HangDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2520);

    /// <summary>
    /// FloatProperty: MinFreeCameraDistance
    /// </summary>
    public unsafe float MinFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// FloatProperty: MaxFreeCameraDistance
    /// </summary>
    public unsafe float MaxFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// FloatProperty: ShortCamSpringConst
    /// </summary>
    public unsafe float ShortCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2540); }
    }

    /// <summary>
    /// FloatProperty: LongCamSpringConst
    /// </summary>
    public unsafe float LongCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2544); }
    }

    /// <summary>
    /// StructProperty: LastLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2548);

    /// <summary>
    /// FloatProperty: CurrentShortCamSpringConst
    /// </summary>
    public unsafe float CurrentShortCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// FloatProperty: CurrentLongCamSpringConst
    /// </summary>
    public unsafe float CurrentLongCamSpringConst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// StructProperty: CameraPivotOffsetDef
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraPivotOffsetDef
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2568);

    /// <summary>
    /// IntProperty: MaxFreeCameraPitch
    /// </summary>
    public unsafe int MaxFreeCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2580); }
    }

    /// <summary>
    /// IntProperty: MinFreeCameraPitch
    /// </summary>
    public unsafe int MinFreeCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2584); }
    }

    /// <summary>
    /// FloatProperty: ZoomSensitivityMod
    /// </summary>
    public unsafe float ZoomSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2588); }
    }

    /// <summary>
    /// FloatProperty: LookSensitivityMod
    /// </summary>
    public unsafe float LookSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2592); }
    }

    /// <summary>
    /// FloatProperty: HarpoonSensitivityMod
    /// </summary>
    public unsafe float HarpoonSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2596); }
    }

    /// <summary>
    /// FloatProperty: JokerGunSensitivityMod
    /// </summary>
    public unsafe float JokerGunSensitivityMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// StructProperty: BaseCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BaseCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2604);

    /// <summary>
    /// StructProperty: ExtraCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ExtraCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2616);

    /// <summary>
    /// StructProperty: FreeCamBobLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCamBobLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2628);

    /// <summary>
    /// StructProperty: LastDesiredCamPositionForDrag
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastDesiredCamPositionForDrag
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2640);

    /// <summary>
    /// StructProperty: ZipLineCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZipLineCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2652);

    /// <summary>
    /// FloatProperty: ZipLineCameraFOVAngle
    /// </summary>
    public unsafe float ZipLineCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// StructProperty: ZipLineDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ZipLineDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2668);

    /// <summary>
    /// StructProperty: ZipLineTargetOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZipLineTargetOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2680);

    /// <summary>
    /// StructProperty: HarpoonPullCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HarpoonPullCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2692);

    /// <summary>
    /// FloatProperty: HarpoonPullCameraFOVAngle
    /// </summary>
    public unsafe float HarpoonPullCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2704); }
    }

    /// <summary>
    /// StructProperty: HarpoonPullDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator HarpoonPullDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2708);

    /// <summary>
    /// StructProperty: HarpoonPullTargetOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HarpoonPullTargetOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2720);

    /// <summary>
    /// StructProperty: FixedCameraHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FixedCameraHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2732);

    /// <summary>
    /// StructProperty: FreeCameraHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCameraHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2744);

    /// <summary>
    /// StructProperty: AlcoveCameraHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 AlcoveCameraHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2756);

    /// <summary>
    /// StructProperty: SwingingFromAboveCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SwingingFromAboveCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2768);

    /// <summary>
    /// FloatProperty: SwingingFromAboveCameraFOVAngle
    /// </summary>
    public unsafe float SwingingFromAboveCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2780); }
    }

    /// <summary>
    /// StructProperty: SwingingFromAboveCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator SwingingFromAboveCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2784);

    /// <summary>
    /// FloatProperty: CeilingClimbCamFOVAngle
    /// </summary>
    public unsafe float CeilingClimbCamFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2796); }
    }

    /// <summary>
    /// StructProperty: CeilingClimbCamHeadOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingClimbCamHeadOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2800);

    /// <summary>
    /// StructProperty: CeilingClimbCamRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CeilingClimbCamRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2812);

    /// <summary>
    /// FloatProperty: ZoomFOV
    /// </summary>
    public unsafe float ZoomFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2824); }
    }

    /// <summary>
    /// FloatProperty: ZoomTime
    /// </summary>
    public unsafe float ZoomTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2828); }
    }

    /// <summary>
    /// FloatProperty: RaftPullFOVAngle
    /// </summary>
    public unsafe float RaftPullFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2832); }
    }

    /// <summary>
    /// IntProperty: ForcedPitch
    /// </summary>
    public unsafe int ForcedPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2836); }
    }

    /// <summary>
    /// StructProperty: TransitionOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TransitionOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2840);

    /// <summary>
    /// StructProperty: TransitionRotatorOffset
    /// </summary>
    public unsafe ref BmSDK.Rotator TransitionRotatorOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 2852);

    /// <summary>
    /// FloatProperty: TransitionFOV
    /// </summary>
    public unsafe float TransitionFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2864); }
    }

    /// <summary>
    /// FloatProperty: CurrentMinFreeCameraDistance
    /// </summary>
    public unsafe float CurrentMinFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2868); }
    }

    /// <summary>
    /// FloatProperty: CurrentMaxFreeCameraDistance
    /// </summary>
    public unsafe float CurrentMaxFreeCameraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2872); }
    }

    /// <summary>
    /// ObjectProperty: ScreenShakeModifier
    /// </summary>
    public unsafe BmSDK.BmGame.RBMScreenShakeModifier ScreenShakeModifier
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMScreenShakeModifier>(Ptr + 2876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2876); }
    }

    /// <summary>
    /// StructProperty: GrateCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GrateCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2880);

    /// <summary>
    /// StructProperty: FreeCameraSitOffsetMin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCameraSitOffsetMin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2892);

    /// <summary>
    /// StructProperty: FreeCameraSitOffsetMax
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCameraSitOffsetMax
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2904);

    /// <summary>
    /// StructProperty: FreeCameraPullOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 FreeCameraPullOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2916);

    /// <summary>
    /// FloatProperty: CurrentSitOffsetPower
    /// </summary>
    public unsafe float CurrentSitOffsetPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2928); }
    }

    /// <summary>
    /// StructProperty: StateFreeCameraSitOffsetMin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StateFreeCameraSitOffsetMin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2932);

    /// <summary>
    /// StructProperty: StateFreeCameraSitOffsetMax
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StateFreeCameraSitOffsetMax
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2944);

    /// <summary>
    /// StructProperty: StateFreeCameraPullOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 StateFreeCameraPullOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2956);

    /// <summary>
    /// FloatProperty: StateSitOffsetPower
    /// </summary>
    public unsafe float StateSitOffsetPower
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2968); }
    }

    /// <summary>
    /// FloatProperty: StateDefaultCameraPitch
    /// </summary>
    public unsafe float StateDefaultCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2972); }
    }

    /// <summary>
    /// FloatProperty: CurrentDefaultCameraPitch
    /// </summary>
    public unsafe float CurrentDefaultCameraPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2976); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraFollowPelvisXY
    /// </summary>
    public unsafe float CurrentCameraFollowPelvisXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2980); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraFollowPelvisZ
    /// </summary>
    public unsafe float CurrentCameraFollowPelvisZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2984); }
    }

    /// <summary>
    /// FloatProperty: CurrentPelvisSway
    /// </summary>
    public unsafe float CurrentPelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2988); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2992);

    /// <summary>
    /// FloatProperty: EdgeSwingCameraFOVAngle
    /// </summary>
    public unsafe float EdgeSwingCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3004); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator EdgeSwingCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3008);

    /// <summary>
    /// StructProperty: CurrentAbsoluteHeadRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CurrentAbsoluteHeadRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3020);

    /// <summary>
    /// StructProperty: LastAnchorRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LastAnchorRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 3032);

    /// <summary>
    /// StructProperty: BaseZoomDOFSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.RDOFManager.FDofStruct BaseZoomDOFSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RDOFManager.FDofStruct>(Ptr + 3044);

    /// <summary>
    /// FloatProperty: MinZoomFarBlur
    /// </summary>
    public unsafe float MinZoomFarBlur
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3108); }
    }

    /// <summary>
    /// StructProperty: ZoomedDOFSetting
    /// </summary>
    public unsafe ref BmSDK.BmGame.RDOFManager.FDofStruct ZoomedDOFSetting
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RDOFManager.FDofStruct>(Ptr + 3112);

    /// <summary>
    /// FloatProperty: VenomHenchmenCombatCameraFOVAngle
    /// </summary>
    public unsafe float VenomHenchmenCombatCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3176); }
    }

    /// <summary>
    /// FloatProperty: PenguinBeatdownFOVAngle
    /// </summary>
    public unsafe float PenguinBeatdownFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3180); }
    }

    /// <summary>
    /// StructProperty: WalkCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig WalkCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3184);

    /// <summary>
    /// StructProperty: AgilityWalkCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig AgilityWalkCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3308);

    /// <summary>
    /// StructProperty: RunCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RunCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3432);

    /// <summary>
    /// StructProperty: RooftopRunCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RooftopRunCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3556);

    /// <summary>
    /// StructProperty: DemonTrialsCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig DemonTrialsCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3680);

    /// <summary>
    /// StructProperty: CombatWalkCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CombatWalkCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3804);

    /// <summary>
    /// StructProperty: StandingHoldCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig StandingHoldCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 3928);

    /// <summary>
    /// StructProperty: StandingGrabCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig StandingGrabCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4052);

    /// <summary>
    /// StructProperty: GrappleCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig GrappleCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4176);

    /// <summary>
    /// StructProperty: GrappleRescueCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig GrappleRescueCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4300);

    /// <summary>
    /// StructProperty: CapeChuteConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CapeChuteConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4424);

    /// <summary>
    /// StructProperty: LedgeHangCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LedgeHangCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4548);

    /// <summary>
    /// StructProperty: LedgeHangKickedByThugCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LedgeHangKickedByThugCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4672);

    /// <summary>
    /// StructProperty: LedgeHangTakedownStartCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LedgeHangTakedownStartCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4796);

    /// <summary>
    /// StructProperty: LedgeHangTakedownCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LedgeHangTakedownCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 4920);

    /// <summary>
    /// StructProperty: QuickTakedownCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig QuickTakedownCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5044);

    /// <summary>
    /// StructProperty: GenericFarFreeCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig GenericFarFreeCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5168);

    /// <summary>
    /// StructProperty: RaftPullCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RaftPullCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5292);

    /// <summary>
    /// StructProperty: VantagePointSwingCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig VantagePointSwingCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5416);

    /// <summary>
    /// StructProperty: HangPointCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig HangPointCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5540);

    /// <summary>
    /// StructProperty: StealthCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig StealthCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5664);

    /// <summary>
    /// StructProperty: StealthWallCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig StealthWallCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5788);

    /// <summary>
    /// StructProperty: CrouchUnderObstacleCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CrouchUnderObstacleCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 5912);

    /// <summary>
    /// StructProperty: RailingCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RailingCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6036);

    /// <summary>
    /// StructProperty: FloorAttackCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FloorAttackCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6160);

    /// <summary>
    /// StructProperty: IntroCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig IntroCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6284);

    /// <summary>
    /// StructProperty: SwingingCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig SwingingCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6408);

    /// <summary>
    /// StructProperty: WallClimbCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig WallClimbCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6532);

    /// <summary>
    /// StructProperty: WallClimbStartCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig WallClimbStartCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6656);

    /// <summary>
    /// StructProperty: PounceCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig PounceCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6780);

    /// <summary>
    /// StructProperty: VantageClimbCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig VantageClimbCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 6904);

    /// <summary>
    /// StructProperty: SwingingFromAboveCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig SwingingFromAboveCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7028);

    /// <summary>
    /// StructProperty: TakedownFromAboveCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig TakedownFromAboveCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7152);

    /// <summary>
    /// StructProperty: SilentPredatorCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig SilentPredatorCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7276);

    /// <summary>
    /// StructProperty: CorridorCombatCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CorridorCombatCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7400);

    /// <summary>
    /// StructProperty: HighCombatCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig HighCombatCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7524);

    /// <summary>
    /// StructProperty: LookDownCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LookDownCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7648);

    /// <summary>
    /// StructProperty: LineLauncherCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LineLauncherCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7772);

    /// <summary>
    /// StructProperty: BatarangCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig BatarangCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 7896);

    /// <summary>
    /// StructProperty: HarpoonAimConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig HarpoonAimConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8020);

    /// <summary>
    /// StructProperty: MagneticBlastAimConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig MagneticBlastAimConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8144);

    /// <summary>
    /// StructProperty: FreezeJammerAimConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig FreezeJammerAimConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8268);

    /// <summary>
    /// StructProperty: JokerGunAimConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig JokerGunAimConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8392);

    /// <summary>
    /// StructProperty: GrateCameraConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig GrateCameraConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8516);

    /// <summary>
    /// StructProperty: HighGrateCameraConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig HighGrateCameraConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8640);

    /// <summary>
    /// StructProperty: VenomHenchmenCombatCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig VenomHenchmenCombatCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8764);

    /// <summary>
    /// StructProperty: VenomHenchmenRideCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig VenomHenchmenRideCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 8888);

    /// <summary>
    /// StructProperty: SlideCameraConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig SlideCameraConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9012);

    /// <summary>
    /// StructProperty: GrundyCombatCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig GrundyCombatCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9136);

    /// <summary>
    /// StructProperty: ClayfaceCombatCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig ClayfaceCombatCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9260);

    /// <summary>
    /// StructProperty: ClayfaceCoupCombatCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig ClayfaceCoupCombatCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9384);

    /// <summary>
    /// StructProperty: RasChokeCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RasChokeCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9508);

    /// <summary>
    /// StructProperty: RasManoCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RasManoCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9632);

    /// <summary>
    /// StructProperty: RasFuryCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RasFuryCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9756);

    /// <summary>
    /// StructProperty: RasBurlyCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RasBurlyCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 9880);

    /// <summary>
    /// StructProperty: RasSwordCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig RasSwordCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10004);

    /// <summary>
    /// StructProperty: CeilingClimbCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CeilingClimbCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10128);

    /// <summary>
    /// StructProperty: CeilingToLedgeHangCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CeilingToLedgeHangCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10252);

    /// <summary>
    /// StructProperty: CeilingToCatwalkCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CeilingToCatwalkCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10376);

    /// <summary>
    /// StructProperty: CeilingBatarangCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CeilingBatarangCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10500);

    /// <summary>
    /// StructProperty: LedgeSwingCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig LedgeSwingCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10624);

    /// <summary>
    /// StructProperty: DeepFallLandCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig DeepFallLandCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10748);

    /// <summary>
    /// StructProperty: HelicopterCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig HelicopterCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10872);

    /// <summary>
    /// StructProperty: PenguinBeatdownCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig PenguinBeatdownCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 10996);

    /// <summary>
    /// FloatProperty: LookDownVantageCamFOVAngle
    /// </summary>
    public unsafe float LookDownVantageCamFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11120); }
    }

    /// <summary>
    /// StructProperty: LookDownDefaultCameraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator LookDownDefaultCameraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11124);

    /// <summary>
    /// StructProperty: AlternativeWalkCamConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig AlternativeWalkCamConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 11136);

    /// <summary>
    /// FloatProperty: AlternativeWalkCamFOV
    /// </summary>
    public unsafe float AlternativeWalkCamFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11260); }
    }

    /// <summary>
    /// FloatProperty: SlideStateCameraFOVAngle
    /// </summary>
    public unsafe float SlideStateCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11264); }
    }

    /// <summary>
    /// StructProperty: DiveOverRailingPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DiveOverRailingPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11268);

    /// <summary>
    /// FloatProperty: DiveOverRailingPitch
    /// </summary>
    public unsafe float DiveOverRailingPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11280); }
    }

    /// <summary>
    /// FloatProperty: CameraWanderTimer
    /// </summary>
    public unsafe float CameraWanderTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11284); }
    }

    /// <summary>
    /// StructProperty: CameraWander
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CameraWander
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11288);

    /// <summary>
    /// StructProperty: CameraWanderRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CameraWanderRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11300);

    /// <summary>
    /// FloatProperty: CameraWanderFOV
    /// </summary>
    public unsafe float CameraWanderFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11312); }
    }

    /// <summary>
    /// StructProperty: CurrentCameraWanderSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings CurrentCameraWanderSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings>(Ptr + 11316);

    /// <summary>
    /// StructProperty: ResonatorWanderSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings ResonatorWanderSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings>(Ptr + 11384);

    /// <summary>
    /// StructProperty: ScarecrowWanderSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings ScarecrowWanderSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings>(Ptr + 11452);

    /// <summary>
    /// StructProperty: GlideWanderSettings
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings GlideWanderSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraWanderSettings>(Ptr + 11520);

    /// <summary>
    /// StructProperty: GlideCameraShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct GlideCameraShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 11588);

    /// <summary>
    /// StructProperty: BoostGlideCameraShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct BoostGlideCameraShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 11732);

    /// <summary>
    /// IntProperty: GlideShakeId
    /// </summary>
    public unsafe int GlideShakeId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11876); }
    }

    /// <summary>
    /// FloatProperty: Test
    /// </summary>
    public unsafe float Test
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11880); }
    }

    /// <summary>
    /// ObjectProperty: MotionBlurEffect
    /// </summary>
    public unsafe BmSDK.Engine.RockOn MotionBlurEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockOn>(Ptr + 11884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11884); }
    }

    /// <summary>
    /// ObjectProperty: UberEffect
    /// </summary>
    public unsafe BmSDK.Engine.RockOn UberEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RockOn>(Ptr + 11888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11888); }
    }

    /// <summary>
    /// IntProperty: GrappleMaxPitch
    /// </summary>
    public unsafe int GrappleMaxPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 11892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11892); }
    }

    /// <summary>
    /// StructProperty: CameraBlendRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CameraBlendRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11896);

    /// <summary>
    /// StructProperty: CameraBlendInitialRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator CameraBlendInitialRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11908);

    /// <summary>
    /// StructProperty: ExtraDeltaRot
    /// </summary>
    public unsafe ref BmSDK.Rotator ExtraDeltaRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11920);

    /// <summary>
    /// StructProperty: CornerStateOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CornerStateOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11932);

    /// <summary>
    /// FloatProperty: CornerStateFOVAngle
    /// </summary>
    public unsafe float CornerStateFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11944); }
    }

    /// <summary>
    /// StructProperty: CornerStateDefaultRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CornerStateDefaultRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 11948);

    /// <summary>
    /// StructProperty: CornerStateCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CornerStateCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 11960);

    /// <summary>
    /// FloatProperty: ZoomedFOVAngle
    /// </summary>
    public unsafe float ZoomedFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11972); }
    }

    /// <summary>
    /// FloatProperty: ZoomProp
    /// </summary>
    public unsafe float ZoomProp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11976); }
    }

    /// <summary>
    /// FloatProperty: ForceZoomFOVAngle
    /// </summary>
    public unsafe float ForceZoomFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11980); }
    }

    /// <summary>
    /// FloatProperty: MotionBlurAmount
    /// </summary>
    public unsafe float MotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11984); }
    }

    /// <summary>
    /// FloatProperty: MotionBlurBlendTime
    /// </summary>
    public unsafe float MotionBlurBlendTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11988); }
    }

    /// <summary>
    /// FloatProperty: InitialMotionBlurAmount
    /// </summary>
    public unsafe float InitialMotionBlurAmount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11992); }
    }

    /// <summary>
    /// FloatProperty: InitialMotionBlurMaxVelocity
    /// </summary>
    public unsafe float InitialMotionBlurMaxVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 11996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 11996); }
    }

    /// <summary>
    /// FloatProperty: MinCameraMotionBlur
    /// </summary>
    public unsafe float MinCameraMotionBlur
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12000); }
    }

    /// <summary>
    /// StructProperty: ResonatorCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ResonatorCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12004);

    /// <summary>
    /// FloatProperty: ResonatorFOVAngle
    /// </summary>
    public unsafe float ResonatorFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12016); }
    }

    /// <summary>
    /// StructProperty: ResonatorCameraPivotOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ResonatorCameraPivotOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12020);

    /// <summary>
    /// StructProperty: LastCameraPivotPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastCameraPivotPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12032);

    /// <summary>
    /// FloatProperty: OverrideBloomValue
    /// </summary>
    public unsafe float OverrideBloomValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12044); }
    }

    /// <summary>
    /// FloatProperty: LoadedAspectRatio
    /// </summary>
    public unsafe float LoadedAspectRatio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12048); }
    }

    /// <summary>
    /// FloatProperty: CurrentCameraAssistStrength
    /// </summary>
    public unsafe float CurrentCameraAssistStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12052); }
    }

    /// <summary>
    /// FloatProperty: CameraAssistBuildUpTime
    /// </summary>
    public unsafe float CameraAssistBuildUpTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12056); }
    }

    /// <summary>
    /// StructProperty: CurrentDefaultPelvisDiff
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentDefaultPelvisDiff
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12060);

    /// <summary>
    /// StructProperty: DefaultPelvisDiff
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DefaultPelvisDiff
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12072);

    /// <summary>
    /// FloatProperty: LastStepUpOffset
    /// </summary>
    public unsafe float LastStepUpOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12084); }
    }

    /// <summary>
    /// ArrayProperty: RetainZoomStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> RetainZoomStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 12088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12088); }
    }

    /// <summary>
    /// ArrayProperty: ForceUnZoomStates
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> ForceUnZoomStates
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 12100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12100); }
    }

    /// <summary>
    /// FloatProperty: OverrideTransitionInDuration
    /// </summary>
    public unsafe float OverrideTransitionInDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12112); }
    }

    /// <summary>
    /// ArrayProperty: LookAtSpeeds
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.R3rdPersonCamera.FCameraLookAtSpeedDescriptor> LookAtSpeeds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.R3rdPersonCamera.FCameraLookAtSpeedDescriptor>>(Ptr + 12116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12116); }
    }

    /// <summary>
    /// ByteProperty: LookAtSpeed
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtSpeed LookAtSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtSpeed>(Ptr + 12128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12128); }
    }

    /// <summary>
    /// ByteProperty: LookAtType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtType LookAtType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtType>(Ptr + 12129); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12129); }
    }

    /// <summary>
    /// ByteProperty: LookAtStrength
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.CameraLookAtStrength LookAtStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.CameraLookAtStrength>(Ptr + 12130); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12130); }
    }

    /// <summary>
    /// ByteProperty: CurrentZoomPoint
    /// </summary>
    public unsafe byte CurrentZoomPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12131); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12131); }
    }

    /// <summary>
    /// StructProperty: DesiredLookRotation
    /// </summary>
    public unsafe ref BmSDK.Rotator DesiredLookRotation
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12132);

    /// <summary>
    /// StructProperty: DesiredLookLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DesiredLookLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12144);

    /// <summary>
    /// ObjectProperty: DesiredLookActor
    /// </summary>
    public unsafe BmSDK.Engine.Actor DesiredLookActor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 12156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12156); }
    }

    /// <summary>
    /// StructProperty: ZoomOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12160);

    /// <summary>
    /// StructProperty: ZoomCameraOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomCameraOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12172);

    /// <summary>
    /// StructProperty: CeilingZoomOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingZoomOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12184);

    /// <summary>
    /// StructProperty: CeilingCameraZoomOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingCameraZoomOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12196);

    /// <summary>
    /// FloatProperty: ZoomFocusSpeed
    /// </summary>
    public unsafe float ZoomFocusSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12208); }
    }

    /// <summary>
    /// FloatProperty: MaxZoomFocusDistance
    /// </summary>
    public unsafe float MaxZoomFocusDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12212); }
    }

    /// <summary>
    /// ArrayProperty: CameraHiddenActors
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> CameraHiddenActors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 12216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12216); }
    }

    /// <summary>
    /// ArrayProperty: CameraHideClasses
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> CameraHideClasses
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 12228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12228); }
    }

    /// <summary>
    /// NameProperty: RunOverlayName
    /// </summary>
    public unsafe BmSDK.FName RunOverlayName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 12240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12240); }
    }

    /// <summary>
    /// FloatProperty: RunOverlayStrength
    /// </summary>
    public unsafe float RunOverlayStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12248); }
    }

    /// <summary>
    /// FloatProperty: RunOverlayZeroFrame
    /// </summary>
    public unsafe float RunOverlayZeroFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12252); }
    }

    /// <summary>
    /// FloatProperty: HelicopterCameraFOVAngle
    /// </summary>
    public unsafe float HelicopterCameraFOVAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12256); }
    }

    /// <summary>
    /// ObjectProperty: InterpBase
    /// </summary>
    public unsafe BmSDK.Engine.Actor InterpBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 12260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12260); }
    }

    /// <summary>
    /// FloatProperty: ResonatorPPFactor
    /// </summary>
    public unsafe float ResonatorPPFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12264); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_HighlightsMod
    /// </summary>
    public unsafe float ResonatorScreenScene_HighlightsMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12268); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_MidTonesMod
    /// </summary>
    public unsafe float ResonatorScreenScene_MidTonesMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12272); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_ShadowsMod
    /// </summary>
    public unsafe float ResonatorScreenScene_ShadowsMod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12276); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFNear
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFNear
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12280); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFFar
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12284); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFFalloff
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFFalloff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12288); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFRadius
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12292); }
    }

    /// <summary>
    /// FloatProperty: ResonatorScreenScene_DOFDistance
    /// </summary>
    public unsafe float ResonatorScreenScene_DOFDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12296); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: CameraSmoothingBuffer
    /// </summary>
    public InlineArray<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime> CameraSmoothingBuffer => new(10, Ptr + 12300, 16, this);

    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12300);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12316);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12332);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12348);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12364);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12380);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12396);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12412);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12428);
    /// <summary>
    /// StructProperty: CameraSmoothingBuffer
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime CameraSmoothingBuffer_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FVector3WithTime>(Ptr + 12444);

    /// <summary>
    /// IntProperty: CameraSmoothingCount
    /// </summary>
    public unsafe int CameraSmoothingCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12460); }
    }

    /// <summary>
    /// FloatProperty: SmoothingConfigMaxVelocity
    /// </summary>
    public unsafe float SmoothingConfigMaxVelocity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12464); }
    }

    /// <summary>
    /// FloatProperty: SmoothingConfigStrength
    /// </summary>
    public unsafe float SmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12468); }
    }

    /// <summary>
    /// FloatProperty: SmoothingConfigMaxAccel
    /// </summary>
    public unsafe float SmoothingConfigMaxAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12472); }
    }

    /// <summary>
    /// FloatProperty: CurrentSmoothingConfigStrength
    /// </summary>
    public unsafe float CurrentSmoothingConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12476); }
    }

    /// <summary>
    /// FloatProperty: OverworldRunningConfigStrength
    /// </summary>
    public unsafe float OverworldRunningConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12480); }
    }

    /// <summary>
    /// FloatProperty: NormalConfigStrength
    /// </summary>
    public unsafe float NormalConfigStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12484); }
    }

    /// <summary>
    /// StructProperty: ChasePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChasePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12488);

    /// <summary>
    /// StructProperty: ChaseVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ChaseVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12500);

    /// <summary>
    /// FloatProperty: LastCameraMoveTime
    /// </summary>
    public unsafe float LastCameraMoveTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12512); }
    }

    /// <summary>
    /// FloatProperty: PelvisFollowZ
    /// </summary>
    public unsafe float PelvisFollowZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12516); }
    }

    /// <summary>
    /// FloatProperty: PelvisFollowXY
    /// </summary>
    public unsafe float PelvisFollowXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12520); }
    }

    /// <summary>
    /// FloatProperty: PelvisSway
    /// </summary>
    public unsafe float PelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12524); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: ZoomPoints
    /// </summary>
    public InlineArray<float> ZoomPoints => new(9, Ptr + 12528, 4, this);

    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12528); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12532); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12536); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12540); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12544); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12548); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12552); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12556); }
    }
    /// <summary>
    /// FloatProperty: ZoomPoints
    /// </summary>
    public unsafe float ZoomPoints_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12560); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: ZoomPointDir
    /// </summary>
    public InlineArray<System.Numerics.Vector3> ZoomPointDir => new(9, Ptr + 12564, 12, this);

    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12564);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12576);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12588);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12600);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12612);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12624);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12636);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12648);
    /// <summary>
    /// StructProperty: ZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 ZoomPointDir_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12660);

    /// <summary>
    /// InlineArray{StructProperty}: TightZoomPointDir
    /// </summary>
    public InlineArray<System.Numerics.Vector3> TightZoomPointDir => new(9, Ptr + 12672, 12, this);

    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12672);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12684);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12696);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12708);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12720);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12732);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12744);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12756);
    /// <summary>
    /// StructProperty: TightZoomPointDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TightZoomPointDir_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 12768);

    /// <summary>
    /// FloatProperty: ZoomPointAngle
    /// </summary>
    public unsafe float ZoomPointAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12780); }
    }

    /// <summary>
    /// FloatProperty: TightZoomPointAngle
    /// </summary>
    public unsafe float TightZoomPointAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12784); }
    }

    /// <summary>
    /// StructProperty: Smoother
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FCameraSmoother Smoother
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FCameraSmoother>(Ptr + 12788);

    /// <summary>
    /// FloatProperty: RunStatePelvisXY
    /// </summary>
    public unsafe float RunStatePelvisXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12816); }
    }

    /// <summary>
    /// FloatProperty: RunStatePelvisZ
    /// </summary>
    public unsafe float RunStatePelvisZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12820); }
    }

    /// <summary>
    /// FloatProperty: RunStatePelvisSway
    /// </summary>
    public unsafe float RunStatePelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12824); }
    }

    /// <summary>
    /// FloatProperty: DefaultPelvisFollowZ
    /// </summary>
    public unsafe float DefaultPelvisFollowZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12828); }
    }

    /// <summary>
    /// FloatProperty: DefaultPelvisFollowXY
    /// </summary>
    public unsafe float DefaultPelvisFollowXY
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12832); }
    }

    /// <summary>
    /// FloatProperty: DefaultPelvisSway
    /// </summary>
    public unsafe float DefaultPelvisSway
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12836); }
    }

    /// <summary>
    /// FloatProperty: LastCollisionDistSqr
    /// </summary>
    public unsafe float LastCollisionDistSqr
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12840); }
    }

    /// <summary>
    /// FloatProperty: MaxCollisionDist
    /// </summary>
    public unsafe float MaxCollisionDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12844); }
    }

    /// <summary>
    /// StructProperty: CustomCameraConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig CustomCameraConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.R3rdPersonCamera.FFreeCameraConfig>(Ptr + 12848);

    /// <summary>
    /// StructProperty: CustomCameraExtraRot
    /// </summary>
    public unsafe ref BmSDK.Rotator CustomCameraExtraRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12972);

    /// <summary>
    /// FloatProperty: CustomCameraFOV
    /// </summary>
    public unsafe float CustomCameraFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12984); }
    }

    /// <summary>
    /// FloatProperty: CustomCameraZoomFOV
    /// </summary>
    public unsafe float CustomCameraZoomFOV
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12988); }
    }

    /// <summary>
    /// StructProperty: CustomCameraRotationSpeed
    /// </summary>
    public unsafe ref BmSDK.Rotator CustomCameraRotationSpeed
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 12992);

    /// <summary>
    /// FloatProperty: CustomCameraTransitionTime
    /// </summary>
    public unsafe float CustomCameraTransitionTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13004); }
    }

    /// <summary>
    /// StructProperty: DefaultRotationSpeed
    /// </summary>
    public unsafe ref BmSDK.Rotator DefaultRotationSpeed
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 13008);

    /// <summary>
    /// ObjectProperty: ViewPP
    /// </summary>
    public unsafe BmSDK.BmGame.RRCBatarangViewPostProcess ViewPP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRCBatarangViewPostProcess>(Ptr + 13020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13020); }
    }

    /// <summary>
    /// FloatProperty: BatarangOutOfRangeFXStrength
    /// </summary>
    public unsafe float BatarangOutOfRangeFXStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13024); }
    }

    /// <summary>
    /// ObjectProperty: OverlayPlayer
    /// </summary>
    public unsafe BmSDK.BmGame.RCameraOverlayPlayer OverlayPlayer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCameraOverlayPlayer>(Ptr + 13028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13028); }
    }

    /// <summary>
    /// FloatProperty: PitchDragSpeed
    /// </summary>
    public unsafe float PitchDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13032); }
    }

    /// <summary>
    /// FloatProperty: DefaultPitchDragSpeed
    /// </summary>
    public unsafe float DefaultPitchDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13036); }
    }

    /// <summary>
    /// FloatProperty: FallingPitchDragSpeed
    /// </summary>
    public unsafe float FallingPitchDragSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 13040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13040); }
    }

    /// <summary>
    /// Struct: FFreeCameraConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 124)]
    public partial record struct FFreeCameraConfig
    {
        /// <summary>
        /// StructProperty: StateFreeCameraSitOffsetMin
        /// </summary>
        public unsafe System.Numerics.Vector3 StateFreeCameraSitOffsetMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCameraSitOffsetMax
        /// </summary>
        public unsafe System.Numerics.Vector3 StateFreeCameraSitOffsetMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCameraPullOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 StateFreeCameraPullOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: CameraPivotOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 CameraPivotOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: ZoomedOffset
        /// </summary>
        public unsafe System.Numerics.Vector3 ZoomedOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: maxPitch
        /// </summary>
        public unsafe float maxPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: MinPitch
        /// </summary>
        public unsafe float MinPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: MinFreeCameraDistance
        /// </summary>
        public unsafe float MinFreeCameraDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: MaxFreeCameraDistance
        /// </summary>
        public unsafe float MaxFreeCameraDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: ShortCamSpringConst
        /// </summary>
        public unsafe float ShortCamSpringConst
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// FloatProperty: LongCamSpringConst
        /// </summary>
        public unsafe float LongCamSpringConst
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: DefaultCameraPitch
        /// </summary>
        public unsafe float DefaultCameraPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// FloatProperty: CameraSitOffsetPower
        /// </summary>
        public unsafe float CameraSitOffsetPower
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// BoolProperty: bUseSeparate43Settings
        /// </summary>
        public unsafe bool bUseSeparate43Settings
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 92); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 92); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCamera43SitOffsetMax
        /// </summary>
        public unsafe System.Numerics.Vector3 StateFreeCamera43SitOffsetMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// StructProperty: StateFreeCamera43SitOffsetMin
        /// </summary>
        public unsafe System.Numerics.Vector3 StateFreeCamera43SitOffsetMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }

        /// <summary>
        /// BoolProperty: bDontModifySitOffsetWhenLookingUp
        /// </summary>
        public unsafe bool bDontModifySitOffsetWhenLookingUp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 120); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 120); }; }
        }
    }
}
