#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnPlayerCatwoman<br/>
/// (size = 6312)
/// (flags = 10486326)
/// </summary>
public partial class RPawnPlayerCatwoman : BmSDK.BmGame.RPawnPlayerCatwomanBase, BmSDK.BmGame.RXrayInterface, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnPlayerCatwoman", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerCatwoman.
    /// </summary>
    public static RPawnPlayerCatwoman DefaultObject => (RPawnPlayerCatwoman)StaticClass().DefaultObject;

    internal RPawnPlayerCatwoman() { }

    /// <summary>
    /// Constructs a new RPawnPlayerCatwoman
    /// </summary>
    public RPawnPlayerCatwoman(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerCatwoman(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerCatwoman>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: PlayCollapseEmote
    /// </summary>
    public unsafe virtual void PlayCollapseEmote()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.PlayCollapseEmote", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetFailedPairedAnimMoveAnimset
    /// </summary>
    public unsafe override void GetFailedPairedAnimMoveAnimset(ref BmSDK.Engine.AnimSet MyAnimset, BmSDK.BmGame.RPawnCombat OtherPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.GetFailedPairedAnimMoveAnimset", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MyAnimset, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        MyAnimset = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: CanJumpOffWallStick
    /// </summary>
    public unsafe override bool CanJumpOffWallStick(BmSDK.BmGame.RSpecialMoveConfig Config, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.CanJumpOffWallStick", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Config, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 116);
    }

    /// <summary>
    /// Function: DieOnCeilingsOnly
    /// </summary>
    public unsafe virtual void DieOnCeilingsOnly(bool bOn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.DieOnCeilingsOnly", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetUnlockedMeleeArmourLevel
    /// </summary>
    public unsafe override int GetUnlockedMeleeArmourLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.GetUnlockedMeleeArmourLevel", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetUnlockedBallisticArmourLevel
    /// </summary>
    public unsafe override int GetUnlockedBallisticArmourLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.GetUnlockedBallisticArmourLevel", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetPersistentMeleeArmour
    /// </summary>
    public unsafe override void SetPersistentMeleeArmour(int armour)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.SetPersistentMeleeArmour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPersistentBallisticArmour
    /// </summary>
    public unsafe override void SetPersistentBallisticArmour(int armour)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.SetPersistentBallisticArmour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(armour, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPersistentMeleeArmour
    /// </summary>
    public unsafe override int GetPersistentMeleeArmour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.GetPersistentMeleeArmour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPersistentBallisticArmour
    /// </summary>
    public unsafe override int GetPersistentBallisticArmour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.GetPersistentBallisticArmour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: OnHelicopterHit
    /// </summary>
    public unsafe override void OnHelicopterHit(BmSDK.BmGame.RHelicopterBase Heli, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.OnHelicopterHit", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Heli, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayHurtEmote
    /// </summary>
    public unsafe override void PlayHurtEmote(float RandChance)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.PlayHurtEmote", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RandChance, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetStrikeTrailPS
    /// </summary>
    public unsafe override BmSDK.Engine.ParticleSystem GetStrikeTrailPS(BmSDK.Class StrikeDmgType, bool bIsSuperStrike, int ComboLevel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.GetStrikeTrailPS", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StrikeDmgType, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsSuperStrike, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ComboLevel, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: PlayCrowStartledLine
    /// </summary>
    public unsafe override void PlayCrowStartledLine()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.PlayCrowStartledLine", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CantPullOffGrateLine
    /// </summary>
    public unsafe override void CantPullOffGrateLine()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.CantPullOffGrateLine", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateMaterialParameters
    /// </summary>
    public unsafe virtual void UpdateMaterialParameters(bool bForceIndoor = default, bool bForceOutdoor = default, float ForceBrightness = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.UpdateMaterialParameters", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceIndoor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOutdoor, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceBrightness, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe override void OnLevelChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.OnLevelChange", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnRoomChange
    /// </summary>
    public unsafe override void OnRoomChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.OnRoomChange", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanPlaySpeech
    /// </summary>
    public unsafe override bool CanPlaySpeech()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.CanPlaySpeech", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CoughTimer
    /// </summary>
    public unsafe virtual void CoughTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.CoughTimer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TakeDamage
    /// </summary>
    public unsafe override void TakeDamage(int Damage, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor.FTraceHitInfo HitInfo = default, BmSDK.Engine.Actor DamageCauser = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TakeDamage", true);
        byte* paramsPtr = stackalloc byte[92];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Damage, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Momentum, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 32);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitInfo, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 72);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindAndPlayOverrideDeathAnim
    /// </summary>
    public unsafe override bool FindAndPlayOverrideDeathAnim(BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.FindAndPlayOverrideDeathAnim", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TriggerInterrogationMove
    /// </summary>
    public unsafe override void TriggerInterrogationMove(BmSDK.BmGame.RPawnVillain Target, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerInterrogationMove", true);
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayWhipImpactFX
    /// </summary>
    public unsafe virtual void PlayWhipImpactFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.PlayWhipImpactFX", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayPounceHardLandFX
    /// </summary>
    public unsafe virtual void PlayPounceHardLandFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.PlayPounceHardLandFX", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayPounceLandFX
    /// </summary>
    public unsafe virtual void PlayPounceLandFX()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.PlayPounceLandFX", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InvestigateModeEyes
    /// </summary>
    public unsafe override void InvestigateModeEyes(bool bOnOrOff)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.InvestigateModeEyes", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bOnOrOff, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetAutoSwing
    /// </summary>
    public unsafe override void ResetAutoSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.ResetAutoSwing", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerAerialWhipPounce
    /// </summary>
    public unsafe override bool TriggerAerialWhipPounce()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerAerialWhipPounce", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetEdgeSwingGrappleLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetEdgeSwingGrappleLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.GetEdgeSwingGrappleLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetEdgeSwingWallLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetEdgeSwingWallLocation(ref System.Numerics.Vector3 WallNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.GetEdgeSwingWallLocation", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WallNormal, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        WallNormal = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetEdgeSwingStartLocation
    /// </summary>
    public unsafe override System.Numerics.Vector3 GetEdgeSwingStartLocation()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.GetEdgeSwingStartLocation", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsAutoSwingToGargoyle
    /// </summary>
    public unsafe override bool IsAutoSwingToGargoyle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.IsAutoSwingToGargoyle", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsAutoSwing
    /// </summary>
    public unsafe override bool IsAutoSwing()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.IsAutoSwing", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RecalculatePath
    /// </summary>
    public unsafe override void RecalculatePath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.RecalculatePath", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasPath
    /// </summary>
    public unsafe override bool HasPath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.HasPath", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ClearPath
    /// </summary>
    public unsafe override void ClearPath()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.ClearPath", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerPickPocketing
    /// </summary>
    public unsafe override void TriggerPickPocketing(BmSDK.BmGame.RPawnVillain Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerPickPocketing", true);
        byte* paramsPtr = stackalloc byte[128];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FakeUnarmedCombatThugRef
    /// </summary>
    public unsafe virtual BmSDK.Engine.AnimSet FakeUnarmedCombatThugRef()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.FakeUnarmedCombatThugRef", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FakeUnarmedCombatThugRefHolder
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RCharacterBioCue FakeUnarmedCombatThugRefHolder()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.FakeUnarmedCombatThugRefHolder", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCharacterBioCue>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpawnFootstepParticles
    /// </summary>
    public unsafe override void SpawnFootstepParticles(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact, System.Numerics.Vector3 FootLocation, BmSDK.BmGame.RPhysicalMaterialProperty Property)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.SpawnFootstepParticles", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FootLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Property, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetContactCharacterName
    /// </summary>
    public unsafe override BmSDK.FString GetContactCharacterName()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.GetContactCharacterName", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindContactName
    /// </summary>
    public unsafe override BmSDK.Engine.AkEvent FindContactName(BmSDK.BmGame.RAnimNotify_Footstep.EFoot Foot, BmSDK.BmGame.RAnimNotify_Footstep.EContactType Contact)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.FindContactName", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Foot, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Contact, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetStunMove
    /// </summary>
    public unsafe override BmSDK.Class GetStunMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.GetStunMove", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: OpenGrateFromBelow
    /// </summary>
    public unsafe virtual void OpenGrateFromBelow()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.OpenGrateFromBelow", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OpenGrateFromAbove
    /// </summary>
    public unsafe virtual void OpenGrateFromAbove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.OpenGrateFromAbove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerGrateFromCeilingMove
    /// </summary>
    public unsafe override void TriggerGrateFromCeilingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerGrateFromCeilingMove", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerGrateToCeilingMove
    /// </summary>
    public unsafe override void TriggerGrateToCeilingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerGrateToCeilingMove", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PounceOnThug
    /// </summary>
    public unsafe override void PounceOnThug(BmSDK.BmGame.RPawnVillain Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.PounceOnThug", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerHitAndDropFromCeilingMove
    /// </summary>
    public unsafe override void TriggerHitAndDropFromCeilingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerHitAndDropFromCeilingMove", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCeilingToCatwalkFarMove
    /// </summary>
    public unsafe override void TriggerCeilingToCatwalkFarMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerCeilingToCatwalkFarMove", true);
        byte* paramsPtr = stackalloc byte[224];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCeilingToCatwalkCloseMove
    /// </summary>
    public unsafe override void TriggerCeilingToCatwalkCloseMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerCeilingToCatwalkCloseMove", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetCeilingClimbCam
    /// </summary>
    public unsafe virtual void SetCeilingClimbCam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.SetCeilingClimbCam", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCatwalkToCeilingVeryFarMove
    /// </summary>
    public unsafe virtual void TriggerCatwalkToCeilingVeryFarMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerCatwalkToCeilingVeryFarMove", true);
        byte* paramsPtr = stackalloc byte[260];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCatwalkToCeilingFarMove
    /// </summary>
    public unsafe override void TriggerCatwalkToCeilingFarMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerCatwalkToCeilingFarMove", true);
        byte* paramsPtr = stackalloc byte[264];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCatwalkToCeilingCloseMove
    /// </summary>
    public unsafe override void TriggerCatwalkToCeilingCloseMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerCatwalkToCeilingCloseMove", true);
        byte* paramsPtr = stackalloc byte[156];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerDangleToCeilingMove
    /// </summary>
    public unsafe override void TriggerDangleToCeilingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerDangleToCeilingMove", true);
        byte* paramsPtr = stackalloc byte[136];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerCeilingToDangleMove
    /// </summary>
    public unsafe override void TriggerCeilingToDangleMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerCeilingToDangleMove", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerDropFromCeilingMove
    /// </summary>
    public unsafe override void TriggerDropFromCeilingMove()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerDropFromCeilingMove", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerPounceToCeilingMove
    /// </summary>
    public unsafe override void TriggerPounceToCeilingMove(System.Numerics.Vector3 Position)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TriggerPounceToCeilingMove", true);
        byte* paramsPtr = stackalloc byte[124];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Position, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HopOffVantagePoint
    /// </summary>
    public unsafe override void HopOffVantagePoint()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.HopOffVantagePoint", true);
        byte* paramsPtr = stackalloc byte[200];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.Tick", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetupGrateCrawlPose
    /// </summary>
    public unsafe virtual void SetupGrateCrawlPose(ref BmSDK.BmGame.RPoseConfig.FPose GrateCrawl)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.SetupGrateCrawlPose", true);
        byte* paramsPtr = stackalloc byte[340];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrateCrawl, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        GrateCrawl = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: AddWallPounceMoves
    /// </summary>
    public unsafe virtual void AddWallPounceMoves(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.AddWallPounceMoves", true);
        byte* paramsPtr = stackalloc byte[348];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddBullwhipMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddBullwhipMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.AddBullwhipMovesToWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[1984];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddCaltropsMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddCaltropsMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.AddCaltropsMovesToWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[2864];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddBolasMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddBolasMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.AddBolasMovesToWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[3952];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddCatwomanMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddCatwomanMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.AddCatwomanMovesToWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[1504];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetupWirePoses
    /// </summary>
    public unsafe virtual void SetupWirePoses(BmSDK.BmGame.RPoseConfig PoseConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.SetupWirePoses", true);
        byte* paramsPtr = stackalloc byte[684];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PoseConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ModifyExistingPoses
    /// </summary>
    public unsafe virtual void ModifyExistingPoses(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.ModifyExistingPoses", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddGapJumpToSwingMoves
    /// </summary>
    public unsafe virtual void AddGapJumpToSwingMoves(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.AddGapJumpToSwingMoves", true);
        byte* paramsPtr = stackalloc byte[3680];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddMovementMovesToWeaponConfig
    /// </summary>
    public unsafe override void AddMovementMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.AddMovementMovesToWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugGiveAllGadgets
    /// </summary>
    public unsafe override void DebugGiveAllGadgets()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.DebugGiveAllGadgets", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddDefaultInventory
    /// </summary>
    public unsafe override void AddDefaultInventory()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.AddDefaultInventory", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInXrayMode
    /// </summary>
    public unsafe virtual void SetInXrayMode(bool On, bool bForceOff)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.SetInXrayMode", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(On, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForceOff, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TakeFallingDamage
    /// </summary>
    public unsafe override void TakeFallingDamage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.TakeFallingDamage", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnPlayerCatwoman.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ObjectProperty: JumpOffVantagePointMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig JumpOffVantagePointMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6148); }
    }

    /// <summary>
    /// ObjectProperty: PounceToCeilingCrouchMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToCeilingCrouchMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6152); }
    }

    /// <summary>
    /// ObjectProperty: PounceToCeilingStandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceToCeilingStandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6156); }
    }

    /// <summary>
    /// ObjectProperty: DropFromCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DropFromCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6160); }
    }

    /// <summary>
    /// ObjectProperty: CeilingToDangleMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CeilingToDangleMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6164); }
    }

    /// <summary>
    /// ObjectProperty: DangleToCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig DangleToCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6168); }
    }

    /// <summary>
    /// ObjectProperty: HitAndDropFromCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig HitAndDropFromCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6172); }
    }

    /// <summary>
    /// ObjectProperty: VentCrouchToCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig VentCrouchToCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6176); }
    }

    /// <summary>
    /// ObjectProperty: VentCeilingToCrouchMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig VentCeilingToCrouchMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6180); }
    }

    /// <summary>
    /// ObjectProperty: CatwalkToCeilingRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CatwalkToCeilingRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6184); }
    }

    /// <summary>
    /// ObjectProperty: CatwalkToCeilingStandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CatwalkToCeilingStandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6188); }
    }

    /// <summary>
    /// ObjectProperty: CatwalkToCeilingEdgeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CatwalkToCeilingEdgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6192); }
    }

    /// <summary>
    /// ObjectProperty: CatwalkToCeilingFarMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CatwalkToCeilingFarMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6196); }
    }

    /// <summary>
    /// ObjectProperty: CeilingToCatwalkRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CeilingToCatwalkRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6200); }
    }

    /// <summary>
    /// ObjectProperty: CeilingToCatwalkEdgeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CeilingToCatwalkEdgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6204); }
    }

    /// <summary>
    /// ObjectProperty: CeilingFarToCatwalkRailingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig CeilingFarToCatwalkRailingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6208); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6208); }
    }

    /// <summary>
    /// ObjectProperty: PounceOnThugFromEdgeMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceOnThugFromEdgeMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6212); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6212); }
    }

    /// <summary>
    /// ObjectProperty: PounceOnThugFromVantageMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceOnThugFromVantageMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6216); }
    }

    /// <summary>
    /// ObjectProperty: PounceOffVantageLandMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceOffVantageLandMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6220); }
    }

    /// <summary>
    /// ObjectProperty: PounceOffVantageFallMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PounceOffVantageFallMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6224); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6224); }
    }

    /// <summary>
    /// ObjectProperty: JumpForwardMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig JumpForwardMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6228); }
    }

    /// <summary>
    /// ObjectProperty: PickPocketMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig PickPocketMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6232); }
    }

    /// <summary>
    /// ObjectProperty: GrateToCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrateToCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6236); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6236); }
    }

    /// <summary>
    /// ObjectProperty: GrateFromCeilingMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig GrateFromCeilingMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6240); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6240); }
    }

    /// <summary>
    /// ObjectProperty: ShortSwingToWallHitMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfig ShortSwingToWallHitMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfig>(Ptr + 6244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6244); }
    }

    /// <summary>
    /// StructProperty: OldCeilingTracePosition
    /// </summary>
    public unsafe ref System.Numerics.Vector3 OldCeilingTracePosition
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 6248);

    /// <summary>
    /// ObjectProperty: PounceLandFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem PounceLandFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6260); }
    }

    /// <summary>
    /// ObjectProperty: PounceHardLandFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem PounceHardLandFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 6264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6264); }
    }

    /// <summary>
    /// BoolProperty: bDebugForceInterrogation
    /// </summary>
    public unsafe bool bDebugForceInterrogation
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6268) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6268); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6268); }
    }

    /// <summary>
    /// BoolProperty: bAllowDeathCoughSpeech
    /// </summary>
    public unsafe bool bAllowDeathCoughSpeech
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6268) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6268); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6268); }
    }

    /// <summary>
    /// BoolProperty: bDieOnCeilingsOnly
    /// </summary>
    public unsafe bool bDieOnCeilingsOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6268) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6268); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6268); }
    }

    /// <summary>
    /// BoolProperty: bForceInstantDeath
    /// </summary>
    public unsafe bool bForceInstantDeath
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6268) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 6268); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 6268); }
    }

    /// <summary>
    /// StructProperty: CoughTransition
    /// </summary>
    public unsafe ref BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId CoughTransition
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(Ptr + 6272);

    /// <summary>
    /// ArrayProperty: SkinMaterials
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant> SkinMaterials
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MaterialInstanceConstant>>(Ptr + 6276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6276); }
    }

    /// <summary>
    /// NameProperty: OWBrightnessMaterialParameterName
    /// </summary>
    public unsafe BmSDK.FName OWBrightnessMaterialParameterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 6288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6288); }
    }

    /// <summary>
    /// FloatProperty: BrightnessIndoors
    /// </summary>
    public unsafe float BrightnessIndoors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6296); }
    }

    /// <summary>
    /// FloatProperty: BrightnessOutdoors
    /// </summary>
    public unsafe float BrightnessOutdoors
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 6300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6300); }
    }

    /// <summary>
    /// ObjectProperty: HairMaterialInst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HairMaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6304); }
    }

    /// <summary>
    /// ObjectProperty: HairCWC1MaterialInst
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant HairCWC1MaterialInst
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 6308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 6308); }
    }

    /// <summary>
    /// Enum: ECatwomanGadgetList
    /// </summary>
    public enum ECatwomanGadgetList : byte
    {
        CWGL_BullWhip = 0,
        CWGL_Bolas = 1,
        CWGL_Caltrops = 2,
        CWGL_BullWhipCombatDisarm = 3,
        CWGL_MAX = 4,
    }
}
