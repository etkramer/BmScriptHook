#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RPawnPlayerAnim<br/>
/// (size = 2004)
/// (flags = 142606518)
/// </summary>
public partial class RPawnPlayerAnim : BmSDK.BmGame.RPawnCombat, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RPawnPlayerAnim", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RPawnPlayerAnim.
    /// </summary>
    public static RPawnPlayerAnim DefaultObject => (RPawnPlayerAnim)StaticClass().DefaultObject;

    internal RPawnPlayerAnim() { }

    /// <summary>
    /// Constructs a new RPawnPlayerAnim
    /// </summary>
    public RPawnPlayerAnim(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RPawnPlayerAnim(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RPawnPlayerAnim>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: PostFallingPhysicsCallback
    /// </summary>
    public unsafe virtual void PostFallingPhysicsCallback()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.PostFallingPhysicsCallback", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPlayerMeshTranslationZ
    /// </summary>
    public unsafe virtual void SetPlayerMeshTranslationZ(float Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.SetPlayerMeshTranslationZ", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Value, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnTeleport
    /// </summary>
    public unsafe override void OnTeleport(BmSDK.Engine.SeqAct_Teleport Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.OnTeleport", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CreateUnarmedWeaponConfig
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RWeaponConfig CreateUnarmedWeaponConfig()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.CreateUnarmedWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RWeaponConfig>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AddMovementMovesToWeaponConfig
    /// </summary>
    public unsafe virtual void AddMovementMovesToWeaponConfig(BmSDK.BmGame.RWeaponConfig WeaponConfig)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.AddMovementMovesToWeaponConfig", true);
        byte* paramsPtr = stackalloc byte[7224];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WeaponConfig, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetupRailingPose
    /// </summary>
    public unsafe virtual void SetupRailingPose(ref BmSDK.BmGame.RPoseConfig.FPose RailingPredator)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.SetupRailingPose", true);
        byte* paramsPtr = stackalloc byte[340];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RailingPredator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RailingPredator = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: SetupSilentPredatorPose
    /// </summary>
    public unsafe virtual void SetupSilentPredatorPose(ref BmSDK.BmGame.RPoseConfig.FPose SilentPredator)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.SetupSilentPredatorPose", true);
        byte* paramsPtr = stackalloc byte[340];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SilentPredator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        SilentPredator = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: SetupCoverCornerRightPose
    /// </summary>
    public unsafe virtual void SetupCoverCornerRightPose(ref BmSDK.BmGame.RPoseConfig.FPose CoverCornerRight, bool bUseRandomOverlays = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.SetupCoverCornerRightPose", true);
        byte* paramsPtr = stackalloc byte[344];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CoverCornerRight, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseRandomOverlays, paramsPtr + 340);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverCornerRight = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: SetupCoverMovementRightPose
    /// </summary>
    public unsafe virtual void SetupCoverMovementRightPose(ref BmSDK.BmGame.RPoseConfig.FPose CoverMovementRight, bool bUseRandomOverlays = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.SetupCoverMovementRightPose", true);
        byte* paramsPtr = stackalloc byte[344];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CoverMovementRight, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bUseRandomOverlays, paramsPtr + 340);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CoverMovementRight = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: SetupCrouchingPose
    /// </summary>
    public unsafe virtual void SetupCrouchingPose(ref BmSDK.BmGame.RPoseConfig.FPose CrouchingPose)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.SetupCrouchingPose", true);
        byte* paramsPtr = stackalloc byte[340];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CrouchingPose, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        CrouchingPose = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: SetupRunningPose
    /// </summary>
    public unsafe virtual void SetupRunningPose(ref BmSDK.BmGame.RPoseConfig.FPose RunningPose)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.SetupRunningPose", true);
        byte* paramsPtr = stackalloc byte[340];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RunningPose, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        RunningPose = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: SetupStandingPose
    /// </summary>
    public unsafe virtual void SetupStandingPose(ref BmSDK.BmGame.RPoseConfig.FPose StandingPose, BmSDK.Engine.AnimSet IdleOverlayAnimSet = default, BmSDK.Engine.AnimSet MovementAnimSet = default, BmSDK.BmGame.RPawnPlayerAnim.FAllowedMovementTypes MovementTypes = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.SetupStandingPose", true);
        byte* paramsPtr = stackalloc byte[472];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StandingPose, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IdleOverlayAnimSet, paramsPtr + 340);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementAnimSet, paramsPtr + 344);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MovementTypes, paramsPtr + 348);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        StandingPose = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: SetDontConsumeAdditiveWeightOnMovement
    /// </summary>
    public unsafe virtual void SetDontConsumeAdditiveWeightOnMovement(ref BmSDK.BmGame.RPoseConfig.FPose InOut_Pose)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RPawnPlayerAnim.SetDontConsumeAdditiveWeightOnMovement", true);
        byte* paramsPtr = stackalloc byte[344];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InOut_Pose, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        InOut_Pose = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPoseConfig.FPose>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Struct: FAllowedMovementTypes
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FAllowedMovementTypes
    {
        /// <summary>
        /// BoolProperty: bRun
        /// </summary>
        public unsafe bool bRun
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bRunBack
        /// </summary>
        public unsafe bool bRunBack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bWalk
        /// </summary>
        public unsafe bool bWalk
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bWalkSlow
        /// </summary>
        public unsafe bool bWalkSlow
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bWalkBack
        /// </summary>
        public unsafe bool bWalkBack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 16) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bSprintBoost
        /// </summary>
        public unsafe bool bSprintBoost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 32) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: AimingConfigDesc
    /// </summary>
    public enum AimingConfigDesc : byte
    {
        ACD_StandardAimingConfig = 0,
        ACD_HarpoonAimingConfig = 1,
        ACD_HarpoonPullAimingConfig = 2,
        ACD_GrappleAimingConfig = 3,
        ACD_SilentPredAimingConfig = 4,
        ACD_GadgetAimingConfig = 5,
        ACD_NoAimingAimingConfig = 6,
        ACD_CrouchingAimingConfig = 7,
        ACD_WireBatarangAimingConfig = 8,
        ACD_GlideGrappleAimingConfig = 9,
        ACD_SwingingAimingConfig = 10,
        ACD_ArmOnlyGrappleAimingConfig = 11,
        ACD_WristDartAimingConfig = 12,
        ACD_CatwomanSwingingAimingConfig = 13,
        ACD_BatarangAimingConfig = 14,
        ACD_MagBlastAimingConfig = 15,
        ACD_MagBlastRailingAimingConfig = 16,
        ACD_FreezeGrenadeAimingConfig = 17,
        ACD_WireBatarangThrowAimingConfig = 18,
        ACD_NullAimingConfig = 19,
        ACD_MAX = 20,
    }

    /// <summary>
    /// ArrayProperty: UsefulAimingConfigs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RAimingConfig> UsefulAimingConfigs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RAimingConfig>>(Ptr + 1964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1964); }
    }

    /// <summary>
    /// ObjectProperty: OverrideNormalStandAnimSet
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet OverrideNormalStandAnimSet
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1976); }
    }

    /// <summary>
    /// ObjectProperty: OverrideNormalCrouchAnimset
    /// </summary>
    public unsafe BmSDK.Engine.AnimSet OverrideNormalCrouchAnimset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AnimSet>(Ptr + 1980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1980); }
    }

    /// <summary>
    /// StructProperty: BaseAimAtTiming
    /// </summary>
    public unsafe ref BmSDK.BmGame.RPoseConfig.FAimingTransitionTiming BaseAimAtTiming
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RPoseConfig.FAimingTransitionTiming>(Ptr + 1984);

    /// <summary>
    /// ObjectProperty: AnimationConfig
    /// </summary>
    public unsafe BmSDK.BmGame.RPawnPlayerConfig AnimationConfig
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayerConfig>(Ptr + 1996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1996); }
    }

    /// <summary>
    /// FloatProperty: CoverWallDistanceOffset
    /// </summary>
    public unsafe float CoverWallDistanceOffset
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 2000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 2000); }
    }
}
