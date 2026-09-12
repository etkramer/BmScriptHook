#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameStatsAggregator<br/>
/// (size = 532)
/// (flags = 134217878)
/// </summary>
public partial class GameStatsAggregator : BmSDK.Engine.GameplayEventsHandler, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameStatsAggregator", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GameStatsAggregator.
    /// </summary>
    public static GameStatsAggregator DefaultObject => (GameStatsAggregator)StaticClass().DefaultObject;

    internal GameStatsAggregator() { }

    /// <summary>
    /// Constructs a new GameStatsAggregator
    /// </summary>
    public GameStatsAggregator(BmSDK.GameObject Outer, string Name = null, BmSDK.GameObject.EObjectFlags SetFlags = 0, GameStatsAggregator Template = null) : base(ConstructObjectInternal(StaticClass(), Outer, Name, SetFlags, Template)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameStatsAggregator(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameStatsAggregator>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameStatsAggregator>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameStatsAggregator>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameStatsAggregator>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameStatsAggregator>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameStatsAggregator>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameStatsAggregator>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameStatsAggregator>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: GetAggregateMappingIDs
    /// </summary>
    public unsafe virtual bool GetAggregateMappingIDs(int EventID, ref int AggregateID, ref int TargetAggregateID)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameStatsAggregator.GetAggregateMappingIDs", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(EventID, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AggregateID, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetAggregateID, paramsPtr + 8);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        AggregateID = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        TargetAggregateID = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: PostProcessStream
    /// </summary>
    public unsafe override void PostProcessStream()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameStatsAggregator.PostProcessStream", true);
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
    /// Function: PreProcessStream
    /// </summary>
    public unsafe override void PreProcessStream()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameStatsAggregator.PreProcessStream", true);
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
    /// Struct: FAggregateEventMapping
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FAggregateEventMapping
    {
        /// <summary>
        /// IntProperty: EventID
        /// </summary>
        public unsafe int EventID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: AggregateID
        /// </summary>
        public unsafe int AggregateID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: TargetAggregateID
        /// </summary>
        public unsafe int TargetAggregateID
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
    }

    /// <summary>
    /// Struct: FPlayerEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 420)]
    public partial record struct FPlayerEvents
    {
        /// <summary>
        /// StructProperty: TotalEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FGameEvents TotalEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FGameEvents>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WeaponEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FWeaponEvents WeaponEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FWeaponEvents>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// StructProperty: DamageAsPlayerEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FDamageEvents DamageAsPlayerEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FDamageEvents>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }

        /// <summary>
        /// StructProperty: DamageAsTargetEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FDamageEvents DamageAsTargetEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FDamageEvents>(Ptr + 204); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }; }
        }

        /// <summary>
        /// StructProperty: ProjectileEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FProjectileEvents ProjectileEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FProjectileEvents>(Ptr + 276); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }; }
        }

        /// <summary>
        /// StructProperty: PawnEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FPawnEvents PawnEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FPawnEvents>(Ptr + 348); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }; }
        }
    }

    /// <summary>
    /// Struct: FTeamEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 420)]
    public partial record struct FTeamEvents
    {
        /// <summary>
        /// StructProperty: TotalEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FGameEvents TotalEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FGameEvents>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WeaponEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FWeaponEvents WeaponEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FWeaponEvents>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// StructProperty: DamageAsPlayerEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FDamageEvents DamageAsPlayerEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FDamageEvents>(Ptr + 132); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 132); }; }
        }

        /// <summary>
        /// StructProperty: DamageAsTargetEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FDamageEvents DamageAsTargetEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FDamageEvents>(Ptr + 204); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 204); }; }
        }

        /// <summary>
        /// StructProperty: ProjectileEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FProjectileEvents ProjectileEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FProjectileEvents>(Ptr + 276); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 276); }; }
        }

        /// <summary>
        /// StructProperty: PawnEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FPawnEvents PawnEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FPawnEvents>(Ptr + 348); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 348); }; }
        }
    }

    /// <summary>
    /// Struct: FPawnEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FPawnEvents
    {
        /// <summary>
        /// StructProperty: TotalEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FGameEvents TotalEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FGameEvents>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: EventsByPawnClass
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FGameEvents> EventsByPawnClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FGameEvents>>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Struct: FDamageEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FDamageEvents
    {
        /// <summary>
        /// StructProperty: TotalEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FGameEvents TotalEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FGameEvents>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: EventsByDamageClass
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FGameEvents> EventsByDamageClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FGameEvents>>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Struct: FProjectileEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FProjectileEvents
    {
        /// <summary>
        /// StructProperty: TotalEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FGameEvents TotalEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FGameEvents>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: EventsByProjectileClass
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FGameEvents> EventsByProjectileClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FGameEvents>>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Struct: FWeaponEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 72)]
    public partial record struct FWeaponEvents
    {
        /// <summary>
        /// StructProperty: TotalEvents
        /// </summary>
        public unsafe BmSDK.Engine.GameStatsAggregator.FGameEvents TotalEvents
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStatsAggregator.FGameEvents>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ArrayProperty: EventsByWeaponClass
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FGameEvents> EventsByWeaponClass
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FGameEvents>>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }
    }

    /// <summary>
    /// Struct: FGameEvents
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FGameEvents
    {
        /// <summary>
        /// StructProperty: Events
        /// </summary>
        public unsafe BmSDK.GameObject.FMap_Mirror Events
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FMap_Mirror>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FGameEvent
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 12)]
    public partial record struct FGameEvent
    {
        /// <summary>
        /// ArrayProperty: EventCountByTimePeriod
        /// </summary>
        public unsafe BmSDK.TArray<float> EventCountByTimePeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<float>>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: GameState
    /// </summary>
    public unsafe BmSDK.Engine.GameStateObject GameState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameStateObject>(Ptr + 72); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 72); }
    }

    /// <summary>
    /// ArrayProperty: AggregatesList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FAggregateEventMapping> AggregatesList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FAggregateEventMapping>>(Ptr + 76); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }
    }

    /// <summary>
    /// StructProperty: AggregateEventsMapping
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMap_Mirror AggregateEventsMapping
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMap_Mirror>(Ptr + 88);

    /// <summary>
    /// ArrayProperty: AggregateEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameplayEvents.FGameplayEventMetaData> AggregateEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameplayEvents.FGameplayEventMetaData>>(Ptr + 148); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 148); }
    }

    /// <summary>
    /// StructProperty: AllGameEvents
    /// </summary>
    public unsafe ref BmSDK.Engine.GameStatsAggregator.FGameEvents AllGameEvents
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.GameStatsAggregator.FGameEvents>(Ptr + 160);

    /// <summary>
    /// ArrayProperty: AllTeamEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FTeamEvents> AllTeamEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FTeamEvents>>(Ptr + 220); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 220); }
    }

    /// <summary>
    /// ArrayProperty: AllPlayerEvents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FPlayerEvents> AllPlayerEvents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameStatsAggregator.FPlayerEvents>>(Ptr + 232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 232); }
    }

    /// <summary>
    /// StructProperty: AllWeaponEvents
    /// </summary>
    public unsafe ref BmSDK.Engine.GameStatsAggregator.FWeaponEvents AllWeaponEvents
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.GameStatsAggregator.FWeaponEvents>(Ptr + 244);

    /// <summary>
    /// StructProperty: AllProjectileEvents
    /// </summary>
    public unsafe ref BmSDK.Engine.GameStatsAggregator.FProjectileEvents AllProjectileEvents
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.GameStatsAggregator.FProjectileEvents>(Ptr + 316);

    /// <summary>
    /// StructProperty: AllPawnEvents
    /// </summary>
    public unsafe ref BmSDK.Engine.GameStatsAggregator.FPawnEvents AllPawnEvents
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.GameStatsAggregator.FPawnEvents>(Ptr + 388);

    /// <summary>
    /// StructProperty: AllDamageEvents
    /// </summary>
    public unsafe ref BmSDK.Engine.GameStatsAggregator.FDamageEvents AllDamageEvents
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.GameStatsAggregator.FDamageEvents>(Ptr + 460);
}
