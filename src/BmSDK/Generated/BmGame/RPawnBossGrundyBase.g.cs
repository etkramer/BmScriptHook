#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnBossGrundyBase<br/>
/// (size = 7124)
/// (flags = 211812535)
/// </summary>
public partial class RPawnBossGrundyBase : BmSDK.BmGame.RPawnVillain, BmSDK.BmGame.RInteractInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnBossGrundyBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnBossGrundyBase.
    /// </summary>
    public static RPawnBossGrundyBase DefaultObject => (RPawnBossGrundyBase)StaticClass().DefaultObject;

    internal RPawnBossGrundyBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnBossGrundyBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundyBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundyBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundyBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundyBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundyBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundyBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundyBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossGrundyBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: HitByFreezeCluster
    /// </summary>
    public unsafe virtual void HitByFreezeCluster(System.Numerics.Vector3 ClusterLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.HitByFreezeCluster", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClusterLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HitByFreezeBlast
    /// </summary>
    public unsafe virtual void HitByFreezeBlast()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.HitByFreezeBlast", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSmashDistToWall
    /// </summary>
    public unsafe virtual float GetSmashDistToWall()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetSmashDistToWall", true);
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
    /// Function: GetLandingNotifyTime
    /// </summary>
    public unsafe virtual bool GetLandingNotifyTime(BmSDK.Engine.AnimSequence inAnim, ref float landingTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetLandingNotifyTime", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(landingTime, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        landingTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetChainSmashNotifyTimes
    /// </summary>
    public unsafe virtual bool GetChainSmashNotifyTimes(BmSDK.BmGame.RAnimUtil.FNotifyAnim inAnim, ref float beginExtendTime, ref float endExtendTime, ref float beginRetractTime, ref float endRetractTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetChainSmashNotifyTimes", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(inAnim, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(beginExtendTime, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(endExtendTime, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(beginRetractTime, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(endRetractTime, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        beginExtendTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 20);
        endExtendTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 24);
        beginRetractTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 28);
        endRetractTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: GetWeightToHandDir
    /// </summary>
    public unsafe virtual void GetWeightToHandDir(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide, ref System.Numerics.Vector3 Dir)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetWeightToHandDir", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Dir, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Dir = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: WeightLookAtHand
    /// </summary>
    public unsafe virtual void WeightLookAtHand(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.WeightLookAtHand", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
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
    /// Function: GetGrundyWeightAttachPos
    /// </summary>
    public unsafe virtual void GetGrundyWeightAttachPos(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide, ref System.Numerics.Vector3 pos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetGrundyWeightAttachPos", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(pos, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        pos = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: DisableWeightPhysics
    /// </summary>
    public unsafe virtual void DisableWeightPhysics(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.DisableWeightPhysics", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
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
    /// Function: EnableWeightPhysics
    /// </summary>
    public unsafe virtual void EnableWeightPhysics(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.EnableWeightPhysics", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
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
    /// Function: GetIsWeightPhysicsEnabled
    /// </summary>
    public unsafe virtual bool GetIsWeightPhysicsEnabled(byte applicationSide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetIsWeightPhysicsEnabled", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: InitPhysics
    /// </summary>
    public unsafe virtual bool InitPhysics()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.InitPhysics", true);
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
    /// Function: SetDepthBiasValues
    /// </summary>
    public unsafe virtual void SetDepthBiasValues()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.SetDepthBiasValues", true);
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
    /// Function: UpdateWeightsBlockingActors
    /// </summary>
    public unsafe virtual void UpdateWeightsBlockingActors(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.UpdateWeightsBlockingActors", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetWeightsBlockActors
    /// </summary>
    public unsafe virtual void SetWeightsBlockActors(bool BlockActors)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.SetWeightsBlockActors", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BlockActors, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetWeightToPose
    /// </summary>
    public unsafe virtual void SetWeightToPose(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide, System.Numerics.Vector3 NewTranslation, BmSDK.Rotator NewRotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.SetWeightToPose", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTranslation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewRotation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DetachWeightFromParent
    /// </summary>
    public unsafe virtual void DetachWeightFromParent(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.DetachWeightFromParent", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AttachWeightToParent
    /// </summary>
    public unsafe virtual void AttachWeightToParent(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.AttachWeightToParent", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAreBothWeightsInAnim
    /// </summary>
    public unsafe virtual bool GetAreBothWeightsInAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetAreBothWeightsInAnim", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: WeightsSetupTetheredArms
    /// </summary>
    public unsafe virtual void WeightsSetupTetheredArms()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.WeightsSetupTetheredArms", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TeleportBallForPhysics
    /// </summary>
    public unsafe virtual void TeleportBallForPhysics(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.TeleportBallForPhysics", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
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
    /// Function: ChangeAutoLengthLimits
    /// </summary>
    public unsafe virtual void ChangeAutoLengthLimits(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide, float MinLength, float MaxLength)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.ChangeAutoLengthLimits", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MinLength, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxLength, paramsPtr + 8);
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
    /// Function: UpdatePhysToAnimTransition
    /// </summary>
    public unsafe virtual void UpdatePhysToAnimTransition(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.UpdatePhysToAnimTransition", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
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
    /// Function: UpdateWeightPhysics
    /// </summary>
    public unsafe virtual void UpdateWeightPhysics(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.UpdateWeightPhysics", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
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
    /// Function: ChangeWeightPhysics
    /// </summary>
    public unsafe virtual void ChangeWeightPhysics(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.ChangeWeightPhysics", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
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
    /// Function: UpdateWeightToTargetData
    /// </summary>
    public unsafe virtual bool UpdateWeightToTargetData(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.UpdateWeightToTargetData", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
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
    /// Function: UpdateWeight
    /// </summary>
    public unsafe virtual void UpdateWeight(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.UpdateWeight", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
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
    /// Function: MinDistToLineSeg2d
    /// </summary>
    public unsafe virtual float MinDistToLineSeg2d(System.Numerics.Vector3 LineStart, System.Numerics.Vector3 LineEnd, System.Numerics.Vector3 TestPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.MinDistToLineSeg2d", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineStart, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineEnd, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPoint, paramsPtr + 24);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: CalculateCurrWeightDistance
    /// </summary>
    public unsafe virtual float CalculateCurrWeightDistance(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.CalculateCurrWeightDistance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UpdateWeightTargetPose
    /// </summary>
    public unsafe virtual bool UpdateWeightTargetPose(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide, float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.UpdateWeightTargetPose", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 4);
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
    /// Function: ApplyWeightChange
    /// </summary>
    public unsafe virtual void ApplyWeightChange(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide, BmSDK.BmGame.RPawnBossGrundyBase.FGrundyWeightControlTargetData NewTargetData)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.ApplyWeightChange", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewTargetData, paramsPtr + 4);
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
    /// Function: MoveBM
    /// </summary>
    public unsafe virtual void MoveBM(System.Numerics.Vector3 Delta)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.MoveBM", true);
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
    /// Function: GetWeightCoM
    /// </summary>
    public unsafe virtual void GetWeightCoM(BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide applicationSide, ref System.Numerics.Vector3 CoM)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetWeightCoM", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(applicationSide, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CoM, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CoM = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: WeightsInstantPhysics
    /// </summary>
    public unsafe virtual void WeightsInstantPhysics()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.WeightsInstantPhysics", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeightsPhysicsHoldingDanglePlus
    /// </summary>
    public unsafe virtual void WeightsPhysicsHoldingDanglePlus()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.WeightsPhysicsHoldingDanglePlus", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeightsPhysicsHoldingDangle
    /// </summary>
    public unsafe virtual void WeightsPhysicsHoldingDangle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.WeightsPhysicsHoldingDangle", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeightsAnimatedVeryLongRopePlusPhysics
    /// </summary>
    public unsafe virtual void WeightsAnimatedVeryLongRopePlusPhysics()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.WeightsAnimatedVeryLongRopePlusPhysics", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeightsAnimatedLongRopePlusPhysics
    /// </summary>
    public unsafe virtual void WeightsAnimatedLongRopePlusPhysics()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.WeightsAnimatedLongRopePlusPhysics", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeightsAnimatedCustomLengthRope
    /// </summary>
    public unsafe virtual void WeightsAnimatedCustomLengthRope()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.WeightsAnimatedCustomLengthRope", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeightsAnimatedVeryLongRope
    /// </summary>
    public unsafe virtual void WeightsAnimatedVeryLongRope()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.WeightsAnimatedVeryLongRope", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeightsAnimatedLongRope
    /// </summary>
    public unsafe virtual void WeightsAnimatedLongRope()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.WeightsAnimatedLongRope", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeightsAnimatedShortRope
    /// </summary>
    public unsafe virtual void WeightsAnimatedShortRope()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.WeightsAnimatedShortRope", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WeightsAttachToGrundyHands
    /// </summary>
    public unsafe virtual void WeightsAttachToGrundyHands()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.WeightsAttachToGrundyHands", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableForceApplication
    /// </summary>
    public unsafe virtual void EnableForceApplication()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.EnableForceApplication", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisableForceApplication
    /// </summary>
    public unsafe virtual void DisableForceApplication()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.DisableForceApplication", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetUppercutAnimSet
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet GetUppercutAnimSet()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetUppercutAnimSet", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetUppercutAnimName
    /// </summary>
    public unsafe virtual BmSDK.FName GetUppercutAnimName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetUppercutAnimName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IntroCinematicFinished
    /// </summary>
    public unsafe virtual void IntroCinematicFinished()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.IntroCinematicFinished", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActionPerformed
    /// </summary>
    public unsafe virtual void ActionPerformed(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.ActionPerformed", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldUseFastSlide
    /// </summary>
    public unsafe virtual bool ShouldUseFastSlide()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.ShouldUseFastSlide", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanUseInCinematicMode
    /// </summary>
    public unsafe virtual bool CanUseInCinematicMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.CanUseInCinematicMode", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanReachItem
    /// </summary>
    public unsafe virtual bool CanReachItem(BmSDK.Engine.Pawn CheckingPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.CanReachItem", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckingPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: OverridesRun
    /// </summary>
    public unsafe virtual float OverridesRun(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.OverridesRun", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CheckBossCounter
    /// </summary>
    public unsafe override bool CheckBossCounter(BmSDK.BmGame.RPawnVillain targ)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.CheckBossCounter", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(targ, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: UsesAttackButton
    /// </summary>
    public unsafe virtual bool UsesAttackButton()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.UsesAttackButton", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: Interact
    /// </summary>
    public unsafe virtual void Interact(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.Interact", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MustBeCrouched
    /// </summary>
    public unsafe virtual bool MustBeCrouched()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.MustBeCrouched", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsCounterButton
    /// </summary>
    public unsafe virtual bool IsCounterButton()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.IsCounterButton", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsButtonPrompt
    /// </summary>
    public unsafe virtual bool IsButtonPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.IsButtonPrompt", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: EitherButtonAllowed
    /// </summary>
    public unsafe virtual bool EitherButtonAllowed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.EitherButtonAllowed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsActive
    /// </summary>
    public unsafe virtual bool IsActive(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.IsActive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetLocationOffset
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetLocationOffset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetLocationOffset", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPriority
    /// </summary>
    public unsafe virtual float GetPriority()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetPriority", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetFOVDegrees
    /// </summary>
    public unsafe virtual float GetFOVDegrees()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetFOVDegrees", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetUpperPrompt
    /// </summary>
    public unsafe virtual BmSDK.FString GetUpperPrompt()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetUpperPrompt", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHeightRange
    /// </summary>
    public unsafe virtual float GetHeightRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetHeightRange", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetRange
    /// </summary>
    public unsafe virtual float GetRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetRange", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPrompt
    /// </summary>
    public unsafe virtual BmSDK.FString GetPrompt(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.GetPrompt", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: dbgBlowPadsUp
    /// </summary>
    public unsafe virtual void dbgBlowPadsUp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.dbgBlowPadsUp", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnSingleMaggot
    /// </summary>
    public unsafe virtual void SpawnSingleMaggot(System.Numerics.Vector3 SpawnLoc, BmSDK.Rotator SpawnRot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.SpawnSingleMaggot", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLoc, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRot, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Killed
    /// </summary>
    public unsafe virtual void Killed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.Killed", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Ignite
    /// </summary>
    public unsafe virtual void Ignite()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.Ignite", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AllowCamera
    /// </summary>
    public unsafe virtual bool AllowCamera(BmSDK.BmGame.RSpecialMoveConfig SpecialMove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.AllowCamera", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpecialMove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: StopMeleeCamera
    /// </summary>
    public unsafe virtual void StopMeleeCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.StopMeleeCamera", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopAttackingFX
    /// </summary>
    public unsafe override void StopAttackingFX(bool bSuccessfullyCountered = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.StopAttackingFX", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSuccessfullyCountered, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartAttackingFX
    /// </summary>
    public unsafe override void StartAttackingFX(int CTypeInt, BmSDK.BmGame.RPlayerController PC = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.StartAttackingFX", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CTypeInt, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoRumble
    /// </summary>
    public unsafe virtual void DoRumble()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossGrundyBase.DoRumble", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Struct: FSmashFire
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FSmashFire
    {
        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: TimeLeft
        /// </summary>
        public unsafe float TimeLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: Duration
        /// </summary>
        public unsafe float Duration_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// FloatProperty: Duration
        /// </summary>
        public unsafe float Duration_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
        /// <summary>
        /// FloatProperty: Duration
        /// </summary>
        public unsafe float Duration_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FFloorSpark
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FFloorSpark
    {
        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: TimeLeft
        /// </summary>
        public unsafe float TimeLeft
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: Origin
        /// </summary>
        public unsafe System.Numerics.Vector3 Origin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: Direction
        /// </summary>
        public unsafe System.Numerics.Vector3 Direction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: Speed
        /// </summary>
        public unsafe float Speed_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
        /// <summary>
        /// FloatProperty: Speed
        /// </summary>
        public unsafe float Speed_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
        /// <summary>
        /// FloatProperty: Speed
        /// </summary>
        public unsafe float Speed_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
    }

    /// <summary>
    /// Struct: FGrundyWeightControlData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 76)]
    public partial record struct FGrundyWeightControlData
    {
        /// <summary>
        /// StructProperty: CurrentWeightTarget
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnBossGrundyBase.FGrundyWeightControlTargetData CurrentWeightTarget
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.FGrundyWeightControlTargetData>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentPhysicsFreedomRadius
        /// </summary>
        public unsafe float CurrentPhysicsFreedomRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentDriveSpringStrength
        /// </summary>
        public unsafe float CurrentDriveSpringStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bCurrentAttachedToParent
        /// </summary>
        public unsafe bool bCurrentAttachedToParent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: CurrentWeightTargetPosition
        /// </summary>
        public unsafe System.Numerics.Vector3 CurrentWeightTargetPosition
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// StructProperty: CurrentWeightTargetRotation
        /// </summary>
        public unsafe BmSDK.Rotator CurrentWeightTargetRotation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Rotator>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentTautRopeLength
        /// </summary>
        public unsafe float CurrentTautRopeLength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentMaxRopeLength
        /// </summary>
        public unsafe float CurrentMaxRopeLength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentAngularFreedomProportion
        /// </summary>
        public unsafe float CurrentAngularFreedomProportion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
    }

    /// <summary>
    /// Struct: FGrundyWeightControlTargetData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FGrundyWeightControlTargetData
    {
        /// <summary>
        /// FloatProperty: ChangeDuration
        /// </summary>
        public unsafe float ChangeDuration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: NewPhysicsFreedomRadius
        /// </summary>
        public unsafe float NewPhysicsFreedomRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: NewPhysicsDriveSpringStrength
        /// </summary>
        public unsafe float NewPhysicsDriveSpringStrength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ByteProperty: NewIsAttachedToParent
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnBossGrundyBase.EGrundyToggleType NewIsAttachedToParent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.EGrundyToggleType>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: NewTautRopeLength
        /// </summary>
        public unsafe float NewTautRopeLength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: NewMaxRopeLength
        /// </summary>
        public unsafe float NewMaxRopeLength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: NewAngularFreedomProportion
        /// </summary>
        public unsafe float NewAngularFreedomProportion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FMeleeAttackParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FMeleeAttackParameters
    {
        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// IntProperty: Damage
        /// </summary>
        public unsafe int Damage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: CounterDamageToGrundy
        /// </summary>
        public unsafe float CounterDamageToGrundy_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// FloatProperty: CounterDamageToGrundy
        /// </summary>
        public unsafe float CounterDamageToGrundy_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// FloatProperty: CounterDamageToGrundy
        /// </summary>
        public unsafe float CounterDamageToGrundy_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: InRangeValue
        /// </summary>
        public unsafe float InRangeValue
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: SmashWidthAttack
        /// </summary>
        public unsafe float SmashWidthAttack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: GrabRadius
        /// </summary>
        public unsafe float GrabRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FHealthReductionParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FHealthReductionParameters
    {
        /// <summary>
        /// FloatProperty: MeleeCounterDamage
        /// </summary>
        public unsafe float MeleeCounterDamage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// FloatProperty: MeleeCounterDamage
        /// </summary>
        public unsafe float MeleeCounterDamage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// FloatProperty: MeleeCounterDamage
        /// </summary>
        public unsafe float MeleeCounterDamage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: MeleeCounterFinalBlowDamage
        /// </summary>
        public unsafe float MeleeCounterFinalBlowDamage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// FloatProperty: MeleeCounterFinalBlowDamage
        /// </summary>
        public unsafe float MeleeCounterFinalBlowDamage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// FloatProperty: MeleeCounterFinalBlowDamage
        /// </summary>
        public unsafe float MeleeCounterFinalBlowDamage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: GelFaceDamage
        /// </summary>
        public unsafe float GelFaceDamage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// FloatProperty: GelFaceDamage
        /// </summary>
        public unsafe float GelFaceDamage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
        /// <summary>
        /// FloatProperty: GelFaceDamage
        /// </summary>
        public unsafe float GelFaceDamage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: RECDamage
        /// </summary>
        public unsafe float RECDamage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
        /// <summary>
        /// FloatProperty: RECDamage
        /// </summary>
        public unsafe float RECDamage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
        /// <summary>
        /// FloatProperty: RECDamage
        /// </summary>
        public unsafe float RECDamage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Struct: FDecayingDeathAttackParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 100)]
    public partial record struct FDecayingDeathAttackParameters
    {
        /// <summary>
        /// StructProperty: NumMaggots
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnBossGrundyBase.FMaggotNumbers NumMaggots_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.FMaggotNumbers>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// StructProperty: NumMaggots
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnBossGrundyBase.FMaggotNumbers NumMaggots_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.FMaggotNumbers>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
        /// <summary>
        /// StructProperty: NumMaggots
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnBossGrundyBase.FMaggotNumbers NumMaggots_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.FMaggotNumbers>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: MaxMaggots
        /// </summary>
        public unsafe int MaxMaggots_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
        /// <summary>
        /// IntProperty: MaxMaggots
        /// </summary>
        public unsafe int MaxMaggots_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
        /// <summary>
        /// IntProperty: MaxMaggots
        /// </summary>
        public unsafe int MaxMaggots_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }

        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// ObjectProperty: HitByMaggotRumble
        /// </summary>
        public unsafe BmSDK.Engine.ForceFeedbackWaveform HitByMaggotRumble
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// ArrayProperty: SpawnSockets
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FName> SpawnSockets
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }
    }

    /// <summary>
    /// Struct: FMaggotNumbers
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FMaggotNumbers
    {
        /// <summary>
        /// IntProperty: MaggotsByPad
        /// </summary>
        public unsafe int MaggotsByPad_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// IntProperty: MaggotsByPad
        /// </summary>
        public unsafe int MaggotsByPad_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// IntProperty: MaggotsByPad
        /// </summary>
        public unsafe int MaggotsByPad_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
        /// <summary>
        /// IntProperty: MaggotsByPad
        /// </summary>
        public unsafe int MaggotsByPad_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// IntProperty: MaggotsByPad
        /// </summary>
        public unsafe int MaggotsByPad_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FStompAttackParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FStompAttackParameters
    {
        /// <summary>
        /// FloatProperty: ProximityForAttackRange
        /// </summary>
        public unsafe float ProximityForAttackRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: AttackRange
        /// </summary>
        public unsafe float AttackRange
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ObjectProperty: HitParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem HitParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FElectrifiedSmashAttackParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 100)]
    public partial record struct FElectrifiedSmashAttackParameters
    {
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: ProximityDamage
        /// </summary>
        public unsafe float ProximityDamage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// FloatProperty: ProximityDamage
        /// </summary>
        public unsafe float ProximityDamage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// FloatProperty: ProximityDamage
        /// </summary>
        public unsafe float ProximityDamage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: HoldPoseTime
        /// </summary>
        public unsafe float HoldPoseTime_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// FloatProperty: HoldPoseTime
        /// </summary>
        public unsafe float HoldPoseTime_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
        /// <summary>
        /// FloatProperty: HoldPoseTime
        /// </summary>
        public unsafe float HoldPoseTime_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: TimeToExtendChain
        /// </summary>
        public unsafe float TimeToExtendChain
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: TimeToRetractChain
        /// </summary>
        public unsafe float TimeToRetractChain
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// ObjectProperty: HitParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem HitParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: KnockedDownTime
        /// </summary>
        public unsafe float KnockedDownTime_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }
        /// <summary>
        /// FloatProperty: KnockedDownTime
        /// </summary>
        public unsafe float KnockedDownTime_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
        /// <summary>
        /// FloatProperty: KnockedDownTime
        /// </summary>
        public unsafe float KnockedDownTime_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }

        /// <summary>
        /// FloatProperty: FailedCrucifixTimeToRetractChain
        /// </summary>
        public unsafe float FailedCrucifixTimeToRetractChain
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: TimeOutCrucifixTimeToRetractChain
        /// </summary>
        public unsafe float TimeOutCrucifixTimeToRetractChain
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }

        /// <summary>
        /// FloatProperty: TimeInCrucifix
        /// </summary>
        public unsafe float TimeInCrucifix_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 68); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 68); }; }
        }
        /// <summary>
        /// FloatProperty: TimeInCrucifix
        /// </summary>
        public unsafe float TimeInCrucifix_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 72); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }; }
        }
        /// <summary>
        /// FloatProperty: TimeInCrucifix
        /// </summary>
        public unsafe float TimeInCrucifix_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// IntProperty: numFloorSparks
        /// </summary>
        public unsafe int numFloorSparks
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 80); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 80); }; }
        }

        /// <summary>
        /// FloatProperty: sparkEffectBaseSize
        /// </summary>
        public unsafe float sparkEffectBaseSize
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }

        /// <summary>
        /// FloatProperty: sparkMinRadius
        /// </summary>
        public unsafe float sparkMinRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// FloatProperty: sparkAngle_degrees
        /// </summary>
        public unsafe float sparkAngle_degrees
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 92); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 92); }; }
        }

        /// <summary>
        /// FloatProperty: interSparkAngle_degrees
        /// </summary>
        public unsafe float interSparkAngle_degrees
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 96); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 96); }; }
        }
    }

    /// <summary>
    /// Struct: FSmashAttackParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial record struct FSmashAttackParameters
    {
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: HoldPoseTime
        /// </summary>
        public unsafe float HoldPoseTime_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// FloatProperty: HoldPoseTime
        /// </summary>
        public unsafe float HoldPoseTime_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// FloatProperty: HoldPoseTime
        /// </summary>
        public unsafe float HoldPoseTime_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: SmashDamageRadius
        /// </summary>
        public unsafe float SmashDamageRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: TimeToExtendChain
        /// </summary>
        public unsafe float TimeToExtendChain
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: TimeToRetractChain
        /// </summary>
        public unsafe float TimeToRetractChain
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// ObjectProperty: HitParticleEffect
        /// </summary>
        public unsafe BmSDK.Engine.ParticleSystem HitParticleEffect
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }
    }

    /// <summary>
    /// Struct: FSwingAttackParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 156)]
    public partial record struct FSwingAttackParameters
    {
        /// <summary>
        /// FloatProperty: Speed
        /// </summary>
        public unsafe float Speed_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// FloatProperty: Speed
        /// </summary>
        public unsafe float Speed_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// FloatProperty: Speed
        /// </summary>
        public unsafe float Speed_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: SpeedIncPerSwing
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnBossGrundyBase.FSwingSpeed SpeedIncPerSwing_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.FSwingSpeed>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// StructProperty: SpeedIncPerSwing
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnBossGrundyBase.FSwingSpeed SpeedIncPerSwing_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.FSwingSpeed>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
        /// <summary>
        /// StructProperty: SpeedIncPerSwing
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnBossGrundyBase.FSwingSpeed SpeedIncPerSwing_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.FSwingSpeed>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: PercChanceOfHighAttack
        /// </summary>
        public unsafe float PercChanceOfHighAttack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 56); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 56); }; }
        }
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// StructProperty: NumSwings
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnBossGrundyBase.FSwingNumbers NumSwings_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.FSwingNumbers>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
        /// <summary>
        /// StructProperty: NumSwings
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnBossGrundyBase.FSwingNumbers NumSwings_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.FSwingNumbers>(Ptr + 84); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 84); }; }
        }
        /// <summary>
        /// StructProperty: NumSwings
        /// </summary>
        public unsafe BmSDK.BmGame.RPawnBossGrundyBase.FSwingNumbers NumSwings_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.FSwingNumbers>(Ptr + 104); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 104); }; }
        }

        /// <summary>
        /// FloatProperty: ChainGrowthPerSecond
        /// </summary>
        public unsafe float ChainGrowthPerSecond
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 124); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 124); }; }
        }

        /// <summary>
        /// FloatProperty: SwingSpeedupPerSecond
        /// </summary>
        public unsafe float SwingSpeedupPerSecond
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 128); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 128); }; }
        }

        /// <summary>
        /// FloatProperty: SwingHeightChangeSpeed
        /// </summary>
        public unsafe float SwingHeightChangeSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }

        /// <summary>
        /// FloatProperty: TimeToSlowDown
        /// </summary>
        public unsafe float TimeToSlowDown
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 136); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 136); }; }
        }

        /// <summary>
        /// FloatProperty: EndChainLength
        /// </summary>
        public unsafe float EndChainLength
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 140); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 140); }; }
        }

        /// <summary>
        /// FloatProperty: StartSpeed
        /// </summary>
        public unsafe float StartSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 144); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 144); }; }
        }

        /// <summary>
        /// FloatProperty: EndSpeed
        /// </summary>
        public unsafe float EndSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 148); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }; }
        }

        /// <summary>
        /// FloatProperty: SwingDamageRadius
        /// </summary>
        public unsafe float SwingDamageRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 152); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 152); }; }
        }
    }

    /// <summary>
    /// Struct: FDoubleSwingParameters
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FDoubleSwingParameters
    {
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// FloatProperty: Damage
        /// </summary>
        public unsafe float Damage_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: ChainGrowthPerSecond
        /// </summary>
        public unsafe float ChainGrowthPerSecond
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FSwingSpeed
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FSwingSpeed
    {
        /// <summary>
        /// ArrayProperty: SwingSpeed
        /// </summary>
        public unsafe BmSDK.TArray<float> _SwingSpeed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FSwingNumbers
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FSwingNumbers
    {
        /// <summary>
        /// IntProperty: SwingsByPad
        /// </summary>
        public unsafe int SwingsByPad_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
        /// <summary>
        /// IntProperty: SwingsByPad
        /// </summary>
        public unsafe int SwingsByPad_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// IntProperty: SwingsByPad
        /// </summary>
        public unsafe int SwingsByPad_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
        /// <summary>
        /// IntProperty: SwingsByPad
        /// </summary>
        public unsafe int SwingsByPad_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// IntProperty: SwingsByPad
        /// </summary>
        public unsafe int SwingsByPad_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// ByteProperty: dbgForcedAttack
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossGrundyBase.EGrundyForcedAttack dbgForcedAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.EGrundyForcedAttack>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }

    /// <summary>
    /// ByteProperty: LastAttack
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossGrundyBase.EGrundyAttacks LastAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.EGrundyAttacks>(Ptr + 3561); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3561); }
    }

    /// <summary>
    /// ByteProperty: GrundyStage
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossGrundyBase.SolomonGrundyState GrundyStage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.SolomonGrundyState>(Ptr + 3562); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3562); }
    }

    /// <summary>
    /// ByteProperty: SmashWeightToUse
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide SmashWeightToUse
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide>(Ptr + 3563); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3563); }
    }

    /// <summary>
    /// ByteProperty: CurrentTetheredArmSide
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide CurrentTetheredArmSide
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnBossGrundyBase.EGrundyWeightSide>(Ptr + 3564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3564); }
    }

    /// <summary>
    /// BoolProperty: bDepthBiasTweakMode
    /// </summary>
    public unsafe bool bDepthBiasTweakMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bScreenBasedDepthBias
    /// </summary>
    public unsafe bool bScreenBasedDepthBias
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bNoForces
    /// </summary>
    public unsafe bool bNoForces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bBatmanNeedsMagblastHint
    /// </summary>
    public unsafe bool bBatmanNeedsMagblastHint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bBatmanNeedsBatclawHint
    /// </summary>
    public unsafe bool bBatmanNeedsBatclawHint
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bCounterPromptOn
    /// </summary>
    public unsafe bool bCounterPromptOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bDead
    /// </summary>
    public unsafe bool bDead
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bHeartRemovalReady
    /// </summary>
    public unsafe bool bHeartRemovalReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bHasJustTurned
    /// </summary>
    public unsafe bool bHasJustTurned
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bDrawWeightDebugLines
    /// </summary>
    public unsafe bool bDrawWeightDebugLines
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bWeightsLookAtAttachPoints
    /// </summary>
    public unsafe bool bWeightsLookAtAttachPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bSuspendKeepInView
    /// </summary>
    public unsafe bool bSuspendKeepInView
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bWantsToMove
    /// </summary>
    public unsafe bool bWantsToMove
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bHasMovedThisIdle
    /// </summary>
    public unsafe bool bHasMovedThisIdle
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bInHighSwing
    /// </summary>
    public unsafe bool bInHighSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bSwinging
    /// </summary>
    public unsafe bool bSwinging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bClockWiseTurn
    /// </summary>
    public unsafe bool bClockWiseTurn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bSlowingDown
    /// </summary>
    public unsafe bool bSlowingDown
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bStartedTransOut
    /// </summary>
    public unsafe bool bStartedTransOut
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bHasChangedHeightThisSwing
    /// </summary>
    public unsafe bool bHasChangedHeightThisSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bHasHitBatmanThisSwing
    /// </summary>
    public unsafe bool bHasHitBatmanThisSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bHitThisSwing
    /// </summary>
    public unsafe bool bHitThisSwing
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bReadyToStop
    /// </summary>
    public unsafe bool bReadyToStop
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bInSmash
    /// </summary>
    public unsafe bool bInSmash
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bInSmashWait
    /// </summary>
    public unsafe bool bInSmashWait
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bInSmashExit
    /// </summary>
    public unsafe bool bInSmashExit
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bSmashChainExtended
    /// </summary>
    public unsafe bool bSmashChainExtended
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bLastAttackWasMaggots
    /// </summary>
    public unsafe bool bLastAttackWasMaggots
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bFailedTwoArm
    /// </summary>
    public unsafe bool bFailedTwoArm
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bOnFire
    /// </summary>
    public unsafe bool bOnFire
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bWalkingToBats
    /// </summary>
    public unsafe bool bWalkingToBats
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bHitThisAttack
    /// </summary>
    public unsafe bool bHitThisAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3568); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3568); }
    }

    /// <summary>
    /// BoolProperty: bAllowCounter
    /// </summary>
    public unsafe bool bAllowCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3572); }
    }

    /// <summary>
    /// BoolProperty: bSuccessfulCounter
    /// </summary>
    public unsafe bool bSuccessfulCounter
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3572); }
    }

    /// <summary>
    /// BoolProperty: bCanBePunched
    /// </summary>
    public unsafe bool bCanBePunched
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3572); }
    }

    /// <summary>
    /// BoolProperty: bIntroCinematicFinished
    /// </summary>
    public unsafe bool bIntroCinematicFinished
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3572); }
    }

    /// <summary>
    /// BoolProperty: bTempStopWeightsBlocking
    /// </summary>
    public unsafe bool bTempStopWeightsBlocking
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3572); }
    }

    /// <summary>
    /// BoolProperty: bApplyForceToCentreOfBall
    /// </summary>
    public unsafe bool bApplyForceToCentreOfBall
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3572); }
    }

    /// <summary>
    /// BoolProperty: bZeroPhysFreedomRadius
    /// </summary>
    public unsafe bool bZeroPhysFreedomRadius
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3572); }
    }

    /// <summary>
    /// BoolProperty: bDoVelocityLimiting
    /// </summary>
    public unsafe bool bDoVelocityLimiting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3572); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3572); }
    }

    /// <summary>
    /// FloatProperty: emissiveDepthBias
    /// </summary>
    public unsafe float emissiveDepthBias
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 3580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3580); }
    }

    /// <summary>
    /// ObjectProperty: SmashEvadeRollMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SmashEvadeRollMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }

    /// <summary>
    /// ObjectProperty: SwingHitHighBackMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SwingHitHighBackMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3588); }
    }

    /// <summary>
    /// ObjectProperty: SwingHitHighFrontMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SwingHitHighFrontMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// ObjectProperty: SwingHitLowBackMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SwingHitLowBackMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3596); }
    }

    /// <summary>
    /// ObjectProperty: SwingHitLowFrontMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig SwingHitLowFrontMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }

    /// <summary>
    /// ObjectProperty: StompEvadeRollMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig StompEvadeRollMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3604); }
    }

    /// <summary>
    /// ObjectProperty: FinishGrundyMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FinishGrundyMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// ObjectProperty: MeleeEvadeRollMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig MeleeEvadeRollMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3612); }
    }

    /// <summary>
    /// ObjectProperty: DoubleSwingEvadeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DoubleSwingEvadeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// ObjectProperty: DoubleSwingHitMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DoubleSwingHitMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3620); }
    }

    /// <summary>
    /// ObjectProperty: MeleeLeapEvadeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig MeleeLeapEvadeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3624); }
    }

    /// <summary>
    /// ObjectProperty: MeleeLeapHitMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig MeleeLeapHitMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3628); }
    }

    /// <summary>
    /// ObjectProperty: FakeDeathMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FakeDeathMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// ObjectProperty: FastSlideMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig FastSlideMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3636); }
    }

    /// <summary>
    /// ObjectProperty: ElectrocuteMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ElectrocuteMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// ObjectProperty: ElectrocutedProximityMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ElectrocutedProximityMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3644); }
    }

    /// <summary>
    /// ObjectProperty: OpenGrundysHandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig OpenGrundysHandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 3648); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3648); }
    }

    /// <summary>
    /// ObjectProperty: BatmanExtraAnims
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BatmanExtraAnims
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3652); }
    }

    /// <summary>
    /// FloatProperty: BatmanDamageImmunity
    /// </summary>
    public unsafe float BatmanDamageImmunity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3656); }
    }

    /// <summary>
    /// FloatProperty: BatmanFireDamageImmunity
    /// </summary>
    public unsafe float BatmanFireDamageImmunity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3660); }
    }

    /// <summary>
    /// ComponentProperty: BMElectricEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BMElectricEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3664); }
    }

    /// <summary>
    /// IntProperty: DifficultyLevel
    /// </summary>
    public unsafe int DifficultyLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3668); }
    }

    /// <summary>
    /// FloatProperty: IdleStateTime
    /// </summary>
    public unsafe float IdleStateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3672); }
    }

    /// <summary>
    /// ObjectProperty: Skin
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant Skin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3676); }
    }

    /// <summary>
    /// ComponentProperty: Heart
    /// </summary>
    public unsafe BmSDK.Engine.StaticMeshComponent Heart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.StaticMeshComponent>(Ptr + 3680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3680); }
    }

    /// <summary>
    /// FloatProperty: GrundyHealth
    /// </summary>
    public unsafe float GrundyHealth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3684); }
    }

    /// <summary>
    /// FloatProperty: GrundyHealthForHud
    /// </summary>
    public unsafe float GrundyHealthForHud
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }

    /// <summary>
    /// ComponentProperty: AttackingPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent AttackingPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3692); }
    }

    /// <summary>
    /// ObjectProperty: HudMovie
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie HudMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// ObjectProperty: GrundyAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet GrundyAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3700); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: DoubleSwingData
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnBossGrundyBase.FDoubleSwingParameters> DoubleSwingData => new(3, Ptr + 3704, 16, this);

    /// <summary>
    /// StructProperty: DoubleSwingData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FDoubleSwingParameters DoubleSwingData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FDoubleSwingParameters>(Ptr + 3704);
    /// <summary>
    /// StructProperty: DoubleSwingData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FDoubleSwingParameters DoubleSwingData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FDoubleSwingParameters>(Ptr + 3720);
    /// <summary>
    /// StructProperty: DoubleSwingData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FDoubleSwingParameters DoubleSwingData_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FDoubleSwingParameters>(Ptr + 3736);

    /// <summary>
    /// InlineArray{StructProperty}: SwingAttackData
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnBossGrundyBase.FSwingAttackParameters> SwingAttackData => new(3, Ptr + 3752, 156, this);

    /// <summary>
    /// StructProperty: SwingAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FSwingAttackParameters SwingAttackData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FSwingAttackParameters>(Ptr + 3752);
    /// <summary>
    /// StructProperty: SwingAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FSwingAttackParameters SwingAttackData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FSwingAttackParameters>(Ptr + 3908);
    /// <summary>
    /// StructProperty: SwingAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FSwingAttackParameters SwingAttackData_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FSwingAttackParameters>(Ptr + 4064);

    /// <summary>
    /// InlineArray{StructProperty}: SmashAttackData
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnBossGrundyBase.FSmashAttackParameters> SmashAttackData => new(3, Ptr + 4220, 40, this);

    /// <summary>
    /// StructProperty: SmashAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FSmashAttackParameters SmashAttackData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FSmashAttackParameters>(Ptr + 4220);
    /// <summary>
    /// StructProperty: SmashAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FSmashAttackParameters SmashAttackData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FSmashAttackParameters>(Ptr + 4260);
    /// <summary>
    /// StructProperty: SmashAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FSmashAttackParameters SmashAttackData_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FSmashAttackParameters>(Ptr + 4300);

    /// <summary>
    /// StructProperty: ElectrifiedSmashAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FElectrifiedSmashAttackParameters ElectrifiedSmashAttackData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FElectrifiedSmashAttackParameters>(Ptr + 4340);

    /// <summary>
    /// InlineArray{StructProperty}: StompAttackData
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnBossGrundyBase.FStompAttackParameters> StompAttackData => new(3, Ptr + 4440, 24, this);

    /// <summary>
    /// StructProperty: StompAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FStompAttackParameters StompAttackData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FStompAttackParameters>(Ptr + 4440);
    /// <summary>
    /// StructProperty: StompAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FStompAttackParameters StompAttackData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FStompAttackParameters>(Ptr + 4464);
    /// <summary>
    /// StructProperty: StompAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FStompAttackParameters StompAttackData_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FStompAttackParameters>(Ptr + 4488);

    /// <summary>
    /// InlineArray{StructProperty}: DecayingDeathData
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnBossGrundyBase.FDecayingDeathAttackParameters> DecayingDeathData => new(3, Ptr + 4512, 100, this);

    /// <summary>
    /// StructProperty: DecayingDeathData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FDecayingDeathAttackParameters DecayingDeathData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FDecayingDeathAttackParameters>(Ptr + 4512);
    /// <summary>
    /// StructProperty: DecayingDeathData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FDecayingDeathAttackParameters DecayingDeathData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FDecayingDeathAttackParameters>(Ptr + 4612);
    /// <summary>
    /// StructProperty: DecayingDeathData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FDecayingDeathAttackParameters DecayingDeathData_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FDecayingDeathAttackParameters>(Ptr + 4712);

    /// <summary>
    /// InlineArray{StructProperty}: MeleeAttackData
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnBossGrundyBase.FMeleeAttackParameters> MeleeAttackData => new(3, Ptr + 4812, 36, this);

    /// <summary>
    /// StructProperty: MeleeAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FMeleeAttackParameters MeleeAttackData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FMeleeAttackParameters>(Ptr + 4812);
    /// <summary>
    /// StructProperty: MeleeAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FMeleeAttackParameters MeleeAttackData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FMeleeAttackParameters>(Ptr + 4848);
    /// <summary>
    /// StructProperty: MeleeAttackData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FMeleeAttackParameters MeleeAttackData_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FMeleeAttackParameters>(Ptr + 4884);

    /// <summary>
    /// StructProperty: NoArmMaggotsData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FDecayingDeathAttackParameters NoArmMaggotsData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FDecayingDeathAttackParameters>(Ptr + 4920);

    /// <summary>
    /// InlineArray{StructProperty}: HealthReductionData
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnBossGrundyBase.FHealthReductionParameters> HealthReductionData => new(3, Ptr + 5020, 48, this);

    /// <summary>
    /// StructProperty: HealthReductionData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FHealthReductionParameters HealthReductionData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FHealthReductionParameters>(Ptr + 5020);
    /// <summary>
    /// StructProperty: HealthReductionData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FHealthReductionParameters HealthReductionData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FHealthReductionParameters>(Ptr + 5068);
    /// <summary>
    /// StructProperty: HealthReductionData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FHealthReductionParameters HealthReductionData_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FHealthReductionParameters>(Ptr + 5116);

    /// <summary>
    /// StructProperty: LowSwingShaker
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct LowSwingShaker
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 5164);

    /// <summary>
    /// ObjectProperty: LowSwingRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform LowSwingRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 5308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5308); }
    }

    /// <summary>
    /// ObjectProperty: HitBySwingRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform HitBySwingRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 5312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5312); }
    }

    /// <summary>
    /// StructProperty: SmashShaker
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct SmashShaker
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 5316);

    /// <summary>
    /// ObjectProperty: HitBySmashRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform HitBySmashRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 5460); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5460); }
    }

    /// <summary>
    /// StructProperty: StompShaker
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct StompShaker
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 5464);

    /// <summary>
    /// ObjectProperty: HitByStompRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform HitByStompRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 5608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5608); }
    }

    /// <summary>
    /// ObjectProperty: HitByMaggotRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform HitByMaggotRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 5612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5612); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: TimeBetweenMajorAttacks
    /// </summary>
    public InlineArray<float> TimeBetweenMajorAttacks => new(3, Ptr + 5616, 4, this);

    /// <summary>
    /// FloatProperty: TimeBetweenMajorAttacks
    /// </summary>
    public unsafe float TimeBetweenMajorAttacks_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5616); }
    }
    /// <summary>
    /// FloatProperty: TimeBetweenMajorAttacks
    /// </summary>
    public unsafe float TimeBetweenMajorAttacks_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5620); }
    }
    /// <summary>
    /// FloatProperty: TimeBetweenMajorAttacks
    /// </summary>
    public unsafe float TimeBetweenMajorAttacks_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5624); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: TimeBetweenMajorAttacksElectrified
    /// </summary>
    public InlineArray<float> TimeBetweenMajorAttacksElectrified => new(3, Ptr + 5628, 4, this);

    /// <summary>
    /// FloatProperty: TimeBetweenMajorAttacksElectrified
    /// </summary>
    public unsafe float TimeBetweenMajorAttacksElectrified_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5628); }
    }
    /// <summary>
    /// FloatProperty: TimeBetweenMajorAttacksElectrified
    /// </summary>
    public unsafe float TimeBetweenMajorAttacksElectrified_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5632); }
    }
    /// <summary>
    /// FloatProperty: TimeBetweenMajorAttacksElectrified
    /// </summary>
    public unsafe float TimeBetweenMajorAttacksElectrified_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 5636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5636); }
    }

    /// <summary>
    /// ArrayProperty: HealthToAttackIntensity
    /// </summary>
    public unsafe BmSDK.TArray<int> HealthToAttackIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 5640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5640); }
    }

    /// <summary>
    /// ComponentProperty: ShoulderLeftFirePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ShoulderLeftFirePFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5652); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5652); }
    }

    /// <summary>
    /// ComponentProperty: ShoulderRightFirePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ShoulderRightFirePFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5656); }
    }

    /// <summary>
    /// ComponentProperty: ChestFirePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ChestFirePFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5660); }
    }

    /// <summary>
    /// ComponentProperty: ShoulderInnerLeftFirePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ShoulderInnerLeftFirePFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5664); }
    }

    /// <summary>
    /// ComponentProperty: ShoulderInnerRightFirePFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent ShoulderInnerRightFirePFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5668); }
    }

    /// <summary>
    /// ComponentProperty: WhirlwindTorsoPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WhirlwindTorsoPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5672); }
    }

    /// <summary>
    /// ComponentProperty: WhirlwindFeetPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WhirlwindFeetPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5676); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5676); }
    }

    /// <summary>
    /// ComponentProperty: WeightTrailPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent WeightTrailPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5680); }
    }

    /// <summary>
    /// ComponentProperty: GeneratorTouchBlastPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent GeneratorTouchBlastPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5684); }
    }

    /// <summary>
    /// ComponentProperty: GeneratorSecondTouchBlastPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent GeneratorSecondTouchBlastPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5688); }
    }

    /// <summary>
    /// ComponentProperty: GrundyGeneratorElectrifiedEffectPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent GrundyGeneratorElectrifiedEffectPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5692); }
    }

    /// <summary>
    /// ComponentProperty: GeneratorOverloadEffectPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent GeneratorOverloadEffectPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5696); }
    }

    /// <summary>
    /// ComponentProperty: BatmanElectrifiedEffectPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent BatmanElectrifiedEffectPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5700); }
    }

    /// <summary>
    /// ComponentProperty: HeartSquashPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HeartSquashPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5704); }
    }

    /// <summary>
    /// ComponentProperty: HeartGlowPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent HeartGlowPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5708); }
    }

    /// <summary>
    /// ComponentProperty: SmashTrailPFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent SmashTrailPFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 5712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 5712); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: FloorSparkData
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark> FloorSparkData => new(12, Ptr + 5716, 52, this);

    /// <summary>
    /// StructProperty: FloorSparkData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark FloorSparkData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark>(Ptr + 5716);
    /// <summary>
    /// StructProperty: FloorSparkData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark FloorSparkData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark>(Ptr + 5768);
    /// <summary>
    /// StructProperty: FloorSparkData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark FloorSparkData_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark>(Ptr + 5820);
    /// <summary>
    /// StructProperty: FloorSparkData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark FloorSparkData_3
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark>(Ptr + 5872);
    /// <summary>
    /// StructProperty: FloorSparkData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark FloorSparkData_4
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark>(Ptr + 5924);
    /// <summary>
    /// StructProperty: FloorSparkData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark FloorSparkData_5
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark>(Ptr + 5976);
    /// <summary>
    /// StructProperty: FloorSparkData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark FloorSparkData_6
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark>(Ptr + 6028);
    /// <summary>
    /// StructProperty: FloorSparkData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark FloorSparkData_7
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark>(Ptr + 6080);
    /// <summary>
    /// StructProperty: FloorSparkData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark FloorSparkData_8
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark>(Ptr + 6132);
    /// <summary>
    /// StructProperty: FloorSparkData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark FloorSparkData_9
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark>(Ptr + 6184);
    /// <summary>
    /// StructProperty: FloorSparkData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark FloorSparkData_10
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark>(Ptr + 6236);
    /// <summary>
    /// StructProperty: FloorSparkData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark FloorSparkData_11
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FFloorSpark>(Ptr + 6288);

    /// <summary>
    /// InlineArray{ComponentProperty}: FloorSparks
    /// </summary>
    public InlineArray<BmSDK.Engine.ParticleSystemComponent> FloorSparks => new(12, Ptr + 6340, 4, this);

    /// <summary>
    /// ComponentProperty: FloorSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorSparks_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6340); }
    }
    /// <summary>
    /// ComponentProperty: FloorSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorSparks_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6344); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6344); }
    }
    /// <summary>
    /// ComponentProperty: FloorSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorSparks_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6348); }
    }
    /// <summary>
    /// ComponentProperty: FloorSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorSparks_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6352); }
    }
    /// <summary>
    /// ComponentProperty: FloorSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorSparks_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6356); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6356); }
    }
    /// <summary>
    /// ComponentProperty: FloorSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorSparks_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6360); }
    }
    /// <summary>
    /// ComponentProperty: FloorSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorSparks_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6364); }
    }
    /// <summary>
    /// ComponentProperty: FloorSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorSparks_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6368); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6368); }
    }
    /// <summary>
    /// ComponentProperty: FloorSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorSparks_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6372); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6372); }
    }
    /// <summary>
    /// ComponentProperty: FloorSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorSparks_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6376); }
    }
    /// <summary>
    /// ComponentProperty: FloorSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorSparks_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6380); }
    }
    /// <summary>
    /// ComponentProperty: FloorSparks
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FloorSparks_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6384); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6384); }
    }

    /// <summary>
    /// IntProperty: NextFloorSpark
    /// </summary>
    public unsafe int NextFloorSpark
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6388); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: SmashFireData
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnBossGrundyBase.FSmashFire> SmashFireData => new(3, Ptr + 6392, 28, this);

    /// <summary>
    /// StructProperty: SmashFireData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FSmashFire SmashFireData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FSmashFire>(Ptr + 6392);
    /// <summary>
    /// StructProperty: SmashFireData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FSmashFire SmashFireData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FSmashFire>(Ptr + 6420);
    /// <summary>
    /// StructProperty: SmashFireData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FSmashFire SmashFireData_2
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FSmashFire>(Ptr + 6448);

    /// <summary>
    /// InlineArray{ComponentProperty}: SmashFires
    /// </summary>
    public InlineArray<BmSDK.Engine.ParticleSystemComponent> SmashFires => new(3, Ptr + 6476, 4, this);

    /// <summary>
    /// ComponentProperty: SmashFires
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent SmashFires_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6476); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6476); }
    }
    /// <summary>
    /// ComponentProperty: SmashFires
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent SmashFires_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6480); }
    }
    /// <summary>
    /// ComponentProperty: SmashFires
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent SmashFires_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 6484); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6484); }
    }

    /// <summary>
    /// IntProperty: NextSmashFire
    /// </summary>
    public unsafe int NextSmashFire
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6488); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6488); }
    }

    /// <summary>
    /// FloatProperty: TimeForNextAttack
    /// </summary>
    public unsafe float TimeForNextAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6492); }
    }

    /// <summary>
    /// ObjectProperty: CenterPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor CenterPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 6496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6496); }
    }

    /// <summary>
    /// FloatProperty: ArenaWidth
    /// </summary>
    public unsafe float ArenaWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6500); }
    }

    /// <summary>
    /// FloatProperty: MaxStrayDistance
    /// </summary>
    public unsafe float MaxStrayDistance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6504); }
    }

    /// <summary>
    /// ObjectProperty: FakeDeathPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor FakeDeathPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 6508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6508); }
    }

    /// <summary>
    /// IntProperty: LastPadGroupBlownUp
    /// </summary>
    public unsafe int LastPadGroupBlownUp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6512); }
    }

    /// <summary>
    /// ObjectProperty: EndOfPhase1StartPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor EndOfPhase1StartPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 6516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6516); }
    }

    /// <summary>
    /// ObjectProperty: GrundyImpactRumble
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform GrundyImpactRumble
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 6520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6520); }
    }

    /// <summary>
    /// ObjectProperty: GrundyImpactRumbleBIG
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform GrundyImpactRumbleBIG
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 6524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6524); }
    }

    /// <summary>
    /// ObjectProperty: GrundyImpactRumbleBIGGEST
    /// </summary>
    public unsafe BmSDK.Engine.ForceFeedbackWaveform GrundyImpactRumbleBIGGEST
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ForceFeedbackWaveform>(Ptr + 6528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6528); }
    }

    /// <summary>
    /// ObjectProperty: BeatSuccessSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BeatSuccessSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6532); }
    }

    /// <summary>
    /// ObjectProperty: BeatFailSound
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent BeatFailSound
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6536); }
    }

    /// <summary>
    /// ObjectProperty: GrundyHurt
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent GrundyHurt
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 6540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6540); }
    }

    /// <summary>
    /// ArrayProperty: MAGNETS
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMagneticSurfaceSMBase> MAGNETS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMagneticSurfaceSMBase>>(Ptr + 6544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6544); }
    }

    /// <summary>
    /// ArrayProperty: MiniMagnets
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RMagneticSurfaceSMBase> MiniMagnets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RMagneticSurfaceSMBase>>(Ptr + 6556); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6556); }
    }

    /// <summary>
    /// FloatProperty: DistanceForMagnetAttract
    /// </summary>
    public unsafe float DistanceForMagnetAttract
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6568); }
    }

    /// <summary>
    /// ArrayProperty: AttachedMagnets
    /// </summary>
    public unsafe BmSDK.TArray<int> AttachedMagnets
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 6572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6572); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: ArmWeights
    /// </summary>
    public InlineArray<BmSDK.Engine.SkeletalMeshComponent> ArmWeights => new(2, Ptr + 6584, 4, this);

    /// <summary>
    /// ComponentProperty: ArmWeights
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ArmWeights_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6584); }
    }
    /// <summary>
    /// ComponentProperty: ArmWeights
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent ArmWeights_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 6588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6588); }
    }

    /// <summary>
    /// InlineArray{ComponentProperty}: ArmWeightRopes
    /// </summary>
    public InlineArray<BmSDK.BmGame.RRope2Component> ArmWeightRopes => new(2, Ptr + 6592, 4, this);

    /// <summary>
    /// ComponentProperty: ArmWeightRopes
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2Component ArmWeightRopes_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2Component>(Ptr + 6592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6592); }
    }
    /// <summary>
    /// ComponentProperty: ArmWeightRopes
    /// </summary>
    public unsafe BmSDK.BmGame.RRope2Component ArmWeightRopes_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRope2Component>(Ptr + 6596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6596); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: ArmWeightAttachDummys
    /// </summary>
    public InlineArray<BmSDK.FName> ArmWeightAttachDummys => new(2, Ptr + 6600, 8, this);

    /// <summary>
    /// NameProperty: ArmWeightAttachDummys
    /// </summary>
    public unsafe BmSDK.FName ArmWeightAttachDummys_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6600); }
    }
    /// <summary>
    /// NameProperty: ArmWeightAttachDummys
    /// </summary>
    public unsafe BmSDK.FName ArmWeightAttachDummys_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6608); }
    }

    /// <summary>
    /// InlineArray{NameProperty}: HandBoneNames
    /// </summary>
    public InlineArray<BmSDK.FName> HandBoneNames => new(2, Ptr + 6616, 8, this);

    /// <summary>
    /// NameProperty: HandBoneNames
    /// </summary>
    public unsafe BmSDK.FName HandBoneNames_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6616); }
    }
    /// <summary>
    /// NameProperty: HandBoneNames
    /// </summary>
    public unsafe BmSDK.FName HandBoneNames_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6624); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: CurrentChainLengths
    /// </summary>
    public InlineArray<float> CurrentChainLengths => new(2, Ptr + 6632, 4, this);

    /// <summary>
    /// FloatProperty: CurrentChainLengths
    /// </summary>
    public unsafe float CurrentChainLengths_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6632); }
    }
    /// <summary>
    /// FloatProperty: CurrentChainLengths
    /// </summary>
    public unsafe float CurrentChainLengths_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6636); }
    }

    /// <summary>
    /// InlineArray{StructProperty}: CurrentWeightsData
    /// </summary>
    public InlineArray<BmSDK.BmGame.RPawnBossGrundyBase.FGrundyWeightControlData> CurrentWeightsData => new(2, Ptr + 6640, 76, this);

    /// <summary>
    /// StructProperty: CurrentWeightsData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FGrundyWeightControlData CurrentWeightsData_0
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FGrundyWeightControlData>(Ptr + 6640);
    /// <summary>
    /// StructProperty: CurrentWeightsData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPawnBossGrundyBase.FGrundyWeightControlData CurrentWeightsData_1
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPawnBossGrundyBase.FGrundyWeightControlData>(Ptr + 6716);

    /// <summary>
    /// InlineArray{FloatProperty}: ExtendChainTime
    /// </summary>
    public InlineArray<float> ExtendChainTime => new(2, Ptr + 6792, 4, this);

    /// <summary>
    /// FloatProperty: ExtendChainTime
    /// </summary>
    public unsafe float ExtendChainTime_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6792); }
    }
    /// <summary>
    /// FloatProperty: ExtendChainTime
    /// </summary>
    public unsafe float ExtendChainTime_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6796); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6796); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: RetractChainTime
    /// </summary>
    public InlineArray<float> RetractChainTime => new(2, Ptr + 6800, 4, this);

    /// <summary>
    /// FloatProperty: RetractChainTime
    /// </summary>
    public unsafe float RetractChainTime_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6800); }
    }
    /// <summary>
    /// FloatProperty: RetractChainTime
    /// </summary>
    public unsafe float RetractChainTime_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6804); }
    }

    /// <summary>
    /// FloatProperty: CurrMaxYawOffset
    /// </summary>
    public unsafe float CurrMaxYawOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6808); }
    }

    /// <summary>
    /// StructProperty: CurrentMovementDestination
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CurrentMovementDestination
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6812);

    /// <summary>
    /// ObjectProperty: NavHandle
    /// </summary>
    public unsafe BmSDK.BmGame.RNavigationHandle NavHandle
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RNavigationHandle>(Ptr + 6824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6824); }
    }

    /// <summary>
    /// FloatProperty: CurrentSwingSpeed
    /// </summary>
    public unsafe float CurrentSwingSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6828); }
    }

    /// <summary>
    /// IntProperty: NumSwingsSoFar
    /// </summary>
    public unsafe int NumSwingsSoFar
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6832); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6832); }
    }

    /// <summary>
    /// IntProperty: NumSwingsTotal
    /// </summary>
    public unsafe int NumSwingsTotal
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6836); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6836); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: ChainLengthAtSlowDownChange
    /// </summary>
    public InlineArray<float> ChainLengthAtSlowDownChange => new(2, Ptr + 6840, 4, this);

    /// <summary>
    /// FloatProperty: ChainLengthAtSlowDownChange
    /// </summary>
    public unsafe float ChainLengthAtSlowDownChange_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6840); }
    }
    /// <summary>
    /// FloatProperty: ChainLengthAtSlowDownChange
    /// </summary>
    public unsafe float ChainLengthAtSlowDownChange_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6844); }
    }

    /// <summary>
    /// FloatProperty: SwingSpeedAtSlowDownChange
    /// </summary>
    public unsafe float SwingSpeedAtSlowDownChange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6848); }
    }

    /// <summary>
    /// FloatProperty: SlowdownTimer
    /// </summary>
    public unsafe float SlowdownTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6852); }
    }

    /// <summary>
    /// IntProperty: NumConsectiveClockwise
    /// </summary>
    public unsafe int NumConsectiveClockwise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6856); }
    }

    /// <summary>
    /// IntProperty: NumConsectiveAntiClockwise
    /// </summary>
    public unsafe int NumConsectiveAntiClockwise
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6860); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: WeightHeightAtSlow
    /// </summary>
    public InlineArray<float> WeightHeightAtSlow => new(2, Ptr + 6864, 4, this);

    /// <summary>
    /// FloatProperty: WeightHeightAtSlow
    /// </summary>
    public unsafe float WeightHeightAtSlow_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6864); }
    }
    /// <summary>
    /// FloatProperty: WeightHeightAtSlow
    /// </summary>
    public unsafe float WeightHeightAtSlow_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6868); }
    }

    /// <summary>
    /// InlineArray{FloatProperty}: WeightDistAtSlow
    /// </summary>
    public InlineArray<float> WeightDistAtSlow => new(2, Ptr + 6872, 4, this);

    /// <summary>
    /// FloatProperty: WeightDistAtSlow
    /// </summary>
    public unsafe float WeightDistAtSlow_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6872); }
    }
    /// <summary>
    /// FloatProperty: WeightDistAtSlow
    /// </summary>
    public unsafe float WeightDistAtSlow_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6876); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6876); }
    }

    /// <summary>
    /// FloatProperty: SmashWaitTimer
    /// </summary>
    public unsafe float SmashWaitTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6880); }
    }

    /// <summary>
    /// StructProperty: SavedSmashAttackPoint
    /// </summary>
    public unsafe ref System.Numerics.Vector3 SavedSmashAttackPoint
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6884);

    /// <summary>
    /// IntProperty: NumRepeatSmashes
    /// </summary>
    public unsafe int NumRepeatSmashes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6896); }
    }

    /// <summary>
    /// ArrayProperty: Maggots
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RJokerBombTeeth> Maggots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RJokerBombTeeth>>(Ptr + 6900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6900); }
    }

    /// <summary>
    /// IntProperty: CurrentSpawnNo
    /// </summary>
    public unsafe int CurrentSpawnNo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6912); }
    }

    /// <summary>
    /// FloatProperty: TotalMagnetTetherTime
    /// </summary>
    public unsafe float TotalMagnetTetherTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6916); }
    }

    /// <summary>
    /// ObjectProperty: LastMagnetPoint
    /// </summary>
    public unsafe BmSDK.Engine.Actor LastMagnetPoint
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 6920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6920); }
    }

    /// <summary>
    /// IntProperty: NumAttacksDuringElectrified
    /// </summary>
    public unsafe int NumAttacksDuringElectrified
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6924); }
    }

    /// <summary>
    /// IntProperty: AttackNumber
    /// </summary>
    public unsafe int AttackNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6928); }
    }

    /// <summary>
    /// FloatProperty: CounterMarkTime
    /// </summary>
    public unsafe float CounterMarkTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6932); }
    }

    /// <summary>
    /// StructProperty: MeleeStartRefLoc
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MeleeStartRefLoc
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6936);

    /// <summary>
    /// StructProperty: MeleeStartRefRot
    /// </summary>
    public unsafe ref BmSDK.Rotator MeleeStartRefRot
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Rotator>(Ptr + 6948);

    /// <summary>
    /// FloatProperty: TimeSinceLastBMPunch
    /// </summary>
    public unsafe float TimeSinceLastBMPunch
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6960); }
    }

    /// <summary>
    /// IntProperty: BMPunchCount
    /// </summary>
    public unsafe int BMPunchCount
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6964); }
    }

    /// <summary>
    /// FloatProperty: HeartBeatValue
    /// </summary>
    public unsafe float HeartBeatValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6968); }
    }

    /// <summary>
    /// FloatProperty: PadGlowValue
    /// </summary>
    public unsafe float PadGlowValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6972); }
    }

    /// <summary>
    /// FloatProperty: GrundyVeinGlowValue
    /// </summary>
    public unsafe float GrundyVeinGlowValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6976); }
    }

    /// <summary>
    /// FloatProperty: HeartBeatReductionPerSec
    /// </summary>
    public unsafe float HeartBeatReductionPerSec
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6980); }
    }

    /// <summary>
    /// FloatProperty: TimeBetweenBeats
    /// </summary>
    public unsafe float TimeBetweenBeats
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6984); }
    }

    /// <summary>
    /// FloatProperty: TimeTillNextBeat
    /// </summary>
    public unsafe float TimeTillNextBeat
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6988); }
    }

    /// <summary>
    /// StructProperty: VeinGlowColour
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor VeinGlowColour
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 6992);

    /// <summary>
    /// FloatProperty: PadBeatAnimThreshold
    /// </summary>
    public unsafe float PadBeatAnimThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7008); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: roomCogsMatinee
    /// </summary>
    public InlineArray<BmSDK.Engine.SeqAct_Interp> roomCogsMatinee => new(3, Ptr + 7012, 4, this);

    /// <summary>
    /// ObjectProperty: roomCogsMatinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp roomCogsMatinee_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 7012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7012); }
    }
    /// <summary>
    /// ObjectProperty: roomCogsMatinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp roomCogsMatinee_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 7016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7016); }
    }
    /// <summary>
    /// ObjectProperty: roomCogsMatinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp roomCogsMatinee_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 7020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7020); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: padCogsMatinee
    /// </summary>
    public InlineArray<BmSDK.Engine.SeqAct_Interp> padCogsMatinee => new(3, Ptr + 7024, 4, this);

    /// <summary>
    /// ObjectProperty: padCogsMatinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp padCogsMatinee_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 7024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7024); }
    }
    /// <summary>
    /// ObjectProperty: padCogsMatinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp padCogsMatinee_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 7028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7028); }
    }
    /// <summary>
    /// ObjectProperty: padCogsMatinee
    /// </summary>
    public unsafe BmSDK.Engine.SeqAct_Interp padCogsMatinee_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SeqAct_Interp>(Ptr + 7032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7032); }
    }

    /// <summary>
    /// FloatProperty: ropeForceStrength
    /// </summary>
    public unsafe float ropeForceStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7036); }
    }

    /// <summary>
    /// FloatProperty: ropeDampingStrength
    /// </summary>
    public unsafe float ropeDampingStrength
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7040); }
    }

    /// <summary>
    /// StructProperty: leftRopeAttachData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RRope2Component.FRopeEndAttachData leftRopeAttachData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RRope2Component.FRopeEndAttachData>(Ptr + 7044);

    /// <summary>
    /// StructProperty: rightRopeAttachData
    /// </summary>
    public unsafe ref BmSDK.BmGame.RRope2Component.FRopeEndAttachData rightRopeAttachData
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RRope2Component.FRopeEndAttachData>(Ptr + 7072);

    /// <summary>
    /// FloatProperty: weightsMaxVel2d
    /// </summary>
    public unsafe float weightsMaxVel2d
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7100); }
    }

    /// <summary>
    /// FloatProperty: weightsMaxVelZ
    /// </summary>
    public unsafe float weightsMaxVelZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7104); }
    }

    /// <summary>
    /// InlineArray{IntProperty}: bWeightsWantToBlockActors
    /// </summary>
    public InlineArray<int> bWeightsWantToBlockActors => new(2, Ptr + 7108, 4, this);

    /// <summary>
    /// IntProperty: bWeightsWantToBlockActors
    /// </summary>
    public unsafe int bWeightsWantToBlockActors_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7108); }
    }
    /// <summary>
    /// IntProperty: bWeightsWantToBlockActors
    /// </summary>
    public unsafe int bWeightsWantToBlockActors_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 7112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7112); }
    }

    /// <summary>
    /// FloatProperty: weightBlockBMDist
    /// </summary>
    public unsafe float weightBlockBMDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7116); }
    }

    /// <summary>
    /// FloatProperty: weightTeleportLeniency
    /// </summary>
    public unsafe float weightTeleportLeniency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 7120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 7120); }
    }

    /// <summary>
    /// Enum: EGrundyForcedAttack
    /// </summary>
    public enum EGrundyForcedAttack : byte
    {
        EGrundyForcedAttack_Swing = 0,
        EGrundyForcedAttack_Smash = 1,
        EGrundyForcedAttack_Melee = 2,
        EGrundyForcedAttack_Maggots = 3,
        EGrundyForcedAttack_SlamDunk = 4,
        EGrundyForcedAttack_NONE = 5,
        EGrundyForcedAttack_MAX = 6,
    }

    /// <summary>
    /// Enum: EGrundyAttacks
    /// </summary>
    public enum EGrundyAttacks : byte
    {
        GRUNDYATTACK_Maggots = 0,
        GRUNDYATTACK_Smash = 1,
        GRUNDYATTACK_Swing = 2,
        GRUNDYATTACK_Melee = 3,
        GRUNDYATTACK_MAX = 4,
    }

    /// <summary>
    /// Enum: EGrundyToggleType
    /// </summary>
    public enum EGrundyToggleType : byte
    {
        GRUNDYTOGGLE_Leave = 0,
        GRUNDYTOGGLE_Enable = 1,
        GRUNDYTOGGLE_Disable = 2,
        GRUNDYTOGGLE_Toggle = 3,
        GRUNDYTOGGLE_MAX = 4,
    }

    /// <summary>
    /// Enum: EGrundyWeightSide
    /// </summary>
    public enum EGrundyWeightSide : byte
    {
        GRUNDYWEIGHTSIDE_Left = 0,
        GRUNDYWEIGHTSIDE_Right = 1,
        GRUNDYWEIGHTSIDE_Both = 2,
        GRUNDYWEIGHTSIDE_None = 3,
        GRUNDYWEIGHTSIDE_MAX = 4,
    }

    /// <summary>
    /// Enum: SolomonGrundyState
    /// </summary>
    public enum SolomonGrundyState : byte
    {
        SGS_Normal = 0,
        SGS_OnFire = 1,
        SGS_Electrified = 2,
        SGS_MAX = 3,
    }
}
