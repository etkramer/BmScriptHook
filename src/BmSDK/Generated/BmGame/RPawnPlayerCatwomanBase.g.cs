#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerCatwomanBase<br/>
/// (size = 6148)
/// (flags = 144703670)
/// </summary>
public partial class RPawnPlayerCatwomanBase : BmSDK.BmGame.RPawnPlayer, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerCatwomanBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerCatwomanBase.
    /// </summary>
    public static RPawnPlayerCatwomanBase DefaultObject => (RPawnPlayerCatwomanBase)StaticClass().DefaultObject;

    internal RPawnPlayerCatwomanBase() { }

    /// <summary>
    /// Constructs a new RPawnPlayerCatwomanBase
    /// </summary>
    public RPawnPlayerCatwomanBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerCatwomanBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwomanBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: CanJumpOffWallStick
    /// </summary>
    public unsafe virtual bool CanJumpOffWallStick(BmSDK.BmGame.RSpecialMoveConfig Config, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.CanJumpOffWallStick", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 116);
    }

    /// <summary>
    /// Function: FlushDebugDraws
    /// </summary>
    public unsafe virtual void FlushDebugDraws(bool bOnlyOncePerFrame = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.FlushDebugDraws", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyOncePerFrame, paramsPtr + 0);
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
    /// Function: OnHelicopterHit
    /// </summary>
    public unsafe virtual void OnHelicopterHit(BmSDK.BmGame.RHelicopterBase Heli, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.OnHelicopterHit", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heli, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClampPointToCeilingVolumes
    /// </summary>
    public unsafe virtual bool ClampPointToCeilingVolumes(ref System.Numerics.Vector3 Point, float ExtraShiftInwards = default, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.ClampPointToCeilingVolumes", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Point, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraShiftInwards, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Point = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: UpdateTouchingCeilingVolume
    /// </summary>
    public unsafe virtual void UpdateTouchingCeilingVolume()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.UpdateTouchingCeilingVolume", true);
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
    /// Function: ButtonMashPenalty
    /// </summary>
    public unsafe virtual void ButtonMashPenalty()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.ButtonMashPenalty", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetAutoSwing
    /// </summary>
    public unsafe virtual void ResetAutoSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.ResetAutoSwing", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerAerialWhipPounce
    /// </summary>
    public unsafe virtual bool TriggerAerialWhipPounce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.TriggerAerialWhipPounce", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetEdgeSwingGrappleLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingGrappleLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetEdgeSwingGrappleLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetEdgeSwingWallLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingWallLocation(ref System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetEdgeSwingWallLocation", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        WallNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetEdgeSwingStartLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingStartLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetEdgeSwingStartLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsAutoSwingToGargoyle
    /// </summary>
    public unsafe virtual bool IsAutoSwingToGargoyle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.IsAutoSwingToGargoyle", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsAutoSwing
    /// </summary>
    public unsafe virtual bool IsAutoSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.IsAutoSwing", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsConcealedDuringSwing
    /// </summary>
    public unsafe virtual bool IsConcealedDuringSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.IsConcealedDuringSwing", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetAutoSwingState
    /// </summary>
    public unsafe virtual void SetAutoSwingState(BmSDK.BmGame.RPawnPlayerCatwomanBase.EAutoSwingState State)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.SetAutoSwingState", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(State, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RecalculatePath
    /// </summary>
    public unsafe virtual void RecalculatePath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.RecalculatePath", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasPath
    /// </summary>
    public unsafe virtual bool HasPath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.HasPath", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearPath
    /// </summary>
    public unsafe virtual void ClearPath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.ClearPath", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetAllowAerialWhipPounce
    /// </summary>
    public unsafe virtual void SetAllowAerialWhipPounce(bool bAllow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.SetAllowAerialWhipPounce", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllow, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerHitAndDropFromCeilingMove
    /// </summary>
    public unsafe virtual void TriggerHitAndDropFromCeilingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.TriggerHitAndDropFromCeilingMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetWhipTargetPose
    /// </summary>
    public unsafe virtual void SetWhipTargetPose(System.Numerics.Vector3 NewPosition, BmSDK.Rotator NewRotation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.SetWhipTargetPose", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 12);
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
    /// Function: GetWhipTargetPose
    /// </summary>
    public unsafe virtual void GetWhipTargetPose(ref System.Numerics.Vector3 OutPosition, ref BmSDK.Rotator OutRotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetWhipTargetPose", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutRotation, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutPosition = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        OutRotation = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: FindNearbyLedgeFromCeiling
    /// </summary>
    public unsafe virtual bool FindNearbyLedgeFromCeiling(System.Numerics.Vector3 PlayerLocation, ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Locator)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.FindNearbyLedgeFromCeiling", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Locator, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Locator = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 124);
    }

    /// <summary>
    /// Function: AddEdgeCollisionNormals
    /// </summary>
    public unsafe virtual void AddEdgeCollisionNormals(System.Numerics.Vector3 Delta)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.AddEdgeCollisionNormals", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
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
    /// Function: SlideOffCeilingVolumeBorders
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 SlideOffCeilingVolumeBorders(System.Numerics.Vector3 Delta)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.SlideOffCeilingVolumeBorders", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: RestrictMoveToCeiling
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 RestrictMoveToCeiling(System.Numerics.Vector3 Delta)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.RestrictMoveToCeiling", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Delta, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(ref BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.GetThoughts", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThoughtList, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: DrawSwingSpot
    /// </summary>
    public unsafe virtual void DrawSwingSpot()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.DrawSwingSpot", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawSwingLastFrame
    /// </summary>
    public unsafe virtual void DrawSwingLastFrame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.DrawSwingLastFrame", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopSwingFallSound
    /// </summary>
    public unsafe virtual void StopSwingFallSound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.StopSwingFallSound", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartSwingFallSound
    /// </summary>
    public unsafe virtual void StartSwingFallSound()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerCatwomanBase.StartSwingFallSound", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: ESwingDirection
    /// </summary>
    public enum ESwingDirection : byte
    {
        SWD_Default = 0,
        SWD_Left = 1,
        SWD_Right = 2,
        SWD_LeftFar = 3,
        SWD_RightFar = 4,
        SWD_MAX = 5,
    }

    /// <summary>
    /// Enum: EAutoSwingState
    /// </summary>
    public enum EAutoSwingState : byte
    {
        ASS_None = 0,
        ASS_InitialJump = 1,
        ASS_Swing = 2,
        ASS_JumpToWall = 3,
        ASS_WallStick = 4,
        ASS_MAX = 5,
    }

    /// <summary>
    /// Struct: FWhipTrailData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FWhipTrailData
    {
        /// <summary>
        /// ComponentProperty: ParticleSystemComp
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent ParticleSystemComp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: BoneAttachName
        /// </summary>
        public unsafe BmSDK.FName BoneAttachName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bCurrentlyActive
        /// </summary>
        public unsafe bool bCurrentlyActive
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: LastUpdatePosition
        /// </summary>
        public unsafe System.Numerics.Vector3 LastUpdatePosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: CachedBoneAttachIndex
        /// </summary>
        public unsafe int CachedBoneAttachIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// BoolProperty: bPhysUseCeilingConstraints
    /// </summary>
    public unsafe bool bPhysUseCeilingConstraints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5956); }
    }

    /// <summary>
    /// BoolProperty: bFlipCeilingCamera
    /// </summary>
    public unsafe bool bFlipCeilingCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5956); }
    }

    /// <summary>
    /// BoolProperty: bAllowAerialWhipPounce
    /// </summary>
    public unsafe bool bAllowAerialWhipPounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5956); }
    }

    /// <summary>
    /// BoolProperty: bAutoSwingEarlyWhip
    /// </summary>
    public unsafe bool bAutoSwingEarlyWhip
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5956); }
    }

    /// <summary>
    /// BoolProperty: bAutoSwingTriggeredFromEdge
    /// </summary>
    public unsafe bool bAutoSwingTriggeredFromEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5956); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingAllowEarlyWhipIn
    /// </summary>
    public unsafe bool bDebugSwingAllowEarlyWhipIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5956); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingForceEarlyWhipIn
    /// </summary>
    public unsafe bool bDebugSwingForceEarlyWhipIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5956); }
    }

    /// <summary>
    /// BoolProperty: bDebugCeilingVisibility
    /// </summary>
    public unsafe bool bDebugCeilingVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5956); }
    }

    /// <summary>
    /// BoolProperty: bDebugCeilingEdgeDetection
    /// </summary>
    public unsafe bool bDebugCeilingEdgeDetection
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5956); }
    }

    /// <summary>
    /// BoolProperty: bPlayingSwingFallSound
    /// </summary>
    public unsafe bool bPlayingSwingFallSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5956); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawFallSwingSound
    /// </summary>
    public unsafe bool bDebugDrawFallSwingSound
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5956); }
    }

    /// <summary>
    /// BoolProperty: bDebugJumpOffWalls
    /// </summary>
    public unsafe bool bDebugJumpOffWalls
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 5956); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 5956); }
    }

    /// <summary>
    /// NameProperty: WhipSkelControlName
    /// </summary>
    public unsafe BmSDK.FName WhipSkelControlName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 5960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5960); }
    }

    /// <summary>
    /// FloatProperty: MaxDirectPounceHeightToCeilings
    /// </summary>
    public unsafe float MaxDirectPounceHeightToCeilings
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5968); }
    }

    /// <summary>
    /// ComponentProperty: WhipMesh
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent WhipMesh
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 5972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5972); }
    }

    /// <summary>
    /// FloatProperty: WhipTrailMinAppearSpeed
    /// </summary>
    public unsafe float WhipTrailMinAppearSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5976); }
    }

    /// <summary>
    /// FloatProperty: MinTrailsWhipExtent
    /// </summary>
    public unsafe float MinTrailsWhipExtent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5980); }
    }

    /// <summary>
    /// ArrayProperty: WhipTrails
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCatwomanBase.FWhipTrailData> WhipTrails
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnPlayerCatwomanBase.FWhipTrailData>>(Ptr + 5984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5984); }
    }

    /// <summary>
    /// ByteProperty: AutoSwingState
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCatwomanBase.EAutoSwingState AutoSwingState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCatwomanBase.EAutoSwingState>(Ptr + 5996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5996); }
    }

    /// <summary>
    /// ByteProperty: SwingDirection
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerCatwomanBase.ESwingDirection SwingDirection
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerCatwomanBase.ESwingDirection>(Ptr + 5997); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5997); }
    }

    /// <summary>
    /// ObjectProperty: WhipCrackFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem WhipCrackFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6000); }
    }

    /// <summary>
    /// ClassProperty: CauseTitanBeserkClass
    /// </summary>
    public unsafe BmSDK.Class CauseTitanBeserkClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 6004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6004); }
    }

    /// <summary>
    /// ObjectProperty: TouchingCeilingVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RCeilingClimbVolume TouchingCeilingVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCeilingClimbVolume>(Ptr + 6008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6008); }
    }

    /// <summary>
    /// FloatProperty: CeilingSuspiciousBodyRange
    /// </summary>
    public unsafe float CeilingSuspiciousBodyRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6012); }
    }

    /// <summary>
    /// FloatProperty: CeilingSuspiciousPredThugsRange
    /// </summary>
    public unsafe float CeilingSuspiciousPredThugsRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6016); }
    }

    /// <summary>
    /// ObjectProperty: SwingStartEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SwingStartEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6020); }
    }

    /// <summary>
    /// ObjectProperty: SwingStopEvent
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent SwingStopEvent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6024); }
    }

    /// <summary>
    /// StructProperty: LastSwingSoundLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastSwingSoundLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6028);

    /// <summary>
    /// FloatProperty: FallSoundStartSpeed
    /// </summary>
    public unsafe float FallSoundStartSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6040); }
    }

    /// <summary>
    /// FloatProperty: BolasRadius
    /// </summary>
    public unsafe float BolasRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6044); }
    }

    /// <summary>
    /// FloatProperty: BolasHeight
    /// </summary>
    public unsafe float BolasHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6048); }
    }

    /// <summary>
    /// StructProperty: BolasShift
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BolasShift
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6052);

    /// <summary>
    /// FloatProperty: BolasRBSpeedFactor
    /// </summary>
    public unsafe float BolasRBSpeedFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6064); }
    }

    /// <summary>
    /// FloatProperty: BolasRBMaxSpeed
    /// </summary>
    public unsafe float BolasRBMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6068); }
    }

    /// <summary>
    /// StructProperty: BolasAngularSpeed
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BolasAngularSpeed
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6072);

    /// <summary>
    /// FloatProperty: LastFlushPersistentLinesFrame
    /// </summary>
    public unsafe float LastFlushPersistentLinesFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6084); }
    }

    /// <summary>
    /// StructProperty: CeilingNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6088);

    /// <summary>
    /// FloatProperty: GrateClimbUpStartCheckDistance
    /// </summary>
    public unsafe float GrateClimbUpStartCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6100); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbUpTargetCheckDistance
    /// </summary>
    public unsafe float GrateClimbUpTargetCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6104); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbUpTargetFloorCheckDistance
    /// </summary>
    public unsafe float GrateClimbUpTargetFloorCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6108); }
    }

    /// <summary>
    /// FloatProperty: GrateClimbDownTargetCheckDistance
    /// </summary>
    public unsafe float GrateClimbDownTargetCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6112); }
    }

    /// <summary>
    /// FloatProperty: JumpOffWallCheckDistance
    /// </summary>
    public unsafe float JumpOffWallCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6116); }
    }

    /// <summary>
    /// ObjectProperty: JammerTakedownPlayerAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet JammerTakedownPlayerAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6120); }
    }

    /// <summary>
    /// ObjectProperty: JammerTakedownVictimAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet JammerTakedownVictimAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 6124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6124); }
    }

    /// <summary>
    /// FloatProperty: MaxPullFromCatwalkDistance
    /// </summary>
    public unsafe float MaxPullFromCatwalkDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6128); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6128); }
    }

    /// <summary>
    /// StructProperty: PullFromCatwalkEdgeCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PullFromCatwalkEdgeCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6132);

    /// <summary>
    /// FloatProperty: PullFromCatwalkEdgeCheckShift
    /// </summary>
    public unsafe float PullFromCatwalkEdgeCheckShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6144); }
    }
}
