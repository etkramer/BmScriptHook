#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmScript;

/// <summary>
/// Class: RPawnVillainFreeze<br/>
/// (size = 4188)
/// (flags = 10485814)
/// </summary>
public partial class RPawnVillainFreeze : BmSDK.BmGame.RPawnVillainFreezeBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmScript.RPawnVillainFreeze", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnVillainFreeze.
    /// </summary>
    public static RPawnVillainFreeze DefaultObject => (RPawnVillainFreeze)StaticClass().DefaultObject;

    internal RPawnVillainFreeze() { }

    /// <summary>
    /// Constructs a new RPawnVillainFreeze
    /// </summary>
    public RPawnVillainFreeze(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnVillainFreeze(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreeze>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreeze>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreeze>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreeze>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreeze>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreeze>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreeze>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnVillainFreeze>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: FireRailsTargetSequenceEvent
    /// </summary>
    public unsafe virtual bool FireRailsTargetSequenceEvent(BmSDK.BmScript.RFreezeEnvironmentTarget RailsTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FireRailsTargetSequenceEvent", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RailsTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: FireIceMeshSequenceEvent
    /// </summary>
    public unsafe virtual bool FireIceMeshSequenceEvent(BmSDK.BmScript.RFreezeDynamicSMIceFormation IceMesh)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FireIceMeshSequenceEvent", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IceMesh, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: FireSequenceEvent
    /// </summary>
    public unsafe virtual void FireSequenceEvent(BmSDK.Class InEventClass)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FireSequenceEvent", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InEventClass, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinishFinalBeatdownSequence
    /// </summary>
    public unsafe virtual void FinishFinalBeatdownSequence()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FinishFinalBeatdownSequence", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetParameterInterference
    /// </summary>
    public unsafe override BmSDK.Engine.AkParameterName GetParameterInterference()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GetParameterInterference", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetParameterAngle
    /// </summary>
    public unsafe override BmSDK.Engine.AkParameterName GetParameterAngle()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GetParameterAngle", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkParameterName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShouldAutoClimbAfterGrapple
    /// </summary>
    public unsafe override bool ShouldAutoClimbAfterGrapple(System.Numerics.Vector3 ClimbLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ShouldAutoClimbAfterGrapple", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClimbLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: FinishBackscreenDownloadTimer
    /// </summary>
    public unsafe virtual void FinishBackscreenDownloadTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FinishBackscreenDownloadTimer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartBackscreenDownloadTimer
    /// </summary>
    public unsafe virtual void StartBackscreenDownloadTimer(float TimerDuration)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.StartBackscreenDownloadTimer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimerDuration, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanOpenBackScreen
    /// </summary>
    public unsafe override bool CanOpenBackScreen()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CanOpenBackScreen", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ReachedRageBeatdownPosition
    /// </summary>
    public unsafe virtual void ReachedRageBeatdownPosition()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ReachedRageBeatdownPosition", true);
        byte* paramsPtr = stackalloc byte[112];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinalStrikeLoseHealth
    /// </summary>
    public unsafe virtual void FinalStrikeLoseHealth()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FinalStrikeLoseHealth", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FinalStrikeShake
    /// </summary>
    public unsafe virtual void FinalStrikeShake()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FinalStrikeShake", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GeneralStrikeShake
    /// </summary>
    public unsafe virtual void GeneralStrikeShake()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GeneralStrikeShake", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BareFaceStrike
    /// </summary>
    public unsafe virtual void BareFaceStrike()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.BareFaceStrike", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactBatmanBone
    /// </summary>
    public unsafe virtual void ImpactBatmanBone(BmSDK.FName BatmanBone)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ImpactBatmanBone", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanBone, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactKneeRight
    /// </summary>
    public unsafe virtual void ImpactKneeRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ImpactKneeRight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactKneeLeft
    /// </summary>
    public unsafe virtual void ImpactKneeLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ImpactKneeLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactElbowRight
    /// </summary>
    public unsafe virtual void ImpactElbowRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ImpactElbowRight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactElbowLeft
    /// </summary>
    public unsafe virtual void ImpactElbowLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ImpactElbowLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactFootRight
    /// </summary>
    public unsafe virtual void ImpactFootRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ImpactFootRight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactFootLeft
    /// </summary>
    public unsafe virtual void ImpactFootLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ImpactFootLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactFistRight
    /// </summary>
    public unsafe virtual void ImpactFistRight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ImpactFistRight", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactFistLeft
    /// </summary>
    public unsafe virtual void ImpactFistLeft()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ImpactFistLeft", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactFace
    /// </summary>
    public unsafe virtual void ImpactFace()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ImpactFace", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ImpactFaceInternal
    /// </summary>
    public unsafe virtual void ImpactFaceInternal(bool IsFinisher)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ImpactFaceInternal", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsFinisher, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShakeHealthBar
    /// </summary>
    public unsafe virtual void ShakeHealthBar()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ShakeHealthBar", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SmashVisor
    /// </summary>
    public unsafe virtual void SmashVisor()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SmashVisor", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetFootSparksActive
    /// </summary>
    public unsafe virtual void SetFootSparksActive(bool make_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetFootSparksActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(make_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetIceCrystalsActive
    /// </summary>
    public unsafe virtual void SetIceCrystalsActive(bool make_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetIceCrystalsActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(make_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetInvulnerableShieldActive
    /// </summary>
    public unsafe virtual void SetInvulnerableShieldActive(bool is_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetInvulnerableShieldActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetBossTakedown
    /// </summary>
    public unsafe override BmSDK.Class GetBossTakedown(BmSDK.BmGame.RPawnPlayer.EStealthTakeDownStages takedown_stage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GetBossTakedown", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown_stage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: DrawDebugGraphics
    /// </summary>
    public unsafe override void DrawDebugGraphics()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.DrawDebugGraphics", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateBatmansFreezeSpecificWeaponConfig
    /// </summary>
    public unsafe virtual void CreateBatmansFreezeSpecificWeaponConfig(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CreateBatmansFreezeSpecificWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[284];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateCombatWeaponConfigFreeze
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateCombatWeaponConfigFreeze(BmSDK.GameObject NewOwner, BmSDK.Engine.AnimSet Anims1, BmSDK.Engine.AnimSet Anims2, BmSDK.Engine.AnimSet Anims3, BmSDK.Engine.AnimSet Anims4, BmSDK.Engine.AnimSet Anims5)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CreateCombatWeaponConfigFreeze", true);
        byte* paramsPtr = stackalloc byte[5752];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anims1, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anims2, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anims3, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anims4, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Anims5, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: SetLegYawOnPose
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPoseConfig.FPose SetLegYawOnPose(BmSDK.BmGame.RPoseConfig.FPose InPose)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetLegYawOnPose", true);
        byte* paramsPtr = stackalloc byte[680];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InPose, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 340);
    }

    /// <summary>
    /// Function: ShouldFreezeBlastDoDamage
    /// </summary>
    public unsafe virtual bool ShouldFreezeBlastDoDamage()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ShouldFreezeBlastDoDamage", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: NotifyNoraStatueDestroyed
    /// </summary>
    public unsafe virtual void NotifyNoraStatueDestroyed(bool bDestroyedByFreeze, System.Numerics.Vector3 StatueLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.NotifyNoraStatueDestroyed", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bDestroyedByFreeze, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StatueLocation, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DroneKeepAliveCountdown
    /// </summary>
    public unsafe virtual void DroneKeepAliveCountdown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.DroneKeepAliveCountdown", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DroneKeepAliveTick
    /// </summary>
    public unsafe virtual void DroneKeepAliveTick()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.DroneKeepAliveTick", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyDroneFoundBatman
    /// </summary>
    public unsafe virtual void NotifyDroneFoundBatman(bool bWasDestroyed)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.NotifyDroneFoundBatman", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasDestroyed, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyBatmanEntersOrLeavesHighBoxVolume
    /// </summary>
    public unsafe virtual void NotifyBatmanEntersOrLeavesHighBoxVolume(bool is_entering)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.NotifyBatmanEntersOrLeavesHighBoxVolume", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_entering, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FreezeNoticesTakedown
    /// </summary>
    public unsafe virtual void FreezeNoticesTakedown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FreezeNoticesTakedown", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BatmanBumped
    /// </summary>
    public unsafe virtual void BatmanBumped()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.BatmanBumped", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CollisionWith
    /// </summary>
    public unsafe override void CollisionWith(BmSDK.BmGame.RPawnCombat OtherPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CollisionWith", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Bump
    /// </summary>
    public unsafe override void Bump(BmSDK.Engine.Actor Other, BmSDK.Engine.PrimitiveComponent OtherComp, System.Numerics.Vector3 HitNormal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.Bump", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OtherComp, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitNormal, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateWeaponConfigUnarmed
    /// </summary>
    public unsafe override BmSDK.BmGame.RWeaponConfig CreateWeaponConfigUnarmed(BmSDK.GameObject NewOwner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CreateWeaponConfigUnarmed", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewOwner, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsValidForStrike
    /// </summary>
    public unsafe virtual bool IsValidForStrike(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.BmGame.RPawnCombat TestPawn, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsValidForStrike", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestPawn, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SetFogProportion
    /// </summary>
    public unsafe virtual void SetFogProportion(float proportion_to_set)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetFogProportion", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(proportion_to_set, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TickFog
    /// </summary>
    public unsafe virtual void TickFog(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TickFog", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RollInFog
    /// </summary>
    public unsafe virtual void RollInFog(float TargetLevel, float FogChangeDuration = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.RollInFog", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetLevel, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FogChangeDuration, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TickRepelAttack
    /// </summary>
    public unsafe virtual void TickRepelAttack(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TickRepelAttack", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RepelBatman
    /// </summary>
    public unsafe virtual void RepelBatman(System.Numerics.Vector3 RepelOrigin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.RepelBatman", true);
        byte* paramsPtr = stackalloc byte[144];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RepelOrigin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HasRepelLineOfSight
    /// </summary>
    public unsafe virtual bool HasRepelLineOfSight()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.HasRepelLineOfSight", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SpawnEmpEffectAtLocation
    /// </summary>
    public unsafe virtual void SpawnEmpEffectAtLocation(System.Numerics.Vector3 EffectLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SpawnEmpEffectAtLocation", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EffectLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldSpawnEffect
    /// </summary>
    public unsafe virtual bool ShouldSpawnEffect(float previous_radius, float actor_distance)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ShouldSpawnEffect", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(previous_radius, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(actor_distance, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TickEmpEffect
    /// </summary>
    public unsafe virtual void TickEmpEffect(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TickEmpEffect", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SortElecticalActors
    /// </summary>
    public unsafe virtual void SortElecticalActors()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SortElecticalActors", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitialiseEmpEffect
    /// </summary>
    public unsafe virtual void InitialiseEmpEffect()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.InitialiseEmpEffect", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitialiseRearFacingRepel
    /// </summary>
    public unsafe virtual void InitialiseRearFacingRepel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.InitialiseRearFacingRepel", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitialiseRepelAttack
    /// </summary>
    public unsafe virtual void InitialiseRepelAttack(bool large_scale)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.InitialiseRepelAttack", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(large_scale, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsVulnerableToTakedown
    /// </summary>
    public unsafe override bool IsVulnerableToTakedown(BmSDK.FString takedown)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsVulnerableToTakedown", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: IsAwareOfPlayer
    /// </summary>
    public unsafe override bool IsAwareOfPlayer(BmSDK.BmGame.RPawnPlayer PlayerPawn, BmSDK.Class dmgType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsAwareOfPlayer", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: IsVulnerableToPawn
    /// </summary>
    public unsafe override bool IsVulnerableToPawn(BmSDK.BmGame.RPawnCombat Attacker)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsVulnerableToPawn", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: HitByJammerGadgetCharge
    /// </summary>
    public unsafe override void HitByJammerGadgetCharge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.HitByJammerGadgetCharge", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsVulnerableToJammerGadget
    /// </summary>
    public unsafe override bool IsVulnerableToJammerGadget()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsVulnerableToJammerGadget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsOutside
    /// </summary>
    public unsafe virtual bool IsOutside()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsOutside", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsVulnerableToBossStrike
    /// </summary>
    public unsafe override bool IsVulnerableToBossStrike()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsVulnerableToBossStrike", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsVulnerableToStunStrike
    /// </summary>
    public unsafe override bool IsVulnerableToStunStrike()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsVulnerableToStunStrike", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: InvulnerableWhileSliding
    /// </summary>
    public unsafe virtual void InvulnerableWhileSliding()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.InvulnerableWhileSliding", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MakeInvulnerableWhileSliding
    /// </summary>
    public unsafe virtual void MakeInvulnerableWhileSliding(float SlideDuration)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.MakeInvulnerableWhileSliding", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlideDuration, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanRepelAttack
    /// </summary>
    public unsafe override bool CanRepelAttack(BmSDK.BmGame.RPawnCombat Attacker, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CanRepelAttack", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Attacker, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: TakeRageStrike
    /// </summary>
    public unsafe virtual void TakeRageStrike(float RageAnimScale, float ClipFront, float MeetingPoint = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TakeRageStrike", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RageAnimScale, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClipFront, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MeetingPoint, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TakeBossStrikeWhileExhausted
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId TakeBossStrikeWhileExhausted(System.Numerics.Vector3 vBMtoFreeze, bool final_strike, ref System.Numerics.Vector3 AttackLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TakeBossStrikeWhileExhausted", true);
        byte* paramsPtr = stackalloc byte[96];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(vBMtoFreeze, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(final_strike, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AttackLocation, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        AttackLocation = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: GetRandomBeatDownReaction
    /// </summary>
    public unsafe virtual BmSDK.FName GetRandomBeatDownReaction()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GetRandomBeatDownReaction", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: TickMagneticBlast
    /// </summary>
    public unsafe override void TickMagneticBlast(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TickMagneticBlast", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TranslateToPosition
    /// </summary>
    public unsafe virtual void TranslateToPosition(System.Numerics.Vector3 target_position)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TranslateToPosition", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(target_position, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartHitWall
    /// </summary>
    public unsafe virtual void StartHitWall(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedAnimID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.StartHitWall", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartFlyBackwards
    /// </summary>
    public unsafe virtual void StartFlyBackwards(BmSDK.BmGame.RAnimUtil_PosePlayer.FTransitionId QueuedAnimID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.StartFlyBackwards", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(QueuedAnimID, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetMagBlastPhase
    /// </summary>
    public unsafe virtual void SetMagBlastPhase(BmSDK.BmScript.RPawnVillainFreeze.MagneticBlastPhase new_phase)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetMagBlastPhase", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_phase, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindMagBlastFlightTime
    /// </summary>
    public unsafe virtual void FindMagBlastFlightTime()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FindMagBlastFlightTime", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoMagneticBlastAttract
    /// </summary>
    public unsafe override void DoMagneticBlastAttract(System.Numerics.Vector3 magnet_source, BmSDK.Rotator wall_normal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.DoMagneticBlastAttract", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(magnet_source, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(wall_normal, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetMagneticBlastDuration
    /// </summary>
    public unsafe override float GetMagneticBlastDuration()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GetMagneticBlastDuration", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DoRecoilAnimationSeekers
    /// </summary>
    public unsafe virtual void DoRecoilAnimationSeekers()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.DoRecoilAnimationSeekers", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoRecoilAnimationGrenade
    /// </summary>
    public unsafe virtual void DoRecoilAnimationGrenade()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.DoRecoilAnimationGrenade", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoRecoilAnimationFreezeBeam
    /// </summary>
    public unsafe virtual void DoRecoilAnimationFreezeBeam()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.DoRecoilAnimationFreezeBeam", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoLookAround
    /// </summary>
    public unsafe virtual void DoLookAround()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.DoLookAround", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoKnockDownInternal
    /// </summary>
    public unsafe virtual void DoKnockDownInternal(System.Numerics.Vector3 offender_origin, bool power_takedown, bool FromAbove = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.DoKnockDownInternal", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(offender_origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(power_takedown, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FromAbove, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RespondToLineLauncher
    /// </summary>
    public unsafe override void RespondToLineLauncher(System.Numerics.Vector3 batmans_position, bool be_knocked_down)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.RespondToLineLauncher", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(batmans_position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(be_knocked_down, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: KickedByBatman
    /// </summary>
    public unsafe override void KickedByBatman(System.Numerics.Vector3 batman_origin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.KickedByBatman", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(batman_origin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HitWithGooMineEnhanced
    /// </summary>
    public unsafe override void HitWithGooMineEnhanced(System.Numerics.Vector3 goo_origin, bool is_glass)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.HitWithGooMineEnhanced", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(goo_origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_glass, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BossCanTakeGooHit
    /// </summary>
    public unsafe override bool BossCanTakeGooHit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.BossCanTakeGooHit", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DamagedBy
    /// </summary>
    public unsafe override BmSDK.BmGame.RPawnCombat.DamageResult DamagedBy(BmSDK.BmGame.RPawnCombat.FDamageInfo DmgInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.DamagedBy", true);
        byte* paramsPtr = stackalloc byte[245];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DmgInfo, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnCombat.DamageResult>(paramsPtr + 244);
    }

    /// <summary>
    /// Function: LightStun
    /// </summary>
    public unsafe virtual void LightStun(System.Numerics.Vector3 offender_origin, bool alert_to_position)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.LightStun", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(offender_origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(alert_to_position, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HitByFreezeCluster
    /// </summary>
    public unsafe override void HitByFreezeCluster(System.Numerics.Vector3 ClusterLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.HitByFreezeCluster", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClusterLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HitByFreezeBlast
    /// </summary>
    public unsafe override void HitByFreezeBlast()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.HitByFreezeBlast", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OverrideHarpoonHit
    /// </summary>
    public unsafe override bool OverrideHarpoonHit(BmSDK.BmGame.RPawnPlayer PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.OverrideHarpoonHit", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: StunPush
    /// </summary>
    public unsafe override bool StunPush(System.Numerics.Vector3 goo_origin, float OrientationProportion = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.StunPush", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(goo_origin, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrientationProportion, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: StunPull
    /// </summary>
    public unsafe override bool StunPull(System.Numerics.Vector3 harpoon_origin)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.StunPull", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(harpoon_origin, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: OrientAndAnimate
    /// </summary>
    public unsafe virtual void OrientAndAnimate(System.Numerics.Vector3 object_position, BmSDK.FName animation_if_object_in_front, BmSDK.FName animation_if_object_behind, BmSDK.FName MovementStance, BmSDK.FName WeaponStance, float TransitionMeetingPoint, float OrientationProportion = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.OrientAndAnimate", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(object_position, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(animation_if_object_in_front, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(animation_if_object_behind, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementStance, paramsPtr + 28);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponStance, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TransitionMeetingPoint, paramsPtr + 44);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OrientationProportion, paramsPtr + 48);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSourceDirection
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RPawnVillainFreeze.SourceDirection GetSourceDirection(System.Numerics.Vector3 Source)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GetSourceDirection", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Source, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnVillainFreeze.SourceDirection>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: IsToLeft
    /// </summary>
    public unsafe virtual bool IsToLeft(System.Numerics.Vector3 Source)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsToLeft", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Source, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: IsInFront
    /// </summary>
    public unsafe virtual bool IsInFront(System.Numerics.Vector3 Source, float angle_radians = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsInFront", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Source, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(angle_radians, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: StunReciprocalPeriod
    /// </summary>
    public unsafe virtual void StunReciprocalPeriod()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.StunReciprocalPeriod", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartStunReciprocalTimer
    /// </summary>
    public unsafe virtual void StartStunReciprocalTimer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.StartStunReciprocalTimer", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsStunReciprocalActive
    /// </summary>
    public unsafe virtual bool IsStunReciprocalActive()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsStunReciprocalActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CanBeKnockedDown
    /// </summary>
    public unsafe override bool CanBeKnockedDown(BmSDK.FString takedown = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CanBeKnockedDown", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(takedown, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: JammerGadgetMuzzleEffect
    /// </summary>
    public unsafe virtual void JammerGadgetMuzzleEffect()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.JammerGadgetMuzzleEffect", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: JammerGadgetKnockDown
    /// </summary>
    public unsafe virtual void JammerGadgetKnockDown()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.JammerGadgetKnockDown", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Electrify
    /// </summary>
    public unsafe override void Electrify()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.Electrify", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForceDisarm
    /// </summary>
    public unsafe override void ForceDisarm()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ForceDisarm", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Disarm
    /// </summary>
    public unsafe override void Disarm()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.Disarm", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnSpecialAttack
    /// </summary>
    public unsafe override bool SpawnSpecialAttack(BmSDK.BmGame.RPawnPlayerCombat PlayerPawn, BmSDK.Class dmgType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SpawnSpecialAttack", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(dmgType, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CanBeHitInCombat
    /// </summary>
    public unsafe override bool CanBeHitInCombat(BmSDK.BmGame.RDamageType DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CanBeHitInCombat", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetBehaviour
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RBMBehaviour_Freeze GetBehaviour()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GetBehaviour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RBMBehaviour_Freeze>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SonicBatarangKill
    /// </summary>
    public unsafe override void SonicBatarangKill()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SonicBatarangKill", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanBatmanGrab
    /// </summary>
    public unsafe override BmSDK.BmGame.RBMAIController.BatmanGrabType CanBatmanGrab()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CanBatmanGrab", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIController.BatmanGrabType>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsBoss
    /// </summary>
    public unsafe override bool IsBoss()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsBoss", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: StopFreezeSound
    /// </summary>
    public unsafe virtual void StopFreezeSound(BmSDK.BmScript.RPawnVillainFreeze.FreezeSounds the_sound)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.StopFreezeSound", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_sound, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayFreezeSound
    /// </summary>
    public unsafe virtual void PlayFreezeSound(BmSDK.BmScript.RPawnVillainFreeze.FreezeSounds the_sound)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.PlayFreezeSound", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_sound, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetTelemetryWarningActive
    /// </summary>
    public unsafe virtual void SetTelemetryWarningActive(bool is_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetTelemetryWarningActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetRoomFreezeExhaustActive
    /// </summary>
    public unsafe virtual void SetRoomFreezeExhaustActive(bool is_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetRoomFreezeExhaustActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TickMovingBits
    /// </summary>
    public unsafe virtual void TickMovingBits(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TickMovingBits", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TickSuitPulse
    /// </summary>
    public unsafe virtual void TickSuitPulse(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TickSuitPulse", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSuitPulse
    /// </summary>
    public unsafe virtual void SetSuitPulse(float Frequency)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetSuitPulse", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Frequency, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsPointNearLaser
    /// </summary>
    public unsafe virtual bool IsPointNearLaser(System.Numerics.Vector3 the_point)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsPointNearLaser", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(the_point, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: TickLasers
    /// </summary>
    public unsafe virtual void TickLasers(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TickLasers", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetLasersActive
    /// </summary>
    public unsafe virtual void SetLasersActive(bool lasers_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetLasersActive", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(lasers_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetLampState
    /// </summary>
    public unsafe virtual void SetLampState(BmSDK.BmScript.RPawnVillainFreeze.FreezeLampState lamp_state)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetLampState", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(lamp_state, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SpawnImpactEffect
    /// </summary>
    public unsafe virtual void SpawnImpactEffect(System.Numerics.Vector3 ImpactLocation, BmSDK.Rotator ImpactRotation, bool IsFinisher)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SpawnImpactEffect", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ImpactRotation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IsFinisher, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetGlassBrokenStage
    /// </summary>
    public unsafe virtual void SetGlassBrokenStage(float new_stage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetGlassBrokenStage", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(new_stage, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetLampColour
    /// </summary>
    public unsafe virtual void SetLampColour(float colR, float colG, float colB)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetLampColour", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(colR, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(colG, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(colB, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetTimeSinceLastVocal
    /// </summary>
    public unsafe virtual float GetTimeSinceLastVocal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GetTimeSinceLastVocal", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SuspendBehaviour
    /// </summary>
    public unsafe override void SuspendBehaviour(bool OnlyIfNoVisualContact = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SuspendBehaviour", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OnlyIfNoVisualContact, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetDialogueTimeStamp
    /// </summary>
    public unsafe virtual void ResetDialogueTimeStamp()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ResetDialogueTimeStamp", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindClearPointNearLocation
    /// </summary>
    public unsafe virtual bool FindClearPointNearLocation(System.Numerics.Vector3 TheLocation, ref System.Numerics.Vector3 ClearPoint)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FindClearPointNearLocation", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TheLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClearPoint, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ClearPoint = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: IsLocationClear
    /// </summary>
    public unsafe virtual bool IsLocationClear(System.Numerics.Vector3 TestLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsLocationClear", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: IsDirectionClear
    /// </summary>
    public unsafe virtual bool IsDirectionClear(BmSDK.Rotator TestDirection, float DistanceToTest = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsDirectionClear", true);
        byte* paramsPtr = stackalloc byte[56];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDirection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DistanceToTest, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetBestArrayDirection
    /// </summary>
    public unsafe virtual float GetBestArrayDirection(ref BmSDK.TArray<int> DirectionClearArray)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GetBestArrayDirection", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DirectionClearArray, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DirectionClearArray = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SampleAreaAndFindSafeDirection
    /// </summary>
    public unsafe virtual void SampleAreaAndFindSafeDirection()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SampleAreaAndFindSafeDirection", true);
        byte* paramsPtr = stackalloc byte[68];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ArrayDirectionToYaw
    /// </summary>
    public unsafe virtual int ArrayDirectionToYaw(float ArrayDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ArrayDirectionToYaw", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayDirection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsArrayRangeClear
    /// </summary>
    public unsafe virtual bool IsArrayRangeClear(ref BmSDK.TArray<int> DirectionClearArray, int TestDirIndex, BmSDK.Rotator CurrentViewDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsArrayRangeClear", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DirectionClearArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDirIndex, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentViewDirection, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DirectionClearArray = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: TestArrayDirection
    /// </summary>
    public unsafe virtual bool TestArrayDirection(ref BmSDK.TArray<int> DirectionClearArray, int ArrayDirection, BmSDK.Rotator CurrentViewDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TestArrayDirection", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DirectionClearArray, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayDirection, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentViewDirection, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        DirectionClearArray = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: ArrayDirectionToDegrees
    /// </summary>
    public unsafe virtual int ArrayDirectionToDegrees(float ArrayDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ArrayDirectionToDegrees", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayDirection, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsArrayDirectionClear
    /// </summary>
    public unsafe virtual bool IsArrayDirectionClear(int ArrayDirection, BmSDK.Rotator CurrentViewDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsArrayDirectionClear", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayDirection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentViewDirection, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: FallTowardsClearArea
    /// </summary>
    public unsafe virtual void FallTowardsClearArea()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FallTowardsClearArea", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckForObstaclesAtEndOfSlide
    /// </summary>
    public unsafe virtual void CheckForObstaclesAtEndOfSlide()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CheckForObstaclesAtEndOfSlide", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FallToEndOfSlope
    /// </summary>
    public unsafe virtual void FallToEndOfSlope(BmSDK.BmScript.RFreezeSlipperySlopeVolume SlipperySlopeVolume)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FallToEndOfSlope", true);
        byte* paramsPtr = stackalloc byte[84];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SlipperySlopeVolume, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckLeftAndRightForObstacles
    /// </summary>
    public unsafe virtual void CheckLeftAndRightForObstacles(bool CheckLeft, bool CheckRight, BmSDK.Rotator FinalFacingDirection)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CheckLeftAndRightForObstacles", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckLeft, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CheckRight, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinalFacingDirection, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckForObstaclesWithPlusMinusOffset
    /// </summary>
    public unsafe virtual bool CheckForObstaclesWithPlusMinusOffset(BmSDK.Rotator FinalFacingDirection, int YawOffset, int PlusMinus)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CheckForObstaclesWithPlusMinusOffset", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FinalFacingDirection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YawOffset, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlusMinus, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: IsDirectionOffsetClear
    /// </summary>
    public unsafe virtual bool IsDirectionOffsetClear(BmSDK.Rotator TestDirection, int YawOffset)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsDirectionOffsetClear", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestDirection, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(YawOffset, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: TurnToFaceClearArea
    /// </summary>
    public unsafe virtual void TurnToFaceClearArea(int ClearFacingYaw, float TurnDuration = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TurnToFaceClearArea", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ClearFacingYaw, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TurnDuration, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetTurnToFaceMeetingPointEnd
    /// </summary>
    public unsafe virtual float GetTurnToFaceMeetingPointEnd(float current_proportion, float total_duration, float requested_turn_duration)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GetTurnToFaceMeetingPointEnd", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(current_proportion, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(total_duration, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(requested_turn_duration, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetCurrentSlipperySlope
    /// </summary>
    public unsafe virtual BmSDK.BmScript.RFreezeSlipperySlopeVolume GetCurrentSlipperySlope()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GetCurrentSlipperySlope", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RFreezeSlipperySlopeVolume>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShouldBatmanUseSomersaultWhenAttackingFrom
    /// </summary>
    public unsafe virtual bool ShouldBatmanUseSomersaultWhenAttackingFrom(System.Numerics.Vector3 BatmanPosition)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ShouldBatmanUseSomersaultWhenAttackingFrom", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BatmanPosition, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: SetFrozenCapeLevel
    /// </summary>
    public unsafe virtual void SetFrozenCapeLevel(float FrozenCapeLevel)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetFrozenCapeLevel", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FrozenCapeLevel, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPropsInXray
    /// </summary>
    public unsafe override void SetPropsInXray(bool bActivate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetPropsInXray", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bActivate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayBatmanSpeechOnceOrInfrequently
    /// </summary>
    public unsafe virtual bool PlayBatmanSpeechOnceOrInfrequently(BmSDK.BmScript.RPawnVillainFreeze.BatmanDialogueLines LineToPlay)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.PlayBatmanSpeechOnceOrInfrequently", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineToPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PlayBatmanSpeech
    /// </summary>
    public unsafe virtual bool PlayBatmanSpeech(BmSDK.BmScript.RPawnVillainFreeze.BatmanDialogueLines LineToPlay, bool ForceInterrupt = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.PlayBatmanSpeech", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineToPlay, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceInterrupt, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: HasPlayedLine
    /// </summary>
    public unsafe virtual bool HasPlayedLine(BmSDK.BmScript.RPawnVillainFreeze.FreezeDialogueLines LineToPlay)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.HasPlayedLine", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineToPlay, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PlayFreezeSpeech
    /// </summary>
    public unsafe virtual bool PlayFreezeSpeech(BmSDK.BmScript.RPawnVillainFreeze.FreezeDialogueLines LineToPlay, bool ForceInterrupt = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.PlayFreezeSpeech", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LineToPlay, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ForceInterrupt, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: CommentObliviouslyOnLineLauncher
    /// </summary>
    public unsafe virtual void CommentObliviouslyOnLineLauncher()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.CommentObliviouslyOnLineLauncher", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShortPauseThenCommentObliviouslyOnLineLauncher
    /// </summary>
    public unsafe virtual void ShortPauseThenCommentObliviouslyOnLineLauncher()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ShortPauseThenCommentObliviouslyOnLineLauncher", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AlertToGadgetNoise
    /// </summary>
    public unsafe virtual void AlertToGadgetNoise()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.AlertToGadgetNoise", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShortPauseThenAlertToGadgetNoise
    /// </summary>
    public unsafe virtual void ShortPauseThenAlertToGadgetNoise()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ShortPauseThenAlertToGadgetNoise", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RefreshLinelauncherAwareness
    /// </summary>
    public unsafe virtual void RefreshLinelauncherAwareness()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.RefreshLinelauncherAwareness", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AlertToLineLauncher
    /// </summary>
    public unsafe virtual void AlertToLineLauncher()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.AlertToLineLauncher", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShortPauseThenAlertToLineLauncher
    /// </summary>
    public unsafe virtual void ShortPauseThenAlertToLineLauncher()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ShortPauseThenAlertToLineLauncher", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BatmanEntersVent
    /// </summary>
    public unsafe override void BatmanEntersVent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.BatmanEntersVent", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AlertToBrokenGlassSound
    /// </summary>
    public unsafe override void AlertToBrokenGlassSound(System.Numerics.Vector3 BreakageLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.AlertToBrokenGlassSound", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(BreakageLocation, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldSeekersSelfDestruct
    /// </summary>
    public unsafe virtual bool ShouldSeekersSelfDestruct()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.ShouldSeekersSelfDestruct", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: BecomeVulnerableAgain
    /// </summary>
    public unsafe virtual void BecomeVulnerableAgain()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.BecomeVulnerableAgain", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsInvulnerable
    /// </summary>
    public unsafe virtual bool IsInvulnerable()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.IsInvulnerable", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PostRecoveryInvulnerablePeriod
    /// </summary>
    public unsafe virtual void PostRecoveryInvulnerablePeriod()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.PostRecoveryInvulnerablePeriod", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BatmanTalksAboutFlawedTactic
    /// </summary>
    public unsafe virtual void BatmanTalksAboutFlawedTactic()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.BatmanTalksAboutFlawedTactic", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PauseThenCommentOnFlawedTactic
    /// </summary>
    public unsafe virtual void PauseThenCommentOnFlawedTactic(BmSDK.BmScript.RPawnVillainFreeze.BatmanDialogueLines FlawDialogue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.PauseThenCommentOnFlawedTactic", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlawDialogue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NoteAndMaybeCommentOnTacticalFlaw
    /// </summary>
    public unsafe virtual void NoteAndMaybeCommentOnTacticalFlaw(BmSDK.BmScript.RPawnVillainFreeze.BatmanDialogueLines FlawDialogue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.NoteAndMaybeCommentOnTacticalFlaw", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlawDialogue, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BatmanTalksAboutIcyLedge
    /// </summary>
    public unsafe virtual void BatmanTalksAboutIcyLedge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.BatmanTalksAboutIcyLedge", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerDropFromIcyLedge
    /// </summary>
    public unsafe override void TriggerDropFromIcyLedge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TriggerDropFromIcyLedge", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BatmanTalksAboutFailedGlide
    /// </summary>
    public unsafe virtual void BatmanTalksAboutFailedGlide()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.BatmanTalksAboutFailedGlide", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayGlideFailAnim
    /// </summary>
    public unsafe virtual void PlayGlideFailAnim()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.PlayGlideFailAnim", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TriggerFailedGlideMove
    /// </summary>
    public unsafe override void TriggerFailedGlideMove(BmSDK.BmGame.RPlayerController RPC, BmSDK.BmGame.RPawnPlayer.FEnvironmentSpecialMoveLocator Loc)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.TriggerFailedGlideMove", true);
        byte* paramsPtr = stackalloc byte[116];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Loc, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindNoraStatues
    /// </summary>
    public unsafe virtual void FindNoraStatues()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FindNoraStatues", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindElecticalDevices
    /// </summary>
    public unsafe virtual void FindElecticalDevices()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FindElecticalDevices", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindFogVolumes
    /// </summary>
    public unsafe virtual void FindFogVolumes()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.FindFogVolumes", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableGrateCollision
    /// </summary>
    public unsafe virtual void EnableGrateCollision()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.EnableGrateCollision", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: KeepFreezeHeadInvisible
    /// </summary>
    public unsafe virtual void KeepFreezeHeadInvisible()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.KeepFreezeHeadInvisible", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetJokerHeadActive
    /// </summary>
    public unsafe virtual void SetJokerHeadActive(bool is_active)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetJokerHeadActive", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(is_active, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitJokerHead
    /// </summary>
    public unsafe virtual void InitJokerHead()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.InitJokerHead", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetBatarangPriority
    /// </summary>
    public unsafe override float GetBatarangPriority()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.GetBatarangPriority", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetVocalsLoaded
    /// </summary>
    public unsafe virtual void SetVocalsLoaded(bool bLoad)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetVocalsLoaded", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bLoad, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetRedEyesParameter
    /// </summary>
    public unsafe virtual void SetRedEyesParameter(float RedEyesParameter)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.SetRedEyesParameter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RedEyesParameter, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Initialise
    /// </summary>
    public unsafe override void Initialise()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmScript.RPawnVillainFreeze.Initialise", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Enum: BatmanDialogueLines
    /// </summary>
    public enum BatmanDialogueLines : byte
    {
        BDL_FailedGlide = 0,
        BDL_DropFromFrozen = 1,
        BDL_HeadOnWarning = 2,
        BDL_RepeatTacticWarning = 3,
        BDL_BatmanSpottedWarning = 4,
        BDL_MAX = 5,
    }

    /// <summary>
    /// Enum: FreezeDialogueLines
    /// </summary>
    public enum FreezeDialogueLines : byte
    {
        FDL_SpotBatman = 0,
        FDL_HearBatman = 1,
        FDL_HearLineLauncher = 2,
        FDL_RecogniseSound = 3,
        FDL_FireSeekers = 4,
        FDL_FireFreezeBeam = 5,
        FDL_FireGrenadeDirect = 6,
        FDL_FireGrenadeBlind = 7,
        FDL_ReachedEndOfTrail = 8,
        FDL_FindFootprintTrail = 9,
        FDL_BatmanSmashedSculpture = 10,
        FDL_FreezeSmashedSculpture = 11,
        FDL_NoticedWalkingInCircles = 12,
        FDL_TauntWhenVisualContact = 13,
        FDL_TauntWithoutVisualContact = 14,
        FDL_FailedSilentTakedown = 15,
        FDL_FailedWeaponJamming = 16,
        FDL_TakedownReaction = 17,
        FDL_WeaponJammingReaction = 18,
        FDL_DisableDetectiveMode = 19,
        FDL_DisableGlideKick = 20,
        FDL_DestroyGeneric = 21,
        FDL_NeutraliseGeneric = 22,
        FDL_NeutraliseWindow = 23,
        FDL_NeverAgainTauntSilentTakedown = 24,
        FDL_NeverAgainTauntMagblast = 25,
        FDL_NeverAgainTauntLineLauncher = 26,
        FDL_NeverAgainTauntGeneric = 27,
        FDL_SeekerDestroyed = 28,
        FDL_SeekerFindsBatman = 29,
        FDL_MAX = 30,
    }

    /// <summary>
    /// Enum: FreezeSounds
    /// </summary>
    public enum FreezeSounds : byte
    {
        FS_RepelWarning = 0,
        FS_RepelActivated = 1,
        FS_FreezeBeam = 2,
        FS_GrenadeLaunch = 3,
        FS_SeekerLaunch = 4,
        FS_HeatTracking = 5,
        FS_MAX = 6,
    }

    /// <summary>
    /// Enum: FreezeLampState
    /// </summary>
    public enum FreezeLampState : byte
    {
        FLS_INITIAL = 0,
        FLS_OFF = 1,
        FLS_LASERS_ACTIVE = 2,
        FLS_VISUAL_CONTACT = 3,
        FLS_MOVING_BLIND = 4,
        FlS_MAX = 5,
    }

    /// <summary>
    /// Enum: MagneticBlastPhase
    /// </summary>
    public enum MagneticBlastPhase : byte
    {
        MBP_STRUGGLE = 0,
        MBP_FLY_BACKWARDS = 1,
        MBP_HIT_WALL_AND_FALL_FORWARDS = 2,
        MBP_MAX = 3,
    }

    /// <summary>
    /// Enum: SourceDirection
    /// </summary>
    public enum SourceDirection : byte
    {
        SD_Front = 0,
        SD_Right = 1,
        SD_Back = 2,
        SD_Left = 3,
        SD_MAX = 4,
    }

    /// <summary>
    /// StructProperty: CachedBeatdownFacing
    /// </summary>
    public unsafe ref System.Numerics.Vector3 CachedBeatdownFacing
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3600);

    /// <summary>
    /// ObjectProperty: Batman
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController Batman
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 3612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3612); }
    }

    /// <summary>
    /// StructProperty: magnetic_blast_origin
    /// </summary>
    public unsafe ref System.Numerics.Vector3 magnetic_blast_origin
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3616);

    /// <summary>
    /// StructProperty: magnetic_blast_target
    /// </summary>
    public unsafe ref System.Numerics.Vector3 magnetic_blast_target
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3628);

    /// <summary>
    /// ByteProperty: magnetic_blast_phase
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnVillainFreeze.MagneticBlastPhase magnetic_blast_phase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnVillainFreeze.MagneticBlastPhase>(Ptr + 3640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3640); }
    }

    /// <summary>
    /// ByteProperty: CurrentLampState
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnVillainFreeze.FreezeLampState CurrentLampState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnVillainFreeze.FreezeLampState>(Ptr + 3641); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3641); }
    }

    /// <summary>
    /// ByteProperty: MostRecentDialoguePlayed
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnVillainFreeze.FreezeDialogueLines MostRecentDialoguePlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnVillainFreeze.FreezeDialogueLines>(Ptr + 3642); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3642); }
    }

    /// <summary>
    /// ByteProperty: FlawedTacticToCommentOn
    /// </summary>
    public unsafe BmSDK.BmScript.RPawnVillainFreeze.BatmanDialogueLines FlawedTacticToCommentOn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmScript.RPawnVillainFreeze.BatmanDialogueLines>(Ptr + 3643); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3643); }
    }

    /// <summary>
    /// BoolProperty: bStartedFacingMagSource
    /// </summary>
    public unsafe bool bStartedFacingMagSource
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: MagBlastFlightIsLong
    /// </summary>
    public unsafe bool MagBlastFlightIsLong
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bBatmanHitByRepel
    /// </summary>
    public unsafe bool bBatmanHitByRepel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bRepelSoundPlayed
    /// </summary>
    public unsafe bool bRepelSoundPlayed
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bRepelIceEffectApplied
    /// </summary>
    public unsafe bool bRepelIceEffectApplied
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bIsLargeScaleRepel
    /// </summary>
    public unsafe bool bIsLargeScaleRepel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bRoomFreezeExhaustActive
    /// </summary>
    public unsafe bool bRoomFreezeExhaustActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bSuitDamageActive
    /// </summary>
    public unsafe bool bSuitDamageActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bFootSparksActive
    /// </summary>
    public unsafe bool bFootSparksActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bInvulnerableShieldActive
    /// </summary>
    public unsafe bool bInvulnerableShieldActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bIsClearOnLeft
    /// </summary>
    public unsafe bool bIsClearOnLeft
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bIsClearOnRight
    /// </summary>
    public unsafe bool bIsClearOnRight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bSuitLasersActive
    /// </summary>
    public unsafe bool bSuitLasersActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: TelemetryWarningActive
    /// </summary>
    public unsafe bool TelemetryWarningActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bFogIsChanging
    /// </summary>
    public unsafe bool bFogIsChanging
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bEmpActive
    /// </summary>
    public unsafe bool bEmpActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// BoolProperty: bJokerHeadActive
    /// </summary>
    public unsafe bool bJokerHeadActive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3644); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 3644); }
    }

    /// <summary>
    /// StructProperty: MagBlastFacingVector
    /// </summary>
    public unsafe ref System.Numerics.Vector3 MagBlastFacingVector
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3648);

    /// <summary>
    /// FloatProperty: MagBlastFlightSpeed
    /// </summary>
    public unsafe float MagBlastFlightSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3660); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3660); }
    }

    /// <summary>
    /// FloatProperty: MagBlastMinimumFlightTime
    /// </summary>
    public unsafe float MagBlastMinimumFlightTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3664); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3664); }
    }

    /// <summary>
    /// FloatProperty: MagBlastFlightDuration
    /// </summary>
    public unsafe float MagBlastFlightDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3668); }
    }

    /// <summary>
    /// StructProperty: vRepelLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 vRepelLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 3672);

    /// <summary>
    /// FloatProperty: fRepelTimer
    /// </summary>
    public unsafe float fRepelTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3684); }
    }

    /// <summary>
    /// FloatProperty: fRepelDuration
    /// </summary>
    public unsafe float fRepelDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3688); }
    }

    /// <summary>
    /// FloatProperty: fRepelTimeToMax
    /// </summary>
    public unsafe float fRepelTimeToMax
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3692); }
    }

    /// <summary>
    /// FloatProperty: fRepelTriggerRadius
    /// </summary>
    public unsafe float fRepelTriggerRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3696); }
    }

    /// <summary>
    /// FloatProperty: fRepelMaxRadius
    /// </summary>
    public unsafe float fRepelMaxRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3700); }
    }

    /// <summary>
    /// FloatProperty: fRoomAttackRepelRadius
    /// </summary>
    public unsafe float fRoomAttackRepelRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3704); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3704); }
    }

    /// <summary>
    /// IntProperty: iPreviousBeatDownReaction
    /// </summary>
    public unsafe int iPreviousBeatDownReaction
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3708); }
    }

    /// <summary>
    /// ObjectProperty: Repel01
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem Repel01
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3712); }
    }

    /// <summary>
    /// ObjectProperty: EmpAttack
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem EmpAttack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3716); }
    }

    /// <summary>
    /// ObjectProperty: EmpEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem EmpEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3720); }
    }

    /// <summary>
    /// ComponentProperty: RoomFreezeEffect
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent RoomFreezeEffect
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3724); }
    }

    /// <summary>
    /// ComponentProperty: SuitDamageFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent SuitDamageFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3728); }
    }

    /// <summary>
    /// ComponentProperty: IceCrystalGeneratorFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent IceCrystalGeneratorFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3732); }
    }

    /// <summary>
    /// ComponentProperty: FootSparksLeftFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FootSparksLeftFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3736); }
    }

    /// <summary>
    /// ComponentProperty: FootSparksRightFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent FootSparksRightFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3740); }
    }

    /// <summary>
    /// ComponentProperty: InvulnerableShieldFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystemComponent InvulnerableShieldFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystemComponent>(Ptr + 3744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3744); }
    }

    /// <summary>
    /// ObjectProperty: GlassImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GlassImpactFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3748); }
    }

    /// <summary>
    /// ObjectProperty: GeneralImpactFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem GeneralImpactFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 3752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3752); }
    }

    /// <summary>
    /// StructProperty: ImpactScreenShake
    /// </summary>
    public unsafe ref BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct ImpactScreenShake
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RBMScreenShakeModifier.FBMScreenShakeStruct>(Ptr + 3756);

    /// <summary>
    /// ArrayProperty: SuitLasers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RFreezeLaserEffect> SuitLasers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RFreezeLaserEffect>>(Ptr + 3900); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3900); }
    }

    /// <summary>
    /// ComponentProperty: FreezeGun
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent FreezeGun
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 3912); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3912); }
    }

    /// <summary>
    /// ObjectProperty: XRayMetalMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface XRayMetalMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 3916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3916); }
    }

    /// <summary>
    /// ObjectProperty: XRayMetalMaterialMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant XRayMetalMaterialMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3920); }
    }

    /// <summary>
    /// ObjectProperty: NormalGunMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface NormalGunMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 3924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3924); }
    }

    /// <summary>
    /// ObjectProperty: FreezeDomeMIC
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant FreezeDomeMIC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3928); }
    }

    /// <summary>
    /// ObjectProperty: BatmanCapeMaterialConstant
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant BatmanCapeMaterialConstant
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3932); }
    }

    /// <summary>
    /// ObjectProperty: BatmanDefaultCapeMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInterface BatmanDefaultCapeMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInterface>(Ptr + 3936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3936); }
    }

    /// <summary>
    /// ArrayProperty: FreezeTakeDowns
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> FreezeTakeDowns
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 3940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3940); }
    }

    /// <summary>
    /// ObjectProperty: LegsMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant LegsMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3952); }
    }

    /// <summary>
    /// ObjectProperty: TorsoMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant TorsoMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3956); }
    }

    /// <summary>
    /// ObjectProperty: GlassMaterial
    /// </summary>
    public unsafe BmSDK.Engine.MaterialInstanceConstant GlassMaterial
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MaterialInstanceConstant>(Ptr + 3960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3960); }
    }

    /// <summary>
    /// FloatProperty: fBrokenGlassLevel
    /// </summary>
    public unsafe float fBrokenGlassLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3964); }
    }

    /// <summary>
    /// FloatProperty: fCurrentSuitPulseFrequency
    /// </summary>
    public unsafe float fCurrentSuitPulseFrequency
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3968); }
    }

    /// <summary>
    /// FloatProperty: fSuitPulseTimeCounter
    /// </summary>
    public unsafe float fSuitPulseTimeCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 3972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3972); }
    }

    /// <summary>
    /// IntProperty: DroneKeepAliveCounter
    /// </summary>
    public unsafe int DroneKeepAliveCounter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 3976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3976); }
    }

    /// <summary>
    /// ArrayProperty: FreezeSoundEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkEvent> FreezeSoundEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkEvent>>(Ptr + 3980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3980); }
    }

    /// <summary>
    /// ArrayProperty: FreezeSoundHandles
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.AkWwise.FAkSoundHandle> FreezeSoundHandles
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.AkWwise.FAkSoundHandle>>(Ptr + 3992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 3992); }
    }

    /// <summary>
    /// ObjectProperty: FreezeTelemetryWarningStart
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FreezeTelemetryWarningStart
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4004); }
    }

    /// <summary>
    /// ObjectProperty: FreezeTelemetryWarningStop
    /// </summary>
    public unsafe BmSDK.Engine.AkEvent FreezeTelemetryWarningStop
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkEvent>(Ptr + 4008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4008); }
    }

    /// <summary>
    /// ArrayProperty: FreezeVocals
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> FreezeVocals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4012); }
    }

    /// <summary>
    /// ArrayProperty: PlayedFreezeVocalsRecord
    /// </summary>
    public unsafe BmSDK.TArray<bool> PlayedFreezeVocalsRecord
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 4024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4024); }
    }

    /// <summary>
    /// FloatProperty: MostRecentDialogueTimeStamp
    /// </summary>
    public unsafe float MostRecentDialogueTimeStamp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4036); }
    }

    /// <summary>
    /// ArrayProperty: BatmanVocals
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RDialogueLine> BatmanVocals
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RDialogueLine>>(Ptr + 4040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4040); }
    }

    /// <summary>
    /// ArrayProperty: PlayedBatmanVocalsRecord
    /// </summary>
    public unsafe BmSDK.TArray<bool> PlayedBatmanVocalsRecord
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<bool>>(Ptr + 4052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4052); }
    }

    /// <summary>
    /// ArrayProperty: FlawedTacticCounts
    /// </summary>
    public unsafe BmSDK.TArray<int> FlawedTacticCounts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 4064); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4064); }
    }

    /// <summary>
    /// IntProperty: LaserTraceIndex
    /// </summary>
    public unsafe int LaserTraceIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4076); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4076); }
    }

    /// <summary>
    /// FloatProperty: FailedGlideInitialZ
    /// </summary>
    public unsafe float FailedGlideInitialZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4080); }
    }

    /// <summary>
    /// ArrayProperty: VariableFogVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RVariableFogVolume> VariableFogVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RVariableFogVolume>>(Ptr + 4084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4084); }
    }

    /// <summary>
    /// FloatProperty: fFogTimer
    /// </summary>
    public unsafe float fFogTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4096); }
    }

    /// <summary>
    /// FloatProperty: fCurrentFogLevel
    /// </summary>
    public unsafe float fCurrentFogLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4100); }
    }

    /// <summary>
    /// FloatProperty: fTargetFogLevel
    /// </summary>
    public unsafe float fTargetFogLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4104); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4104); }
    }

    /// <summary>
    /// FloatProperty: fFogChangeDuration
    /// </summary>
    public unsafe float fFogChangeDuration
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4108); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4108); }
    }

    /// <summary>
    /// FloatProperty: fFogChangeSpeed
    /// </summary>
    public unsafe float fFogChangeSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4112); }
    }

    /// <summary>
    /// ObjectProperty: JammerMovieInstance
    /// </summary>
    public unsafe BmSDK.GFxUI.SwfMovie JammerMovieInstance
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GFxUI.SwfMovie>(Ptr + 4116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4116); }
    }

    /// <summary>
    /// ArrayProperty: ElectricalDevices
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmScript.RFreezeEnvironmentElectricalDevice> ElectricalDevices
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmScript.RFreezeEnvironmentElectricalDevice>>(Ptr + 4120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4120); }
    }

    /// <summary>
    /// FloatProperty: fEmpEffectRadiusSpeed
    /// </summary>
    public unsafe float fEmpEffectRadiusSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4132); }
    }

    /// <summary>
    /// FloatProperty: fEmpEffectCurrentRadius
    /// </summary>
    public unsafe float fEmpEffectCurrentRadius
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4136); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4136); }
    }

    /// <summary>
    /// FloatProperty: fBatmanDistanceForEmp
    /// </summary>
    public unsafe float fBatmanDistanceForEmp
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4140); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4140); }
    }

    /// <summary>
    /// ObjectProperty: FreezeRagingBeatdownMove
    /// </summary>
    public unsafe BmSDK.BmGame.RSpecialMoveConfigConfigurable FreezeRagingBeatdownMove
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RSpecialMoveConfigConfigurable>(Ptr + 4144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4144); }
    }

    /// <summary>
    /// ComponentProperty: JokerHead
    /// </summary>
    public unsafe BmSDK.Engine.SkeletalMeshComponent JokerHead
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.SkeletalMeshComponent>(Ptr + 4148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4148); }
    }

    /// <summary>
    /// FloatProperty: fJokerHeadScale
    /// </summary>
    public unsafe float fJokerHeadScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4152); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4152); }
    }

    /// <summary>
    /// IntProperty: NumberOfDamagingBlastsThisSalvo
    /// </summary>
    public unsafe int NumberOfDamagingBlastsThisSalvo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4156); }
    }

    /// <summary>
    /// ObjectProperty: JammerGadgetMuzzleFX
    /// </summary>
    public unsafe BmSDK.Engine.ParticleSystem JammerGadgetMuzzleFX
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleSystem>(Ptr + 4160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4160); }
    }

    /// <summary>
    /// ObjectProperty: MovingBitsAnimation
    /// </summary>
    public unsafe BmSDK.Engine.AnimSequence MovingBitsAnimation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSequence>(Ptr + 4164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4164); }
    }

    /// <summary>
    /// FloatProperty: MovingBitsTimer
    /// </summary>
    public unsafe float MovingBitsTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4168); }
    }

    /// <summary>
    /// FloatProperty: MovingBitsPeriod
    /// </summary>
    public unsafe float MovingBitsPeriod
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4172); }
    }

    /// <summary>
    /// ArrayProperty: SpecialReverseChokeLocations
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.Actor> SpecialReverseChokeLocations
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(Ptr + 4176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4176); }
    }
}
