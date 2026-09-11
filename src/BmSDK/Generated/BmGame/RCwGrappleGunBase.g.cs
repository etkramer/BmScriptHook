#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RCwGrappleGunBase<br/>
/// (size = 4916)
/// (flags = 142606514)
/// </summary>
public partial class RCwGrappleGunBase : BmSDK.BmGame.RGrappleGun, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RCwGrappleGunBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RCwGrappleGunBase.
    /// </summary>
    public static RCwGrappleGunBase DefaultObject => (RCwGrappleGunBase)StaticClass().DefaultObject;

    internal RCwGrappleGunBase() { }

    /// <summary>
    /// Constructs a new RCwGrappleGunBase
    /// </summary>
    public RCwGrappleGunBase(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RCwGrappleGunBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RCwGrappleGunBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: PointAndLineCheck
    /// </summary>
    public unsafe virtual bool PointAndLineCheck(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 End, System.Numerics.Vector3 Start, System.Numerics.Vector3 Extent, int ExtraTraceFlags = default, bool bIgnoreRailings = default, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.PointAndLineCheck", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ExtraTraceFlags, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreRailings, paramsPtr + 64);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 68);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 72);
    }

    /// <summary>
    /// Function: GetChainStartLocator
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RClimbLocator GetChainStartLocator(System.Numerics.Vector3 PlayerLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetChainStartLocator", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RClimbLocator>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetLocatorChainLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLocatorChainLocation(BmSDK.BmGame.RClimbLocator LowestChainLocator, System.Numerics.Vector3 InLocation, System.Numerics.Vector3 TargetLocation, bool bAlignLowerPoints = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetLocatorChainLocation", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LowestChainLocator, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAlignLowerPoints, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: HandleGlobalPounceTargeting
    /// </summary>
    public unsafe virtual void HandleGlobalPounceTargeting()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.HandleGlobalPounceTargeting", true);
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
    /// Function: PickNextLowerSwingHeight
    /// </summary>
    public unsafe virtual bool PickNextLowerSwingHeight(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo ClimbInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.PickNextLowerSwingHeight", true);
        byte* paramsPtr = stackalloc byte[988];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 984);
    }

    /// <summary>
    /// Function: CheckForCeilingTarget
    /// </summary>
    public unsafe virtual bool CheckForCeilingTarget(out System.Numerics.Vector3 CeilingTargetLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckForCeilingTarget", true);
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CeilingTargetLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: CheckThisGrapple
    /// </summary>
    public unsafe virtual bool CheckThisGrapple(BmSDK.BmGame.RGrapplePoint ThisGrapplePoint = default, BmSDK.BmGame.RHidePoint ThisHidePoint = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckThisGrapple", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThisHidePoint, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetInBoundVector
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetInBoundVector(System.Numerics.Vector3 StartVelocity, System.Numerics.Vector3 EndVelocity)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetInBoundVector", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndVelocity, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: StoreCurrentClimbInfo
    /// </summary>
    public unsafe virtual void StoreCurrentClimbInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.StoreCurrentClimbInfo", true);
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
    /// Function: DrawPounceBlockingVolumes
    /// </summary>
    public unsafe virtual bool DrawPounceBlockingVolumes(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo Info, bool bDrawPersistent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.DrawPounceBlockingVolumes", true);
        byte* paramsPtr = stackalloc byte[992];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 984);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 988);
    }

    /// <summary>
    /// Function: CheckWallPounce
    /// </summary>
    public unsafe virtual bool CheckWallPounce(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo Info, out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath NewPath, int FromPoint, bool bOptimisePass, bool bTweakFinalPounce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckWallPounce", true);
        byte* paramsPtr = stackalloc byte[1180];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromPoint, paramsPtr + 1164);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOptimisePass, paramsPtr + 1168);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTweakFinalPounce, paramsPtr + 1172);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        NewPath = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath>(paramsPtr + 984);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 1176);
    }

    /// <summary>
    /// Function: OptimisePath
    /// </summary>
    public unsafe virtual void OptimisePath(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo Info, bool bIgnoreDangleEdges)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.OptimisePath", true);
        byte* paramsPtr = stackalloc byte[988];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreDangleEdges, paramsPtr + 984);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetClosestLandEdge
    /// </summary>
    public unsafe virtual bool GetClosestLandEdge(System.Numerics.Vector3 OriginalLocation, System.Numerics.Vector3 OriginalNormal, out BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FClimbLedges> Ledges, float HTolerance, float VToleranceUp, float VExtraDangleToleranceUp, float VToleranceDown, bool bIgnoreLimits, bool bIgnoreDangle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetClosestLandEdge", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OriginalNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HTolerance, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VToleranceUp, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VExtraDangleToleranceUp, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VToleranceDown, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreLimits, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreDangle, paramsPtr + 56);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Ledges = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FClimbLedges>>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 60);
    }

    /// <summary>
    /// Function: DrawClimbRoute
    /// </summary>
    public unsafe virtual void DrawClimbRoute(bool bPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.DrawClimbRoute", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsWallClimbMove
    /// </summary>
    public unsafe virtual bool IsWallClimbMove(BmSDK.BmGame.RSpecialMoveConfig Config)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsWallClimbMove", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: StartWallClimbCamera
    /// </summary>
    public unsafe virtual void StartWallClimbCamera(System.Numerics.Vector3 CurrentLandLocation, int FirstClimbPointIndex = default, bool bEstimatedLandPoint = default, bool bFromSwing = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.StartWallClimbCamera", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentLandLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FirstClimbPointIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEstimatedLandPoint, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFromSwing, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanClimbToHidePoint
    /// </summary>
    public unsafe virtual bool CanClimbToHidePoint(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 GrappleLocation, System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CanClimbToHidePoint", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrappleLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: CanClimbToGrapplePoint
    /// </summary>
    public unsafe virtual bool CanClimbToGrapplePoint(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 GrappleLocation, System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CanClimbToGrapplePoint", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrappleLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: ClampToLineSegment
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 ClampToLineSegment(System.Numerics.Vector3 P, System.Numerics.Vector3 A, System.Numerics.Vector3 B)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.ClampToLineSegment", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: InitialWallCheck
    /// </summary>
    public unsafe virtual bool InitialWallCheck(System.Numerics.Vector3 WallLocation, System.Numerics.Vector3 WallNormal, System.Numerics.Vector3 Right, float OutTolerance, float InTolerance, System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 TargetWallLocation, BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath NewPath, BmSDK.BmGame.RCwGrappleGunBase.EStartPoints StartCheck, bool bForcePounceCheck, out System.Numerics.Vector3 NewWallLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.InitialWallCheck", true);
        byte* paramsPtr = stackalloc byte[272];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Right, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutTolerance, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTolerance, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetWallLocation, paramsPtr + 56);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPath, paramsPtr + 68);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartCheck, paramsPtr + 248);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForcePounceCheck, paramsPtr + 252);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        NewWallLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 256);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 268);
    }

    /// <summary>
    /// Function: CreateClimbRoute
    /// </summary>
    public unsafe virtual bool CreateClimbRoute(out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool bPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CreateClimbRoute", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 112);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 116);
    }

    /// <summary>
    /// Function: CheckPounceToGrapple
    /// </summary>
    public unsafe virtual bool CheckPounceToGrapple(System.Numerics.Vector3 TargetLoc, System.Numerics.Vector3 WallNormal, System.Numerics.Vector3 PlayerLoc, bool bDrawDebug = default, bool bDrawPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckPounceToGrapple", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLoc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: InitialPathCheck
    /// </summary>
    public unsafe virtual bool InitialPathCheck(BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath NewPath, System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 TargetWallLocation, System.Numerics.Vector3 WallLocation, System.Numerics.Vector3 WallNormal, System.Numerics.Vector3 CheckExtent, bool bLimitCheckToPlane)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.InitialPathCheck", true);
        byte* paramsPtr = stackalloc byte[248];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 180);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetWallLocation, paramsPtr + 192);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 204);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 216);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckExtent, paramsPtr + 228);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLimitCheckToPlane, paramsPtr + 240);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 244);
    }

    /// <summary>
    /// Function: CheckPounceToWall
    /// </summary>
    public unsafe virtual bool CheckPounceToWall(System.Numerics.Vector3 WallLoc, System.Numerics.Vector3 WallNormal, System.Numerics.Vector3 PlayerLoc, bool bLimitCheckToPlane, bool bDrawDebug = default, bool bDrawPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckPounceToWall", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLoc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLimitCheckToPlane, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: GetBestWallClimbIndex
    /// </summary>
    public unsafe virtual int GetBestWallClimbIndex(System.Numerics.Vector3 EndLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetBestWallClimbIndex", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetAerialSwingGrappleTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAerialSwingGrappleTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingGrappleTarget", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetAerialSwingTargetNormal
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAerialSwingTargetNormal(BmSDK.BmGame.RGrapplePoint NewGrapplePoint = default, System.Numerics.Vector3 TargetLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingTargetNormal", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetAerialSwingTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAerialSwingTargetLocation(bool bOnlyEstimate = default, bool bOnWall = default, bool bDebugDraw = default, bool bDrawPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingTargetLocation", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEstimate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnWall, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetAerialSwingEstimatedTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetAerialSwingEstimatedTarget(BmSDK.BmGame.RGrapplePoint NewGrapplePoint = default, System.Numerics.Vector3 TargetLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingEstimatedTarget", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetIdealSwingParameters
    /// </summary>
    public unsafe virtual void GetIdealSwingParameters(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 EndLocation, System.Numerics.Vector3 WallLocation, out float IdealSwingTime, out float IdealSwingLength)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetIdealSwingParameters", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        IdealSwingTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 36);
        IdealSwingLength = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 40);
        return;
    }

    /// <summary>
    /// Function: GetAerialSwingWallEndParams
    /// </summary>
    public unsafe virtual bool GetAerialSwingWallEndParams(out System.Numerics.Vector3 PlayerLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingWallEndParams", true);
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetAerialSwingEndParams
    /// </summary>
    public unsafe virtual void GetAerialSwingEndParams(out System.Numerics.Vector3 PlayerLocation, bool bOnlyEstimate = default, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingEndParams", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEstimate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetAerialSwingStartParams
    /// </summary>
    public unsafe virtual bool GetAerialSwingStartParams(out System.Numerics.Vector3 Origin, out System.Numerics.Vector3 StartVelocity, out float StartTime, bool bDrawDebug)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetAerialSwingStartParams", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Origin = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        StartVelocity = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        StartTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: IsValidClimbStartPoint
    /// </summary>
    public unsafe virtual bool IsValidClimbStartPoint(BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath CheckPath, bool bNewPath = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsValidClimbStartPoint", true);
        byte* paramsPtr = stackalloc byte[188];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckPath, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewPath, paramsPtr + 180);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 184);
    }

    /// <summary>
    /// Function: GetEdgeSwingGrappleTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingGrappleTarget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingGrappleTarget", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetEdgeSwingGrappleTargetingParams
    /// </summary>
    public unsafe virtual void GetEdgeSwingGrappleTargetingParams(out System.Numerics.Vector3 Origin, out BmSDK.Rotator AimDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingGrappleTargetingParams", true);
        byte* paramsPtr = stackalloc byte[24];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Origin = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        AimDirection = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: GetEdgeSwingWallLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingWallLocation(out System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingWallLocation", true);
        byte* paramsPtr = stackalloc byte[24];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        WallNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetEdgeSwingWallEndParams
    /// </summary>
    public unsafe virtual void GetEdgeSwingWallEndParams(out System.Numerics.Vector3 PlayerLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingWallEndParams", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetEdgeSwingEndParams
    /// </summary>
    public unsafe virtual void GetEdgeSwingEndParams(out System.Numerics.Vector3 PlayerLocation, bool bOnlyEstimate = default, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingEndParams", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEstimate, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        PlayerLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetEdgeSwingTargetNormal
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingTargetNormal(BmSDK.BmGame.RGrapplePoint NewGrapplePoint = default, System.Numerics.Vector3 TargetLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingTargetNormal", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetEdgeSwingTargetLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingTargetLocation(bool bOnlyEstimate = default, bool bOnWall = default, bool bDebugDraw = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingTargetLocation", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnlyEstimate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnWall, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 8);
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
    /// Function: GetEdgeSwingEstimatedTarget
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetEdgeSwingEstimatedTarget(BmSDK.BmGame.RGrapplePoint NewGrapplePoint = default, System.Numerics.Vector3 TargetLocation = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingEstimatedTarget", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrapplePoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetEdgeSwingStartParams
    /// </summary>
    public unsafe virtual bool GetEdgeSwingStartParams(out System.Numerics.Vector3 Origin, out System.Numerics.Vector3 StartVelocity, out float StartTime, bool bDrawDebug)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetEdgeSwingStartParams", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Origin = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        StartVelocity = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        StartTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: IsWallClimbStartInDirectPounceRange
    /// </summary>
    public unsafe virtual bool IsWallClimbStartInDirectPounceRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsWallClimbStartInDirectPounceRange", true);
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
    /// Function: IsHidePointInClimbDistance
    /// </summary>
    public unsafe virtual bool IsHidePointInClimbDistance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsHidePointInClimbDistance", true);
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
    /// Function: IsHidePointInPounceDistance
    /// </summary>
    public unsafe virtual bool IsHidePointInPounceDistance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsHidePointInPounceDistance", true);
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
    /// Function: IsGrapplePointInClimbDistance
    /// </summary>
    public unsafe virtual bool IsGrapplePointInClimbDistance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsGrapplePointInClimbDistance", true);
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
    /// Function: IsGrapplePointInPounceDistance
    /// </summary>
    public unsafe virtual bool IsGrapplePointInPounceDistance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsGrapplePointInPounceDistance", true);
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
    /// Function: TraceGroundPath
    /// </summary>
    public unsafe virtual bool TraceGroundPath(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 DirXY, int Steps, float HeightTolerance, bool bDebugExtraPounce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.TraceGroundPath", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DirXY, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Steps, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HeightTolerance, paramsPtr + 40);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugExtraPounce, paramsPtr + 44);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 48);
    }

    /// <summary>
    /// Function: TraceGround
    /// </summary>
    public unsafe virtual bool TraceGround(out System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Direction, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool bDebugExtraPounce)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.TraceGround", true);
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugExtraPounce, paramsPtr + 136);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 140);
    }

    /// <summary>
    /// Function: CanLongPounce
    /// </summary>
    public unsafe virtual bool CanLongPounce(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo Info, bool bHideOrGrapplePoint, System.Numerics.Vector3 WallLocation, out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, bool bDebugLongPounce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CanLongPounce", true);
        byte* paramsPtr = stackalloc byte[1120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHideOrGrapplePoint, paramsPtr + 984);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 988);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugLongPounce, paramsPtr + 1112);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Info = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 1000);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 1116);
    }

    /// <summary>
    /// Function: CheckLongPounceFloor
    /// </summary>
    public unsafe virtual bool CheckLongPounceFloor(out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, System.Numerics.Vector3 WallLocation, System.Numerics.Vector3 WallNormal, bool bDebugDraw = default, bool bDebugLongPounce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckLongPounceFloor", true);
        byte* paramsPtr = stackalloc byte[148];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 112);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 124);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugLongPounce, paramsPtr + 140);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 144);
    }

    /// <summary>
    /// Function: IsLongPounceDist
    /// </summary>
    public unsafe virtual bool IsLongPounceDist(System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 WallLocation, bool bDirectPounceCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsLongPounceDist", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDirectPounceCheck, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: CheckAerialSwing
    /// </summary>
    public unsafe virtual bool CheckAerialSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckAerialSwing", true);
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
    /// Function: CheckAerialSwingCollision
    /// </summary>
    public unsafe virtual bool CheckAerialSwingCollision(out System.Numerics.Vector3 FirstHitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckAerialSwingCollision", true);
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FirstHitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: CheckEdgeSwingCollision
    /// </summary>
    public unsafe virtual bool CheckEdgeSwingCollision(out System.Numerics.Vector3 FirstHitLocation, bool bTryShortJump = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckEdgeSwingCollision", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bTryShortJump, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        FirstHitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: UpdateInitialLocator
    /// </summary>
    public unsafe virtual bool UpdateInitialLocator(out BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath CheckPath, bool bNewPath = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.UpdateInitialLocator", true);
        byte* paramsPtr = stackalloc byte[300];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewPath, paramsPtr + 292);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Loc = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(paramsPtr + 0);
        CheckPath = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath>(paramsPtr + 112);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 296);
    }

    /// <summary>
    /// Function: CheckSwingFromEdge
    /// </summary>
    public unsafe virtual bool CheckSwingFromEdge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckSwingFromEdge", true);
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
    /// Function: GotSwingTargetPoint
    /// </summary>
    public unsafe virtual bool GotSwingTargetPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GotSwingTargetPoint", true);
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
    /// Function: GotEdgeSwingTargetPoint
    /// </summary>
    public unsafe virtual bool GotEdgeSwingTargetPoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GotEdgeSwingTargetPoint", true);
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
    /// Function: IsAutoSwingToGargoyle
    /// </summary>
    public unsafe virtual bool IsAutoSwingToGargoyle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsAutoSwingToGargoyle", true);
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
    /// Function: IsAutoSwing
    /// </summary>
    public unsafe virtual bool IsAutoSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.IsAutoSwing", true);
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
    /// Function: CheckDelayedSwing
    /// </summary>
    public unsafe virtual bool CheckDelayedSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CheckDelayedSwing", true);
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
    /// Function: HandlePounceTargeting
    /// </summary>
    public unsafe virtual void HandlePounceTargeting(bool bGrappleCheck = default, int Iteration = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.HandlePounceTargeting", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bGrappleCheck, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Iteration, paramsPtr + 4);
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
    /// Function: UpdateSwingPaths
    /// </summary>
    public unsafe virtual bool UpdateSwingPaths()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.UpdateSwingPaths", true);
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
    /// Function: SwingLineCheck
    /// </summary>
    public unsafe virtual bool SwingLineCheck(out System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 HitNormal, System.Numerics.Vector3 EndLocation, System.Numerics.Vector3 StartLocation, System.Numerics.Vector3 CheckExtent, bool bStartWithPointCheck, bool bDrawDebug = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.SwingLineCheck", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartLocation, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckExtent, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStartWithPointCheck, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawDebug, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        HitNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 68);
    }

    /// <summary>
    /// Function: GetJumpVelocity
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetJumpVelocity(System.Numerics.Vector3 Direction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetJumpVelocity", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Direction, paramsPtr + 0);
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
    /// Function: UpdateFlightPath
    /// </summary>
    public unsafe virtual void UpdateFlightPath(float DeltaTime, bool bModifyTranitionTime, bool bFirstFrame)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.UpdateFlightPath", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bModifyTranitionTime, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFirstFrame, paramsPtr + 8);
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
    /// Function: GetFlightPathDeltaTangent
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFlightPathDeltaTangent(out BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters SP, float Proportion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetFlightPathDeltaTangent", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 92);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SP = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 96);
    }

    /// <summary>
    /// Function: GetFlightPathTangent
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFlightPathTangent(out BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters SP, float Proportion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetFlightPathTangent", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 92);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SP = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 96);
    }

    /// <summary>
    /// Function: GetFlightPathPosition
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetFlightPathPosition(out BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters SP, float Proportion)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.GetFlightPathPosition", true);
        byte* paramsPtr = stackalloc byte[108];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Proportion, paramsPtr + 92);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        SP = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 96);
    }

    /// <summary>
    /// Function: DrawSwingPath
    /// </summary>
    public unsafe virtual void DrawSwingPath(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo ClimbInfo, bool bPersistent = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.DrawSwingPath", true);
        byte* paramsPtr = stackalloc byte[988];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bPersistent, paramsPtr + 984);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: CalculateSwingPath
    /// </summary>
    public unsafe virtual bool CalculateSwingPath(out BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo ClimbInfo, System.Numerics.Vector3 DesiredStartLocation, System.Numerics.Vector3 TargetLocation, System.Numerics.Vector3 StartVelocity, System.Numerics.Vector3 EndVelocity, float IdealSwingTime, float IdealSwingLength, float CheckSizeMod, out System.Numerics.Vector3 FirstHitLocation, bool bDebugDraw, bool bDrawPersistent)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RCwGrappleGunBase.CalculateSwingPath", true);
        byte* paramsPtr = stackalloc byte[1068];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DesiredStartLocation, paramsPtr + 984);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLocation, paramsPtr + 996);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartVelocity, paramsPtr + 1008);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndVelocity, paramsPtr + 1020);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealSwingTime, paramsPtr + 1032);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdealSwingLength, paramsPtr + 1036);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckSizeMod, paramsPtr + 1040);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugDraw, paramsPtr + 1056);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDrawPersistent, paramsPtr + 1060);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ClimbInfo = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(paramsPtr + 0);
        FirstHitLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 1044);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 1064);
    }

    /// <summary>
    /// Struct: FClimbLedges
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FClimbLedges
    {
        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Normal
        /// </summary>
        public unsafe System.Numerics.Vector3 Normal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bDangleLedge
        /// </summary>
        public unsafe bool bDangleLedge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: EClawClimbStartMode
    /// </summary>
    public enum EClawClimbStartMode : byte
    {
        CCSM_FromGround = 0,
        CCSM_FromWallStick = 1,
        CCSM_FromSwing = 2,
        CCSM_FromShortSwing = 3,
        CCSM_MAX = 4,
    }

    /// <summary>
    /// Struct: FWallClimbInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 984)]
    public partial record struct FWallClimbInfo
    {
        /// <summary>
        /// StructProperty: ClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath ClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbPath>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bGotValidPath
        /// </summary>
        public unsafe bool bGotValidPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }; }
        }

        /// <summary>
        /// BoolProperty: bEdgeSwingCheckNewPath
        /// </summary>
        public unsafe bool bEdgeSwingCheckNewPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }; }
        }

        /// <summary>
        /// BoolProperty: bUsingFallbackPath
        /// </summary>
        public unsafe bool bUsingFallbackPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }; }
        }

        /// <summary>
        /// BoolProperty: bFromWallStick
        /// </summary>
        public unsafe bool bFromWallStick
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 180); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 180); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailedPreferedClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection LastFailedPreferedClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 184); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 184); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailedEdgeSwingPreferedClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection LastFailedEdgeSwingPreferedClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 185); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 185); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailedAerialSwingPreferedClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection LastFailedAerialSwingPreferedClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 186); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 186); }; }
        }

        /// <summary>
        /// BoolProperty: bLastFailedDueToPounceDistance
        /// </summary>
        public unsafe bool bLastFailedDueToPounceDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 188); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 188); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailReason
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.ClimbPathFailReason LastFailReason
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.ClimbPathFailReason>(Ptr + 192); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 192); }; }
        }

        /// <summary>
        /// ByteProperty: LastSuccessfulPreferedClimbPath
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection LastSuccessfulPreferedClimbPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 193); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 193); }; }
        }

        /// <summary>
        /// ByteProperty: LastFailedStartPoint
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EStartPoints LastFailedStartPoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EStartPoints>(Ptr + 194); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 194); }; }
        }

        /// <summary>
        /// StructProperty: LastCheckedAerialSwingStart
        /// </summary>
        public unsafe System.Numerics.Vector3 LastCheckedAerialSwingStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }

        /// <summary>
        /// StructProperty: InitialLocator
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator InitialLocator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }; }
        }

        /// <summary>
        /// ObjectProperty: LastValidGrapplePoint
        /// </summary>
        public unsafe BmSDK.BmGame.RGrapplePoint LastValidGrapplePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 320); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 320); }; }
        }

        /// <summary>
        /// ObjectProperty: LastValidHidePoint
        /// </summary>
        public unsafe BmSDK.BmGame.RHidePoint LastValidHidePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 324); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 324); }; }
        }

        /// <summary>
        /// BoolProperty: bLastValidIsCeilingTarget
        /// </summary>
        public unsafe bool bLastValidIsCeilingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 328); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 328); }; }
        }

        /// <summary>
        /// StructProperty: LastValidCeilingLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastValidCeilingLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 332); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 332); }; }
        }

        /// <summary>
        /// StructProperty: WallNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 WallNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 344); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 344); }; }
        }

        /// <summary>
        /// StructProperty: LastTargetLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastTargetLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 356); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 356); }; }
        }

        /// <summary>
        /// StructProperty: LastTargetWallLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastTargetWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 368); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 368); }; }
        }

        /// <summary>
        /// StructProperty: LastMaxRight
        /// </summary>
        public unsafe System.Numerics.Vector3 LastMaxRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 380); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 380); }; }
        }

        /// <summary>
        /// StructProperty: LastMaxLeft
        /// </summary>
        public unsafe System.Numerics.Vector3 LastMaxLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 392); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 392); }; }
        }

        /// <summary>
        /// StructProperty: LastGrappleRight
        /// </summary>
        public unsafe System.Numerics.Vector3 LastGrappleRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 404); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 404); }; }
        }

        /// <summary>
        /// StructProperty: LastGrappleLeft
        /// </summary>
        public unsafe System.Numerics.Vector3 LastGrappleLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 416); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 416); }; }
        }

        /// <summary>
        /// BoolProperty: bLastExtremeRight
        /// </summary>
        public unsafe bool bLastExtremeRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }; }
        }

        /// <summary>
        /// BoolProperty: bLastExtremeLeft
        /// </summary>
        public unsafe bool bLastExtremeLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }; }
        }

        /// <summary>
        /// StructProperty: EdgeSwingLaunchLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 EdgeSwingLaunchLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 432); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }; }
        }

        /// <summary>
        /// BoolProperty: bEdgeSwingPointCheckFailed
        /// </summary>
        public unsafe bool bEdgeSwingPointCheckFailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bValidEdgeSwingTarget
        /// </summary>
        public unsafe bool bValidEdgeSwingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bAerialSwingPointCheckFailed
        /// </summary>
        public unsafe bool bAerialSwingPointCheckFailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bValidAerialSwingTarget
        /// </summary>
        public unsafe bool bValidAerialSwingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bValidDirectPounceTarget
        /// </summary>
        public unsafe bool bValidDirectPounceTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bValidWallClimbTarget
        /// </summary>
        public unsafe bool bValidWallClimbTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bValidCeilingTarget
        /// </summary>
        public unsafe bool bValidCeilingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// BoolProperty: bValidVantageSwingTarget
        /// </summary>
        public unsafe bool bValidVantageSwingTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444) & 128) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 444); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 444); }; }
        }

        /// <summary>
        /// StructProperty: AssociatedGrapplePoint
        /// </summary>
        public unsafe System.IntPtr AssociatedGrapplePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 448); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 448); }; }
        }

        /// <summary>
        /// FloatProperty: AssociatedBonusScore
        /// </summary>
        public unsafe float AssociatedBonusScore
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 452); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 452); }; }
        }

        /// <summary>
        /// StructProperty: LockedExtendedEdgeSwingStart
        /// </summary>
        public unsafe System.Numerics.Vector3 LockedExtendedEdgeSwingStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 456); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }; }
        }

        /// <summary>
        /// StructProperty: LockedExtendedEdgeSwingWallLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LockedExtendedEdgeSwingWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 468); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }; }
        }

        /// <summary>
        /// StructProperty: LockedExtendedAerialSwingStart
        /// </summary>
        public unsafe System.Numerics.Vector3 LockedExtendedAerialSwingStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 480); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }; }
        }

        /// <summary>
        /// StructProperty: PlayerStartLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 PlayerStartLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 492); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }; }
        }

        /// <summary>
        /// FloatProperty: SwingHeightOffset
        /// </summary>
        public unsafe float SwingHeightOffset
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }; }
        }

        /// <summary>
        /// BoolProperty: bDebugNewPath
        /// </summary>
        public unsafe bool bDebugNewPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 508); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 508); }; }
        }

        /// <summary>
        /// StructProperty: InitialWallLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 InitialWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 512); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }; }
        }

        /// <summary>
        /// StructProperty: InitialLandLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 InitialLandLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 524); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }; }
        }

        /// <summary>
        /// StructProperty: SwingParams
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters SwingParams
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.FSwingParameters>(Ptr + 536); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }; }
        }

        /// <summary>
        /// StructProperty: LastFailedSwingLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastFailedSwingLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 628); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }; }
        }

        /// <summary>
        /// BoolProperty: bCheckedLPounceWall
        /// </summary>
        public unsafe bool bCheckedLPounceWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 640); }; }
        }

        /// <summary>
        /// BoolProperty: bFoundLPounceWall
        /// </summary>
        public unsafe bool bFoundLPounceWall
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 640); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 640); }; }
        }

        /// <summary>
        /// StructProperty: LPounceWallLocation
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator LPounceWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 644); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }; }
        }

        /// <summary>
        /// StructProperty: LastLPounceWallCheckPlayerLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastLPounceWallCheckPlayerLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 756); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }; }
        }

        /// <summary>
        /// BoolProperty: bFoundLPounceToTarget
        /// </summary>
        public unsafe bool bFoundLPounceToTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }; }
        }

        /// <summary>
        /// BoolProperty: bCheckedLPounceToTarget
        /// </summary>
        public unsafe bool bCheckedLPounceToTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 768); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 768); }; }
        }

        /// <summary>
        /// StructProperty: LPounceToTargetLocation
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator LPounceToTargetLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 772); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 772); }; }
        }

        /// <summary>
        /// StructProperty: LastLPounceTargetCheckPlayerLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 LastLPounceTargetCheckPlayerLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 884); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 884); }; }
        }

        /// <summary>
        /// NameProperty: LastLPounceTargetCheckState
        /// </summary>
        public unsafe BmSDK.FName LastLPounceTargetCheckState
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 896); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }; }
        }

        /// <summary>
        /// IntProperty: ArrayIndex
        /// </summary>
        public unsafe int ArrayIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 904); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }; }
        }

        /// <summary>
        /// ObjectProperty: GrapplePoint
        /// </summary>
        public unsafe BmSDK.BmGame.RGrapplePoint GrapplePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 908); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }; }
        }

        /// <summary>
        /// ObjectProperty: HidePoint
        /// </summary>
        public unsafe BmSDK.BmGame.RHidePoint HidePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 912); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 912); }; }
        }

        /// <summary>
        /// BoolProperty: bEdgeSwingPointNeedsCheck
        /// </summary>
        public unsafe bool bEdgeSwingPointNeedsCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 916); }; }
        }

        /// <summary>
        /// BoolProperty: bEdgeSwingUseShortPounceOff
        /// </summary>
        public unsafe bool bEdgeSwingUseShortPounceOff
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 916); }; }
        }

        /// <summary>
        /// BoolProperty: bAerialSwingPointNeedsCheck
        /// </summary>
        public unsafe bool bAerialSwingPointNeedsCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 916); }; }
        }

        /// <summary>
        /// BoolProperty: bLastSwingCheckWasShortSwing
        /// </summary>
        public unsafe bool bLastSwingCheckWasShortSwing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 916); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 916); }; }
        }

        /// <summary>
        /// StructProperty: DebugLastSwingStartLoc
        /// </summary>
        public unsafe System.Numerics.Vector3 DebugLastSwingStartLoc
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 920); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }; }
        }

        /// <summary>
        /// StructProperty: DebugLastSwingStartVel
        /// </summary>
        public unsafe System.Numerics.Vector3 DebugLastSwingStartVel
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 932); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }; }
        }

        /// <summary>
        /// FloatProperty: SwingStartTime
        /// </summary>
        public unsafe float SwingStartTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 944); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }; }
        }

        /// <summary>
        /// IntProperty: PathRetries
        /// </summary>
        public unsafe int PathRetries
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 948); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }; }
        }

        /// <summary>
        /// IntProperty: PathRecalcs
        /// </summary>
        public unsafe int PathRecalcs
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 952); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }; }
        }

        /// <summary>
        /// StructProperty: ToGrappleLine
        /// </summary>
        public unsafe System.Numerics.Vector3 ToGrappleLine
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 956); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }; }
        }

        /// <summary>
        /// StructProperty: ToRight
        /// </summary>
        public unsafe System.Numerics.Vector3 ToRight
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 968); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }; }
        }

        /// <summary>
        /// ObjectProperty: ClimbLocator
        /// </summary>
        public unsafe BmSDK.BmGame.RClimbLocator ClimbLocator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RClimbLocator>(Ptr + 980); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }; }
        }
    }

    /// <summary>
    /// Struct: FSwingParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 92)]
    public partial record struct FSwingParameters
    {
        /// <summary>
        /// StructProperty: SwingStartLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingStartLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: SwingStartTangent
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingStartTangent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: SwingEndLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingEndLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: SwingEndTangent
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingEndTangent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: SwingWallLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 SwingWallLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: SwingTime
        /// </summary>
        public unsafe float SwingTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: OneOverSwingTime
        /// </summary>
        public unsafe float OneOverSwingTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: ProportionAlongPath
        /// </summary>
        public unsafe float ProportionAlongPath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: ProportionAtAnimationStart
        /// </summary>
        public unsafe float ProportionAtAnimationStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }

        /// <summary>
        /// FloatProperty: IdealEndYaw
        /// </summary>
        public unsafe float IdealEndYaw
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// FloatProperty: IdealStartPitch
        /// </summary>
        public unsafe float IdealStartPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: IdealEndPitch
        /// </summary>
        public unsafe float IdealEndPitch
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// BoolProperty: bUsed
        /// </summary>
        public unsafe bool bUsed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }; }
        }

        /// <summary>
        /// BoolProperty: bValid
        /// </summary>
        public unsafe bool bValid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 88); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 88); }; }
        }
    }

    /// <summary>
    /// Enum: ClimbPathFailReason
    /// </summary>
    public enum ClimbPathFailReason : byte
    {
        CPFR_None = 0,
        CPFR_NoStartPoint = 1,
        CPFR_PouncesTooFar = 2,
        CPFR_ExceedingHorizontalPounce = 3,
        CPFR_MAX = 4,
    }

    /// <summary>
    /// Struct: FWallClimbPath
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 180)]
    public partial record struct FWallClimbPath
    {
        /// <summary>
        /// BoolProperty: bSearchedEdges
        /// </summary>
        public unsafe bool bSearchedEdges
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: ClimbPoints
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FWallLandPoint> ClimbPoints
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FWallLandPoint>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bClimbToVantagePoint
        /// </summary>
        public unsafe bool bClimbToVantagePoint
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: VantagePointActor
        /// </summary>
        public unsafe BmSDK.Engine.Actor VantagePointActor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bClimbToCeiling
        /// </summary>
        public unsafe bool bClimbToCeiling
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: TargetLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: TargetNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: OriginalPlayerLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 OriginalPlayerLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// StructProperty: TargetFeature
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator TargetFeature
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: NumClimbSteps
        /// </summary>
        public unsafe float NumClimbSteps
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 176); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 176); }; }
        }
    }

    /// <summary>
    /// Struct: FWallLandPoint
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 292)]
    public partial record struct FWallLandPoint
    {
        /// <summary>
        /// BoolProperty: bFoundEdge
        /// </summary>
        public unsafe bool bFoundEdge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bDangleEdge
        /// </summary>
        public unsafe bool bDangleEdge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Location
        /// </summary>
        public unsafe System.Numerics.Vector3 Location
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: OriginalLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 OriginalLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: OriginalNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 OriginalNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// StructProperty: NextHoldLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 NextHoldLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: NextHoldNormal
        /// </summary>
        public unsafe System.Numerics.Vector3 NextHoldNormal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bGotAnyEdge
        /// </summary>
        public unsafe bool bGotAnyEdge
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 64); }; }
        }

        /// <summary>
        /// StructProperty: Normal
        /// </summary>
        public unsafe System.Numerics.Vector3 Normal
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// ByteProperty: InDir
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection InDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// ByteProperty: OutDir
        /// </summary>
        public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection OutDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbDirection>(Ptr + 81); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 81); }; }
        }

        /// <summary>
        /// StructProperty: CheckRefLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckRefLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// StructProperty: CheckStart
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// StructProperty: CheckEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 108); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 108); }; }
        }

        /// <summary>
        /// StructProperty: CheckExtent
        /// </summary>
        public unsafe System.Numerics.Vector3 CheckExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 120); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 120); }; }
        }

        /// <summary>
        /// StructProperty: HitLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 HitLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }

        /// <summary>
        /// StructProperty: FootCheckStart
        /// </summary>
        public unsafe System.Numerics.Vector3 FootCheckStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }

        /// <summary>
        /// StructProperty: FootCheckEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 FootCheckEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 156); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 156); }; }
        }

        /// <summary>
        /// StructProperty: FootCheckExtent
        /// </summary>
        public unsafe System.Numerics.Vector3 FootCheckExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 168); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 168); }; }
        }

        /// <summary>
        /// StructProperty: FootHitLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 FootHitLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 180); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 180); }; }
        }

        /// <summary>
        /// BoolProperty: FootCheckDone
        /// </summary>
        public unsafe bool FootCheckDone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 192); }; }
        }

        /// <summary>
        /// BoolProperty: FootCheckFailed
        /// </summary>
        public unsafe bool FootCheckFailed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 192); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 192); }; }
        }

        /// <summary>
        /// StructProperty: SpotCheck
        /// </summary>
        public unsafe System.Numerics.Vector3 SpotCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 196); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 196); }; }
        }

        /// <summary>
        /// StructProperty: ToNextExtent
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNextExtent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 208); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 208); }; }
        }

        /// <summary>
        /// StructProperty: ToNextStart
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNextStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 220); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }; }
        }

        /// <summary>
        /// StructProperty: ToNextEnd
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNextEnd
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 232); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }; }
        }

        /// <summary>
        /// StructProperty: Spot2Check
        /// </summary>
        public unsafe System.Numerics.Vector3 Spot2Check
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 244); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 244); }; }
        }

        /// <summary>
        /// StructProperty: ToNext2Extent
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNext2Extent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 256); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 256); }; }
        }

        /// <summary>
        /// StructProperty: ToNext2Start
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNext2Start
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 268); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 268); }; }
        }

        /// <summary>
        /// StructProperty: ToNext2End
        /// </summary>
        public unsafe System.Numerics.Vector3 ToNext2End
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 280); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 280); }; }
        }
    }

    /// <summary>
    /// Enum: EStartPoints
    /// </summary>
    public enum EStartPoints : byte
    {
        START_NextToPlayer = 0,
        START_BelowTarget = 1,
        START_FarLeft = 2,
        START_FarRight = 3,
        START_Left = 4,
        START_Right = 5,
        START_VantageLeft = 6,
        START_VantageRight = 7,
        START_ClimbLocator = 8,
        START_ExtraPounceCheck = 9,
        START_Failed = 10,
        START_MAX = 11,
    }

    /// <summary>
    /// Enum: EClawClimbDirection
    /// </summary>
    public enum EClawClimbDirection : byte
    {
        CCD_Random = 0,
        CCD_Left = 1,
        CCD_Center = 2,
        CCD_Right = 3,
        CCD_None = 4,
        CCD_MAX = 5,
    }

    /// <summary>
    /// ObjectProperty: PounceToLedgeHangMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToLedgeHangMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1728); }
    }

    /// <summary>
    /// ObjectProperty: PounceToLedgeDangleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToLedgeDangleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1732); }
    }

    /// <summary>
    /// ObjectProperty: PounceOntoRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceOntoRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1736); }
    }

    /// <summary>
    /// ObjectProperty: PounceToVantagePointMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1740); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbStartMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbStartMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1744); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallLand
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallLand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1748); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallJumpOff
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallJumpOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1752); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndLedgeHang
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndLedgeHang
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1756); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndLedgeDangle
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndLedgeDangle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1760); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1760); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOverLedgeStand
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOverLedgeStand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1764); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1764); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOverLedgeRun
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOverLedgeRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1768); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOverRailingStand
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOverRailingStand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1772); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOverRailingRun
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOverRailingRun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1776); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndOnRailing
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndOnRailing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1780); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndVantagePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndVantagePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1784); }
    }

    /// <summary>
    /// ObjectProperty: ClawClimbWallEndCeiling
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ClawClimbWallEndCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1788); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounce
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig AerialWhipPounce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceFar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig AerialWhipPounceFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1796); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceClose
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig AerialWhipPounceClose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1800); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedClose
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedClose
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1804); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedCloseSq
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedCloseSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1808); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargeted
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargeted
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1812); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedSq
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1816); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedFar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1820); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedFarSq
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedFarSq
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1824); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedCloseWallStick
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedCloseWallStick
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1828); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedCloseWallStickDangle
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedCloseWallStickDangle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1832); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedLeft
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedLeft
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1836); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedRight
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedRight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1840); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedLeftFar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedLeftFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1844); }
    }

    /// <summary>
    /// ObjectProperty: AerialWhipPounceTargetedRightFar
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable AerialWhipPounceTargetedRightFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 1848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1848); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1856); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortFromStealthMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortFromStealthMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1860); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingMoveWithAlignment
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingMoveWithAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1864); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortMoveWithAlignment
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortMoveWithAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1868); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortMoveWith180LAlignment
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortMoveWith180LAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1872); }
    }

    /// <summary>
    /// ObjectProperty: EdgeSwingShortMoveWith180RAlignment
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig EdgeSwingShortMoveWith180RAlignment
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1876); }
    }

    /// <summary>
    /// FloatProperty: CamSwitchTime
    /// </summary>
    public unsafe float CamSwitchTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1880); }
    }

    /// <summary>
    /// FloatProperty: MaxWhipBoost2dRange
    /// </summary>
    public unsafe float MaxWhipBoost2dRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1884); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1884); }
    }

    /// <summary>
    /// BoolProperty: bDebugTargetModes
    /// </summary>
    public unsafe bool bDebugTargetModes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingPath
    /// </summary>
    public unsafe bool bDebugSwingPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugWallClimb
    /// </summary>
    public unsafe bool bDebugWallClimb
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugWallClimbPersistent
    /// </summary>
    public unsafe bool bDebugWallClimbPersistent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawPath
    /// </summary>
    public unsafe bool bDebugDrawPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawPathPersistent
    /// </summary>
    public unsafe bool bDebugDrawPathPersistent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawPathPounces
    /// </summary>
    public unsafe bool bDebugDrawPathPounces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawPathWallChecks
    /// </summary>
    public unsafe bool bDebugDrawPathWallChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawInitialTestPersistent
    /// </summary>
    public unsafe bool bDebugDrawInitialTestPersistent
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawCeilingChecks
    /// </summary>
    public unsafe bool bDebugDrawCeilingChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugForcePathRecalculation
    /// </summary>
    public unsafe bool bDebugForcePathRecalculation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceFallbackPath
    /// </summary>
    public unsafe bool bDebugForceFallbackPath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugEdgeSwing
    /// </summary>
    public unsafe bool bDebugEdgeSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugEdgeSwingLaunch
    /// </summary>
    public unsafe bool bDebugEdgeSwingLaunch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugEdgeSwingStartCheck
    /// </summary>
    public unsafe bool bDebugEdgeSwingStartCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugEdgeSwingSkipFinalPounceCheck
    /// </summary>
    public unsafe bool bDebugEdgeSwingSkipFinalPounceCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugSkipInitialSwingHitCheck
    /// </summary>
    public unsafe bool bDebugSkipInitialSwingHitCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugShortEdgeSwing
    /// </summary>
    public unsafe bool bDebugShortEdgeSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugAerialSwing
    /// </summary>
    public unsafe bool bDebugAerialSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugLongPounceIn
    /// </summary>
    public unsafe bool bDebugLongPounceIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugLongPounceInDirectPounce
    /// </summary>
    public unsafe bool bDebugLongPounceInDirectPounce
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugLongPounceDraw
    /// </summary>
    public unsafe bool bDebugLongPounceDraw
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugInitialPounceToWall
    /// </summary>
    public unsafe bool bDebugInitialPounceToWall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugCheckWallStick
    /// </summary>
    public unsafe bool bDebugCheckWallStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugSkipInitialPathTest
    /// </summary>
    public unsafe bool bDebugSkipInitialPathTest
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugSuppressGrapplePoints
    /// </summary>
    public unsafe bool bDebugSuppressGrapplePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugDelayedSwing
    /// </summary>
    public unsafe bool bDebugDelayedSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugSwingStart
    /// </summary>
    public unsafe bool bDebugSwingStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugDrawLinkedHidePoints
    /// </summary>
    public unsafe bool bDebugDrawLinkedHidePoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugClimbLocators
    /// </summary>
    public unsafe bool bDebugClimbLocators
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugPounceTargetingIterations
    /// </summary>
    public unsafe bool bDebugPounceTargetingIterations
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bDebugLocatorChainAlignment
    /// </summary>
    public unsafe bool bDebugLocatorChainAlignment
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1888); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1888); }
    }

    /// <summary>
    /// BoolProperty: bEnableEdgeSwing
    /// </summary>
    public unsafe bool bEnableEdgeSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bEnableDelayedSwing
    /// </summary>
    public unsafe bool bEnableDelayedSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bAutoClimbFromWallStick
    /// </summary>
    public unsafe bool bAutoClimbFromWallStick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bClimbUseLookAt
    /// </summary>
    public unsafe bool bClimbUseLookAt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bClimbCamOverlay
    /// </summary>
    public unsafe bool bClimbCamOverlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bPawnAtSwingEdge
    /// </summary>
    public unsafe bool bPawnAtSwingEdge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bScaleLR
    /// </summary>
    public unsafe bool bScaleLR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bScaleLRClampMin
    /// </summary>
    public unsafe bool bScaleLRClampMin
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bScaleLRClampMax
    /// </summary>
    public unsafe bool bScaleLRClampMax
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bScaleUp
    /// </summary>
    public unsafe bool bScaleUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bClipLR
    /// </summary>
    public unsafe bool bClipLR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bClipUp
    /// </summary>
    public unsafe bool bClipUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bFinalScaleLR
    /// </summary>
    public unsafe bool bFinalScaleLR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bFinalScaleUp
    /// </summary>
    public unsafe bool bFinalScaleUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bFinalClipLR
    /// </summary>
    public unsafe bool bFinalClipLR
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bFinalClipUp
    /// </summary>
    public unsafe bool bFinalClipUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bOptimisePaths
    /// </summary>
    public unsafe bool bOptimisePaths
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bDebugVantageTrace
    /// </summary>
    public unsafe bool bDebugVantageTrace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bUseNewVantagePath
    /// </summary>
    public unsafe bool bUseNewVantagePath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceHoldOntoLedge
    /// </summary>
    public unsafe bool bDebugForceHoldOntoLedge
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bLastCeilingCheckResult
    /// </summary>
    public unsafe bool bLastCeilingCheckResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bTriggeredWhipImpactFX
    /// </summary>
    public unsafe bool bTriggeredWhipImpactFX
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bExtraPounceTargetIteration
    /// </summary>
    public unsafe bool bExtraPounceTargetIteration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bEnableSwingParamsCaching
    /// </summary>
    public unsafe bool bEnableSwingParamsCaching
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// BoolProperty: bGASSPLastResult
    /// </summary>
    public unsafe bool bGASSPLastResult
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1892); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1892); }
    }

    /// <summary>
    /// FloatProperty: MinimumSwingTime
    /// </summary>
    public unsafe float MinimumSwingTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1896); }
    }

    /// <summary>
    /// IntProperty: CurrentLandPointIndex
    /// </summary>
    public unsafe int CurrentLandPointIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1900); }
    }

    /// <summary>
    /// StructProperty: CurrentClimbInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo CurrentClimbInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(Ptr + 1904);

    /// <summary>
    /// StructProperty: LastClimbInfo
    /// </summary>
    public unsafe ref BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo LastClimbInfo
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>(Ptr + 2888);

    /// <summary>
    /// FloatProperty: LastClimbInfoTime
    /// </summary>
    public unsafe float LastClimbInfoTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3872); }
    }

    /// <summary>
    /// FloatProperty: LastClimbInfoDelay
    /// </summary>
    public unsafe float LastClimbInfoDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3876); }
    }

    /// <summary>
    /// ArrayProperty: WallClimbs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo> WallClimbs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCwGrappleGunBase.FWallClimbInfo>>(Ptr + 3880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3880); }
    }

    /// <summary>
    /// StructProperty: LastClimbLandLocator
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator LastClimbLandLocator
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator>(Ptr + 3892);

    /// <summary>
    /// StructProperty: LastWallLandLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastWallLandLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4004);

    /// <summary>
    /// FloatProperty: MaxDistanceToWall
    /// </summary>
    public unsafe float MaxDistanceToWall
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4016); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceToWallDirectPounce
    /// </summary>
    public unsafe float MaxDistanceToWallDirectPounce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4020); }
    }

    /// <summary>
    /// FloatProperty: MaxDirectPounceDistance
    /// </summary>
    public unsafe float MaxDirectPounceDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }
    }

    /// <summary>
    /// FloatProperty: MaxHDistanceToPouncePoints
    /// </summary>
    public unsafe float MaxHDistanceToPouncePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4028); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceHeightToVantagePoints
    /// </summary>
    public unsafe float MaxPounceHeightToVantagePoints
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4032); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceHeightToVantagePointsHPH
    /// </summary>
    public unsafe float MaxPounceHeightToVantagePointsHPH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4036); }
    }

    /// <summary>
    /// FloatProperty: MaxPounceHeightToLedges
    /// </summary>
    public unsafe float MaxPounceHeightToLedges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }

    /// <summary>
    /// FloatProperty: MinPounceHeightToLedges
    /// </summary>
    public unsafe float MinPounceHeightToLedges
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4044); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceToWallDirectPounceHPH
    /// </summary>
    public unsafe float MaxDistanceToWallDirectPounceHPH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4048); }
    }

    /// <summary>
    /// FloatProperty: MaxDirectPounceDistanceHPH
    /// </summary>
    public unsafe float MaxDirectPounceDistanceHPH
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4052); }
    }

    /// <summary>
    /// FloatProperty: MaxWallClimbCosRightAngle
    /// </summary>
    public unsafe float MaxWallClimbCosRightAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4056); }
    }

    /// <summary>
    /// FloatProperty: MinWallClimbMargin
    /// </summary>
    public unsafe float MinWallClimbMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4060); }
    }

    /// <summary>
    /// FloatProperty: MaxWallClimbWidth
    /// </summary>
    public unsafe float MaxWallClimbWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4064); }
    }

    /// <summary>
    /// FloatProperty: MaxHorizontalWallPounce
    /// </summary>
    public unsafe float MaxHorizontalWallPounce
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4068); }
    }

    /// <summary>
    /// FloatProperty: GrappleTargetEdgeMaxCos
    /// </summary>
    public unsafe float GrappleTargetEdgeMaxCos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4072); }
    }

    /// <summary>
    /// FloatProperty: GrappleTargetNormalMaxCos
    /// </summary>
    public unsafe float GrappleTargetNormalMaxCos
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4076); }
    }

    /// <summary>
    /// FloatProperty: VantagePathWidth
    /// </summary>
    public unsafe float VantagePathWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }

    /// <summary>
    /// FloatProperty: VantagePathWidthNew
    /// </summary>
    public unsafe float VantagePathWidthNew
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4084); }
    }

    /// <summary>
    /// FloatProperty: MaxEdgeToAerialDelayTime
    /// </summary>
    public unsafe float MaxEdgeToAerialDelayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4088); }
    }

    /// <summary>
    /// FloatProperty: MaxAerialToAerialDelayTime
    /// </summary>
    public unsafe float MaxAerialToAerialDelayTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4092); }
    }

    /// <summary>
    /// ObjectProperty: OriginalGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint OriginalGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// ByteProperty: ClawClimbStartMode
    /// </summary>
    public unsafe BmSDK.BmGame.RCwGrappleGunBase.EClawClimbStartMode ClawClimbStartMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCwGrappleGunBase.EClawClimbStartMode>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// FloatProperty: CamOverlayStrength
    /// </summary>
    public unsafe float CamOverlayStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }

    /// <summary>
    /// ObjectProperty: LockedEdgeSwingGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint LockedEdgeSwingGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 4108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4108); }
    }

    /// <summary>
    /// StructProperty: LockedEdgeSwingGrappleTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LockedEdgeSwingGrappleTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4112);

    /// <summary>
    /// ObjectProperty: LockedEdgeSwingHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint LockedEdgeSwingHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 4124); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4124); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingLaunchLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingLaunchLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4128);

    /// <summary>
    /// StructProperty: EdgeSwingStartLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingStartLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4140);

    /// <summary>
    /// StructProperty: EdgeSwingEndLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingEndLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4152);

    /// <summary>
    /// StructProperty: EdgeSwingWallLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingWallLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4164);

    /// <summary>
    /// StructProperty: EdgeSwingWallNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingWallNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4176);

    /// <summary>
    /// ObjectProperty: EdgeSwingGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint EdgeSwingGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 4188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4188); }
    }

    /// <summary>
    /// StructProperty: EdgeSwingGrappleTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingGrappleTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4192);

    /// <summary>
    /// StructProperty: SwingLaunchVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SwingLaunchVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4204);

    /// <summary>
    /// StructProperty: SwingLaunchShortVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SwingLaunchShortVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4216);

    /// <summary>
    /// StructProperty: SwingLaunchOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SwingLaunchOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4228);

    /// <summary>
    /// StructProperty: SwingLaunchShortOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SwingLaunchShortOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4240);

    /// <summary>
    /// StructProperty: EdgeSwingLaunchCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EdgeSwingLaunchCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4252);

    /// <summary>
    /// FloatProperty: EdgeSwingLaunchCheckShift
    /// </summary>
    public unsafe float EdgeSwingLaunchCheckShift
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4264); }
    }

    /// <summary>
    /// FloatProperty: SwingStartIdealZTolerance
    /// </summary>
    public unsafe float SwingStartIdealZTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4268); }
    }

    /// <summary>
    /// FloatProperty: SwingStartMaxZAbovePlayerTolerance
    /// </summary>
    public unsafe float SwingStartMaxZAbovePlayerTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4272); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingGrappleTargetPitch
    /// </summary>
    public unsafe float EdgeSwingGrappleTargetPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4276); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingExtraFallFactor
    /// </summary>
    public unsafe float EdgeSwingExtraFallFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4280); }
    }

    /// <summary>
    /// FloatProperty: MinEdgeSwingDistance
    /// </summary>
    public unsafe float MinEdgeSwingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4284); }
    }

    /// <summary>
    /// FloatProperty: MaxEdgeSwingTan
    /// </summary>
    public unsafe float MaxEdgeSwingTan
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4288); }
    }

    /// <summary>
    /// FloatProperty: CloseSwingDistance
    /// </summary>
    public unsafe float CloseSwingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4292); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4292); }
    }

    /// <summary>
    /// FloatProperty: MaxDistanceForAimedEdgeSwingGrapple
    /// </summary>
    public unsafe float MaxDistanceForAimedEdgeSwingGrapple
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4296); }
    }

    /// <summary>
    /// FloatProperty: MinSwingWallLandToGrappleDistance
    /// </summary>
    public unsafe float MinSwingWallLandToGrappleDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4300); }
    }

    /// <summary>
    /// FloatProperty: MinEdgeShortSwingHeight
    /// </summary>
    public unsafe float MinEdgeShortSwingHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4304); }
    }

    /// <summary>
    /// FloatProperty: EdgeShortSwingHDistThreshold
    /// </summary>
    public unsafe float EdgeShortSwingHDistThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4308); }
    }

    /// <summary>
    /// FloatProperty: ForceShortPounceOffHThreshold
    /// </summary>
    public unsafe float ForceShortPounceOffHThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4312); }
    }

    /// <summary>
    /// FloatProperty: ForceShortPounceOffZThreshold
    /// </summary>
    public unsafe float ForceShortPounceOffZThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4316); }
    }

    /// <summary>
    /// FloatProperty: MinAerialSwingDistance
    /// </summary>
    public unsafe float MinAerialSwingDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4320); }
    }

    /// <summary>
    /// FloatProperty: AerialSwingTargetCloseRange
    /// </summary>
    public unsafe float AerialSwingTargetCloseRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4324); }
    }

    /// <summary>
    /// FloatProperty: AerialSwingTargetMaxExtraDrop
    /// </summary>
    public unsafe float AerialSwingTargetMaxExtraDrop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4328); }
    }

    /// <summary>
    /// FloatProperty: AerialSwingTargetDropPerMs
    /// </summary>
    public unsafe float AerialSwingTargetDropPerMs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4332); }
    }

    /// <summary>
    /// FloatProperty: MaxSwingWallTargetHeight
    /// </summary>
    public unsafe float MaxSwingWallTargetHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4336); }
    }

    /// <summary>
    /// FloatProperty: MaxSwingHeightOffset
    /// </summary>
    public unsafe float MaxSwingHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4340); }
    }

    /// <summary>
    /// FloatProperty: MinSwingHeightOffset
    /// </summary>
    public unsafe float MinSwingHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4344); }
    }

    /// <summary>
    /// FloatProperty: ClimbStartPointExtraDistance
    /// </summary>
    public unsafe float ClimbStartPointExtraDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4348); }
    }

    /// <summary>
    /// StructProperty: SecondLastPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SecondLastPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4352);

    /// <summary>
    /// StructProperty: LastPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4364);

    /// <summary>
    /// FloatProperty: WallCheckOut
    /// </summary>
    public unsafe float WallCheckOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4376); }
    }

    /// <summary>
    /// FloatProperty: WallCheckIn
    /// </summary>
    public unsafe float WallCheckIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4380); }
    }

    /// <summary>
    /// FloatProperty: WallCheckInVantage
    /// </summary>
    public unsafe float WallCheckInVantage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4384); }
    }

    /// <summary>
    /// FloatProperty: MaxWallOut
    /// </summary>
    public unsafe float MaxWallOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4388); }
    }

    /// <summary>
    /// StructProperty: PlayerCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PlayerCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4392);

    /// <summary>
    /// StructProperty: WallCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4404);

    /// <summary>
    /// StructProperty: WallCheckShift
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallCheckShift
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4416);

    /// <summary>
    /// StructProperty: WallFootCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallFootCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4428);

    /// <summary>
    /// StructProperty: WallFootCheckShift
    /// </summary>
    public unsafe ref System.Numerics.Vector3 WallFootCheckShift
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4440);

    /// <summary>
    /// FloatProperty: WallHandToFootCheckZDiff
    /// </summary>
    public unsafe float WallHandToFootCheckZDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4452); }
    }

    /// <summary>
    /// FloatProperty: WallHandsToFeetInTolerance
    /// </summary>
    public unsafe float WallHandsToFeetInTolerance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4456); }
    }

    /// <summary>
    /// FloatProperty: AlongWallCheckDistance
    /// </summary>
    public unsafe float AlongWallCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4460); }
    }

    /// <summary>
    /// FloatProperty: AlongWallExtraEndOutOfWallDist
    /// </summary>
    public unsafe float AlongWallExtraEndOutOfWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4464); }
    }

    /// <summary>
    /// FloatProperty: AlongWallExtraStartOutOfWallDist
    /// </summary>
    public unsafe float AlongWallExtraStartOutOfWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4468); }
    }

    /// <summary>
    /// FloatProperty: AlongWallExtraEndIntoWallDist
    /// </summary>
    public unsafe float AlongWallExtraEndIntoWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4472); }
    }

    /// <summary>
    /// FloatProperty: AlongWallExtraStartIntoWallDist
    /// </summary>
    public unsafe float AlongWallExtraStartIntoWallDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4476); }
    }

    /// <summary>
    /// FloatProperty: EdgeLocationCheckDistance
    /// </summary>
    public unsafe float EdgeLocationCheckDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4480); }
    }

    /// <summary>
    /// FloatProperty: GrappleCheckOut
    /// </summary>
    public unsafe float GrappleCheckOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4484); }
    }

    /// <summary>
    /// StructProperty: PounceToGrappleCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PounceToGrappleCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4488);

    /// <summary>
    /// FloatProperty: MaxWallStickHidePointInDiff
    /// </summary>
    public unsafe float MaxWallStickHidePointInDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4500); }
    }

    /// <summary>
    /// FloatProperty: MaxWallStickHidePointOutDiff
    /// </summary>
    public unsafe float MaxWallStickHidePointOutDiff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4504); }
    }

    /// <summary>
    /// FloatProperty: MaxRunningEdgeSwingCheckRange
    /// </summary>
    public unsafe float MaxRunningEdgeSwingCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4508); }
    }

    /// <summary>
    /// FloatProperty: MinRunningEdgeSwingCheckRange
    /// </summary>
    public unsafe float MinRunningEdgeSwingCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4512); }
    }

    /// <summary>
    /// FloatProperty: MaxStandingEdgeSwingCheckRange
    /// </summary>
    public unsafe float MaxStandingEdgeSwingCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4516); }
    }

    /// <summary>
    /// FloatProperty: MinStandingEdgeSwingCheckRange
    /// </summary>
    public unsafe float MinStandingEdgeSwingCheckRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4520); }
    }

    /// <summary>
    /// FloatProperty: EdgeSwingCheckRangeSteps
    /// </summary>
    public unsafe float EdgeSwingCheckRangeSteps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4524); }
    }

    /// <summary>
    /// ObjectProperty: WallClimbCamera
    /// </summary>
    public unsafe BmSDK.BmGame.RWallClimbCamera WallClimbCamera
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWallClimbCamera>(Ptr + 4528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4528); }
    }

    /// <summary>
    /// FloatProperty: SwingJumpToWallPitch
    /// </summary>
    public unsafe float SwingJumpToWallPitch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4532); }
    }

    /// <summary>
    /// FloatProperty: SwingJumpToWallSpeed
    /// </summary>
    public unsafe float SwingJumpToWallSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4536); }
    }

    /// <summary>
    /// FloatProperty: FirstClimbStepToCeiling
    /// </summary>
    public unsafe float FirstClimbStepToCeiling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4540); }
    }

    /// <summary>
    /// StructProperty: CeilingSpaceCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CeilingSpaceCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4544);

    /// <summary>
    /// FloatProperty: CeilingTraceHeight
    /// </summary>
    public unsafe float CeilingTraceHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4556); }
    }

    /// <summary>
    /// FloatProperty: MinLRDist
    /// </summary>
    public unsafe float MinLRDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4560); }
    }

    /// <summary>
    /// FloatProperty: MaxLRDist
    /// </summary>
    public unsafe float MaxLRDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4564); }
    }

    /// <summary>
    /// FloatProperty: MinLRScale
    /// </summary>
    public unsafe float MinLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4568); }
    }

    /// <summary>
    /// FloatProperty: MaxLRScale
    /// </summary>
    public unsafe float MaxLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4572); }
    }

    /// <summary>
    /// FloatProperty: LRScale
    /// </summary>
    public unsafe float LRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4576); }
    }

    /// <summary>
    /// FloatProperty: MinUpDist
    /// </summary>
    public unsafe float MinUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4580); }
    }

    /// <summary>
    /// FloatProperty: MaxUpDist
    /// </summary>
    public unsafe float MaxUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4584); }
    }

    /// <summary>
    /// FloatProperty: MinUpScale
    /// </summary>
    public unsafe float MinUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4588); }
    }

    /// <summary>
    /// FloatProperty: MaxUpScale
    /// </summary>
    public unsafe float MaxUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4592); }
    }

    /// <summary>
    /// FloatProperty: UpScale
    /// </summary>
    public unsafe float UpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4596); }
    }

    /// <summary>
    /// FloatProperty: ClipLRIdealDist
    /// </summary>
    public unsafe float ClipLRIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4600); }
    }

    /// <summary>
    /// FloatProperty: ClipLRPer100
    /// </summary>
    public unsafe float ClipLRPer100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4604); }
    }

    /// <summary>
    /// FloatProperty: ClipLRMaxTime
    /// </summary>
    public unsafe float ClipLRMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4608); }
    }

    /// <summary>
    /// FloatProperty: ClipUpIdealDist
    /// </summary>
    public unsafe float ClipUpIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4612); }
    }

    /// <summary>
    /// FloatProperty: ClipUpPer100
    /// </summary>
    public unsafe float ClipUpPer100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4616); }
    }

    /// <summary>
    /// FloatProperty: ClipUpMaxTime
    /// </summary>
    public unsafe float ClipUpMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4620); }
    }

    /// <summary>
    /// FloatProperty: FinalMinLRDist
    /// </summary>
    public unsafe float FinalMinLRDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4624); }
    }

    /// <summary>
    /// FloatProperty: FinalMaxLRDist
    /// </summary>
    public unsafe float FinalMaxLRDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4628); }
    }

    /// <summary>
    /// FloatProperty: FinalMinLRScale
    /// </summary>
    public unsafe float FinalMinLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4632); }
    }

    /// <summary>
    /// FloatProperty: FinalMaxLRScale
    /// </summary>
    public unsafe float FinalMaxLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4636); }
    }

    /// <summary>
    /// FloatProperty: FinalLRScale
    /// </summary>
    public unsafe float FinalLRScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4640); }
    }

    /// <summary>
    /// FloatProperty: FinalMinUpDist
    /// </summary>
    public unsafe float FinalMinUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4644); }
    }

    /// <summary>
    /// FloatProperty: FinalMaxUpDist
    /// </summary>
    public unsafe float FinalMaxUpDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4648); }
    }

    /// <summary>
    /// FloatProperty: FinalMinUpScale
    /// </summary>
    public unsafe float FinalMinUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4652); }
    }

    /// <summary>
    /// FloatProperty: FinalMaxUpScale
    /// </summary>
    public unsafe float FinalMaxUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4656); }
    }

    /// <summary>
    /// FloatProperty: FinalUpScale
    /// </summary>
    public unsafe float FinalUpScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4660); }
    }

    /// <summary>
    /// FloatProperty: FinalClipLRIdealDist
    /// </summary>
    public unsafe float FinalClipLRIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4664); }
    }

    /// <summary>
    /// FloatProperty: FinalClipLRPer100
    /// </summary>
    public unsafe float FinalClipLRPer100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4668); }
    }

    /// <summary>
    /// FloatProperty: FinalClipLRMaxTime
    /// </summary>
    public unsafe float FinalClipLRMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4672); }
    }

    /// <summary>
    /// FloatProperty: FinalClipUpIdealDist
    /// </summary>
    public unsafe float FinalClipUpIdealDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4676); }
    }

    /// <summary>
    /// FloatProperty: FinalClipUpPer100
    /// </summary>
    public unsafe float FinalClipUpPer100
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4680); }
    }

    /// <summary>
    /// FloatProperty: FinalClipUpMaxTime
    /// </summary>
    public unsafe float FinalClipUpMaxTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4684); }
    }

    /// <summary>
    /// FloatProperty: PounceDelay
    /// </summary>
    public unsafe float PounceDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4688); }
    }

    /// <summary>
    /// FloatProperty: EdgeVUpTolerancePercentage
    /// </summary>
    public unsafe float EdgeVUpTolerancePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4692); }
    }

    /// <summary>
    /// FloatProperty: EdgeVDownTolerancePercentage
    /// </summary>
    public unsafe float EdgeVDownTolerancePercentage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4696); }
    }

    /// <summary>
    /// FloatProperty: MinEdgeVDistance
    /// </summary>
    public unsafe float MinEdgeVDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4700); }
    }

    /// <summary>
    /// FloatProperty: MaxAerialTargetingAngle
    /// </summary>
    public unsafe float MaxAerialTargetingAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4704); }
    }

    /// <summary>
    /// FloatProperty: VantageWallTraceSide
    /// </summary>
    public unsafe float VantageWallTraceSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4708); }
    }

    /// <summary>
    /// FloatProperty: VantageWallTraceDown
    /// </summary>
    public unsafe float VantageWallTraceDown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4712); }
    }

    /// <summary>
    /// FloatProperty: VantageWallTraceOut
    /// </summary>
    public unsafe float VantageWallTraceOut
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4716); }
    }

    /// <summary>
    /// FloatProperty: VantageWallTraceIn
    /// </summary>
    public unsafe float VantageWallTraceIn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4720); }
    }

    /// <summary>
    /// FloatProperty: VantagePathMinDistance
    /// </summary>
    public unsafe float VantagePathMinDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4724); }
    }

    /// <summary>
    /// StructProperty: LastCeilingCheckLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastCeilingCheckLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4728);

    /// <summary>
    /// ObjectProperty: LastCeilingClimbVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RCeilingClimbVolume LastCeilingClimbVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCeilingClimbVolume>(Ptr + 4740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4740); }
    }

    /// <summary>
    /// StructProperty: LastCeilingCheckTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 LastCeilingCheckTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4744);

    /// <summary>
    /// FloatProperty: LastCeilingCheckFrame
    /// </summary>
    public unsafe float LastCeilingCheckFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4756); }
    }

    /// <summary>
    /// StructProperty: InitialPounceToWallCheckExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InitialPounceToWallCheckExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4760);

    /// <summary>
    /// IntProperty: NumPounceItersPerUpdate
    /// </summary>
    public unsafe int NumPounceItersPerUpdate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4772); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4772); }
    }

    /// <summary>
    /// IntProperty: MaxPounceSingleLineChecks
    /// </summary>
    public unsafe int MaxPounceSingleLineChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4776); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4776); }
    }

    /// <summary>
    /// IntProperty: MaxPounceSingleLineChecksCoherency
    /// </summary>
    public unsafe int MaxPounceSingleLineChecksCoherency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4780); }
    }

    /// <summary>
    /// IntProperty: MaxPounceSingleLineChecksLowPrio
    /// </summary>
    public unsafe int MaxPounceSingleLineChecksLowPrio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4784); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4784); }
    }

    /// <summary>
    /// IntProperty: MaxFullPounceIters
    /// </summary>
    public unsafe int MaxFullPounceIters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4788); }
    }

    /// <summary>
    /// IntProperty: PounceSingleLineChecks
    /// </summary>
    public unsafe int PounceSingleLineChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4792); }
    }

    /// <summary>
    /// IntProperty: PounceSingleLineChecksTotal
    /// </summary>
    public unsafe int PounceSingleLineChecksTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4796); }
    }

    /// <summary>
    /// FloatProperty: LastPounceSingleLineCheck
    /// </summary>
    public unsafe float LastPounceSingleLineCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4800); }
    }

    /// <summary>
    /// FloatProperty: SwingStartCheckTime
    /// </summary>
    public unsafe float SwingStartCheckTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4804); }
    }

    /// <summary>
    /// IntProperty: SwingStartCheckIterations
    /// </summary>
    public unsafe int SwingStartCheckIterations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4808); }
    }

    /// <summary>
    /// IntProperty: MaxSwingPathChecks
    /// </summary>
    public unsafe int MaxSwingPathChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4812); }
    }

    /// <summary>
    /// IntProperty: MinSwingPathChecks
    /// </summary>
    public unsafe int MinSwingPathChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4816); }
    }

    /// <summary>
    /// FloatProperty: SwingPathCheckUnits
    /// </summary>
    public unsafe float SwingPathCheckUnits
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4820); }
    }

    /// <summary>
    /// IntProperty: SwingLineChecks
    /// </summary>
    public unsafe int SwingLineChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4824); }
    }

    /// <summary>
    /// IntProperty: SwingLineChecksTotal
    /// </summary>
    public unsafe int SwingLineChecksTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4828); }
    }

    /// <summary>
    /// FloatProperty: LastSwingLineCheck
    /// </summary>
    public unsafe float LastSwingLineCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4832); }
    }

    /// <summary>
    /// IntProperty: MaxSwingLineChecks
    /// </summary>
    public unsafe int MaxSwingLineChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4836); }
    }

    /// <summary>
    /// IntProperty: MaxSwingLineChecksCoherency
    /// </summary>
    public unsafe int MaxSwingLineChecksCoherency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4840); }
    }

    /// <summary>
    /// IntProperty: MaxSwingLineChecksLowPrio
    /// </summary>
    public unsafe int MaxSwingLineChecksLowPrio
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4844); }
    }

    /// <summary>
    /// ObjectProperty: LastPickedGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint LastPickedGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 4848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4848); }
    }

    /// <summary>
    /// ObjectProperty: LastPickedHidePoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastPickedHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4852); }
    }

    /// <summary>
    /// ObjectProperty: GASSPLastGrapplePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RGrapplePoint GASSPLastGrapplePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGrapplePoint>(Ptr + 4856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4856); }
    }

    /// <summary>
    /// ObjectProperty: GASSPLastHidePoint
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint GASSPLastHidePoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint>(Ptr + 4860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4860); }
    }

    /// <summary>
    /// StructProperty: GASSPLastPlayerLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GASSPLastPlayerLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4864);

    /// <summary>
    /// StructProperty: GASSPLastPlayerVel
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GASSPLastPlayerVel
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4876);

    /// <summary>
    /// FloatProperty: GASSPLastSwingStartTime
    /// </summary>
    public unsafe float GASSPLastSwingStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4888); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4888); }
    }

    /// <summary>
    /// StructProperty: GASSPLastOrigin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GASSPLastOrigin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4892);

    /// <summary>
    /// StructProperty: GASSPLastStartVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GASSPLastStartVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 4904);
}
