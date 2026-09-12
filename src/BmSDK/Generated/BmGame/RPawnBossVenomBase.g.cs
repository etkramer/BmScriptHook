#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// ABSTRACT Class: RPawnBossVenomBase<br/>
/// (size = 3876)
/// (flags = 144703671)
/// </summary>
public partial class RPawnBossVenomBase : BmSDK.BmGame.RPawnVillain, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnBossVenomBase", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnBossVenomBase.
    /// </summary>
    public static RPawnBossVenomBase DefaultObject => (RPawnBossVenomBase)StaticClass().DefaultObject;

    internal RPawnBossVenomBase() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnBossVenomBase(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossVenomBase>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossVenomBase>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossVenomBase>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossVenomBase>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossVenomBase>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossVenomBase>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnBossVenomBase>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnBossVenomBase>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: IsInBeatUp
    /// </summary>
    public unsafe virtual bool IsInBeatUp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.IsInBeatUp", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDeathTip
    /// </summary>
    public unsafe virtual BmSDK.FString GetDeathTip()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetDeathTip", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: HitDisruptableLaserGrid
    /// </summary>
    public unsafe virtual bool HitDisruptableLaserGrid()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.HitDisruptableLaserGrid", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetDeadThugPickupPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetDeadThugPickupPoint(BmSDK.BmGame.RPawnCombat DeadThug)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetDeadThugPickupPoint", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeadThug, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDeadThug
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnCombat GetDeadThug(float SearchRange)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetDeadThug", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SearchRange, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetClampedTargetDirection
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetClampedTargetDirection(System.Numerics.Vector3 Heading, System.Numerics.Vector3 TargetPos, float MaxYawDelta)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetClampedTargetDirection", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heading, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetPos, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxYawDelta, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: GetRightStrikeHitReaction
    /// </summary>
    public unsafe virtual void GetRightStrikeHitReaction(ref BmSDK.FName HitReaction, ref BmSDK.FName PoseName, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetRightStrikeHitReaction", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReaction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitReaction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
        PoseName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: GetLeftStrikeHitReaction
    /// </summary>
    public unsafe virtual void GetLeftStrikeHitReaction(ref BmSDK.FName HitReaction, ref BmSDK.FName PoseName, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetLeftStrikeHitReaction", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReaction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitReaction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
        PoseName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: GetRearStrikeHitReaction
    /// </summary>
    public unsafe virtual void GetRearStrikeHitReaction(ref BmSDK.FName HitReaction, ref BmSDK.FName PoseName, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetRearStrikeHitReaction", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReaction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitReaction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
        PoseName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: GetFrontStrikeHitReaction
    /// </summary>
    public unsafe virtual void GetFrontStrikeHitReaction(ref BmSDK.FName HitReaction, ref BmSDK.FName PoseName, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetFrontStrikeHitReaction", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReaction, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseName, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitReaction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
        PoseName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: GetRightExplosionHitReaction
    /// </summary>
    public unsafe virtual void GetRightExplosionHitReaction(bool bThresholdReached, ref BmSDK.FName HitReaction, ref BmSDK.FName PoseName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetRightExplosionHitReaction", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThresholdReached, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReaction, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitReaction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
        PoseName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: GetLeftExplosionHitReaction
    /// </summary>
    public unsafe virtual void GetLeftExplosionHitReaction(bool bThresholdReached, ref BmSDK.FName HitReaction, ref BmSDK.FName PoseName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetLeftExplosionHitReaction", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThresholdReached, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReaction, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitReaction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
        PoseName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: GetRearExplosionHitReaction
    /// </summary>
    public unsafe virtual void GetRearExplosionHitReaction(bool bThresholdReached, ref BmSDK.FName HitReaction, ref BmSDK.FName PoseName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetRearExplosionHitReaction", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThresholdReached, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReaction, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitReaction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
        PoseName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: GetFrontExplosionHitReaction
    /// </summary>
    public unsafe virtual void GetFrontExplosionHitReaction(bool bThresholdReached, ref BmSDK.FName HitReaction, ref BmSDK.FName PoseName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetFrontExplosionHitReaction", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThresholdReached, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReaction, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitReaction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
        PoseName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: GetWallHitReaction
    /// </summary>
    public unsafe virtual void GetWallHitReaction(bool bThresholdReached, ref BmSDK.FName HitReaction, ref BmSDK.FName PoseName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetWallHitReaction", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bThresholdReached, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitReaction, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        HitReaction = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 4);
        PoseName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: ShockwaveTriggered
    /// </summary>
    public unsafe virtual void ShockwaveTriggered()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.ShockwaveTriggered", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DeactivateCollision
    /// </summary>
    public unsafe virtual void DeactivateCollision()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.DeactivateCollision", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChargedIntoDisruptableLaserGrid
    /// </summary>
    public unsafe virtual void ChargedIntoDisruptableLaserGrid(bool bQuickBatarang)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.ChargedIntoDisruptableLaserGrid", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bQuickBatarang, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChargedIntoWall
    /// </summary>
    public unsafe virtual void ChargedIntoWall(bool bQuickBatarang)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.ChargedIntoWall", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bQuickBatarang, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateBatmansVenomWeaponConfig
    /// </summary>
    public unsafe virtual void CreateBatmansVenomWeaponConfig(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.CreateBatmansVenomWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EvadeableAttackHitPlayer
    /// </summary>
    public unsafe virtual void EvadeableAttackHitPlayer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.EvadeableAttackHitPlayer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AttackCompleted
    /// </summary>
    public unsafe virtual void AttackCompleted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.AttackCompleted", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BerserkTimedOut
    /// </summary>
    public unsafe virtual void BerserkTimedOut()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.BerserkTimedOut", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BerserkEnd
    /// </summary>
    public unsafe virtual void BerserkEnd()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.BerserkEnd", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BerserkBegin
    /// </summary>
    public unsafe virtual void BerserkBegin()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.BerserkBegin", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ChargeDodged
    /// </summary>
    public unsafe virtual void ChargeDodged()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.ChargeDodged", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SuccessfulEvade
    /// </summary>
    public unsafe virtual void SuccessfulEvade()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.SuccessfulEvade", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SuccessfulBeatUp
    /// </summary>
    public unsafe virtual void SuccessfulBeatUp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.SuccessfulBeatUp", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SuccessfulBatarang
    /// </summary>
    public unsafe virtual void SuccessfulBatarang()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.SuccessfulBatarang", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetStunnedPfx
    /// </summary>
    public unsafe virtual void SetStunnedPfx(bool bOn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.SetStunnedPfx", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayAdditiveBatarangReaction
    /// </summary>
    public unsafe virtual void PlayAdditiveBatarangReaction()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.PlayAdditiveBatarangReaction", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayBatarangHitFX
    /// </summary>
    public unsafe virtual void PlayBatarangHitFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.PlayBatarangHitFX", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StopLookAtBatman
    /// </summary>
    public unsafe virtual void StopLookAtBatman()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.StopLookAtBatman", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LookAtBatman
    /// </summary>
    public unsafe virtual void LookAtBatman()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.LookAtBatman", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetThugThrowHitSoundCue
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetThugThrowHitSoundCue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetThugThrowHitSoundCue", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPlayerThrowHitSoundCue
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetPlayerThrowHitSoundCue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetPlayerThrowHitSoundCue", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetThugChargedSoundCue
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetThugChargedSoundCue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetThugChargedSoundCue", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPlayerChargedSoundCue
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetPlayerChargedSoundCue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetPlayerChargedSoundCue", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetThugPunchedSoundCue
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetThugPunchedSoundCue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetThugPunchedSoundCue", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPlayerPunchedSoundCue
    /// </summary>
    public unsafe virtual BmSDK.Engine.AkEvent GetPlayerPunchedSoundCue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetPlayerPunchedSoundCue", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetTargetPriority
    /// </summary>
    public unsafe override float GetTargetPriority(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetTargetPriority", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsValidForStrike
    /// </summary>
    public unsafe virtual bool IsValidForStrike(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.IsValidForStrike", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ForceChargeAttack
    /// </summary>
    public unsafe virtual void ForceChargeAttack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.ForceChargeAttack", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetMaxWalkAttackRange
    /// </summary>
    public unsafe virtual float GetMaxWalkAttackRange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetMaxWalkAttackRange", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetChargeHomingValue
    /// </summary>
    public unsafe virtual float GetChargeHomingValue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetChargeHomingValue", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsBeingRidden
    /// </summary>
    public unsafe virtual bool IsBeingRidden()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.IsBeingRidden", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsVulnerableToExplosion
    /// </summary>
    public unsafe virtual bool IsVulnerableToExplosion()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.IsVulnerableToExplosion", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetSmokeBombReactionClass
    /// </summary>
    public unsafe override BmSDK.Class GetSmokeBombReactionClass()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetSmokeBombReactionClass", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsHenchman
    /// </summary>
    public unsafe virtual bool IsHenchman()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.IsHenchman", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetLastCombatMoveClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetLastCombatMoveClass()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetLastCombatMoveClass", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsVirtuallyDead
    /// </summary>
    public unsafe virtual bool IsVirtuallyDead()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.IsVirtuallyDead", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetHealth
    /// </summary>
    public unsafe override int GetHealth()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetHealth", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RBMBehaviour_Venom GetBehaviour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetBehaviour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMBehaviour_Venom>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsPathClear
    /// </summary>
    public unsafe virtual bool IsPathClear(System.Numerics.Vector3 FromPoint, System.Numerics.Vector3 EndPoint, float Radius, ref System.Numerics.Vector3 CollidePoint, ref System.Numerics.Vector3 CollideNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.IsPathClear", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromPoint, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EndPoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Radius, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollidePoint, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollideNormal, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CollidePoint = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 28);
        CollideNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 52);
    }

    /// <summary>
    /// Function: GetCollideFreePosition
    /// </summary>
    public unsafe virtual bool GetCollideFreePosition(ref System.Numerics.Vector3 Position)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.GetCollideFreePosition", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Position = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: WillCollideWithWall
    /// </summary>
    public unsafe virtual bool WillCollideWithWall(System.Numerics.Vector3 Heading, ref System.Numerics.Vector3 CollidePoint, ref System.Numerics.Vector3 Normal, ref BmSDK.Engine.Actor HitActorL, ref BmSDK.Engine.Actor HitActorR)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnBossVenomBase.WillCollideWithWall", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heading, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CollidePoint, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Normal, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActorL, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitActorR, paramsPtr + 40);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CollidePoint = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        Normal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
        HitActorL = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 36);
        HitActorR = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(paramsPtr + 40);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 44);
    }

    /// <summary>
    /// Struct: FCombatMoveInfo
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FCombatMoveInfo
    {
        /// <summary>
        /// ClassProperty: CombatMoveClass
        /// </summary>
        public unsafe BmSDK.Class CombatMoveClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: NumTimesUsed
        /// </summary>
        public unsafe int NumTimesUsed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Time
        /// </summary>
        public unsafe float Time
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// FloatProperty: ShortRange
    /// </summary>
    public unsafe float ShortRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3560); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3560); }
    }

    /// <summary>
    /// FloatProperty: MediumRange
    /// </summary>
    public unsafe float MediumRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3564); }
    }

    /// <summary>
    /// FloatProperty: LongRange
    /// </summary>
    public unsafe float LongRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3568); }
    }

    /// <summary>
    /// FloatProperty: MaxAttackDelay
    /// </summary>
    public unsafe float MaxAttackDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3572); }
    }

    /// <summary>
    /// IntProperty: Id
    /// </summary>
    public unsafe int Id
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3576); }
    }

    /// <summary>
    /// ObjectProperty: BossAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BossAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3580); }
    }

    /// <summary>
    /// ObjectProperty: BMAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet BMAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3584); }
    }

    /// <summary>
    /// ObjectProperty: RedirectAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RedirectAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3588); }
    }

    /// <summary>
    /// ObjectProperty: VHThrowAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VHThrowAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3592); }
    }

    /// <summary>
    /// ObjectProperty: RidingAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet RidingAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3596); }
    }

    /// <summary>
    /// ObjectProperty: VHTakeDownAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet VHTakeDownAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3600); }
    }

    /// <summary>
    /// ObjectProperty: MainCombatAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet MainCombatAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3604); }
    }

    /// <summary>
    /// ObjectProperty: MainHenchmanAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet MainHenchmanAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3608); }
    }

    /// <summary>
    /// ObjectProperty: HudMovie
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie HudMovie
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 3612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3612); }
    }

    /// <summary>
    /// StrProperty: HudMovieString
    /// </summary>
    public unsafe BmSDK.FString HudMovieString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 3616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3616); }
    }

    /// <summary>
    /// BoolProperty: bExhausted
    /// </summary>
    public unsafe bool bExhausted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3628); }
    }

    /// <summary>
    /// BoolProperty: bChargeOvershoot
    /// </summary>
    public unsafe bool bChargeOvershoot
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3628); }
    }

    /// <summary>
    /// BoolProperty: bCharging
    /// </summary>
    public unsafe bool bCharging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3628); }
    }

    /// <summary>
    /// BoolProperty: bForceChargeAttack
    /// </summary>
    public unsafe bool bForceChargeAttack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3628); }
    }

    /// <summary>
    /// BoolProperty: bTauntEnabled
    /// </summary>
    public unsafe bool bTauntEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3628); }
    }

    /// <summary>
    /// BoolProperty: bNeverBataranged
    /// </summary>
    public unsafe bool bNeverBataranged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3628); }
    }

    /// <summary>
    /// BoolProperty: bNeverUsedAgainstEachOther
    /// </summary>
    public unsafe bool bNeverUsedAgainstEachOther
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3628); }
    }

    /// <summary>
    /// BoolProperty: SlowRideIn
    /// </summary>
    public unsafe bool SlowRideIn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3628); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3628); }
    }

    /// <summary>
    /// ObjectProperty: HitParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem HitParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3632); }
    }

    /// <summary>
    /// ObjectProperty: ChargeHitParticleSystem
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem ChargeHitParticleSystem
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3636); }
    }

    /// <summary>
    /// ComponentProperty: StunnedFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent StunnedFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 3644);

    /// <summary>
    /// ArrayProperty: CombatMoveHistory
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPawnBossVenomBase.FCombatMoveInfo> CombatMoveHistory
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPawnBossVenomBase.FCombatMoveInfo>>(Ptr + 3788); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3788); }
    }

    /// <summary>
    /// ClassProperty: LastCombatMoveClass
    /// </summary>
    public unsafe BmSDK.Class LastCombatMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3800); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3800); }
    }

    /// <summary>
    /// ClassProperty: PreferedCombatMoveClass
    /// </summary>
    public unsafe BmSDK.Class PreferedCombatMoveClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 3804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3804); }
    }

    /// <summary>
    /// ObjectProperty: HeadMic0
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HeadMic0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3808); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3808); }
    }

    /// <summary>
    /// ObjectProperty: HeadMic1
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HeadMic1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3812); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3812); }
    }

    /// <summary>
    /// ObjectProperty: BodyMic0
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BodyMic0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3816); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3816); }
    }

    /// <summary>
    /// ObjectProperty: BodyMic1
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BodyMic1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3820); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3820); }
    }

    /// <summary>
    /// IntProperty: ThresholdIndex
    /// </summary>
    public unsafe int ThresholdIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3824); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3824); }
    }

    /// <summary>
    /// ArrayProperty: HealthThresholds
    /// </summary>
    public unsafe BmSDK.TArray<int> HealthThresholds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 3828); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3828); }
    }

    /// <summary>
    /// IntProperty: AttackPriority
    /// </summary>
    public unsafe int AttackPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3840); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3840); }
    }

    /// <summary>
    /// FloatProperty: ChargeHomingValue
    /// </summary>
    public unsafe float ChargeHomingValue
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3844); }
    }

    /// <summary>
    /// FloatProperty: MaxBerserkWindowTime
    /// </summary>
    public unsafe float MaxBerserkWindowTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3848); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3848); }
    }

    /// <summary>
    /// ObjectProperty: DeadThugToThrow
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnCombat DeadThugToThrow
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat>(Ptr + 3852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3852); }
    }

    /// <summary>
    /// ComponentProperty: BatarangOverride
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionComponent BatarangOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionComponent>(Ptr + 3856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3856); }
    }

    /// <summary>
    /// FloatProperty: BerserkDuration
    /// </summary>
    public unsafe float BerserkDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3860); }
    }

    /// <summary>
    /// ComponentProperty: AttackingPS
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent AttackingPS
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3864); }
    }

    /// <summary>
    /// ObjectProperty: TakedownCameraAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet TakedownCameraAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 3868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3868); }
    }

    /// <summary>
    /// IntProperty: TotalTimesRidden
    /// </summary>
    public unsafe int TotalTimesRidden
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3872); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3872); }
    }
}
