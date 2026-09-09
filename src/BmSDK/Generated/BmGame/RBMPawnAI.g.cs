#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RBMPawnAI<br/>
/// (size = 2700)
/// (flags = 144703671)
/// </summary>
public partial class RBMPawnAI : BmSDK.BmGame.RBMPawnAIAnim, BmSDK.Engine.Interface_NavigationHandle, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RBMPawnAI", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RBMPawnAI.
    /// </summary>
    public static RBMPawnAI DefaultObject => (RBMPawnAI)StaticClass().DefaultObject;

    internal RBMPawnAI() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RBMPawnAI(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RBMPawnAI>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: OnFinishGettingUpFromRagdoll
    /// </summary>
    public unsafe virtual void OnFinishGettingUpFromRagdoll()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.OnFinishGettingUpFromRagdoll", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldTriggerPredAlerts
    /// </summary>
    public unsafe virtual bool ShouldTriggerPredAlerts()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ShouldTriggerPredAlerts", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HitWall
    /// </summary>
    public unsafe override void HitWall(System.Numerics.Vector3 HitNormal, BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent WallComp)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.HitWall", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallComp, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCombatIdleStance
    /// </summary>
    public unsafe virtual void SetCombatIdleStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetCombatIdleStance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCombatIdleStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCombatIdleStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetCombatIdleStance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNonFatalTakedownDamage
    /// </summary>
    public unsafe virtual float GetNonFatalTakedownDamage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetNonFatalTakedownDamage", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AreTakedownsFatal
    /// </summary>
    public unsafe virtual bool AreTakedownsFatal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.AreTakedownsFatal", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AttemptTeleportToSafeLocation
    /// </summary>
    public unsafe override void AttemptTeleportToSafeLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.AttemptTeleportToSafeLocation", true);
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
    /// Function: InternalSetPhysWalkingType
    /// </summary>
    public unsafe void InternalSetPhysWalkingType(BmSDK.BmGame.RGameRI.EPhysWalkingType NewType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.InternalSetPhysWalkingType", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RevertTempPhysWalking
    /// </summary>
    public unsafe virtual void RevertTempPhysWalking()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.RevertTempPhysWalking", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetTempPhysWalking
    /// </summary>
    public unsafe virtual void SetTempPhysWalking(BmSDK.BmGame.RGameRI.EPhysWalkingType NewPhysWalkType, bool bNewDisableRagdollVsNavMeshConstraint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetTempPhysWalking", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhysWalkType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewDisableRagdollVsNavMeshConstraint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPhysWalkingTypeAndRagdoll
    /// </summary>
    public unsafe virtual void SetPhysWalkingTypeAndRagdoll(BmSDK.BmGame.RGameRI.EPhysWalkingType NewPhysWalkType, bool bNewDisableRagdollVsNavMeshConstraint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetPhysWalkingTypeAndRagdoll", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhysWalkType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewDisableRagdollVsNavMeshConstraint, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPhysWalkingType
    /// </summary>
    public unsafe virtual void SetPhysWalkingType(BmSDK.BmGame.RGameRI.EPhysWalkingType NewPhysWalkType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetPhysWalkingType", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPhysWalkType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnModifyHealth
    /// </summary>
    public unsafe override void OnModifyHealth(BmSDK.Engine.SeqAct_ModifyHealth Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.OnModifyHealth", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ConversationInterrupted
    /// </summary>
    public unsafe virtual void ConversationInterrupted(BmSDK.BmGame.RBMPawnAI InterruptedSpeaker)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ConversationInterrupted", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InterruptedSpeaker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TauntNotify
    /// </summary>
    public unsafe virtual void TauntNotify(BmSDK.BmGame.RGameRI.ETauntNotifyType Type)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.TauntNotify", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Type, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetHostile
    /// </summary>
    public unsafe virtual void SetHostile(bool bNewValue, BmSDK.FName NewNotHostileReason = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetHostile", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewValue, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewNotHostileReason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsHostile
    /// </summary>
    public unsafe virtual bool IsHostile()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.IsHostile", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: MulticastDamagedBy
    /// </summary>
    public unsafe virtual void MulticastDamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo Info)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.MulticastDamagedBy", true);
        byte* paramsPtr = stackalloc byte[244];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Info, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NewActionActive
    /// </summary>
    public unsafe virtual void NewActionActive(BmSDK.BmGame.RBMAIAction NewAction, System.Numerics.Vector3 SnapLoc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.NewActionActive", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SnapLoc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EarlyWarningOfBatarang
    /// </summary>
    public unsafe virtual void EarlyWarningOfBatarang()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.EarlyWarningOfBatarang", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanBeGlideKicked
    /// </summary>
    public unsafe virtual bool CanBeGlideKicked()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CanBeGlideKicked", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGlideKickEffectLocation
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetGlideKickEffectLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetGlideKickEffectLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AdjustGlideKickZ
    /// </summary>
    public unsafe virtual float AdjustGlideKickZ()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.AdjustGlideKickZ", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StopGlideKickFX
    /// </summary>
    public unsafe virtual void StopGlideKickFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.StopGlideKickFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartGlideKickFX
    /// </summary>
    public unsafe virtual void StartGlideKickFX(BmSDK.Engine.ParticleSystem OverrideFX, BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.StartGlideKickFX", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OverrideFX, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetRandomCreationVars
    /// </summary>
    public unsafe virtual void SetRandomCreationVars()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetRandomCreationVars", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LockRandomCreationVars
    /// </summary>
    public unsafe virtual void LockRandomCreationVars(float varOne, float varTwo, float varThree, float varFour, float varFive)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.LockRandomCreationVars", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(varOne, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(varTwo, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(varThree, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(varFour, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(varFive, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsDoingSomethingLatent
    /// </summary>
    public unsafe virtual bool IsDoingSomethingLatent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.IsDoingSomethingLatent", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GlanceHandledByCurrentAction
    /// </summary>
    public unsafe virtual bool GlanceHandledByCurrentAction()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GlanceHandledByCurrentAction", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: EndCurrentAction
    /// </summary>
    public unsafe virtual void EndCurrentAction()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.EndCurrentAction", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddInterrupt
    /// </summary>
    public unsafe virtual void AddInterrupt(BmSDK.BmGame.RBMAIAction NewAction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.AddInterrupt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCurrentAction
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIAction GetCurrentAction()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetCurrentAction", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ServerTickActionQueue
    /// </summary>
    public unsafe virtual void ServerTickActionQueue(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ServerTickActionQueue", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: KillQueue
    /// </summary>
    public unsafe virtual void KillQueue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.KillQueue", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReactivateQueue
    /// </summary>
    public unsafe virtual void ReactivateQueue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ReactivateQueue", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InterruptQueue
    /// </summary>
    public unsafe virtual void InterruptQueue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.InterruptQueue", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddToQueue
    /// </summary>
    public unsafe virtual void AddToQueue(BmSDK.BmGame.RBMAIAction NewAction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.AddToQueue", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartNewQueue
    /// </summary>
    public unsafe virtual void StartNewQueue(BmSDK.BmGame.RBMAIAction NewAction, BmSDK.BmGame.RBMAIAction.ActionExitLevel Urgency = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.StartNewQueue", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Urgency, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RefreshActionAnimInfo
    /// </summary>
    public unsafe virtual void RefreshActionAnimInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.RefreshActionAnimInfo", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateAction
    /// </summary>
    public unsafe virtual void ActivateAction()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ActivateAction", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResolveMovementMetaPose
    /// </summary>
    public unsafe virtual BmSDK.FName ResolveMovementMetaPose(BmSDK.FName InPose)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ResolveMovementMetaPose", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPose, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ResolveWeaponMetaPose
    /// </summary>
    public unsafe virtual BmSDK.FName ResolveWeaponMetaPose(BmSDK.FName InPose)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ResolveWeaponMetaPose", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPose, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ActionStanceUpdated
    /// </summary>
    public unsafe virtual void ActionStanceUpdated()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ActionStanceUpdated", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayFenceJumpAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayFenceJumpAnim(System.Numerics.Vector3 JumpLocation, float JumpYaw, BmSDK.FName JumpType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.PlayFenceJumpAnim", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpYaw, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(JumpType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: PlayJumpDownLadderAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayJumpDownLadderAnim(BmSDK.BmGame.RLadder TargetLadder)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.PlayJumpDownLadderAnim", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLadder, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PlayClimbLadderAnim
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId PlayClimbLadderAnim(BmSDK.BmGame.RLadder TargetLadder)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.PlayClimbLadderAnim", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLadder, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetCombatWeaponStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCombatWeaponStance(bool bWeaponWillBeDropped)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetCombatWeaponStance", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWeaponWillBeDropped, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDisarmStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetDisarmStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetDisarmStance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCombatStance
    /// </summary>
    public unsafe virtual BmSDK.FName GetCombatStance()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetCombatStance", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetCameraLookAtPriority
    /// </summary>
    public unsafe override float GetCameraLookAtPriority()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetCameraLookAtPriority", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PickupGun
    /// </summary>
    public unsafe virtual void PickupGun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.PickupGun", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DropGun
    /// </summary>
    public unsafe virtual void DropGun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.DropGun", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnSetGunFiring
    /// </summary>
    public unsafe virtual void OnSetGunFiring(BmSDK.BmGame.RSeqAct_SetGunFiring GunFireAction)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.OnSetGunFiring", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GunFireAction, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RealiseGunIsJammed
    /// </summary>
    public unsafe virtual void RealiseGunIsJammed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.RealiseGunIsJammed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreventEnterCombat
    /// </summary>
    public unsafe virtual bool PreventEnterCombat()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.PreventEnterCombat", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: WeaponStopOnBurstEnd
    /// </summary>
    public unsafe virtual void WeaponStopOnBurstEnd()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.WeaponStopOnBurstEnd", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeaponStop
    /// </summary>
    public unsafe virtual void WeaponStop()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.WeaponStop", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeaponFire
    /// </summary>
    public unsafe virtual void WeaponFire(bool bBurst = default, bool bFireOnce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.WeaponFire", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bBurst, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFireOnce, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Anim_WeaponStop
    /// </summary>
    public unsafe virtual void Anim_WeaponStop()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.Anim_WeaponStop", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Anim_WeaponFireFullAuto
    /// </summary>
    public unsafe virtual void Anim_WeaponFireFullAuto()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.Anim_WeaponFireFullAuto", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Anim_WeaponFireOneShot
    /// </summary>
    public unsafe virtual void Anim_WeaponFireOneShot()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.Anim_WeaponFireOneShot", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Anim_WeaponFire
    /// </summary>
    public unsafe virtual void Anim_WeaponFire()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.Anim_WeaponFire", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopFire
    /// </summary>
    public unsafe override void StopFire(byte FireModeNum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.StopFire", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartFire
    /// </summary>
    public unsafe override void StartFire(byte FireModeNum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.StartFire", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FireModeNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoFiringRecoil
    /// </summary>
    public unsafe virtual void DoFiringRecoil(BmSDK.FName RecoilAnimName, BmSDK.Engine.AnimSet Set)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.DoFiringRecoil", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RecoilAnimName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Set, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ReloadGun
    /// </summary>
    public unsafe virtual void ReloadGun(bool bMagicReload = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ReloadGun", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bMagicReload, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Anim_ReloadGun
    /// </summary>
    public unsafe virtual void Anim_ReloadGun()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.Anim_ReloadGun", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TickGunFire
    /// </summary>
    public unsafe virtual void TickGunFire(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.TickGunFire", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldMiss
    /// </summary>
    public unsafe virtual bool ShouldMiss(float TestDistSq)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ShouldMiss", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDistSq, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetThoughts
    /// </summary>
    public unsafe override void GetThoughts(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetThoughts", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: GetNavHandle_PathBetweenChasePoints
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetNavHandle_PathBetweenChasePoints(BmSDK.BmGame.RChasePoint StartPoint, BmSDK.BmGame.RChasePoint EndPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetNavHandle_PathBetweenChasePoints", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: RemoveNavHandles
    /// </summary>
    public unsafe virtual void RemoveNavHandles()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.RemoveNavHandles", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopMoveToAtCurrentLocation
    /// </summary>
    public unsafe virtual void StopMoveToAtCurrentLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.StopMoveToAtCurrentLocation", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FollowNavHandle
    /// </summary>
    public unsafe virtual void FollowNavHandle(BmSDK.BmGame.RNavigationHandle NavHandle)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.FollowNavHandle", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NavHandle, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetNavHandle_PathToActor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetNavHandle_PathToActor(BmSDK.Engine.Actor destActor, BmSDK.FName ClaimName, int Priority = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetNavHandle_PathToActor", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(destActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetNavHandle_PathToPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetNavHandle_PathToPoint(System.Numerics.Vector3 DestPos, BmSDK.FName ClaimName, int Priority = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetNavHandle_PathToPoint", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Priority, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: GetNavHandle
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RNavigationHandle GetNavHandle(BmSDK.FName ClaimName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetNavHandle", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClaimName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CreateBasicWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateBasicWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets, BmSDK.Engine.AnimSet TurnAnimSet = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CreateBasicWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[716];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSets, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnAnimSet, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetEntryAnim
    /// </summary>
    public unsafe virtual BmSDK.FName GetEntryAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetEntryAnim", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetEntryAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetEntryAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetEntryAnimSet", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RemovePropSkeletal
    /// </summary>
    public unsafe override void RemovePropSkeletal(System.Numerics.Vector3 PropForce, bool PawnDied = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.RemovePropSkeletal", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropForce, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PawnDied, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanHitLaserGrid
    /// </summary>
    public unsafe override bool CanHitLaserGrid()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CanHitLaserGrid", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanRepel
    /// </summary>
    public unsafe override bool CanRepel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CanRepel", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PlaySound_ImpactAI
    /// </summary>
    public unsafe override void PlaySound_ImpactAI(bool bIsStrike, bool bFinishingBlow, bool bIsHeadImpact, bool bIsPunch, bool bIsStrong, bool bIsBlocked, bool bCanEmote = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.PlaySound_ImpactAI", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrike, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFinishingBlow, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsHeadImpact, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsPunch, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsStrong, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsBlocked, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCanEmote, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RigidBodyCollision
    /// </summary>
    public unsafe override void RigidBodyCollision(BmSDK.Engine.PrimitiveComponent HitComponent, BmSDK.Engine.PrimitiveComponent OtherComponent, BmSDK.Engine.Actor.FCollisionImpactData RigidCollisionData, int ContactIndex, float Speed, int Index0, int Index1)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.RigidBodyCollision", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitComponent, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComponent, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RigidCollisionData, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ContactIndex, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Speed, paramsPtr + 48);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index0, paramsPtr + 52);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index1, paramsPtr + 56);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FadeOutAfterDeath
    /// </summary>
    public unsafe virtual void FadeOutAfterDeath(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.FadeOutAfterDeath", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CombatMoveInitialised
    /// </summary>
    public unsafe override void CombatMoveInitialised(BmSDK.BmGame.RCombatMove NewMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CombatMoveInitialised", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetJammedAttackMoveClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetJammedAttackMoveClass()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetJammedAttackMoveClass", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetAttackMoveClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetAttackMoveClass()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetAttackMoveClass", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CurrentBehaviourChanged
    /// </summary>
    public unsafe virtual void CurrentBehaviourChanged(BmSDK.BmGame.RBMBehaviour NewBehaviour)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CurrentBehaviourChanged", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewBehaviour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinishedGetUp
    /// </summary>
    public unsafe override void FinishedGetUp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.FinishedGetUp", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowWeaponRight
    /// </summary>
    public unsafe virtual void ShowWeaponRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ShowWeaponRight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowWeaponLeft
    /// </summary>
    public unsafe virtual void ShowWeaponLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ShowWeaponLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowWeapon
    /// </summary>
    public unsafe virtual void ShowWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ShowWeapon", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HideWeapon
    /// </summary>
    public unsafe virtual void HideWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.HideWeapon", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Drop
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject Drop()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.Drop", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ThrowWeaponVelocity
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject ThrowWeaponVelocity(System.Numerics.Vector3 NewVel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ThrowWeaponVelocity", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewVel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ThrowWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMCombatThrownObject ThrowWeapon(System.Numerics.Vector3 TargetPos = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ThrowWeapon", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPos, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: HandleWeaponUnJammed
    /// </summary>
    public unsafe virtual void HandleWeaponUnJammed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.HandleWeaponUnJammed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HandleWeaponJammed
    /// </summary>
    public unsafe virtual void HandleWeaponJammed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.HandleWeaponJammed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HandlePredThugDisarm
    /// </summary>
    public unsafe virtual void HandlePredThugDisarm()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.HandlePredThugDisarm", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HandleThugDisarmGunFX
    /// </summary>
    public unsafe virtual void HandleThugDisarmGunFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.HandleThugDisarmGunFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeaponSwitchCallback
    /// </summary>
    public unsafe override void WeaponSwitchCallback(BmSDK.Engine.Inventory NewWeapon, BmSDK.Engine.Inventory PreviousWeapon)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.WeaponSwitchCallback", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousWeapon, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NewWeaponAttached
    /// </summary>
    public unsafe virtual void NewWeaponAttached(BmSDK.BmGame.RBMWeapon NewWeapon)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.NewWeaponAttached", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeaponChanged
    /// </summary>
    public unsafe virtual void WeaponChanged(BmSDK.BmGame.RBMWeapon NewWeapon)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.WeaponChanged", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWeapon, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DodgedMagneticBlastDisarm
    /// </summary>
    public unsafe virtual void DodgedMagneticBlastDisarm()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.DodgedMagneticBlastDisarm", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TryDisarmByMagneticBlast
    /// </summary>
    public unsafe virtual void TryDisarmByMagneticBlast(System.Numerics.Vector3 Impulse, BmSDK.BmGame.RPawnCombat Attacker, BmSDK.BmGame.RMagneticBlastReceiver Receiver, bool bSuccessfulDisarm)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.TryDisarmByMagneticBlast", true);
        byte* paramsPtr = stackalloc byte[272];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Impulse, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Receiver, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccessfulDisarm, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForceDisarm
    /// </summary>
    public unsafe virtual void ForceDisarm()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ForceDisarm", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DropWeapon
    /// </summary>
    public unsafe virtual void DropWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.DropWeapon", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Disarm
    /// </summary>
    public unsafe virtual void Disarm()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.Disarm", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerBumped
    /// </summary>
    public unsafe virtual void PlayerBumped(BmSDK.BmGame.RPawnPlayer Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.PlayerBumped", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.Bump", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckDodgeProjectile
    /// </summary>
    public unsafe virtual bool CheckDodgeProjectile(BmSDK.BmGame.RPawn Thrower, BmSDK.FName TargetBone, System.Numerics.Vector3 ProjPos, int BatarangID, bool bForceDodge = default, bool bSteerableProj = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CheckDodgeProjectile", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Thrower, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetBone, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ProjPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatarangID, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceDodge, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSteerableProj, paramsPtr + 32);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: CollisionWith
    /// </summary>
    public unsafe override void CollisionWith(BmSDK.BmGame.RPawnCombat OtherPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CollisionWith", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IdleConfigNotify
    /// </summary>
    public unsafe virtual void IdleConfigNotify(BmSDK.BmGame.RAnimNotify_IdleConfigOutput Notify)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.IdleConfigNotify", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Notify, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckBigGuyDamage
    /// </summary>
    public unsafe virtual void CheckBigGuyDamage(BmSDK.BmGame.RPawnCombat NewAttacker, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CheckBigGuyDamage", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewAttacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCombatBehaviourClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetCombatBehaviourClass()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetCombatBehaviourClass", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HasWeapon
    /// </summary>
    public unsafe virtual bool HasWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.HasWeapon", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpawnWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMWeapon SpawnWeapon(BmSDK.Class WeaponClass, bool bForce = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SpawnWeapon", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForce, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CreateWeapon
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMWeapon CreateWeapon()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CreateWeapon", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetupCustomPhysics
    /// </summary>
    public unsafe override void SetupCustomPhysics()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetupCustomPhysics", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPropsInXray
    /// </summary>
    public unsafe override void SetPropsInXray(bool bActivate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetPropsInXray", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPropsInThermal
    /// </summary>
    public unsafe override void SetPropsInThermal(bool bActivate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetPropsInThermal", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetIndividualStaticPropInVM
    /// </summary>
    public unsafe virtual void SetIndividualStaticPropInVM(bool bActivate, bool bThermal, int MeshToChangeIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetIndividualStaticPropInVM", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThermal, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshToChangeIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetIndividualSkeletalPropInVM
    /// </summary>
    public unsafe virtual void SetIndividualSkeletalPropInVM(bool bActivate, bool bThermal, int MeshToChangeIndex)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetIndividualSkeletalPropInVM", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThermal, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeshToChangeIndex, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AttachSkeletalProps
    /// </summary>
    public unsafe virtual void AttachSkeletalProps()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.AttachSkeletalProps", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetStaticPropIndexByMesh
    /// </summary>
    public unsafe virtual int GetStaticPropIndexByMesh(BmSDK.Engine.StaticMesh SM)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetStaticPropIndexByMesh", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SM, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: OverrideStaticPropMaterial
    /// </summary>
    public unsafe virtual void OverrideStaticPropMaterial(int Index, BmSDK.Engine.Material Mat)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.OverrideStaticPropMaterial", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Mat, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetStaticPropHidden
    /// </summary>
    public unsafe virtual void SetStaticPropHidden(int Index, bool bHide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetStaticPropHidden", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHide, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitPropStatic
    /// </summary>
    public unsafe virtual void InitPropStatic(int Index)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.InitPropStatic", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Index, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AttachStaticProps
    /// </summary>
    public unsafe virtual void AttachStaticProps()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.AttachStaticProps", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AttachProps
    /// </summary>
    public unsafe virtual void AttachProps()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.AttachProps", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddPawnProps
    /// </summary>
    public unsafe virtual void AddPawnProps()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.AddPawnProps", true);
        byte* paramsPtr = stackalloc byte[204];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShrinkAttachmentArrays
    /// </summary>
    public unsafe virtual void ShrinkAttachmentArrays()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ShrinkAttachmentArrays", true);
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
    /// Function: PostLoadXrayCheck
    /// </summary>
    public unsafe virtual void PostLoadXrayCheck()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.PostLoadXrayCheck", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPawnName
    /// </summary>
    public unsafe virtual void GetPawnName(out BmSDK.TArray<BmSDK.Engine.Actor.FThought> ThoughtList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetPawnName", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ThoughtList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor.FThought>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe override void ReplicatedEvent(BmSDK.FName VarName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ReplicatedEvent", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Died
    /// </summary>
    public unsafe override bool Died(BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.Died", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: Destroyed
    /// </summary>
    public unsafe override void Destroyed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.Destroyed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreStreamOut
    /// </summary>
    public unsafe override void PreStreamOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.PreStreamOut", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DestroyPawn
    /// </summary>
    public unsafe virtual void DestroyPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.DestroyPawn", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe override void SetInXrayMode(bool show, bool bForceOff)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetInXrayMode", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetFleeRunPose
    /// </summary>
    public unsafe virtual void SetFleeRunPose()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetFleeRunPose", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetExtendedSightRange
    /// </summary>
    public unsafe virtual void SetExtendedSightRange(float NewRange)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetExtendedSightRange", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetFocusedVisionRadius
    /// </summary>
    public unsafe virtual void SetFocusedVisionRadius(float NewRadius)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetFocusedVisionRadius", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRadius, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetFocusedSightRange
    /// </summary>
    public unsafe virtual void SetFocusedSightRange(float NewRange)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetFocusedSightRange", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPeripheralSightRange
    /// </summary>
    public unsafe virtual void SetPeripheralSightRange(float NewRange)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetPeripheralSightRange", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetCheckSightRange
    /// </summary>
    public unsafe virtual float GetCheckSightRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetCheckSightRange", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanMoveToPoint
    /// </summary>
    public unsafe virtual bool CanMoveToPoint(System.Numerics.Vector3 MoveToPoint, out float HitTime, out BmSDK.Engine.Actor HitActor, bool bSlopeCheck = default, System.Numerics.Vector3 TestLocation = default, bool bForceExtentCheck = default, bool bDoGroundCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CanMoveToPoint", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MoveToPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSlopeCheck, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceExtentCheck, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDoGroundCheck, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        HitTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
        HitActor = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: CreateLadderWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateLadderWeaponConfig(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet AnimSet1, BmSDK.Engine.AnimSet AnimSet2 = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CreateLadderWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[1520];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AnimSet2, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CreateWeaponConfigUnarmed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: DeregisterWeaponConfig
    /// </summary>
    public unsafe virtual void DeregisterWeaponConfig()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.DeregisterWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateWeaponConfig
    /// </summary>
    public unsafe virtual void CreateWeaponConfig()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CreateWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostInitCharacter
    /// </summary>
    public unsafe override void PostInitCharacter()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.PostInitCharacter", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForceTickIndividualComponent
    /// </summary>
    public unsafe virtual void ForceTickIndividualComponent(BmSDK.Engine.ActorComponent CompToTick, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.ForceTickIndividualComponent", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CompToTick, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
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
    /// Function: UpdatePropsVisibility
    /// </summary>
    public unsafe override void UpdatePropsVisibility(float AlphaVal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.UpdatePropsVisibility", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AlphaVal, paramsPtr + 0);
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
    /// Function: SetTickIsDisabled
    /// </summary>
    public unsafe override void SetTickIsDisabled(bool bInDisabled)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetTickIsDisabled", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bInDisabled, paramsPtr + 0);
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
    /// Function: SetLastValidNavMeshPoly
    /// </summary>
    public unsafe virtual void SetLastValidNavMeshPoly(BmSDK.Engine.Pylon ValidPylon, int ValidPolyID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.SetLastValidNavMeshPoly", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValidPylon, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ValidPolyID, paramsPtr + 4);
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
    /// Function: LogPopCorrectionInAnimLog
    /// </summary>
    public unsafe virtual void LogPopCorrectionInAnimLog()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.LogPopCorrectionInAnimLog", true);
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
    /// Function: UpdateVertVisibility
    /// </summary>
    public unsafe virtual void UpdateVertVisibility()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.UpdateVertVisibility", true);
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
    /// Function: GetMaxSightRange
    /// </summary>
    public unsafe virtual float GetMaxSightRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetMaxSightRange", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanSeeActorFromPos
    /// </summary>
    public unsafe virtual float CanSeeActorFromPos(BmSDK.Engine.Actor TestActor, System.Numerics.Vector3 TestPos, bool bEarlyOut = default, bool bIgnoreSmoke = default, bool bSkipTestedBones = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CanSeeActorFromPos", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEarlyOut, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreSmoke, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipTestedBones, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: CanSeeActor
    /// </summary>
    public unsafe virtual float CanSeeActor(BmSDK.Engine.Actor TestActor, bool bEarlyOut = default, bool bIgnoreSmoke = default, bool bSkipTestedBones = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CanSeeActor", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEarlyOut, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreSmoke, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSkipTestedBones, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CanSeePos
    /// </summary>
    public unsafe virtual bool CanSeePos(System.Numerics.Vector3 TestPos, bool bIgnoreSmoke = default, bool bStartWithPointCheck = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CanSeePos", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIgnoreSmoke, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bStartWithPointCheck, paramsPtr + 16);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: GetPawnVisionCheckEyeLoc
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetPawnVisionCheckEyeLoc()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.GetPawnVisionCheckEyeLoc", true);
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
    /// Function: CreateActionOfClass
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMAIAction CreateActionOfClass(BmSDK.Class NewClass, BmSDK.FString NewId = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.CreateActionOfClass", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewId, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: InitCharacter
    /// </summary>
    public unsafe virtual void InitCharacter(BmSDK.BmGame.RBMPawnAI.FInitCharacterDescription Description)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.InitCharacter", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Description, paramsPtr + 0);
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
    /// Function: NotifyPathChanged
    /// </summary>
    public unsafe virtual void NotifyPathChanged()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RBMPawnAI.NotifyPathChanged", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FAlwaysOnParticles
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FAlwaysOnParticles
    {
        /// <summary>
        /// ComponentProperty: Part
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystemComponent Part
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// NameProperty: AttachBone
        /// </summary>
        public unsafe BmSDK.FName AttachBone
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FValidNavMeshPoly
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FValidNavMeshPoly
    {
        /// <summary>
        /// StructProperty: Position
        /// </summary>
        public unsafe System.Numerics.Vector3 Position
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Pylon
        /// </summary>
        public unsafe BmSDK.Engine.Pylon Pylon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: PolyId
        /// </summary>
        public unsafe int PolyId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Enum: GunTargetBoneState
    /// </summary>
    public enum GunTargetBoneState : byte
    {
        GTBS_Untested = 0,
        GTBS_Obscured = 1,
        GTBS_Visible = 2,
        GTBS_MAX = 3,
    }

    /// <summary>
    /// Struct: FInitCharacterDescription
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FInitCharacterDescription
    {
        /// <summary>
        /// ClassProperty: Character
        /// </summary>
        public unsafe BmSDK.Class Character
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ClassProperty: WeaponType
        /// </summary>
        public unsafe BmSDK.Class WeaponType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: AlternateAnimAndWeapon
        /// </summary>
        public unsafe BmSDK.BmGame.RAlternateAnimationAndWeaponConfig AlternateAnimAndWeapon
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlternateAnimationAndWeaponConfig>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: InitialMovementStance
        /// </summary>
        public unsafe BmSDK.FName InitialMovementStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// NameProperty: InitialWeaponStance
        /// </summary>
        public unsafe BmSDK.FName InitialWeaponStance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: bCastShadow
        /// </summary>
        public unsafe bool bCastShadow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bForceFlappyBitsOff
        /// </summary>
        public unsafe bool bForceFlappyBitsOff
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bForceAlwaysUsePhysicsOn
        /// </summary>
        public unsafe bool bForceAlwaysUsePhysicsOn
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bCanBeXrayed
        /// </summary>
        public unsafe bool bCanBeXrayed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bSilentRagdoll
        /// </summary>
        public unsafe bool bSilentRagdoll
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bUsedInCutsceneDialogue
        /// </summary>
        public unsafe bool bUsedInCutsceneDialogue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: OverridePhysWalkingType
        /// </summary>
        public unsafe bool OverridePhysWalkingType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28) & 64) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 28); }; }
        }

        /// <summary>
        /// ByteProperty: PhysWalkingType
        /// </summary>
        public unsafe BmSDK.BmGame.RGameRI.EPhysWalkingType PhysWalkingType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPhysWalkingType>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bFallBackToNavMeshFloor
        /// </summary>
        public unsafe bool bFallBackToNavMeshFloor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// ByteProperty: RagdollVsNavMeshSolution
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh RagdollVsNavMeshSolution
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCharacter.ERagdollVsNavMesh>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: bReduceBlinksAndEyeMovements
        /// </summary>
        public unsafe bool bReduceBlinksAndEyeMovements
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bForceDisableFloorCorrection
        /// </summary>
        public unsafe bool bForceDisableFloorCorrection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// BoolProperty: bUseSkeletalMeshAggressiveLODScale
        /// </summary>
        public unsafe bool bUseSkeletalMeshAggressiveLODScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: SkeletalMeshAggressiveLODMultiplier
        /// </summary>
        public unsafe float SkeletalMeshAggressiveLODMultiplier
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Struct: FCharacterStaticProps
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FCharacterStaticProps
    {
        /// <summary>
        /// ObjectProperty: Prop
        /// </summary>
        public unsafe BmSDK.Engine.StaticMesh Prop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMesh>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ComponentProperty: PropComp
        /// </summary>
        public unsafe BmSDK.Engine.StaticMeshComponent PropComp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// NameProperty: PropGlobalFlagCheck
        /// </summary>
        public unsafe BmSDK.FName PropGlobalFlagCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// NameProperty: SocketToAttachPropTo
        /// </summary>
        public unsafe BmSDK.FName SocketToAttachPropTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// NameProperty: BoneToAttachPropTo
        /// </summary>
        public unsafe BmSDK.FName BoneToAttachPropTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialXrayMat
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstance SpecialXrayMat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialXrayMatIC
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstanceConstant SpecialXrayMatIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialThermalMat
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstance SpecialThermalMat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialThermalMatIC
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstanceConstant SpecialThermalMatIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// ArrayProperty: SavedXrayMats
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> SavedXrayMats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// ArrayProperty: SavedThermalMats
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> SavedThermalMats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Struct: FCharacterSkeletalProps
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 124)]
    public partial record struct FCharacterSkeletalProps
    {
        /// <summary>
        /// ObjectProperty: Prop
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh Prop
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: MultiProps
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FMultiProp> MultiProps
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FMultiProp>>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: MultiPropChance
        /// </summary>
        public unsafe float MultiPropChance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ComponentProperty: PropComp
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMeshComponent PropComp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialXrayMat
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstance SpecialXrayMat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialXrayMatIC
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstanceConstant SpecialXrayMatIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialThermalMat
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstance SpecialThermalMat
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstance>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecialThermalMatIC
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInstanceConstant SpecialThermalMatIC
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// BoolProperty: bDontAllowColorChange
        /// </summary>
        public unsafe bool bDontAllowColorChange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// ObjectProperty: PropPhys
        /// </summary>
        public unsafe BmSDK.Engine.PhysicsAsset PropPhys
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsAsset>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// NameProperty: SocketToAttachPropTo
        /// </summary>
        public unsafe BmSDK.FName SocketToAttachPropTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// NameProperty: BoneToAttachPropTo
        /// </summary>
        public unsafe BmSDK.FName BoneToAttachPropTo
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// NameProperty: PropGlobalFlagCheck
        /// </summary>
        public unsafe BmSDK.FName PropGlobalFlagCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// BoolProperty: bRemovePropOnStrike
        /// </summary>
        public unsafe bool bRemovePropOnStrike
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bRemovePropOnDeath
        /// </summary>
        public unsafe bool bRemovePropOnDeath
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bRemovedProp
        /// </summary>
        public unsafe bool bRemovedProp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bUsesParentAnim
        /// </summary>
        public unsafe bool bUsesParentAnim
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// ByteProperty: ParentAnimComponentMode
        /// </summary>
        public unsafe BmSDK.Engine.RSkeletalMeshComponent_Export.EParentAnimComponentMode ParentAnimComponentMode
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RSkeletalMeshComponent_Export.EParentAnimComponentMode>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// ObjectProperty: AnimTree
        /// </summary>
        public unsafe BmSDK.Engine.AnimTree AnimTree
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimTree>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// ArrayProperty: AnimSets
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.AnimSet> AnimSets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AnimSet>>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// ClassProperty: RemovedPropClass
        /// </summary>
        public unsafe BmSDK.Class RemovedPropClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }

        /// <summary>
        /// ArrayProperty: SavedXrayMats
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> SavedXrayMats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// ArrayProperty: SavedThermalMats
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInterface> SavedThermalMats
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInterface>>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }
    }

    /// <summary>
    /// Struct: FMultiProp
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FMultiProp
    {
        /// <summary>
        /// ObjectProperty: MultiProp
        /// </summary>
        public unsafe BmSDK.Engine.SkeletalMesh _MultiProp
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMesh>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ClassProperty: MultiPropRemovedPropClass
        /// </summary>
        public unsafe BmSDK.Class MultiPropRemovedPropClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// ObjectProperty: SpecificMatToUse
        /// </summary>
        public unsafe BmSDK.Engine.MaterialInterface SpecificMatToUse
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// StructProperty: VfTable_IInterface_NavigationHandle
    /// </summary>
    public unsafe System.IntPtr VfTable_IInterface_NavigationHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 2112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2112); }
    }

    /// <summary>
    /// ByteProperty: PhysWalkingType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EPhysWalkingType PhysWalkingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPhysWalkingType>(Ptr + 2116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2116); }
    }

    /// <summary>
    /// ByteProperty: TempPhysWalkingType
    /// </summary>
    public unsafe BmSDK.BmGame.RGameRI.EPhysWalkingType TempPhysWalkingType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameRI.EPhysWalkingType>(Ptr + 2117); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2117); }
    }

    /// <summary>
    /// ByteProperty: Faction
    /// </summary>
    public unsafe BmSDK.BmGame.RChapterLineSet.EFaction Faction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RChapterLineSet.EFaction>(Ptr + 2118); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2118); }
    }

    /// <summary>
    /// ByteProperty: KOGameAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction KOGameAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 2119); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2119); }
    }

    /// <summary>
    /// ByteProperty: WeaponConfigType
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager.EWeaponConfigType WeaponConfigType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager.EWeaponConfigType>(Ptr + 2120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2120); }
    }

    /// <summary>
    /// BoolProperty: bFallBackToNavMeshFloor
    /// </summary>
    public unsafe bool bFallBackToNavMeshFloor
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bBlockOtherPawns
    /// </summary>
    public unsafe bool bBlockOtherPawns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bFriendly
    /// </summary>
    public unsafe bool bFriendly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bCrowd
    /// </summary>
    public unsafe bool bCrowd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bKeepWeapon
    /// </summary>
    public unsafe bool bKeepWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bSilentPredatorAI
    /// </summary>
    public unsafe bool bSilentPredatorAI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bIsSilentPredV2
    /// </summary>
    public unsafe bool bIsSilentPredV2
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bIsLitePred
    /// </summary>
    public unsafe bool bIsLitePred
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bTriggerPredAlerts
    /// </summary>
    public unsafe bool bTriggerPredAlerts
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bDoPredatorVision
    /// </summary>
    public unsafe bool bDoPredatorVision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bSniper
    /// </summary>
    public unsafe bool bSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bCanPickupSniperRifleSniper
    /// </summary>
    public unsafe bool bCanPickupSniperRifleSniper
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bCombatMirrored
    /// </summary>
    public unsafe bool bCombatMirrored
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bCanBeDisarmedByMagBlast
    /// </summary>
    public unsafe bool bCanBeDisarmedByMagBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bMagneticBlastClingToWeapon
    /// </summary>
    public unsafe bool bMagneticBlastClingToWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bDodgedMagneticBlastDisarm
    /// </summary>
    public unsafe bool bDodgedMagneticBlastDisarm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bInstantEnterCombatOnMagBlast
    /// </summary>
    public unsafe bool bInstantEnterCombatOnMagBlast
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bApplySoftPawnCollision
    /// </summary>
    public unsafe bool bApplySoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bReceiveSoftPawnCollision
    /// </summary>
    public unsafe bool bReceiveSoftPawnCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bDoPlayerCollision
    /// </summary>
    public unsafe bool bDoPlayerCollision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bApplyRouterPawnAvoidance
    /// </summary>
    public unsafe bool bApplyRouterPawnAvoidance
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bTickGunFire
    /// </summary>
    public unsafe bool bTickGunFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bFireOnceOnly
    /// </summary>
    public unsafe bool bFireOnceOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bForceBehaviourTickEveryFrame
    /// </summary>
    public unsafe bool bForceBehaviourTickEveryFrame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bWeaponCanBePickedUp
    /// </summary>
    public unsafe bool bWeaponCanBePickedUp
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bWeaponCanBePickedUpOnlyBySelf
    /// </summary>
    public unsafe bool bWeaponCanBePickedUpOnlyBySelf
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bWeaponWasJammed
    /// </summary>
    public unsafe bool bWeaponWasJammed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bDisableCornerSliding
    /// </summary>
    public unsafe bool bDisableCornerSliding
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bAttackASAP
    /// </summary>
    public unsafe bool bAttackASAP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bHostile
    /// </summary>
    public unsafe bool bHostile
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bForceConstantGroundChecks
    /// </summary>
    public unsafe bool bForceConstantGroundChecks
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bFleeASAP
    /// </summary>
    public unsafe bool bFleeASAP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2124); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2124); }
    }

    /// <summary>
    /// BoolProperty: bPostFleeIdleASAP
    /// </summary>
    public unsafe bool bPostFleeIdleASAP
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bWanderingAI
    /// </summary>
    public unsafe bool bWanderingAI
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bDontShowPredatorEscapeInstructions
    /// </summary>
    public unsafe bool bDontShowPredatorEscapeInstructions
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bTriggerBatarangCamera
    /// </summary>
    public unsafe bool bTriggerBatarangCamera
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bDisallowQuickTakedowns
    /// </summary>
    public unsafe bool bDisallowQuickTakedowns
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bFadeOutAfterDeath
    /// </summary>
    public unsafe bool bFadeOutAfterDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bStreamWeapon
    /// </summary>
    public unsafe bool bStreamWeapon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bCanBeXrayed
    /// </summary>
    public unsafe bool bCanBeXrayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bBatarangCanKill
    /// </summary>
    public unsafe bool bBatarangCanKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bBatarangCantTarget
    /// </summary>
    public unsafe bool bBatarangCantTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bDontReactToBatarang
    /// </summary>
    public unsafe bool bDontReactToBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bAlwaysDodgeBatarang
    /// </summary>
    public unsafe bool bAlwaysDodgeBatarang
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bForceBatarangMirror
    /// </summary>
    public unsafe bool bForceBatarangMirror
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bHarpoonCantTarget
    /// </summary>
    public unsafe bool bHarpoonCantTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bDontReactToHarpoon
    /// </summary>
    public unsafe bool bDontReactToHarpoon
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bReallyDead
    /// </summary>
    public unsafe bool bReallyDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bUseRealNameForInvestigate
    /// </summary>
    public unsafe bool bUseRealNameForInvestigate
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bIsCaucassian
    /// </summary>
    public unsafe bool bIsCaucassian
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bFiring
    /// </summary>
    public unsafe bool bFiring
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bFiringBurst
    /// </summary>
    public unsafe bool bFiringBurst
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bStopAfterBurst
    /// </summary>
    public unsafe bool bStopAfterBurst
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bHasBuiltInGun
    /// </summary>
    public unsafe bool bHasBuiltInGun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bInDialogue
    /// </summary>
    public unsafe bool bInDialogue
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bICSuspendStasis
    /// </summary>
    public unsafe bool bICSuspendStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bICForceStasis
    /// </summary>
    public unsafe bool bICForceStasis
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bAllowActionTick
    /// </summary>
    public unsafe bool bAllowActionTick
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bActionTickActive
    /// </summary>
    public unsafe bool bActionTickActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bActionCustomEyeLocation
    /// </summary>
    public unsafe bool bActionCustomEyeLocation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bIsRescueTarget
    /// </summary>
    public unsafe bool bIsRescueTarget
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// BoolProperty: bShowRouterBlockedInfo
    /// </summary>
    public unsafe bool bShowRouterBlockedInfo
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2128); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 2128); }
    }

    /// <summary>
    /// StructProperty: SearchExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SearchExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2132);

    /// <summary>
    /// StructProperty: TerrifiedSearchExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 TerrifiedSearchExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2144);

    /// <summary>
    /// ArrayProperty: NavHandleList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RNavigationHandle> NavHandleList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RNavigationHandle>>(Ptr + 2156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2156); }
    }

    /// <summary>
    /// ObjectProperty: CurrNavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle CurrNavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 2168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2168); }
    }

    /// <summary>
    /// ObjectProperty: Spawner
    /// </summary>
    public unsafe BmSDK.GameObject Spawner
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(Ptr + 2172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2172); }
    }

    /// <summary>
    /// ObjectProperty: LastMagBlastReceiver
    /// </summary>
    public unsafe BmSDK.BmGame.RMagneticBlastReceiver LastMagBlastReceiver
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RMagneticBlastReceiver>(Ptr + 2176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2176); }
    }

    /// <summary>
    /// StructProperty: SoftPawnCollisionVelocity
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SoftPawnCollisionVelocity
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2180);

    /// <summary>
    /// NameProperty: NotHostileReason
    /// </summary>
    public unsafe BmSDK.FName NotHostileReason
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2192); }
    }

    /// <summary>
    /// IntProperty: ForceGroundChecks
    /// </summary>
    public unsafe int ForceGroundChecks
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2200); }
    }

    /// <summary>
    /// FloatProperty: InstantSightRange
    /// </summary>
    public unsafe float InstantSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2204); }
    }

    /// <summary>
    /// FloatProperty: FocusedSightRange
    /// </summary>
    public unsafe float FocusedSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2208); }
    }

    /// <summary>
    /// FloatProperty: FocusedVisionRadius
    /// </summary>
    public unsafe float FocusedVisionRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2212); }
    }

    /// <summary>
    /// FloatProperty: PeripheralSightRange
    /// </summary>
    public unsafe float PeripheralSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2216); }
    }

    /// <summary>
    /// FloatProperty: ExtendedSightRange
    /// </summary>
    public unsafe float ExtendedSightRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2220); }
    }

    /// <summary>
    /// StructProperty: PrevFloorNormal
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PrevFloorNormal
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2224);

    /// <summary>
    /// StrProperty: ForceDeathTip
    /// </summary>
    public unsafe BmSDK.FString ForceDeathTip
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2236); }
    }

    /// <summary>
    /// ClassProperty: WeaponType
    /// </summary>
    public unsafe BmSDK.Class WeaponType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2248); }
    }

    /// <summary>
    /// ObjectProperty: AlternateAnimAndWeap
    /// </summary>
    public unsafe BmSDK.BmGame.RAlternateAnimationAndWeaponConfig AlternateAnimAndWeap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAlternateAnimationAndWeaponConfig>(Ptr + 2252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2252); }
    }

    /// <summary>
    /// ObjectProperty: CurrWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeapon CurrWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeapon>(Ptr + 2256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2256); }
    }

    /// <summary>
    /// ObjectProperty: CurrDroppedWeapon
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatThrownObject CurrDroppedWeapon
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatThrownObject>(Ptr + 2260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2260); }
    }

    /// <summary>
    /// StructProperty: HitReactionWeaponSwitchThrowImpulse
    /// </summary>
    public unsafe ref System.Numerics.Vector3 HitReactionWeaponSwitchThrowImpulse
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2264);

    /// <summary>
    /// ClassProperty: CharactersType
    /// </summary>
    public unsafe BmSDK.Class CharactersType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2276); }
    }

    /// <summary>
    /// FloatProperty: DeathTimer
    /// </summary>
    public unsafe float DeathTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2280); }
    }

    /// <summary>
    /// ArrayProperty: DeathMat
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> DeathMat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 2284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2284); }
    }

    /// <summary>
    /// FloatProperty: DeathFadePause
    /// </summary>
    public unsafe float DeathFadePause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2296); }
    }

    /// <summary>
    /// FloatProperty: DeathFadeDuration
    /// </summary>
    public unsafe float DeathFadeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2300); }
    }

    /// <summary>
    /// StructProperty: CachedCylinderExtent
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CachedCylinderExtent
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2304);

    /// <summary>
    /// ObjectProperty: StreamedWeaponRefHolder
    /// </summary>
    public unsafe BmSDK.BmGame.RCharacterBioCue StreamedWeaponRefHolder
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterBioCue>(Ptr + 2316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2316); }
    }

    /// <summary>
    /// StrProperty: WeaponPackageToLoadBeforeSpawn
    /// </summary>
    public unsafe BmSDK.FString WeaponPackageToLoadBeforeSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2320); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2320); }
    }

    /// <summary>
    /// FloatProperty: MaxBumpedTimer
    /// </summary>
    public unsafe float MaxBumpedTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2332); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2332); }
    }

    /// <summary>
    /// ArrayProperty: PropStatics
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterStaticProps> PropStatics
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterStaticProps>>(Ptr + 2336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2336); }
    }

    /// <summary>
    /// ArrayProperty: PropSkeletals
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterSkeletalProps> PropSkeletals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FCharacterSkeletalProps>>(Ptr + 2348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2348); }
    }

    /// <summary>
    /// StructProperty: PropLightingChannels
    /// </summary>
    public unsafe ref BmSDK.Engine.LightComponent.FLightingChannelContainer PropLightingChannels
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.LightComponent.FLightingChannelContainer>(Ptr + 2360);

    /// <summary>
    /// IntProperty: OverrideKOXP
    /// </summary>
    public unsafe int OverrideKOXP
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2364); }
    }

    /// <summary>
    /// ClassProperty: CombatBehaviourClass
    /// </summary>
    public unsafe BmSDK.Class CombatBehaviourClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 2368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2368); }
    }

    /// <summary>
    /// StructProperty: InvestigateOffset
    /// </summary>
    public unsafe ref System.Numerics.Vector3 InvestigateOffset
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2372);

    /// <summary>
    /// ObjectProperty: AttackedAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet AttackedAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 2384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2384); }
    }

    /// <summary>
    /// ArrayProperty: BatarangTargetBodyParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> BatarangTargetBodyParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2388); }
    }

    /// <summary>
    /// ArrayProperty: WhipTargetBodyParts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> WhipTargetBodyParts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2400); }
    }

    /// <summary>
    /// IntProperty: HeartBeatType
    /// </summary>
    public unsafe int HeartBeatType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2412); }
    }

    /// <summary>
    /// IntProperty: OverrideHeartBeatType
    /// </summary>
    public unsafe int OverrideHeartBeatType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2416); }
    }

    /// <summary>
    /// StrProperty: RealNameForInvestigate
    /// </summary>
    public unsafe BmSDK.FString RealNameForInvestigate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 2420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2420); }
    }

    /// <summary>
    /// NameProperty: SpineName
    /// </summary>
    public unsafe BmSDK.FName SpineName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2432); }
    }

    /// <summary>
    /// ObjectProperty: EntryAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet EntryAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 2440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2440); }
    }

    /// <summary>
    /// NameProperty: EntryAnim
    /// </summary>
    public unsafe BmSDK.FName EntryAnim
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 2444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2444); }
    }

    /// <summary>
    /// ObjectProperty: LastFloorPanel
    /// </summary>
    public unsafe BmSDK.BmGame.RElectrifiedFloorPanel LastFloorPanel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RElectrifiedFloorPanel>(Ptr + 2452); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2452); }
    }

    /// <summary>
    /// FloatProperty: LastFireTime
    /// </summary>
    public unsafe float LastFireTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2456); }
    }

    /// <summary>
    /// FloatProperty: FireTimer
    /// </summary>
    public unsafe float FireTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2460); }
    }

    /// <summary>
    /// ObjectProperty: CurrentGun
    /// </summary>
    public unsafe BmSDK.BmGame.RBMWeaponRanged CurrentGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMWeaponRanged>(Ptr + 2464); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2464); }
    }

    /// <summary>
    /// IntProperty: BurstCount
    /// </summary>
    public unsafe int BurstCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2468); }
    }

    /// <summary>
    /// IntProperty: ClipCount
    /// </summary>
    public unsafe int ClipCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2472); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2472); }
    }

    /// <summary>
    /// FloatProperty: GunMomentumTime
    /// </summary>
    public unsafe float GunMomentumTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2476); }
    }

    /// <summary>
    /// StructProperty: GunMomentumDir
    /// </summary>
    public unsafe ref System.Numerics.Vector3 GunMomentumDir
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2480);

    /// <summary>
    /// ArrayProperty: GunTargetBones
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.GunTargetBoneState> GunTargetBones
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.GunTargetBoneState>>(Ptr + 2492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2492); }
    }

    /// <summary>
    /// ObjectProperty: GlanceTarget
    /// </summary>
    public unsafe BmSDK.BmGame.AlertInstance GlanceTarget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.AlertInstance>(Ptr + 2504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2504); }
    }

    /// <summary>
    /// FloatProperty: BeenStartledTimer
    /// </summary>
    public unsafe float BeenStartledTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2508); }
    }

    /// <summary>
    /// ObjectProperty: StasisLinkPawn
    /// </summary>
    public unsafe BmSDK.BmGame.RBMPawnAI StasisLinkPawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMPawnAI>(Ptr + 2512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2512); }
    }

    /// <summary>
    /// FloatProperty: OverrideStasisDist
    /// </summary>
    public unsafe float OverrideStasisDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2516); }
    }

    /// <summary>
    /// ArrayProperty: Queue
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMAIAction> Queue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMAIAction>>(Ptr + 2520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2520); }
    }

    /// <summary>
    /// ObjectProperty: ClientAction
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIAction ClientAction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIAction>(Ptr + 2532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2532); }
    }

    /// <summary>
    /// ArrayProperty: MoveToTargetList
    /// </summary>
    public unsafe BmSDK.TArray<System.Numerics.Vector3> MoveToTargetList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.Numerics.Vector3>>(Ptr + 2536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2536); }
    }

    /// <summary>
    /// StructProperty: MoveToTarget
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MoveToTarget
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2548);

    /// <summary>
    /// IntProperty: CreationRand1
    /// </summary>
    public unsafe int CreationRand1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2560); }
    }

    /// <summary>
    /// IntProperty: CreationRand2
    /// </summary>
    public unsafe int CreationRand2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2564); }
    }

    /// <summary>
    /// IntProperty: CreationRand3
    /// </summary>
    public unsafe int CreationRand3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2568); }
    }

    /// <summary>
    /// IntProperty: CreationRand4
    /// </summary>
    public unsafe int CreationRand4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2572); }
    }

    /// <summary>
    /// IntProperty: CreationRand5
    /// </summary>
    public unsafe int CreationRand5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2576); }
    }

    /// <summary>
    /// StructProperty: LastValidNavMeshPoly
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMPawnAI.FValidNavMeshPoly LastValidNavMeshPoly
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMPawnAI.FValidNavMeshPoly>(Ptr + 2580);

    /// <summary>
    /// ObjectProperty: ArmouredThugMagnetisedAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet ArmouredThugMagnetisedAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 2600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2600); }
    }

    /// <summary>
    /// StructProperty: RouterBlockedPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2604);

    /// <summary>
    /// StructProperty: RouterBlockedNewPos
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedNewPos
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2616);

    /// <summary>
    /// StructProperty: RouterBlockedDestination
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedDestination
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2628);

    /// <summary>
    /// StructProperty: RouterBlockedSnappedDestination
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedSnappedDestination
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2640);

    /// <summary>
    /// StructProperty: RouterBlockedExtents
    /// </summary>
    public unsafe ref System.Numerics.Vector3 RouterBlockedExtents
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 2652);

    /// <summary>
    /// ArrayProperty: AlwaysOnPS
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FAlwaysOnParticles> AlwaysOnPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RBMPawnAI.FAlwaysOnParticles>>(Ptr + 2664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2664); }
    }

    /// <summary>
    /// FloatProperty: CurrDestZ
    /// </summary>
    public unsafe float CurrDestZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2676); }
    }

    /// <summary>
    /// FloatProperty: ZBlendSpeed
    /// </summary>
    public unsafe float ZBlendSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2680); }
    }

    /// <summary>
    /// ArrayProperty: CombatIdleStances
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> CombatIdleStances
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 2684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2684); }
    }

    /// <summary>
    /// IntProperty: CombatIdleStanceID
    /// </summary>
    public unsafe int CombatIdleStanceID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 2696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2696); }
    }
}
