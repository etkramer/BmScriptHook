namespace BmSDK.Framework;

internal static class GameFunctions
{
    // UObject::StaticConstructObject()
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr StaticConstructObjectDelegate(
        IntPtr InClass,
        IntPtr InOuter,
        FName InName,
        GameObject.EObjectFlags InFlags,
        IntPtr InTemplate,
        IntPtr Error,
        IntPtr SubobjectRoot,
        IntPtr InInstanceGraph
    );

    // UObject::StaticFindObject()
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr StaticFindObjectDelegate(
        IntPtr Class,
        IntPtr InOuter,
        IntPtr OrigInName,
        int ExactClass
    );

    // UObject::LoadPackage()
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr LoadPackageDelegate(IntPtr InOuter, IntPtr Filename, int LoadFlags);

    // UObject::CollectGarbage()
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void CollectGarbageDelegate(
        GameObject.EObjectFlags KeepFlags,
        int bPerformFullPurge
    );

    // UObject::ProcessEvent()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ProcessEventDelegate(
        IntPtr self,
        IntPtr Function,
        IntPtr Parms,
        IntPtr UnusedResult
    );

    // UObject::ProcessInternal()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ProcessInternalDelegate(IntPtr self, IntPtr Stack, IntPtr Result);

    // FWindowsViewport::ProcessDeferredMessage()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ProcessDeferredMessageDelegate(IntPtr self, ref FDeferredMessage Message);

    // UObject::CallFunction()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void CallFunctionDelegate(
        IntPtr self,
        IntPtr Stack,
        IntPtr Result,
        IntPtr Function
    );

    // UObject::AddObject()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void AddObjectDelegate(IntPtr self, int InIndex);

    // UObject::~UObject()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ConditionalDestroyDelegate(IntPtr self);

    // UObject::FindFunction()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate IntPtr FindFunctionDelegate(IntPtr self, FName InName, int Global);

    // UClass::GetDefaultObject()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate IntPtr GetDefaultObjectDelegate(IntPtr self, int bForce);

    // UWorld::SpawnActor()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate IntPtr SpawnActorDelegate(
        IntPtr self,
        IntPtr Class,
        FName InName,
        IntPtr Location,
        IntPtr Rotation,
        IntPtr Template,
        int bNoCollisionFail,
        int bRemoteOwned,
        IntPtr Owner,
        IntPtr Instigator,
        int bNoFail
    );

    // FName::Init()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void NameInitDelegate(
        IntPtr self,
        IntPtr InName,
        int InNumber,
        int FindType,
        int bSplitName
    );

    // FString::FString()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate IntPtr StringCtorDelegate(IntPtr self, IntPtr In);

    // appRealloc()
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate IntPtr AppReallocDelegate(IntPtr Original, int Count, int Alignment);

    // appFree()
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void AppFreeDelegate(IntPtr Original);

    // FEngineLoop::Tick()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate IntPtr EngineTickDelegate(IntPtr self);

    // UObject::ConditionalPostLoad()
    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
    public delegate void ConditionalPostLoadDelegate(IntPtr self);

    private static StaticConstructObjectDelegate? _StaticConstructObject = null;
    private static StaticFindObjectDelegate? _StaticFindObject = null;
    private static LoadPackageDelegate? _LoadPackage = null;
    private static CollectGarbageDelegate? _CollectGarbage = null;
    private static ProcessEventDelegate? _ProcessEvent = null;
    private static ProcessInternalDelegate? _ProcessInternal = null;
    private static CallFunctionDelegate? _CallFunction = null;
    private static AddObjectDelegate? _AddObject = null;
    private static ConditionalDestroyDelegate? _ConditionalDestroy = null;
    private static FindFunctionDelegate? _FindFunction = null;
    private static GetDefaultObjectDelegate? _GetDefaultObject = null;
    private static SpawnActorDelegate? _SpawnActor = null;
    private static NameInitDelegate? _NameInit = null;
    private static StringCtorDelegate? _StringCtor = null;
    private static AppReallocDelegate? _AppRealloc = null;
    private static AppFreeDelegate? _AppFree = null;
    private static EngineTickDelegate? _EngineTick = null;

    public static StaticConstructObjectDelegate StaticConstructObject =>
        _StaticConstructObject ??=
            Marshal.GetDelegateForFunctionPointer<StaticConstructObjectDelegate>(
                MemUtil.GetIntPointer(GameDefine.Current.StaticConstructObject)
            );

    public static StaticFindObjectDelegate StaticFindObject =>
        _StaticFindObject ??= Marshal.GetDelegateForFunctionPointer<StaticFindObjectDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.StaticFindObject)
        );

    public static LoadPackageDelegate LoadPackage =>
        _LoadPackage ??= Marshal.GetDelegateForFunctionPointer<LoadPackageDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.LoadPackage)
        );

    public static CollectGarbageDelegate CollectGarbage =>
        _CollectGarbage ??= Marshal.GetDelegateForFunctionPointer<CollectGarbageDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.CollectGarbage)
        );

    public static ProcessEventDelegate ProcessEvent =>
        _ProcessEvent ??= Marshal.GetDelegateForFunctionPointer<ProcessEventDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.ProcessEvent)
        );

    public static ProcessInternalDelegate ProcessInternal =>
        _ProcessInternal ??= Marshal.GetDelegateForFunctionPointer<ProcessInternalDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.ProcessInternal)
        );

    public static CallFunctionDelegate CallFunction =>
        _CallFunction ??= Marshal.GetDelegateForFunctionPointer<CallFunctionDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.CallFunction)
        );

    public static AddObjectDelegate AddObject =>
        _AddObject ??= Marshal.GetDelegateForFunctionPointer<AddObjectDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.AddObject)
        );

    public static ConditionalDestroyDelegate ConditionalDestroy =>
        _ConditionalDestroy ??= Marshal.GetDelegateForFunctionPointer<ConditionalDestroyDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.ConditionalDestroy)
        );

    public static FindFunctionDelegate FindFunction =>
        _FindFunction ??= Marshal.GetDelegateForFunctionPointer<FindFunctionDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.FindFunction)
        );

    public static GetDefaultObjectDelegate GetDefaultObject =>
        _GetDefaultObject ??= Marshal.GetDelegateForFunctionPointer<GetDefaultObjectDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.GetDefaultObject)
        );

    public static SpawnActorDelegate SpawnActor =>
        _SpawnActor ??= Marshal.GetDelegateForFunctionPointer<SpawnActorDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.SpawnActor)
        );

    public static NameInitDelegate NameInit =>
        _NameInit ??= Marshal.GetDelegateForFunctionPointer<NameInitDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.NameInit)
        );

    public static StringCtorDelegate StringCtor =>
        _StringCtor ??= Marshal.GetDelegateForFunctionPointer<StringCtorDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.StringCtor)
        );

    public static AppReallocDelegate AppRealloc =>
        _AppRealloc ??= Marshal.GetDelegateForFunctionPointer<AppReallocDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.AppRealloc)
        );

    public static AppFreeDelegate AppFree =>
        _AppFree ??= Marshal.GetDelegateForFunctionPointer<AppFreeDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.AppFree)
        );

    public static EngineTickDelegate EngineTick =>
        _EngineTick ??= Marshal.GetDelegateForFunctionPointer<EngineTickDelegate>(
            MemUtil.GetIntPointer(GameDefine.Current.EngineTick)
        );
}
