#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RCwGrappleGun<br/>
/// (size = 4948)
/// (flags = 8388658)
/// </summary>
public partial class RCwGrappleGun : BmSDK.BmGame.RCwGrappleGunBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RCwGrappleGun", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCwGrappleGun.
    /// </summary>
    public static RCwGrappleGun DefaultObject => (RCwGrappleGun)StaticClass().DefaultObject;

    internal RCwGrappleGun() { }

    /// <summary>
    /// Constructs a new RCwGrappleGun
    /// </summary>
    public RCwGrappleGun(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCwGrappleGun(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGun>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: CanAimGrapple
    /// </summary>
    public unsafe override bool CanAimGrapple()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.CanAimGrapple", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RecalculatePath
    /// </summary>
    public unsafe virtual void RecalculatePath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.RecalculatePath", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsWallClimbMove
    /// </summary>
    public unsafe override bool IsWallClimbMove(BmSDK.BmGame.RSpecialMoveConfig Config)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.IsWallClimbMove", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: FindGrapplePointMultipleCones
    /// </summary>
    public unsafe override BmSDK.BmGame.RGrapplePoint FindGrapplePointMultipleCones(ref BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition> Cones, float MinAngle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.FindGrapplePointMultipleCones", true);
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cones, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Cones = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ModifyCone
    /// </summary>
    public unsafe virtual void ModifyCone(ref BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition> Cones, float MinAngle, System.Numerics.Vector3 CameraLocation, BmSDK.Rotator CameraRotation, System.Numerics.Vector3 PlayerLocation, bool bZoomed, float OverrideMaxDistance = default, BmSDK.FString Desc = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.ModifyCone", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Cones, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinAngle, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraRotation, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bZoomed, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideMaxDistance, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Desc, paramsPtr + 60);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Cones = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGrappleGun.FGrappleConeDefinition>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: ResetAutoSwing
    /// </summary>
    public unsafe virtual void ResetAutoSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.ResetAutoSwing", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartAutoSwing
    /// </summary>
    public unsafe virtual void StartAutoSwing(bool bTriggeredFromEdge = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.StartAutoSwing", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTriggeredFromEdge, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ScriptTick
    /// </summary>
    public unsafe override void ScriptTick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.ScriptTick", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawClimbRoute
    /// </summary>
    public unsafe override void DrawClimbRoute(bool bPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.DrawClimbRoute", true);
        byte* paramsPtr = stackalloc byte[344];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckForSwingEdge
    /// </summary>
    public unsafe virtual void CheckForSwingEdge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.CheckForSwingEdge", true);
        byte* paramsPtr = stackalloc byte[196];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawDebugInfo
    /// </summary>
    public unsafe virtual void DrawDebugInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.DrawDebugInfo", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearDebugInfo
    /// </summary>
    public unsafe virtual void ClearDebugInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.ClearDebugInfo", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpTargetInfo
    /// </summary>
    public unsafe virtual void DumpTargetInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.DumpTargetInfo", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetIdealSwingParameters
    /// </summary>
    public unsafe override void GetIdealSwingParameters(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 EndLocation, System.Numerics.Vector3 WallLocation, ref float IdealSwingTime, ref float IdealSwingLength)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.GetIdealSwingParameters", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealSwingTime, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealSwingLength, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IdealSwingTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 36);
        IdealSwingLength = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 40);
        return;
    }

    /// <summary>
    /// Function: GetAerialWhipConfig
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RSpecialMoveConfig_CwAerialWhipPounce GetAerialWhipConfig(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 EndLocation, System.Numerics.Vector3 WallLocation, BmSDK.BmGame.RPawnPlayerCatwomanBase.ESwingDirection SwingDirection = default, bool bGetSafeMove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.GetAerialWhipConfig", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SwingDirection, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGetSafeMove, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RSpecialMoveConfig_CwAerialWhipPounce>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: TriggerAerialWhipPounce
    /// </summary>
    public unsafe virtual bool TriggerAerialWhipPounce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.TriggerAerialWhipPounce", true);
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TriggerAerialAutoWhipPounce
    /// </summary>
    public unsafe virtual bool TriggerAerialAutoWhipPounce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.TriggerAerialAutoWhipPounce", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StartWallClimbCamera
    /// </summary>
    public unsafe override void StartWallClimbCamera(System.Numerics.Vector3 CurrentLandLocation, int FirstClimbPointIndex = default, bool bEstimatedLandPoint = default, bool bFromSwing = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.StartWallClimbCamera", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentLandLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstClimbPointIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEstimatedLandPoint, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFromSwing, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerClawClimb
    /// </summary>
    public unsafe virtual void TriggerClawClimb(bool bForceClawClimb)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.TriggerClawClimb", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceClawClimb, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerPounce
    /// </summary>
    public unsafe virtual void TriggerPounce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.TriggerPounce", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryAerialSwingMove
    /// </summary>
    public unsafe virtual bool TryAerialSwingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.TryAerialSwingMove", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Grapple
    /// </summary>
    public unsafe override bool Grapple(BmSDK.BmGame.RSpecialMoveConfig OverrideGrappleMove = default, bool bForceSucced = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RCwGrappleGun.Grapple", true);
        byte* paramsPtr = stackalloc byte[1180];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideGrappleMove, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceSucced, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// IntProperty: FrameCount
    /// </summary>
    public unsafe int FrameCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4916); }
    }

    /// <summary>
    /// StructProperty: DirectPounceDetectShift
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DirectPounceDetectShift
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4920);

    /// <summary>
    /// BoolProperty: bDebugDirectPounceFeatureDetection
    /// </summary>
    public unsafe bool bDebugDirectPounceFeatureDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4932) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4932); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4932); }
    }

    /// <summary>
    /// FloatProperty: ShortJumpOffPitchDown
    /// </summary>
    public unsafe float ShortJumpOffPitchDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4936); }
    }

    /// <summary>
    /// FloatProperty: ShortJumpOffRelativePitchDown
    /// </summary>
    public unsafe float ShortJumpOffRelativePitchDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4940); }
    }

    /// <summary>
    /// IntProperty: MaximumClimb
    /// </summary>
    public unsafe int MaximumClimb
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4944); }
    }
}
