#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: WorldInfo<br/>
/// (size = 1944)
/// (flags = 144705718)
/// </summary>
public partial class WorldInfo : BmSDK.Engine.ZoneInfo, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.WorldInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as WorldInfo.
    /// </summary>
    public static WorldInfo DefaultObject => (WorldInfo)StaticClass().DefaultObject;

    internal WorldInfo() { }

    /// <summary>
    /// Constructs a new WorldInfo
    /// </summary>
    public WorldInfo(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected WorldInfo(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<WorldInfo>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<WorldInfo>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: ClearPhysicsPools
    /// </summary>
    public unsafe virtual void ClearPhysicsPools()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.ClearPhysicsPools", true);
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
    /// Function: ToggleHostMigration
    /// </summary>
    public unsafe virtual void ToggleHostMigration(bool bEnabled)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.ToggleHostMigration", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bEnabled, paramsPtr + 0);
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
    /// Function: BeginHostMigration
    /// </summary>
    public unsafe virtual bool BeginHostMigration()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.BeginHostMigration", true);
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
    /// Function: FindEnvironmentVolume
    /// </summary>
    public unsafe virtual BmSDK.Engine.EnvironmentVolume FindEnvironmentVolume(System.Numerics.Vector3 TestLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.FindEnvironmentVolume", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestLocation, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.EnvironmentVolume>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetWorldInfo
    /// </summary>
    public unsafe static BmSDK.Engine.WorldInfo GetWorldInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetWorldInfo", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetWorldFractureSettings
    /// </summary>
    public unsafe virtual BmSDK.Engine.WorldInfo.FWorldFractureSettings GetWorldFractureSettings()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetWorldFractureSettings", true);
        byte* paramsPtr = stackalloc byte[28];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.FWorldFractureSettings>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: DoMemoryTracking
    /// </summary>
    public unsafe virtual void DoMemoryTracking()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.DoMemoryTracking", true);
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
    /// Function: GetDemoRewindPoints
    /// </summary>
    public unsafe virtual bool GetDemoRewindPoints(out BmSDK.TArray<int> OutRewindPoints)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetDemoRewindPoints", true);
        byte* paramsPtr = stackalloc byte[16];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutRewindPoints = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetDemoFrameInfo
    /// </summary>
    public unsafe virtual void GetDemoFrameInfo(out int CurrentFrame, out int TotalFrames)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetDemoFrameInfo", true);
        byte* paramsPtr = stackalloc byte[8];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        CurrentFrame = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        TotalFrames = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: IsPlayingDemo
    /// </summary>
    public unsafe virtual bool IsPlayingDemo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.IsPlayingDemo", true);
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
    /// Function: IsRecordingDemo
    /// </summary>
    public unsafe virtual bool IsRecordingDemo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.IsRecordingDemo", true);
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
    /// Function: GetDetailMode
    /// </summary>
    public unsafe virtual BmSDK.Engine.Scene.EDetailMode GetDetailMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetDetailMode", true);
        byte* paramsPtr = stackalloc byte[1];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Scene.EDetailMode>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetMapName
    /// </summary>
    public unsafe virtual BmSDK.FString GetMapName(bool bIncludePrefix = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetMapName", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIncludePrefix, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ResetActorChannel
    /// </summary>
    public unsafe virtual void ResetActorChannel(BmSDK.Engine.Actor ChannelOwner)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.ResetActorChannel", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ChannelOwner, paramsPtr + 0);
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
    /// Function: SetMapInfo
    /// </summary>
    public unsafe virtual void SetMapInfo(BmSDK.Engine.MapInfo NewMapInfo)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.SetMapInfo", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewMapInfo, paramsPtr + 0);
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
    /// Function: GetMapInfo
    /// </summary>
    public unsafe virtual BmSDK.Engine.MapInfo GetMapInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetMapInfo", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MapInfo>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetSeamlessTravelMidpointPause
    /// </summary>
    public unsafe virtual void SetSeamlessTravelMidpointPause(bool bNowPaused)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.SetSeamlessTravelMidpointPause", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNowPaused, paramsPtr + 0);
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
    /// Function: IsInSeamlessTravel
    /// </summary>
    public unsafe virtual bool IsInSeamlessTravel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.IsInSeamlessTravel", true);
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
    /// Function: SeamlessTravel
    /// </summary>
    public unsafe virtual void SeamlessTravel(BmSDK.FString URL, bool bAbsolute = default, BmSDK.GameObject.FGuid MapPackageGuid = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.SeamlessTravel", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbsolute, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapPackageGuid, paramsPtr + 16);
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
    /// Function: CommitMapChange
    /// </summary>
    public unsafe virtual void CommitMapChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.CommitMapChange", true);
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
    /// Function: CancelPendingMapChange
    /// </summary>
    public unsafe virtual void CancelPendingMapChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.CancelPendingMapChange", true);
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
    /// Function: IsMapChangeReady
    /// </summary>
    public unsafe virtual bool IsMapChangeReady()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.IsMapChangeReady", true);
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
    /// Function: IsPreparingMapChange
    /// </summary>
    public unsafe virtual bool IsPreparingMapChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.IsPreparingMapChange", true);
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
    /// Function: PrepareMapChange
    /// </summary>
    public unsafe virtual void PrepareMapChange(BmSDK.TArray<BmSDK.FName> LevelNames, BmSDK.TArray<BmSDK.FName> LevelsToNotMakeVisible = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.PrepareMapChange", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelNames, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LevelsToNotMakeVisible, paramsPtr + 12);
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
    /// Function: NotifyMatchStarted
    /// </summary>
    public unsafe virtual void NotifyMatchStarted(bool bShouldActivateLevelStartupEvents = default, bool bShouldActivateLevelBeginningEvents = default, bool bShouldActivateLevelLoadedEvents = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.NotifyMatchStarted", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldActivateLevelStartupEvents, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldActivateLevelBeginningEvents, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldActivateLevelLoadedEvents, paramsPtr + 8);
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
    /// Function: NavigationPointCheck
    /// </summary>
    public unsafe virtual void NavigationPointCheck(System.Numerics.Vector3 Point, System.Numerics.Vector3 Extent, out BmSDK.TArray<BmSDK.Engine.NavigationPoint> Navs, out BmSDK.TArray<BmSDK.Engine.ReachSpec> Specs)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.NavigationPointCheck", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Point, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Extent, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        Navs = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.NavigationPoint>>(paramsPtr + 24);
        Specs = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ReachSpec>>(paramsPtr + 36);
        return;
    }

    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.Reset", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.PreBeginPlay", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ServerTravel
    /// </summary>
    public unsafe virtual void ServerTravel(BmSDK.FString URL, bool bAbsolute = default, bool bShouldSkipGameNotify = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.ServerTravel", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbsolute, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bShouldSkipGameNotify, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetAddressURL
    /// </summary>
    public unsafe virtual BmSDK.FString GetAddressURL()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetAddressURL", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: VerifyNavList
    /// </summary>
    public unsafe virtual void VerifyNavList()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.VerifyNavList", true);
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
    /// Function: ForceGarbageCollection
    /// </summary>
    public unsafe virtual void ForceGarbageCollection(bool bFullPurge = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.ForceGarbageCollection", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFullPurge, paramsPtr + 0);
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
    /// Function: IsPlayInPreview
    /// </summary>
    public unsafe static bool IsPlayInPreview()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.IsPlayInPreview", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsPlayInEditor
    /// </summary>
    public unsafe static bool IsPlayInEditor()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.IsPlayInEditor", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsShippingBuild
    /// </summary>
    public unsafe static bool IsShippingBuild()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.IsShippingBuild", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsConsoleBuild
    /// </summary>
    public unsafe static bool IsConsoleBuild(BmSDK.Engine.WorldInfo.EConsoleType ConsoleType = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.IsConsoleBuild", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConsoleType, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsDemoBuild
    /// </summary>
    public unsafe static bool IsDemoBuild()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.IsDemoBuild", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetLocalURL
    /// </summary>
    public unsafe virtual BmSDK.FString GetLocalURL()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetLocalURL", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: SetLevelRBGravity
    /// </summary>
    public unsafe virtual void SetLevelRBGravity(System.Numerics.Vector3 NewGrav)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.SetLevelRBGravity", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewGrav, paramsPtr + 0);
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
    /// Function: GetAllRootSequences
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.Engine.Sequence> GetAllRootSequences()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetAllRootSequences", true);
        byte* paramsPtr = stackalloc byte[12];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Sequence>>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGameSequence
    /// </summary>
    public unsafe virtual BmSDK.Engine.Sequence GetGameSequence()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetGameSequence", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Sequence>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetGravityZ
    /// </summary>
    public unsafe override float GetGravityZ()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetGravityZ", true);
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
    /// Function: IsMenuLevel
    /// </summary>
    public unsafe static bool IsMenuLevel(BmSDK.FString MapName = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.IsMenuLevel", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: AddOnScreenDebugMessage
    /// </summary>
    public unsafe virtual void AddOnScreenDebugMessage(int Key, float TimeToDisplay, BmSDK.GameObject.FColor DisplayColor, BmSDK.FString DebugMessage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.AddOnScreenDebugMessage", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Key, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeToDisplay, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DisplayColor, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DebugMessage, paramsPtr + 12);
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
    /// Function: ReplicatedEvent
    /// </summary>
    public unsafe override void ReplicatedEvent(BmSDK.FName VarName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.ReplicatedEvent", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VarName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetNavMeshPathGoalEvaluatorFromCache
    /// </summary>
    public unsafe virtual BmSDK.Engine.NavMeshPathGoalEvaluator GetNavMeshPathGoalEvaluatorFromCache(BmSDK.Class GoalEvalClass, BmSDK.Engine.NavigationHandle Requestor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetNavMeshPathGoalEvaluatorFromCache", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GoalEvalClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Requestor, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathGoalEvaluator>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetNavMeshPathConstraintFromCache
    /// </summary>
    public unsafe virtual BmSDK.Engine.NavMeshPathConstraint GetNavMeshPathConstraintFromCache(BmSDK.Class ConstraintClass, BmSDK.Engine.NavigationHandle Requestor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.GetNavMeshPathConstraintFromCache", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ConstraintClass, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Requestor, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathConstraint>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ReleaseCachedConstraintsAndEvaluators
    /// </summary>
    public unsafe virtual void ReleaseCachedConstraintsAndEvaluators()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.WorldInfo.ReleaseCachedConstraintsAndEvaluators", true);
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
    /// Struct: FHostMigrationState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FHostMigrationState
    {
        /// <summary>
        /// ByteProperty: HostMigrationProgress
        /// </summary>
        public unsafe BmSDK.Engine.WorldInfo.EHostMigrationProgress HostMigrationProgress
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.EHostMigrationProgress>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: HostMigrationElapsedTime
        /// </summary>
        public unsafe float HostMigrationElapsedTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: HostMigrationTravelCountdown
        /// </summary>
        public unsafe float HostMigrationTravelCountdown
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: HostMigrationTravelURL
        /// </summary>
        public unsafe BmSDK.FString HostMigrationTravelURL
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bHostMigrationEnabled
        /// </summary>
        public unsafe bool bHostMigrationEnabled
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: EHostMigrationProgress
    /// </summary>
    public enum EHostMigrationProgress : byte
    {
        HostMigration_None = 0,
        HostMigration_FindingNewHost = 1,
        HostMigration_MigratingAsHost = 2,
        HostMigration_MigratingAsClient = 3,
        HostMigration_HostReadyToTravel = 4,
        HostMigration_MAX = 5,
    }

    /// <summary>
    /// Struct: FNavMeshPathGoalEvaluatorCacheDatum
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FNavMeshPathGoalEvaluatorCacheDatum
    {
        /// <summary>
        /// IntProperty: ListIdx
        /// </summary>
        public unsafe int ListIdx
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: List
        /// </summary>
        public unsafe BmSDK.Engine.NavMeshPathGoalEvaluator List_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathGoalEvaluator>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// ObjectProperty: List
        /// </summary>
        public unsafe BmSDK.Engine.NavMeshPathGoalEvaluator List_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathGoalEvaluator>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
        /// <summary>
        /// ObjectProperty: List
        /// </summary>
        public unsafe BmSDK.Engine.NavMeshPathGoalEvaluator List_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathGoalEvaluator>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// ObjectProperty: List
        /// </summary>
        public unsafe BmSDK.Engine.NavMeshPathGoalEvaluator List_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathGoalEvaluator>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// ObjectProperty: List
        /// </summary>
        public unsafe BmSDK.Engine.NavMeshPathGoalEvaluator List_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathGoalEvaluator>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FNavMeshPathConstraintCacheDatum
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FNavMeshPathConstraintCacheDatum
    {
        /// <summary>
        /// IntProperty: ListIdx
        /// </summary>
        public unsafe int ListIdx
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: List
        /// </summary>
        public unsafe BmSDK.Engine.NavMeshPathConstraint List_0
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathConstraint>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
        /// <summary>
        /// ObjectProperty: List
        /// </summary>
        public unsafe BmSDK.Engine.NavMeshPathConstraint List_1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathConstraint>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }
        /// <summary>
        /// ObjectProperty: List
        /// </summary>
        public unsafe BmSDK.Engine.NavMeshPathConstraint List_2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathConstraint>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
        /// <summary>
        /// ObjectProperty: List
        /// </summary>
        public unsafe BmSDK.Engine.NavMeshPathConstraint List_3
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathConstraint>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
        /// <summary>
        /// ObjectProperty: List
        /// </summary>
        public unsafe BmSDK.Engine.NavMeshPathConstraint List_4
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavMeshPathConstraint>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FLightmassWorldInfoSettings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 60)]
    public partial record struct FLightmassWorldInfoSettings
    {
        /// <summary>
        /// FloatProperty: StaticLightingLevelScale
        /// </summary>
        public unsafe float StaticLightingLevelScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: NumIndirectLightingBounces
        /// </summary>
        public unsafe int NumIndirectLightingBounces
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: EnvironmentColor
        /// </summary>
        public unsafe BmSDK.GameObject.FColor EnvironmentColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: EnvironmentIntensity
        /// </summary>
        public unsafe float EnvironmentIntensity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: EmissiveBoost
        /// </summary>
        public unsafe float EmissiveBoost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: DiffuseBoost
        /// </summary>
        public unsafe float DiffuseBoost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: SpecularBoost
        /// </summary>
        public unsafe float SpecularBoost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: IndirectNormalInfluenceBoost
        /// </summary>
        public unsafe float IndirectNormalInfluenceBoost
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// BoolProperty: bUseNormalMapsForSimpleLightMaps
        /// </summary>
        public unsafe bool bUseNormalMapsForSimpleLightMaps
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bUseAmbientOcclusion
        /// </summary>
        public unsafe bool bUseAmbientOcclusion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// BoolProperty: bEnableImageReflectionShadowing
        /// </summary>
        public unsafe bool bEnableImageReflectionShadowing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: DirectIlluminationOcclusionFraction
        /// </summary>
        public unsafe float DirectIlluminationOcclusionFraction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// FloatProperty: IndirectIlluminationOcclusionFraction
        /// </summary>
        public unsafe float IndirectIlluminationOcclusionFraction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// FloatProperty: OcclusionExponent
        /// </summary>
        public unsafe float OcclusionExponent
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// FloatProperty: FullyOccludedSamplesFraction
        /// </summary>
        public unsafe float FullyOccludedSamplesFraction
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: MaxOcclusionDistance
        /// </summary>
        public unsafe float MaxOcclusionDistance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 52); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }; }
        }

        /// <summary>
        /// BoolProperty: bVisualizeMaterialDiffuse
        /// </summary>
        public unsafe bool bVisualizeMaterialDiffuse
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }

        /// <summary>
        /// BoolProperty: bVisualizeAmbientOcclusion
        /// </summary>
        public unsafe bool bVisualizeAmbientOcclusion
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 56); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 56); }; }
        }
    }

    /// <summary>
    /// Struct: FScreenMessageString
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FScreenMessageString
    {
        /// <summary>
        /// StructProperty: Key
        /// </summary>
        public unsafe ulong Key
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<ulong>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ScreenMessage
        /// </summary>
        public unsafe BmSDK.FString ScreenMessage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: DisplayColor
        /// </summary>
        public unsafe BmSDK.GameObject.FColor DisplayColor
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject.FColor>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: TimeToDisplay
        /// </summary>
        public unsafe float TimeToDisplay
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: CurrentTimeDisplayed
        /// </summary>
        public unsafe float CurrentTimeDisplayed
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }
    }

    /// <summary>
    /// Enum: EVisibilityAggressiveness
    /// </summary>
    public enum EVisibilityAggressiveness : byte
    {
        VIS_LeastAggressive = 0,
        VIS_ModeratelyAggressive = 1,
        VIS_MostAggressive = 2,
        VIS_Max = 3,
    }

    /// <summary>
    /// Struct: FWorldFractureSettings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial record struct FWorldFractureSettings
    {
        /// <summary>
        /// FloatProperty: ChanceOfPhysicsChunkOverride
        /// </summary>
        public unsafe float ChanceOfPhysicsChunkOverride
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bEnableChanceOfPhysicsChunkOverride
        /// </summary>
        public unsafe bool bEnableChanceOfPhysicsChunkOverride
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// BoolProperty: bLimitExplosionChunkSize
        /// </summary>
        public unsafe bool bLimitExplosionChunkSize
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: MaxExplosionChunkSize
        /// </summary>
        public unsafe float MaxExplosionChunkSize
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bLimitDamageChunkSize
        /// </summary>
        public unsafe bool bLimitDamageChunkSize
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: MaxDamageChunkSize
        /// </summary>
        public unsafe float MaxDamageChunkSize
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: MaxNumFacturedChunksToSpawnInAFrame
        /// </summary>
        public unsafe int MaxNumFacturedChunksToSpawnInAFrame
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: FractureExplosionVelScale
        /// </summary>
        public unsafe float FractureExplosionVelScale
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Enum: EConsoleType
    /// </summary>
    public enum EConsoleType : byte
    {
        CONSOLE_Any = 0,
        CONSOLE_Xbox360 = 1,
        CONSOLE_PS3 = 2,
        CONSOLE_Mobile = 3,
        CONSOLE_IPhone = 4,
        CONSOLE_Android = 5,
        CONSOLE_MAX = 6,
    }

    /// <summary>
    /// Struct: FPhysXVerticalProperties
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FPhysXVerticalProperties
    {
        /// <summary>
        /// StructProperty: Emitters
        /// </summary>
        public unsafe BmSDK.Engine.WorldInfo.FPhysXEmitterVerticalProperties Emitters
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.FPhysXEmitterVerticalProperties>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FPhysXEmitterVerticalProperties
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FPhysXEmitterVerticalProperties
    {
        /// <summary>
        /// BoolProperty: bDisableLod
        /// </summary>
        public unsafe bool bDisableLod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: ParticlesLodMin
        /// </summary>
        public unsafe int ParticlesLodMin
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: ParticlesLodMax
        /// </summary>
        public unsafe int ParticlesLodMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: PacketsPerPhysXParticleSystemMax
        /// </summary>
        public unsafe int PacketsPerPhysXParticleSystemMax
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// BoolProperty: bApplyCylindricalPacketCulling
        /// </summary>
        public unsafe bool bApplyCylindricalPacketCulling
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: SpawnLodVsFifoBias
        /// </summary>
        public unsafe float SpawnLodVsFifoBias
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Struct: FApexModuleDestructibleSettings
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FApexModuleDestructibleSettings
    {
        /// <summary>
        /// IntProperty: MaxChunkIslandCount
        /// </summary>
        public unsafe int MaxChunkIslandCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: MaxRrbActorCount
        /// </summary>
        public unsafe int MaxRrbActorCount
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: MaxChunkSeparationLOD
        /// </summary>
        public unsafe float MaxChunkSeparationLOD
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// BoolProperty: bOverrideMaxChunkSeparationLOD
        /// </summary>
        public unsafe bool bOverrideMaxChunkSeparationLOD
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FPhysXSceneProperties
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial record struct FPhysXSceneProperties
    {
        /// <summary>
        /// StructProperty: PrimaryScene
        /// </summary>
        public unsafe BmSDK.Engine.WorldInfo.FPhysXSimulationProperties PrimaryScene
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.FPhysXSimulationProperties>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: CompartmentRigidBody
        /// </summary>
        public unsafe BmSDK.Engine.WorldInfo.FPhysXSimulationProperties CompartmentRigidBody
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.FPhysXSimulationProperties>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// StructProperty: CompartmentFluid
        /// </summary>
        public unsafe BmSDK.Engine.WorldInfo.FPhysXSimulationProperties CompartmentFluid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.FPhysXSimulationProperties>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// StructProperty: CompartmentCloth
        /// </summary>
        public unsafe BmSDK.Engine.WorldInfo.FPhysXSimulationProperties CompartmentCloth
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.FPhysXSimulationProperties>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StructProperty: CompartmentSoftBody
        /// </summary>
        public unsafe BmSDK.Engine.WorldInfo.FPhysXSimulationProperties CompartmentSoftBody
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.FPhysXSimulationProperties>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FPhysXSimulationProperties
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 16)]
    public partial record struct FPhysXSimulationProperties
    {
        /// <summary>
        /// BoolProperty: bUseHardware
        /// </summary>
        public unsafe bool bUseHardware
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bFixedTimeStep
        /// </summary>
        public unsafe bool bFixedTimeStep
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: TimeStep
        /// </summary>
        public unsafe float TimeStep
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: MaxTimeStep
        /// </summary>
        public unsafe float MaxTimeStep
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// IntProperty: MaxSubSteps
        /// </summary>
        public unsafe int MaxSubSteps
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Struct: FCompartmentRunList
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FCompartmentRunList
    {
        /// <summary>
        /// BoolProperty: RigidBody
        /// </summary>
        public unsafe bool RigidBody
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Fluid
        /// </summary>
        public unsafe bool Fluid
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: Cloth
        /// </summary>
        public unsafe bool Cloth
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 4) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: SoftBody
        /// </summary>
        public unsafe bool SoftBody
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 8) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Struct: FNetViewer
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 32)]
    public partial record struct FNetViewer
    {
        /// <summary>
        /// ObjectProperty: InViewer
        /// </summary>
        public unsafe BmSDK.Engine.PlayerController InViewer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ObjectProperty: Viewer
        /// </summary>
        public unsafe BmSDK.Engine.Actor Viewer
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// StructProperty: ViewLocation
        /// </summary>
        public unsafe System.Numerics.Vector3 ViewLocation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StructProperty: ViewDir
        /// </summary>
        public unsafe System.Numerics.Vector3 ViewDir
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }
    }

    /// <summary>
    /// Enum: ENetMode
    /// </summary>
    public enum ENetMode : byte
    {
        NM_Standalone = 0,
        NM_DedicatedServer = 1,
        NM_ListenServer = 2,
        NM_Client = 3,
        NM_MAX = 4,
    }

    /// <summary>
    /// StructProperty: DefaultPostProcessSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.PostProcessVolume.FPostProcessSettings DefaultPostProcessSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.PostProcessVolume.FPostProcessSettings>(Ptr + 444);

    /// <summary>
    /// ObjectProperty: WorldPostProcessChain
    /// </summary>
    public unsafe BmSDK.Engine.PostProcessChain WorldPostProcessChain
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessChain>(Ptr + 844); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 844); }
    }

    /// <summary>
    /// BoolProperty: bPersistPostProcessToNextLevel
    /// </summary>
    public unsafe bool bPersistPostProcessToNextLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bMapNeedsLightingFullyRebuilt
    /// </summary>
    public unsafe bool bMapNeedsLightingFullyRebuilt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bMapHasDLEsOutsideOfImportanceVolume
    /// </summary>
    public unsafe bool bMapHasDLEsOutsideOfImportanceVolume
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bMapHasMultipleDominantLightsAffectingOnePrimitive
    /// </summary>
    public unsafe bool bMapHasMultipleDominantLightsAffectingOnePrimitive
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bMapHasPathingErrors
    /// </summary>
    public unsafe bool bMapHasPathingErrors
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bRequestedBlockOnAsyncLoading
    /// </summary>
    public unsafe bool bRequestedBlockOnAsyncLoading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bBegunPlay
    /// </summary>
    public unsafe bool bBegunPlay
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bPlayersOnly
    /// </summary>
    public unsafe bool bPlayersOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bPlayersOnlyPending
    /// </summary>
    public unsafe bool bPlayersOnlyPending
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bDropDetail
    /// </summary>
    public unsafe bool bDropDetail
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bAggressiveLOD
    /// </summary>
    public unsafe bool bAggressiveLOD
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bStartup
    /// </summary>
    public unsafe bool bStartup
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bPathsRebuilt
    /// </summary>
    public unsafe bool bPathsRebuilt
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bHasPathNodes
    /// </summary>
    public unsafe bool bHasPathNodes
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bIsMenuLevel
    /// </summary>
    public unsafe bool bIsMenuLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bUseConsoleInput
    /// </summary>
    public unsafe bool bUseConsoleInput
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bNoDefaultInventoryForPlayer
    /// </summary>
    public unsafe bool bNoDefaultInventoryForPlayer
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bNoPathWarnings
    /// </summary>
    public unsafe bool bNoPathWarnings
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bHighPriorityLoading
    /// </summary>
    public unsafe bool bHighPriorityLoading
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bHighPriorityLoadingLocal
    /// </summary>
    public unsafe bool bHighPriorityLoadingLocal
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: DebugMenuWantsPause
    /// </summary>
    public unsafe bool DebugMenuWantsPause
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bSupportDoubleBufferedPhysics
    /// </summary>
    public unsafe bool bSupportDoubleBufferedPhysics
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bEnableChanceOfPhysicsChunkOverride
    /// </summary>
    public unsafe bool bEnableChanceOfPhysicsChunkOverride
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bLimitExplosionChunkSize
    /// </summary>
    public unsafe bool bLimitExplosionChunkSize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bLimitDamageChunkSize
    /// </summary>
    public unsafe bool bLimitDamageChunkSize
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bPrecomputeVisibility
    /// </summary>
    public unsafe bool bPrecomputeVisibility
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bPlaceCellsOnSurfaces
    /// </summary>
    public unsafe bool bPlaceCellsOnSurfaces
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 67108864) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 67108864) : (currentMask & ~67108864); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bAllowLightEnvSphericalHarmonicLights
    /// </summary>
    public unsafe bool bAllowLightEnvSphericalHarmonicLights
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 134217728) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 134217728) : (currentMask & ~134217728); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bAllowModulateBetterShadows
    /// </summary>
    public unsafe bool bAllowModulateBetterShadows
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 268435456) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 268435456) : (currentMask & ~268435456); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bIncreaseFogNearPrecision
    /// </summary>
    public unsafe bool bIncreaseFogNearPrecision
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 536870912) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 536870912) : (currentMask & ~536870912); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bUseGlobalIllumination
    /// </summary>
    public unsafe bool bUseGlobalIllumination
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & 1073741824) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | 1073741824) : (currentMask & ~1073741824); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bForceNoPrecomputedLighting
    /// </summary>
    public unsafe bool bForceNoPrecomputedLighting
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848) & -2147483648) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 848); var newMask = value ? (currentMask | -2147483648) : (currentMask & ~-2147483648); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 848); }
    }

    /// <summary>
    /// BoolProperty: bSimpleLightmapsStoredInLinearSpace
    /// </summary>
    public unsafe bool bSimpleLightmapsStoredInLinearSpace
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bHaveActiveCrowd
    /// </summary>
    public unsafe bool bHaveActiveCrowd
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bMapAudioMode
    /// </summary>
    public unsafe bool bMapAudioMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// BoolProperty: bAllowHostMigration
    /// </summary>
    public unsafe bool bAllowHostMigration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 852); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 852); }
    }

    /// <summary>
    /// FloatProperty: SquintModeKernelSize
    /// </summary>
    public unsafe float SquintModeKernelSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 856); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 856); }
    }

    /// <summary>
    /// ObjectProperty: HighestPriorityPostProcessVolume
    /// </summary>
    public unsafe BmSDK.Engine.PostProcessVolume HighestPriorityPostProcessVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessVolume>(Ptr + 860); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 860); }
    }

    /// <summary>
    /// ObjectProperty: ForcedActivePostProcessVolume
    /// </summary>
    public unsafe BmSDK.Engine.PostProcessVolume ForcedActivePostProcessVolume
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PostProcessVolume>(Ptr + 864); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 864); }
    }

    /// <summary>
    /// ArrayProperty: MassiveLODOverrideVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.MassiveLODOverrideVolume> MassiveLODOverrideVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.MassiveLODOverrideVolume>>(Ptr + 868); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 868); }
    }

    /// <summary>
    /// ArrayProperty: PortalVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PortalVolume> PortalVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PortalVolume>>(Ptr + 880); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 880); }
    }

    /// <summary>
    /// ArrayProperty: EnvironmentVolumes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.EnvironmentVolume> EnvironmentVolumes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.EnvironmentVolume>>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ArrayProperty: StreamingLevels
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.LevelStreaming> StreamingLevels
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.LevelStreaming>>(Ptr + 904); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 904); }
    }

    /// <summary>
    /// StructProperty: LastTimeUnbuiltLightingWasEncountered
    /// </summary>
    public unsafe double LastTimeUnbuiltLightingWasEncountered
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<double>(Ptr + 916); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 916); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: BookMarks
    /// </summary>
    public InlineArray<BmSDK.Engine.BookMark> BookMarks => new(10, Ptr + 924, 4, this);

    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe BmSDK.Engine.BookMark BookMarks_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.BookMark>(Ptr + 924); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 924); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe BmSDK.Engine.BookMark BookMarks_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.BookMark>(Ptr + 928); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 928); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe BmSDK.Engine.BookMark BookMarks_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.BookMark>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe BmSDK.Engine.BookMark BookMarks_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.BookMark>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe BmSDK.Engine.BookMark BookMarks_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.BookMark>(Ptr + 940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 940); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe BmSDK.Engine.BookMark BookMarks_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.BookMark>(Ptr + 944); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 944); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe BmSDK.Engine.BookMark BookMarks_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.BookMark>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe BmSDK.Engine.BookMark BookMarks_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.BookMark>(Ptr + 952); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 952); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe BmSDK.Engine.BookMark BookMarks_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.BookMark>(Ptr + 956); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 956); }
    }
    /// <summary>
    /// ObjectProperty: BookMarks
    /// </summary>
    public unsafe BmSDK.Engine.BookMark BookMarks_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.BookMark>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }

    /// <summary>
    /// InlineArray{ObjectProperty}: KismetBookMarks
    /// </summary>
    public InlineArray<BmSDK.Engine.KismetBookMark> KismetBookMarks => new(10, Ptr + 964, 4, this);

    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe BmSDK.Engine.KismetBookMark KismetBookMarks_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KismetBookMark>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe BmSDK.Engine.KismetBookMark KismetBookMarks_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KismetBookMark>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe BmSDK.Engine.KismetBookMark KismetBookMarks_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KismetBookMark>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe BmSDK.Engine.KismetBookMark KismetBookMarks_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KismetBookMark>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe BmSDK.Engine.KismetBookMark KismetBookMarks_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KismetBookMark>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe BmSDK.Engine.KismetBookMark KismetBookMarks_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KismetBookMark>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe BmSDK.Engine.KismetBookMark KismetBookMarks_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KismetBookMark>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe BmSDK.Engine.KismetBookMark KismetBookMarks_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KismetBookMark>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe BmSDK.Engine.KismetBookMark KismetBookMarks_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KismetBookMark>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }
    /// <summary>
    /// ObjectProperty: KismetBookMarks
    /// </summary>
    public unsafe BmSDK.Engine.KismetBookMark KismetBookMarks_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.KismetBookMark>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ArrayProperty: ClipPadEntries
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.ClipPadEntry> ClipPadEntries
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.ClipPadEntry>>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// FloatProperty: TimeDilation
    /// </summary>
    public unsafe float TimeDilation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// FloatProperty: DemoPlayTimeDilation
    /// </summary>
    public unsafe float DemoPlayTimeDilation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// FloatProperty: TimeSeconds
    /// </summary>
    public unsafe float TimeSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1024); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1024); }
    }

    /// <summary>
    /// FloatProperty: RealTimeSeconds
    /// </summary>
    public unsafe float RealTimeSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: AudioTimeSeconds
    /// </summary>
    public unsafe float AudioTimeSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: DeltaSeconds
    /// </summary>
    public unsafe float DeltaSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: PauseDelay
    /// </summary>
    public unsafe float PauseDelay
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: RealTimeToUnPause
    /// </summary>
    public unsafe float RealTimeToUnPause
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: SubtitleTimeSeconds
    /// </summary>
    public unsafe float SubtitleTimeSeconds
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// ObjectProperty: Pauser
    /// </summary>
    public unsafe BmSDK.Engine.PlayerReplicationInfo Pauser
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerReplicationInfo>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// StrProperty: VisibleGroups
    /// </summary>
    public unsafe BmSDK.FString VisibleGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// StrProperty: SelectedGroups
    /// </summary>
    public unsafe BmSDK.FString SelectedGroups
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1068); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1068); }
    }

    /// <summary>
    /// ObjectProperty: DefaultTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D DefaultTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1080); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1080); }
    }

    /// <summary>
    /// ObjectProperty: WireframeTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D WireframeTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1084); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1084); }
    }

    /// <summary>
    /// ObjectProperty: WhiteSquareTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D WhiteSquareTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1088); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1088); }
    }

    /// <summary>
    /// ObjectProperty: LargeVertex
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D LargeVertex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1092); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1092); }
    }

    /// <summary>
    /// ObjectProperty: BSPVertex
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D BSPVertex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1096); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1096); }
    }

    /// <summary>
    /// ArrayProperty: DeferredExecs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DeferredExecs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1100); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1100); }
    }

    /// <summary>
    /// ObjectProperty: GRI
    /// </summary>
    public unsafe BmSDK.Engine.GameReplicationInfo GRI
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameReplicationInfo>(Ptr + 1112); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1112); }
    }

    /// <summary>
    /// ByteProperty: NetMode
    /// </summary>
    public unsafe BmSDK.Engine.WorldInfo.ENetMode NetMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.ENetMode>(Ptr + 1116); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1116); }
    }

    /// <summary>
    /// ByteProperty: NextTravelType
    /// </summary>
    public unsafe BmSDK.Engine.Actor.ETravelType NextTravelType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Actor.ETravelType>(Ptr + 1117); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1117); }
    }

    /// <summary>
    /// ByteProperty: VisibilityAggressiveness
    /// </summary>
    public unsafe BmSDK.Engine.WorldInfo.EVisibilityAggressiveness VisibilityAggressiveness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.WorldInfo.EVisibilityAggressiveness>(Ptr + 1118); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1118); }
    }

    /// <summary>
    /// ByteProperty: LevelLightingQuality
    /// </summary>
    public unsafe BmSDK.Engine.EngineTypes.ELightingBuildQuality LevelLightingQuality
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.EngineTypes.ELightingBuildQuality>(Ptr + 1119); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1119); }
    }

    /// <summary>
    /// StrProperty: ComputerName
    /// </summary>
    public unsafe BmSDK.FString ComputerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1120); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1120); }
    }

    /// <summary>
    /// StrProperty: EngineVersion
    /// </summary>
    public unsafe BmSDK.FString EngineVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1132); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1132); }
    }

    /// <summary>
    /// StrProperty: MinNetVersion
    /// </summary>
    public unsafe BmSDK.FString MinNetVersion
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1144); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1144); }
    }

    /// <summary>
    /// ObjectProperty: Game
    /// </summary>
    public unsafe BmSDK.Engine.GameInfo Game
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameInfo>(Ptr + 1156); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1156); }
    }

    /// <summary>
    /// FloatProperty: StallZ
    /// </summary>
    public unsafe float StallZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1160); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1160); }
    }

    /// <summary>
    /// FloatProperty: WorldGravityZ
    /// </summary>
    public unsafe float WorldGravityZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1164); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1164); }
    }

    /// <summary>
    /// FloatProperty: DefaultGravityZ
    /// </summary>
    public unsafe float DefaultGravityZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// FloatProperty: GlobalGravityZ
    /// </summary>
    public unsafe float GlobalGravityZ
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// FloatProperty: RBPhysicsGravityScaling
    /// </summary>
    public unsafe float RBPhysicsGravityScaling
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1176); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1176); }
    }

    /// <summary>
    /// ObjectProperty: NavigationPointList
    /// </summary>
    public unsafe BmSDK.Engine.NavigationPoint NavigationPointList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavigationPoint>(Ptr + 1180); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1180); }
    }

    /// <summary>
    /// ObjectProperty: ControllerList
    /// </summary>
    public unsafe BmSDK.Engine.Controller ControllerList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// ObjectProperty: PawnList
    /// </summary>
    public unsafe BmSDK.Engine.Pawn PawnList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// ObjectProperty: CoverList
    /// </summary>
    public unsafe BmSDK.Engine.CoverLink CoverList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.CoverLink>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ObjectProperty: PylonList
    /// </summary>
    public unsafe BmSDK.Engine.Pylon PylonList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pylon>(Ptr + 1196); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1196); }
    }

    /// <summary>
    /// FloatProperty: MoveRepSize
    /// </summary>
    public unsafe float MoveRepSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1200); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1200); }
    }

    /// <summary>
    /// ArrayProperty: ReplicationViewers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.WorldInfo.FNetViewer> ReplicationViewers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.WorldInfo.FNetViewer>>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// StrProperty: NextURL
    /// </summary>
    public unsafe BmSDK.FString NextURL
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// FloatProperty: NextSwitchCountdown
    /// </summary>
    public unsafe float NextSwitchCountdown
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// IntProperty: PackedLightAndShadowMapTextureSize
    /// </summary>
    public unsafe int PackedLightAndShadowMapTextureSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// StructProperty: DefaultColorScale
    /// </summary>
    public unsafe ref System.Numerics.Vector3 DefaultColorScale
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1236);

    /// <summary>
    /// ArrayProperty: GameTypesSupportedOnThisMap
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Class> GameTypesSupportedOnThisMap
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Class>>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ClassProperty: GameTypeForPIE
    /// </summary>
    public unsafe BmSDK.Class GameTypeForPIE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// ArrayProperty: ClientDestroyedActorContent
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> ClientDestroyedActorContent
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ArrayProperty: PreparingLevelNames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FName> PreparingLevelNames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FName>>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// NameProperty: CommittedPersistentLevelName
    /// </summary>
    public unsafe BmSDK.FName CommittedPersistentLevelName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// ObjectProperty: PersistentMapForcedObjects
    /// </summary>
    public unsafe BmSDK.Engine.ObjectReferencer PersistentMapForcedObjects
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ObjectReferencer>(Ptr + 1296); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1296); }
    }

    /// <summary>
    /// StrProperty: Title
    /// </summary>
    public unsafe BmSDK.FString Title
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// ObjectProperty: MyMapInfo
    /// </summary>
    public unsafe BmSDK.Engine.MapInfo MyMapInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.MapInfo>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// ArrayProperty: ParticleAttractorComponents
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.RParticleAttractorComponent> ParticleAttractorComponents
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.RParticleAttractorComponent>>(Ptr + 1316); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1316); }
    }

    /// <summary>
    /// StrProperty: SetFlagsInPIE
    /// </summary>
    public unsafe BmSDK.FString SetFlagsInPIE
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1328); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1328); }
    }

    /// <summary>
    /// NameProperty: PlayerCharacterName
    /// </summary>
    public unsafe BmSDK.FName PlayerCharacterName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// StrProperty: EmitterPoolClassPath
    /// </summary>
    public unsafe BmSDK.FString EmitterPoolClassPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1348); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1348); }
    }

    /// <summary>
    /// ObjectProperty: MyEmitterPool
    /// </summary>
    public unsafe BmSDK.Engine.EmitterPool MyEmitterPool
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.EmitterPool>(Ptr + 1360); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1360); }
    }

    /// <summary>
    /// StrProperty: DecalManagerClassPath
    /// </summary>
    public unsafe BmSDK.FString DecalManagerClassPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ObjectProperty: MyDecalManager
    /// </summary>
    public unsafe BmSDK.Engine.DecalManager MyDecalManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.DecalManager>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// StrProperty: FractureManagerClassPath
    /// </summary>
    public unsafe BmSDK.FString FractureManagerClassPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1380); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1380); }
    }

    /// <summary>
    /// ObjectProperty: MyFractureManager
    /// </summary>
    public unsafe BmSDK.Engine.FractureManager MyFractureManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.FractureManager>(Ptr + 1392); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1392); }
    }

    /// <summary>
    /// StrProperty: ParticleEventManagerClassPath
    /// </summary>
    public unsafe BmSDK.FString ParticleEventManagerClassPath
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1396); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1396); }
    }

    /// <summary>
    /// ObjectProperty: MyParticleEventManager
    /// </summary>
    public unsafe BmSDK.Engine.ParticleEventManager MyParticleEventManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.ParticleEventManager>(Ptr + 1408); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1408); }
    }

    /// <summary>
    /// FloatProperty: MaxPhysicsDeltaTime
    /// </summary>
    public unsafe float MaxPhysicsDeltaTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1412); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1412); }
    }

    /// <summary>
    /// IntProperty: MaxPhysicsSubsteps
    /// </summary>
    public unsafe int MaxPhysicsSubsteps
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// StructProperty: PhysicsProperties
    /// </summary>
    public unsafe ref BmSDK.Engine.WorldInfo.FPhysXSceneProperties PhysicsProperties
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.WorldInfo.FPhysXSceneProperties>(Ptr + 1420);

    /// <summary>
    /// ArrayProperty: CompartmentRunFrames
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.WorldInfo.FCompartmentRunList> CompartmentRunFrames
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.WorldInfo.FCompartmentRunList>>(Ptr + 1500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1500); }
    }

    /// <summary>
    /// FloatProperty: DefaultSkinWidth
    /// </summary>
    public unsafe float DefaultSkinWidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1512); }
    }

    /// <summary>
    /// FloatProperty: ApexLODResourceBudget
    /// </summary>
    public unsafe float ApexLODResourceBudget
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1516); }
    }

    /// <summary>
    /// StructProperty: DestructibleSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.WorldInfo.FApexModuleDestructibleSettings DestructibleSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.WorldInfo.FApexModuleDestructibleSettings>(Ptr + 1520);

    /// <summary>
    /// ObjectProperty: EmitterVertical
    /// </summary>
    public unsafe BmSDK.Engine.PhysicsLODVerticalEmitter EmitterVertical
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PhysicsLODVerticalEmitter>(Ptr + 1536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1536); }
    }

    /// <summary>
    /// StructProperty: VerticalProperties
    /// </summary>
    public unsafe ref BmSDK.Engine.WorldInfo.FPhysXVerticalProperties VerticalProperties
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.WorldInfo.FPhysXVerticalProperties>(Ptr + 1540);

    /// <summary>
    /// FloatProperty: ChanceOfPhysicsChunkOverride
    /// </summary>
    public unsafe float ChanceOfPhysicsChunkOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1564); }
    }

    /// <summary>
    /// FloatProperty: MaxExplosionChunkSize
    /// </summary>
    public unsafe float MaxExplosionChunkSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1568); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1568); }
    }

    /// <summary>
    /// FloatProperty: MaxDamageChunkSize
    /// </summary>
    public unsafe float MaxDamageChunkSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1572); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1572); }
    }

    /// <summary>
    /// FloatProperty: FractureExplosionVelScale
    /// </summary>
    public unsafe float FractureExplosionVelScale
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1576); }
    }

    /// <summary>
    /// IntProperty: MaxNumFacturedChunksToSpawnInAFrame
    /// </summary>
    public unsafe int MaxNumFacturedChunksToSpawnInAFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1580); }
    }

    /// <summary>
    /// IntProperty: NumFacturedChunksSpawnedThisFrame
    /// </summary>
    public unsafe int NumFacturedChunksSpawnedThisFrame
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1584); }
    }

    /// <summary>
    /// FloatProperty: FracturedMeshWeaponDamage
    /// </summary>
    public unsafe float FracturedMeshWeaponDamage
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1588); }
    }

    /// <summary>
    /// IntProperty: VisibilityCellSize
    /// </summary>
    public unsafe int VisibilityCellSize
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1592); }
    }

    /// <summary>
    /// FloatProperty: CharacterLitIndirectBrightness
    /// </summary>
    public unsafe float CharacterLitIndirectBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1596); }
    }

    /// <summary>
    /// FloatProperty: CharacterLitIndirectContrastFactor
    /// </summary>
    public unsafe float CharacterLitIndirectContrastFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1600); }
    }

    /// <summary>
    /// FloatProperty: CharacterShadowedIndirectBrightness
    /// </summary>
    public unsafe float CharacterShadowedIndirectBrightness
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1604); }
    }

    /// <summary>
    /// FloatProperty: CharacterShadowedIndirectContrastFactor
    /// </summary>
    public unsafe float CharacterShadowedIndirectContrastFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1608); }
    }

    /// <summary>
    /// FloatProperty: CharacterLightingContrastFactor
    /// </summary>
    public unsafe float CharacterLightingContrastFactor
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1612); }
    }

    /// <summary>
    /// ObjectProperty: ImageReflectionEnvironmentTexture
    /// </summary>
    public unsafe BmSDK.Engine.Texture2D ImageReflectionEnvironmentTexture
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Texture2D>(Ptr + 1616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1616); }
    }

    /// <summary>
    /// StructProperty: ImageReflectionEnvironmentColor
    /// </summary>
    public unsafe ref BmSDK.GameObject.FLinearColor ImageReflectionEnvironmentColor
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FLinearColor>(Ptr + 1620);

    /// <summary>
    /// FloatProperty: ImageReflectionEnvironmentRotation
    /// </summary>
    public unsafe float ImageReflectionEnvironmentRotation
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1636); }
    }

    /// <summary>
    /// StructProperty: ScreenMessages
    /// </summary>
    public unsafe ref BmSDK.GameObject.FMap_Mirror ScreenMessages
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.GameObject.FMap_Mirror>(Ptr + 1640);

    /// <summary>
    /// ArrayProperty: PriorityScreenMessages
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.WorldInfo.FScreenMessageString> PriorityScreenMessages
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.WorldInfo.FScreenMessageString>>(Ptr + 1700); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1700); }
    }

    /// <summary>
    /// IntProperty: MaxTrianglesPerLeaf
    /// </summary>
    public unsafe int MaxTrianglesPerLeaf
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1712); }
    }

    /// <summary>
    /// ComponentProperty: InteractionManager
    /// </summary>
    public unsafe BmSDK.Engine.RInteractionManager InteractionManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.RInteractionManager>(Ptr + 1716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1716); }
    }

    /// <summary>
    /// StructProperty: PlayerLocation
    /// </summary>
    public unsafe ref System.Numerics.Vector3 PlayerLocation
        => ref BmSDK.Framework.MarshalUtil.AsRef<System.Numerics.Vector3>(Ptr + 1720);

    /// <summary>
    /// StructProperty: LightmassSettings
    /// </summary>
    public unsafe ref BmSDK.Engine.WorldInfo.FLightmassWorldInfoSettings LightmassSettings
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.WorldInfo.FLightmassWorldInfoSettings>(Ptr + 1732);

    /// <summary>
    /// MapProperty: NavMeshPathConstraintCache
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ NavMeshPathConstraintCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 1792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1792); }
    }

    /// <summary>
    /// MapProperty: NavMeshPathGoalEvaluatorCache
    /// </summary>
    public unsafe BmSDK.TMap<object, object> /* TODO */ NavMeshPathGoalEvaluatorCache
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TMap<object, object> /* TODO */>(Ptr + 1852); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1852); }
    }

    /// <summary>
    /// StructProperty: PeerHostMigration
    /// </summary>
    public unsafe ref BmSDK.Engine.WorldInfo.FHostMigrationState PeerHostMigration
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.Engine.WorldInfo.FHostMigrationState>(Ptr + 1912);

    /// <summary>
    /// FloatProperty: HostMigrationTimeout
    /// </summary>
    public unsafe float HostMigrationTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1940); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1940); }
    }
}
