#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RLineLauncher<br/>
/// (size = 1264)
/// (flags = 142606515)
/// </summary>
public partial class RLineLauncher : BmSDK.BmGame.RInventoryGadget, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RLineLauncher", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RLineLauncher.
    /// </summary>
    public static RLineLauncher DefaultObject => (RLineLauncher)StaticClass().DefaultObject;

    internal RLineLauncher() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RLineLauncher(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RLineLauncher>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.Destroyed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: VillainHitRope
    /// </summary>
    public unsafe virtual void VillainHitRope(BmSDK.BmGame.RPawnVillain HitVillain)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.VillainHitRope", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitVillain, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckToBreakRope
    /// </summary>
    public unsafe virtual bool CheckToBreakRope(System.Numerics.Vector3 StartPos, System.Numerics.Vector3 EndPos, bool OnlyCheckInterpActorsInFront, bool DoAccuratePawnsTest)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.CheckToBreakRope", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnlyCheckInterpActorsInFront, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DoAccuratePawnsTest, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: IsActive
    /// </summary>
    public unsafe virtual bool IsActive()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.IsActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PlayCameraAnimEx
    /// </summary>
    public unsafe virtual void PlayCameraAnimEx(BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc, BmSDK.FName AnimName, BmSDK.Engine.AnimSet AnimSet, bool bCamMirrored, BmSDK.Engine.Actor CameraCollisionTarget, float FOV = default, System.Numerics.Vector3 CollisionTargetPos = default, bool bHardCut = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.PlayCameraAnimEx", true);
        byte* paramsPtr = stackalloc byte[160];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimName, paramsPtr + 112);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet, paramsPtr + 120);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCamMirrored, paramsPtr + 124);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraCollisionTarget, paramsPtr + 128);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FOV, paramsPtr + 132);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollisionTargetPos, paramsPtr + 136);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHardCut, paramsPtr + 148);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BackToPlayerCamera
    /// </summary>
    public unsafe virtual void BackToPlayerCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.BackToPlayerCamera", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetHelpPrompt
    /// </summary>
    public unsafe override void GetHelpPrompt(BmSDK.BmGame.RHUDPrompt HelpPrompt, bool bKismetHelpOn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.GetHelpPrompt", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HelpPrompt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bKismetHelpOn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerLineLauncherCamera
    /// </summary>
    public unsafe virtual void TriggerLineLauncherCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.TriggerLineLauncherCamera", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AttachToHand
    /// </summary>
    public unsafe override void AttachToHand(BmSDK.FName CustomBone = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.AttachToHand", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CustomBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.Tick", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TurnOffProjectiles
    /// </summary>
    public unsafe override void TurnOffProjectiles()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.TurnOffProjectiles", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FireDualProjectiles
    /// </summary>
    public unsafe virtual void FireDualProjectiles()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.FireDualProjectiles", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TraceForOutOfBounds
    /// </summary>
    public unsafe virtual bool TraceForOutOfBounds(System.Numerics.Vector3 Start, System.Numerics.Vector3 End)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.TraceForOutOfBounds", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: TraceForHostageTakers
    /// </summary>
    public unsafe virtual bool TraceForHostageTakers(System.Numerics.Vector3 Start, System.Numerics.Vector3 End)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.TraceForHostageTakers", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: TraceGuidingVolume
    /// </summary>
    public unsafe virtual bool TraceGuidingVolume(System.Numerics.Vector3 PlayerLocation, System.Numerics.Vector3 Start, System.Numerics.Vector3 End, ref BmSDK.BmGame.RLineLauncherGuidingVolume GuidingVolume)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.TraceGuidingVolume", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GuidingVolume, paramsPtr + 36);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        GuidingVolume = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncherGuidingVolume>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 40);
    }

    /// <summary>
    /// Function: TraceRescueVolume
    /// </summary>
    public unsafe virtual bool TraceRescueVolume(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, ref BmSDK.BmGame.RLineLauncherRescueVolume HostagePickupVolume, ref BmSDK.BmGame.RLineLauncherRescueVolume RescueSafeZoneVolume)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.TraceRescueVolume", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HostagePickupVolume, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RescueSafeZoneVolume, paramsPtr + 28);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HostagePickupVolume = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncherRescueVolume>(paramsPtr + 24);
        RescueSafeZoneVolume = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncherRescueVolume>(paramsPtr + 28);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: GetLineLaucherTetherPoints
    /// </summary>
    public unsafe virtual bool GetLineLaucherTetherPoints(ref System.Numerics.Vector3 RearPoint, ref System.Numerics.Vector3 FrontPoint, ref System.Numerics.Vector3 ActorStartPoint, ref System.Numerics.Vector3 ActorEndPoint, System.Numerics.Vector3 CurrentPosition, System.Numerics.Vector3 CameraLoc, System.Numerics.Vector3 CurrentFacing, System.Numerics.Vector3 TargetLoc = default, bool bDebugTrace = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.GetLineLaucherTetherPoints", true);
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RearPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrontPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorStartPoint, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorEndPoint, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentPosition, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CameraLoc, paramsPtr + 60);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentFacing, paramsPtr + 72);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLoc, paramsPtr + 84);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDebugTrace, paramsPtr + 96);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        RearPoint = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        FrontPoint = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        ActorStartPoint = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
        ActorEndPoint = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 36);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 100);
    }

    /// <summary>
    /// Function: FireLineLauncher
    /// </summary>
    public unsafe virtual bool FireLineLauncher()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.FireLineLauncher", true);
        byte* paramsPtr = stackalloc byte[160];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FailedFiringLineLauncher
    /// </summary>
    public unsafe virtual void FailedFiringLineLauncher()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.FailedFiringLineLauncher", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetClosestPointOnLine
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetClosestPointOnLine(System.Numerics.Vector3 Start, System.Numerics.Vector3 End, System.Numerics.Vector3 TestPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.GetClosestPointOnLine", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: FireProjectiles
    /// </summary>
    public unsafe virtual void FireProjectiles(System.Numerics.Vector3 ProjectileTarget, System.Numerics.Vector3 ProjectileTarget2)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.FireProjectiles", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjectileTarget, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjectileTarget2, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DrawAimingHUD
    /// </summary>
    public unsafe virtual void DrawAimingHUD(BmSDK.Engine.HUD H)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.DrawAimingHUD", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(H, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideAimingHud
    /// </summary>
    public unsafe virtual void HideAimingHud()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.HideAimingHud", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsSafeToFire
    /// </summary>
    public unsafe virtual bool IsSafeToFire()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.IsSafeToFire", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GoodFireAngle
    /// </summary>
    public unsafe virtual bool GoodFireAngle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.GoodFireAngle", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TryHostageAlignedTargeting
    /// </summary>
    public unsafe virtual bool TryHostageAlignedTargeting()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.TryHostageAlignedTargeting", true);
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TryAlignedTargeting
    /// </summary>
    public unsafe virtual bool TryAlignedTargeting(System.Numerics.Vector3 Start, System.Numerics.Vector3 End)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.TryAlignedTargeting", true);
        byte* paramsPtr = stackalloc byte[132];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Start, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(End, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: UpdateAiming
    /// </summary>
    public unsafe virtual void UpdateAiming()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.UpdateAiming", true);
        byte* paramsPtr = stackalloc byte[76];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanFire2ndLine
    /// </summary>
    public unsafe virtual bool CanFire2ndLine()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.CanFire2ndLine", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StopSloMoFromFlip
    /// </summary>
    public unsafe virtual void StopSloMoFromFlip()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.StopSloMoFromFlip", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPrimedPose
    /// </summary>
    public unsafe override BmSDK.FName GetPrimedPose(ref BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch StanceIsCrouched, ref BmSDK.BmGame.RAnimUtil.EMirrorChoice MirroredNess, bool InSoftCover, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType, ref BmSDK.FName OutCapeState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.GetPrimedPose", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StanceIsCrouched, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MirroredNess, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OutCapeState, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StanceIsCrouched = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RInventoryGadget.PlayerWantsToCrouch>(paramsPtr + 0);
        MirroredNess = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil.EMirrorChoice>(paramsPtr + 1);
        OutCapeState = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetGadgetCamera
    /// </summary>
    public unsafe override BmSDK.FName GetGadgetCamera(bool InSoftCover = default, BmSDK.BmGame.RInventoryGadget.CoverCornerType CornerType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RLineLauncher.GetGadgetCamera", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InSoftCover, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CornerType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
    }

    /// <summary>
    /// FloatProperty: LineLauncherRange
    /// </summary>
    public unsafe float LineLauncherRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherBackRange
    /// </summary>
    public unsafe float LineLauncherBackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherHeight
    /// </summary>
    public unsafe float LineLauncherHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherPlayerHeight
    /// </summary>
    public unsafe float LineLauncherPlayerHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }

    /// <summary>
    /// FloatProperty: MinLineLauncherRange
    /// </summary>
    public unsafe float MinLineLauncherRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }

    /// <summary>
    /// FloatProperty: MinLineLauncherBackRange
    /// </summary>
    public unsafe float MinLineLauncherBackRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherFireRightOffset
    /// </summary>
    public unsafe float LineLauncherFireRightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ObjectProperty: SuccessfulFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SuccessfulFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ObjectProperty: SuccessfulFire2ndLineLeftMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SuccessfulFire2ndLineLeftMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ObjectProperty: SuccessfulFire2ndLineRightMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SuccessfulFire2ndLineRightMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ObjectProperty: FailedFireMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FailedFireMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// FloatProperty: ZipForwardMaxSpeed
    /// </summary>
    public unsafe float ZipForwardMaxSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// FloatProperty: ZipForwardAccel
    /// </summary>
    public unsafe float ZipForwardAccel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// IntProperty: YawRangeToCheck
    /// </summary>
    public unsafe int YawRangeToCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// IntProperty: NumChecksOnEachSide
    /// </summary>
    public unsafe int NumChecksOnEachSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: LineLauncherAttachAngle
    /// </summary>
    public unsafe float LineLauncherAttachAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: LowLineLauncherHeightOffset
    /// </summary>
    public unsafe float LowLineLauncherHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: LowLineLauncherPlayerHeightOffset
    /// </summary>
    public unsafe float LowLineLauncherPlayerHeightOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// StructProperty: CurrentWinchUpPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentWinchUpPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1040);

    /// <summary>
    /// StructProperty: CurrentEndPosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentEndPosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1052);

    /// <summary>
    /// FloatProperty: CurrentZipSpeed
    /// </summary>
    public unsafe float CurrentZipSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1064); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: Projectile
    /// </summary>
    public InlineArray<BmSDK.BmGame.RProjectileWithRope> Projectile => new(2, Ptr + 1068, 4, this);

    /// <summary>
    /// ObjectProperty: Projectile
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileWithRope Projectile_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileWithRope>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }
    /// <summary>
    /// ObjectProperty: Projectile
    /// </summary>
    public unsafe BmSDK.BmGame.RProjectileWithRope Projectile_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RProjectileWithRope>(Ptr + 1072); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1072); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: ProjectileRope
    /// </summary>
    public InlineArray<BmSDK.BmGame.RSimpleRopeComponent> ProjectileRope => new(2, Ptr + 1076, 4, this);

    /// <summary>
    /// ComponentProperty: ProjectileRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent ProjectileRope_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 1076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1076); }
    }
    /// <summary>
    /// ComponentProperty: ProjectileRope
    /// </summary>
    public unsafe BmSDK.BmGame.RSimpleRopeComponent ProjectileRope_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSimpleRopeComponent>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ComponentProperty: MuzzleFlash
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent MuzzleFlash
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// FloatProperty: CosLineLauncherAttachAngle
    /// </summary>
    public unsafe float CosLineLauncherAttachAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// StructProperty: EndRopePos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EndRopePos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1092);

    /// <summary>
    /// StructProperty: BackRopePos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BackRopePos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1104);

    /// <summary>
    /// StructProperty: BatmanStartPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatmanStartPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1116);

    /// <summary>
    /// StructProperty: BatmanEndPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatmanEndPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1128);

    /// <summary>
    /// StructProperty: EndRopePosAim
    /// </summary>
    public unsafe ref System.Numerics.Vector3 EndRopePosAim
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1140);

    /// <summary>
    /// StructProperty: BackRopePosAim
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BackRopePosAim
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1152);

    /// <summary>
    /// StructProperty: BatmanStartPointAim
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatmanStartPointAim
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1164);

    /// <summary>
    /// StructProperty: BatmanEndPointAim
    /// </summary>
    public unsafe ref System.Numerics.Vector3 BatmanEndPointAim
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1176);

    /// <summary>
    /// IntProperty: RopeInitTimer
    /// </summary>
    public unsafe int RopeInitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// IntProperty: RopesFired
    /// </summary>
    public unsafe int RopesFired
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// FloatProperty: FirstRopePlayerHeight
    /// </summary>
    public unsafe float FirstRopePlayerHeight
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// FloatProperty: MinAimAngle
    /// </summary>
    public unsafe float MinAimAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// FloatProperty: CosMinAimAngle
    /// </summary>
    public unsafe float CosMinAimAngle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// ObjectProperty: RescueVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLineLauncherRescueVolume RescueVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncherRescueVolume>(Ptr + 1208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1208); }
    }

    /// <summary>
    /// ObjectProperty: HostageVolume
    /// </summary>
    public unsafe BmSDK.BmGame.RLineLauncherRescueVolume HostageVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLineLauncherRescueVolume>(Ptr + 1212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1212); }
    }

    /// <summary>
    /// ObjectProperty: TargetedHostage
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI TargetedHostage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// BoolProperty: bGrabHostageMode
    /// </summary>
    public unsafe bool bGrabHostageMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1220) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1220); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1220); }
    }

    /// <summary>
    /// BoolProperty: BlockedByHostageTaker
    /// </summary>
    public unsafe bool BlockedByHostageTaker
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1220) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1220); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1220); }
    }

    /// <summary>
    /// BoolProperty: bFailedLaunch
    /// </summary>
    public unsafe bool bFailedLaunch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1220) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1220); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1220); }
    }

    /// <summary>
    /// BoolProperty: AlwaysAllowLineLauncherTightrope
    /// </summary>
    public unsafe bool AlwaysAllowLineLauncherTightrope
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1220) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1220); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1220); }
    }

    /// <summary>
    /// ObjectProperty: GrabbedVillain
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnVillain GrabbedVillain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(Ptr + 1224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1224); }
    }

    /// <summary>
    /// ObjectProperty: GrabbedHostage
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI GrabbedHostage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// ObjectProperty: LineLauncherWire
    /// </summary>
    public unsafe BmSDK.BmGame.RHidePoint_RopeBase LineLauncherWire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RHidePoint_RopeBase>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// ObjectProperty: FlipUpOntoTightropeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FlipUpOntoTightropeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 1236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1236); }
    }

    /// <summary>
    /// ObjectProperty: CameraAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet CameraAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1240); }
    }

    /// <summary>
    /// NameProperty: CameraFire2ndLineLeftAnim
    /// </summary>
    public unsafe BmSDK.FName CameraFire2ndLineLeftAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// NameProperty: CameraFire2ndLineRightAnim
    /// </summary>
    public unsafe BmSDK.FName CameraFire2ndLineRightAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// FloatProperty: CameraAnimFactor
    /// </summary>
    public unsafe float CameraAnimFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }
}
