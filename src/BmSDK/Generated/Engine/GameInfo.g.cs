#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Class: GameInfo<br/>
/// (size = 816)
/// (flags = 142606518)
/// </summary>
public partial class GameInfo : BmSDK.Engine.Info, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.GameInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as GameInfo.
    /// </summary>
    public static GameInfo DefaultObject => (GameInfo)StaticClass().DefaultObject;

    internal GameInfo() { }

    /// <summary>
    /// Constructs a new GameInfo
    /// </summary>
    public GameInfo(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected GameInfo(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameInfo>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<GameInfo>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: OnEngineHasLoaded
    /// </summary>
    public unsafe virtual void OnEngineHasLoaded()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.OnEngineHasLoaded", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EnableStandbyCheatDetection
    /// </summary>
    public unsafe virtual void EnableStandbyCheatDetection(bool bIsEnabled)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.EnableStandbyCheatDetection", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bIsEnabled, paramsPtr + 0);
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
    /// Function: GetGameTimePlayed
    /// </summary>
    public unsafe virtual float GetGameTimePlayed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetGameTimePlayed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: OnServerCreateComplete
    /// </summary>
    public unsafe virtual void OnServerCreateComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.OnServerCreateComplete", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterServer
    /// </summary>
    public unsafe virtual void RegisterServer()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.RegisterServer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnLoginChange
    /// </summary>
    public unsafe virtual void OnLoginChange(byte LocalUserNum)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.OnLoginChange", true);
        byte* paramsPtr = stackalloc byte[1];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnLoginFailed
    /// </summary>
    public unsafe virtual void OnLoginFailed(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus ErrorCode)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.OnLoginFailed", true);
        byte* paramsPtr = stackalloc byte[2];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LocalUserNum, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ErrorCode, paramsPtr + 1);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ClearAutoLoginDelegates
    /// </summary>
    public unsafe virtual void ClearAutoLoginDelegates()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ClearAutoLoginDelegates", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MatineeCancelled
    /// </summary>
    public unsafe virtual void MatineeCancelled()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.MatineeCancelled", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RecalculateSkillRating
    /// </summary>
    public unsafe virtual void RecalculateSkillRating()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.RecalculateSkillRating", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyArbitratedMatchEnd
    /// </summary>
    public unsafe virtual void NotifyArbitratedMatchEnd()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.NotifyArbitratedMatchEnd", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MatchIsInProgress
    /// </summary>
    public unsafe virtual bool MatchIsInProgress()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.MatchIsInProgress", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ArbitrationRegistrationComplete
    /// </summary>
    public unsafe virtual void ArbitrationRegistrationComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ArbitrationRegistrationComplete", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterServerForArbitration
    /// </summary>
    public unsafe virtual void RegisterServerForArbitration()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.RegisterServerForArbitration", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartArbitratedMatch
    /// </summary>
    public unsafe virtual void StartArbitratedMatch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.StartArbitratedMatch", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartArbitrationRegistration
    /// </summary>
    public unsafe virtual void StartArbitrationRegistration()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.StartArbitrationRegistration", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ProcessClientRegistrationCompletion
    /// </summary>
    public unsafe virtual void ProcessClientRegistrationCompletion(BmSDK.Engine.PlayerController PC, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ProcessClientRegistrationCompletion", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateGameSettingsCounts
    /// </summary>
    public unsafe virtual void UpdateGameSettingsCounts()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.UpdateGameSettingsCounts", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetSeamlessTravelViewTarget
    /// </summary>
    public unsafe virtual void SetSeamlessTravelViewTarget(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.SetSeamlessTravelViewTarget", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HandleSeamlessTravelPlayer
    /// </summary>
    public unsafe virtual void HandleSeamlessTravelPlayer(out BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.HandleSeamlessTravelPlayer", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        C = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: UpdateGameSettings
    /// </summary>
    public unsafe virtual void UpdateGameSettings()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.UpdateGameSettings", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostSeamlessTravel
    /// </summary>
    public unsafe virtual void PostSeamlessTravel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PostSeamlessTravel", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SwapPlayerControllers
    /// </summary>
    public unsafe virtual void SwapPlayerControllers(BmSDK.Engine.PlayerController OldPC, BmSDK.Engine.PlayerController NewPC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.SwapPlayerControllers", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPC, paramsPtr + 4);
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
    /// Function: GetSeamlessTravelActorList
    /// </summary>
    public unsafe virtual void GetSeamlessTravelActorList(bool bToEntry, out BmSDK.TArray<BmSDK.Engine.Actor> ActorList)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetSeamlessTravelActorList", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bToEntry, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ActorList = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.Actor>>(paramsPtr + 4);
        return;
    }

    /// <summary>
    /// Function: OverridePRI
    /// </summary>
    public unsafe virtual void OverridePRI(BmSDK.Engine.PlayerController PC, BmSDK.Engine.PlayerReplicationInfo OldPRI)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.OverridePRI", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldPRI, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindInactivePRI
    /// </summary>
    public unsafe virtual bool FindInactivePRI(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.FindInactivePRI", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: AddInactivePRI
    /// </summary>
    public unsafe virtual void AddInactivePRI(BmSDK.Engine.PlayerReplicationInfo PRI, BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.AddInactivePRI", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PRI, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostCommitMapChange
    /// </summary>
    public unsafe virtual void PostCommitMapChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PostCommitMapChange", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreCommitMapChange
    /// </summary>
    public unsafe virtual void PreCommitMapChange(BmSDK.FString PreviousMapName, BmSDK.FString NextMapName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PreCommitMapChange", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousMapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextMapName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AllowPausing
    /// </summary>
    public unsafe virtual bool AllowPausing(BmSDK.Engine.PlayerController PC = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.AllowPausing", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: AllowCheats
    /// </summary>
    public unsafe virtual bool AllowCheats(BmSDK.Engine.PlayerController P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.AllowCheats", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PlayerCanRestart
    /// </summary>
    public unsafe virtual bool PlayerCanRestart(BmSDK.Engine.PlayerController aPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PlayerCanRestart", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: PlayerCanRestartGame
    /// </summary>
    public unsafe virtual bool PlayerCanRestartGame(BmSDK.Engine.PlayerController aPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PlayerCanRestartGame", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(aPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ModifyScoreKill
    /// </summary>
    public unsafe virtual void ModifyScoreKill(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller Other)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ModifyScoreKill", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ScoreKill
    /// </summary>
    public unsafe virtual void ScoreKill(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller Other)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ScoreKill", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckScore
    /// </summary>
    public unsafe virtual bool CheckScore(BmSDK.Engine.PlayerReplicationInfo Scorer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.CheckScore", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Scorer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: RatePlayerStart
    /// </summary>
    public unsafe virtual float RatePlayerStart(BmSDK.Engine.PlayerStart P, byte Team, BmSDK.Engine.Controller Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.RatePlayerStart", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ChoosePlayerStart
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerStart ChoosePlayerStart(BmSDK.Engine.Controller Player, byte InTeam = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ChoosePlayerStart", true);
        byte* paramsPtr = stackalloc byte[29];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTeam, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerStart>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: FindPlayerStart
    /// </summary>
    public unsafe virtual BmSDK.Engine.NavigationPoint FindPlayerStart(BmSDK.Engine.Controller Player, byte InTeam = default, BmSDK.FString IncomingName = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.FindPlayerStart", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InTeam, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(IncomingName, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.NavigationPoint>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: ShouldSpawnAtStartSpot
    /// </summary>
    public unsafe virtual bool ShouldSpawnAtStartSpot(BmSDK.Engine.Controller Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ShouldSpawnAtStartSpot", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: EndLogging
    /// </summary>
    public unsafe virtual void EndLogging(BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.EndLogging", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GameEventsPoll
    /// </summary>
    public unsafe virtual void GameEventsPoll()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GameEventsPoll", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EndOnlineGame
    /// </summary>
    public unsafe virtual void EndOnlineGame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.EndOnlineGame", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PerformEndGameHandling
    /// </summary>
    public unsafe virtual void PerformEndGameHandling()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PerformEndGameHandling", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: EndGame
    /// </summary>
    public unsafe virtual void EndGame(BmSDK.Engine.PlayerReplicationInfo Winner, BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.EndGame", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WriteOnlinePlayerScores
    /// </summary>
    public unsafe virtual void WriteOnlinePlayerScores()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.WriteOnlinePlayerScores", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: WriteOnlineStats
    /// </summary>
    public unsafe virtual void WriteOnlineStats()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.WriteOnlineStats", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckEndGame
    /// </summary>
    public unsafe virtual bool CheckEndGame(BmSDK.Engine.PlayerReplicationInfo Winner, BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.CheckEndGame", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CheckModifiedEndGame
    /// </summary>
    public unsafe virtual bool CheckModifiedEndGame(BmSDK.Engine.PlayerReplicationInfo Winner, BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.CheckModifiedEndGame", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: RestartGame
    /// </summary>
    public unsafe virtual void RestartGame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.RestartGame", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetTravelType
    /// </summary>
    public unsafe virtual bool GetTravelType()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetTravelType", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNextMap
    /// </summary>
    public unsafe virtual BmSDK.FString GetNextMap()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetNextMap", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: PickTeam
    /// </summary>
    public unsafe virtual byte PickTeam(byte Current, BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PickTeam", true);
        byte* paramsPtr = stackalloc byte[9];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Current, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: ChangeTeam
    /// </summary>
    public unsafe virtual bool ChangeTeam(BmSDK.Engine.Controller Other, int N, bool bNewTeam)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ChangeTeam", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(N, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNewTeam, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ChangeName
    /// </summary>
    public unsafe virtual void ChangeName(BmSDK.Engine.Controller Other, BmSDK.FString S, bool bNameChange)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ChangeName", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(S, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bNameChange, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DiscardInventory
    /// </summary>
    public unsafe virtual void DiscardInventory(BmSDK.Engine.Pawn Other, BmSDK.Engine.Controller Killer = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.DiscardInventory", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PickupQuery
    /// </summary>
    public unsafe virtual bool PickupQuery(BmSDK.Engine.Pawn Other, BmSDK.Class ItemClass, BmSDK.Engine.Actor Pickup)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PickupQuery", true);
        byte* paramsPtr = stackalloc byte[17];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ItemClass, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pickup, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: ShouldRespawn
    /// </summary>
    public unsafe virtual bool ShouldRespawn(BmSDK.Engine.PickupFactory Other)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ShouldRespawn", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: CheckRelevance
    /// </summary>
    public unsafe virtual bool CheckRelevance(BmSDK.Engine.Actor Other)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.CheckRelevance", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Other, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ReduceDamage
    /// </summary>
    public unsafe virtual void ReduceDamage(out int Damage, BmSDK.Engine.Pawn injured, BmSDK.Engine.Controller InstigatedBy, System.Numerics.Vector3 HitLocation, out System.Numerics.Vector3 Momentum, BmSDK.Class DamageType, BmSDK.Engine.Actor DamageCauser)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ReduceDamage", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(injured, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InstigatedBy, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 36);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageCauser, paramsPtr + 40);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Damage = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        Momentum = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
        return;
    }

    /// <summary>
    /// Function: CanSpectate
    /// </summary>
    public unsafe virtual bool CanSpectate(BmSDK.Engine.PlayerController Viewer, BmSDK.Engine.PlayerReplicationInfo ViewTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.CanSpectate", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Viewer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ViewTarget, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: KickBan
    /// </summary>
    public unsafe virtual void KickBan(BmSDK.FString S)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.KickBan", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(S, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Kick
    /// </summary>
    public unsafe virtual void Kick(BmSDK.FString S)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.Kick", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(S, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreventDeath
    /// </summary>
    public unsafe virtual bool PreventDeath(BmSDK.Engine.Pawn KilledPawn, BmSDK.Engine.Controller Killer, BmSDK.Class DamageType, System.Numerics.Vector3 HitLocation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PreventDeath", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HitLocation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: Killed
    /// </summary>
    public unsafe virtual void Killed(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.Killed", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyKilled
    /// </summary>
    public unsafe virtual void NotifyKilled(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller Killed, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.NotifyKilled", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killed, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPlayerDefaults
    /// </summary>
    public unsafe virtual void SetPlayerDefaults(BmSDK.Engine.Pawn PlayerPawn)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.SetPlayerDefaults", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerPawn, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Mutate
    /// </summary>
    public unsafe virtual void Mutate(BmSDK.FString MutateString, BmSDK.Engine.PlayerController Sender)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.Mutate", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutateString, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Sender, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AddDefaultInventory
    /// </summary>
    public unsafe virtual void AddDefaultInventory(BmSDK.Engine.Pawn P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.AddDefaultInventory", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnregisterPlayer
    /// </summary>
    public unsafe virtual void UnregisterPlayer(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.UnregisterPlayer", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Logout
    /// </summary>
    public unsafe virtual void Logout(BmSDK.Engine.Controller Exiting)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.Logout", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Exiting, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreExit
    /// </summary>
    public unsafe virtual void PreExit()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PreExit", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateNetSpeeds
    /// </summary>
    public unsafe virtual void UpdateNetSpeeds()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.UpdateNetSpeeds", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostLogin
    /// </summary>
    public unsafe virtual void PostLogin(BmSDK.Engine.PlayerController NewPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PostLogin", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GenericPlayerInitialization
    /// </summary>
    public unsafe virtual void GenericPlayerInitialization(BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GenericPlayerInitialization", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDefaultPlayerClass
    /// </summary>
    public unsafe virtual BmSDK.Class GetDefaultPlayerClass(BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetDefaultPlayerClass", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SpawnDefaultPawnFor
    /// </summary>
    public unsafe virtual BmSDK.Engine.Pawn SpawnDefaultPawnFor(BmSDK.Engine.Controller NewPlayer, BmSDK.Engine.NavigationPoint StartSpot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.SpawnDefaultPawnFor", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartSpot, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: RestartPlayer
    /// </summary>
    public unsafe virtual void RestartPlayer(BmSDK.Engine.Controller NewPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.RestartPlayer", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartBots
    /// </summary>
    public unsafe virtual void StartBots()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.StartBots", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartHumans
    /// </summary>
    public unsafe virtual void StartHumans()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.StartHumans", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnStartOnlineGameComplete
    /// </summary>
    public unsafe virtual void OnStartOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.OnStartOnlineGameComplete", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SessionName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bWasSuccessful, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartOnlineGame
    /// </summary>
    public unsafe virtual void StartOnlineGame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.StartOnlineGame", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: StartMatch
    /// </summary>
    public unsafe virtual void StartMatch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.StartMatch", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Login
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerController Login(BmSDK.FString Portal, BmSDK.FString Options, BmSDK.Engine.OnlineSubsystem.FUniqueNetId UniqueId, out BmSDK.FString ErrorMessage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.Login", true);
        byte* paramsPtr = stackalloc byte[120];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Portal, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(UniqueId, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 32);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: SpawnPlayerController
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerController SpawnPlayerController(System.Numerics.Vector3 SpawnLocation, BmSDK.Rotator SpawnRotation)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.SpawnPlayerController", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnLocation, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SpawnRotation, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: GetNextPlayerID
    /// </summary>
    public unsafe virtual int GetNextPlayerID()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetNextPlayerID", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: AtCapacity
    /// </summary>
    public unsafe virtual bool AtCapacity(bool bSpectator)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.AtCapacity", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSpectator, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: ProcessClientTravel
    /// </summary>
    public unsafe virtual BmSDK.Engine.PlayerController ProcessClientTravel(out BmSDK.FString URL, BmSDK.GameObject.FGuid NextMapGuid, bool bSeamless, bool bAbsolute)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ProcessClientTravel", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextMapGuid, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bSeamless, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbsolute, paramsPtr + 20);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        URL = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.PlayerController>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: ProcessServerTravel
    /// </summary>
    public unsafe virtual void ProcessServerTravel(BmSDK.FString URL, bool bAbsolute = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ProcessServerTravel", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(URL, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAbsolute, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RemoveMutator
    /// </summary>
    public unsafe virtual void RemoveMutator(BmSDK.Engine.Mutator MutatorToRemove)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.RemoveMutator", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MutatorToRemove, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyPendingConnectionLost
    /// </summary>
    public unsafe virtual void NotifyPendingConnectionLost()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.NotifyPendingConnectionLost", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InitGame
    /// </summary>
    public unsafe virtual void InitGame(BmSDK.FString Options, out BmSDK.FString ErrorMessage)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.InitGame", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        ErrorMessage = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
        return;
    }

    /// <summary>
    /// Function: SetGameType
    /// </summary>
    public unsafe static BmSDK.Class SetGameType(BmSDK.FString MapName, BmSDK.FString Options, BmSDK.FString Portal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.SetGameType", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Portal, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: GetDefaultGameClassPath
    /// </summary>
    public unsafe static BmSDK.FString GetDefaultGameClassPath(BmSDK.FString MapName, BmSDK.FString Options, BmSDK.FString Portal)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetDefaultGameClassPath", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Portal, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 36);
    }

    /// <summary>
    /// Function: GetIntOption
    /// </summary>
    public unsafe static int GetIntOption(BmSDK.FString Options, BmSDK.FString ParseString, int CurrentValue)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetIntOption", true);
        byte* paramsPtr = stackalloc byte[44];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ParseString, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CurrentValue, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: HasOption
    /// </summary>
    public unsafe static bool HasOption(BmSDK.FString Options, BmSDK.FString InKey)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.HasOption", true);
        byte* paramsPtr = stackalloc byte[64];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: ParseOption
    /// </summary>
    public unsafe static BmSDK.FString ParseOption(BmSDK.FString Options, BmSDK.FString InKey)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ParseOption", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Options, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InKey, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: GetKeyValue
    /// </summary>
    public unsafe static void GetKeyValue(BmSDK.FString Pair, out BmSDK.FString Key, out BmSDK.FString Value)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetKeyValue", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Pair, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Key = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
        Value = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 24);
        return;
    }

    /// <summary>
    /// Function: GrabOption
    /// </summary>
    public unsafe static bool GrabOption(out BmSDK.FString Options, out BmSDK.FString Result)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GrabOption", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(StaticClass().DefaultObject.Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Options = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        Result = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: SetGameSpeedWithSFX
    /// </summary>
    public unsafe virtual void SetGameSpeedWithSFX(float T)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.SetGameSpeedWithSFX", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetGameSpeed
    /// </summary>
    public unsafe virtual void SetGameSpeed(float T)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.SetGameSpeed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(T, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DebugPause
    /// </summary>
    public unsafe virtual void DebugPause()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.DebugPause", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForceClearUnpauseDelegates
    /// </summary>
    public unsafe virtual void ForceClearUnpauseDelegates(BmSDK.Engine.Actor PauseActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ForceClearUnpauseDelegates", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PauseActor, paramsPtr + 0);
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
    /// Function: ClearPause
    /// </summary>
    public unsafe virtual void ClearPause()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ClearPause", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetPause
    /// </summary>
    public unsafe virtual bool SetPause(BmSDK.Engine.PlayerController PC, System.IntPtr CanUnpauseDelegate = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.SetPause", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CanUnpauseDelegate, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: CanUnpause
    /// </summary>
    public unsafe virtual bool CanUnpause()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.CanUnpause", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNumPlayers
    /// </summary>
    public unsafe virtual int GetNumPlayers()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetNumPlayers", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNetworkNumber
    /// </summary>
    public unsafe virtual BmSDK.FString GetNetworkNumber()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetNetworkNumber", true);
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
    /// Function: InitGameReplicationInfo
    /// </summary>
    public unsafe virtual void InitGameReplicationInfo()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.InitGameReplicationInfo", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ForceKickPlayer
    /// </summary>
    public unsafe virtual void ForceKickPlayer(BmSDK.Engine.PlayerController PC, BmSDK.FString KickReason)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ForceKickPlayer", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KickReason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: KickIdler
    /// </summary>
    public unsafe virtual void KickIdler(BmSDK.Engine.PlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.KickIdler", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GameEnding
    /// </summary>
    public unsafe virtual void GameEnding()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GameEnding", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: NotifyNavigationChanged
    /// </summary>
    public unsafe virtual void NotifyNavigationChanged(BmSDK.Engine.NavigationPoint N)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.NotifyNavigationChanged", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(N, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DoNavFearCostFallOff
    /// </summary>
    public unsafe virtual void DoNavFearCostFallOff()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.DoNavFearCostFallOff", true);
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
    /// Function: ResetLevel
    /// </summary>
    public unsafe virtual void ResetLevel()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ResetLevel", true);
        byte* paramsPtr = stackalloc byte[40];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShouldReset
    /// </summary>
    public unsafe virtual bool ShouldReset(BmSDK.Engine.Actor ActorToReset)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.ShouldReset", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ActorToReset, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: Reset
    /// </summary>
    public unsafe override void Reset()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.Reset", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DisplayDebug
    /// </summary>
    public unsafe override void DisplayDebug(BmSDK.Engine.HUD HUD, out float out_YL, out float out_YPos)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.DisplayDebug", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(HUD, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_YL = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 4);
        out_YPos = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 8);
        return;
    }

    /// <summary>
    /// Function: PostBeginPlay
    /// </summary>
    public unsafe override void PostBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PostBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.PreBeginPlay", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetMapCommonPackageName
    /// </summary>
    public unsafe virtual bool GetMapCommonPackageName(BmSDK.FString InFilename, out BmSDK.FString OutCommonPackageName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetMapCommonPackageName", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFilename, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutCommonPackageName = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: GetSupportedGameTypes
    /// </summary>
    public unsafe virtual bool GetSupportedGameTypes(BmSDK.FString InFilename, out BmSDK.Engine.GameInfo.FGameTypePrefix OutGameType, bool bCheckExt = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.GameInfo.GetSupportedGameTypes", true);
        byte* paramsPtr = stackalloc byte[72];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InFilename, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bCheckExt, paramsPtr + 64);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        OutGameType = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameInfo.FGameTypePrefix>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 68);
    }

    /// <summary>
    /// Struct: FGameTypePrefix
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FGameTypePrefix
    {
        /// <summary>
        /// StrProperty: Prefix
        /// </summary>
        public unsafe BmSDK.FString Prefix
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// BoolProperty: bUsesCommonPackage
        /// </summary>
        public unsafe bool bUsesCommonPackage
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: GameType
        /// </summary>
        public unsafe BmSDK.FString GameType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// ArrayProperty: AdditionalGameTypes
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> AdditionalGameTypes
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// ArrayProperty: ForcedObjects
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.FString> ForcedObjects
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FGameClassShortName
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FGameClassShortName
    {
        /// <summary>
        /// StrProperty: ShortName
        /// </summary>
        public unsafe BmSDK.FString ShortName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: GameClassName
        /// </summary>
        public unsafe BmSDK.FString GameClassName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// Enum: EStandbyType
    /// </summary>
    public enum EStandbyType : byte
    {
        STDBY_Rx = 0,
        STDBY_Tx = 1,
        STDBY_BadPing = 2,
        STDBY_MAX = 3,
    }

    /// <summary>
    /// BoolProperty: bRestartLevel
    /// </summary>
    public unsafe bool bRestartLevel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bPauseable
    /// </summary>
    public unsafe bool bPauseable
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bTeamGame
    /// </summary>
    public unsafe bool bTeamGame
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bGameEnded
    /// </summary>
    public unsafe bool bGameEnded
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bOverTime
    /// </summary>
    public unsafe bool bOverTime
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bDelayedStart
    /// </summary>
    public unsafe bool bDelayedStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bWaitingToStartMatch
    /// </summary>
    public unsafe bool bWaitingToStartMatch
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bChangeLevels
    /// </summary>
    public unsafe bool bChangeLevels
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bAlreadyChanged
    /// </summary>
    public unsafe bool bAlreadyChanged
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bAdminCanPause
    /// </summary>
    public unsafe bool bAdminCanPause
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bGameRestarted
    /// </summary>
    public unsafe bool bGameRestarted
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bLevelChange
    /// </summary>
    public unsafe bool bLevelChange
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bKickLiveIdlers
    /// </summary>
    public unsafe bool bKickLiveIdlers
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bUsingArbitration
    /// </summary>
    public unsafe bool bUsingArbitration
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bHasArbitratedHandshakeBegun
    /// </summary>
    public unsafe bool bHasArbitratedHandshakeBegun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bNeedsEndGameHandshake
    /// </summary>
    public unsafe bool bNeedsEndGameHandshake
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bIsEndGameHandshakeComplete
    /// </summary>
    public unsafe bool bIsEndGameHandshakeComplete
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bHasEndGameHandshakeBegun
    /// </summary>
    public unsafe bool bHasEndGameHandshakeBegun
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bFixedPlayerStart
    /// </summary>
    public unsafe bool bFixedPlayerStart
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bDoFearCostFallOff
    /// </summary>
    public unsafe bool bDoFearCostFallOff
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bUseSeamlessTravel
    /// </summary>
    public unsafe bool bUseSeamlessTravel
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bHasNetworkError
    /// </summary>
    public unsafe bool bHasNetworkError
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 2097152) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 2097152) : (currentMask & ~2097152); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bRequiresPushToTalk
    /// </summary>
    public unsafe bool bRequiresPushToTalk
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 4194304) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 4194304) : (currentMask & ~4194304); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bIsStandbyCheckingEnabled
    /// </summary>
    public unsafe bool bIsStandbyCheckingEnabled
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 8388608) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 8388608) : (currentMask & ~8388608); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bIsStandbyCheckingOn
    /// </summary>
    public unsafe bool bIsStandbyCheckingOn
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 16777216) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 16777216) : (currentMask & ~16777216); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// BoolProperty: bHasStandbyCheatTriggered
    /// </summary>
    public unsafe bool bHasStandbyCheatTriggered
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428) & 33554432) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 428); var newMask = value ? (currentMask | 33554432) : (currentMask & ~33554432); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 428); }
    }

    /// <summary>
    /// StrProperty: CauseEventCommand
    /// </summary>
    public unsafe BmSDK.FString CauseEventCommand
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 432); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 432); }
    }

    /// <summary>
    /// StrProperty: BugLocString
    /// </summary>
    public unsafe BmSDK.FString BugLocString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 444); }
    }

    /// <summary>
    /// StrProperty: BugRotString
    /// </summary>
    public unsafe BmSDK.FString BugRotString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 456); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 456); }
    }

    /// <summary>
    /// ArrayProperty: PendingArbitrationPCs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerController> PendingArbitrationPCs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerController>>(Ptr + 468); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 468); }
    }

    /// <summary>
    /// ArrayProperty: ArbitrationPCs
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerController> ArbitrationPCs
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerController>>(Ptr + 480); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 480); }
    }

    /// <summary>
    /// FloatProperty: ArbitrationHandshakeTimeout
    /// </summary>
    public unsafe float ArbitrationHandshakeTimeout
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 492); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 492); }
    }

    /// <summary>
    /// FloatProperty: GameDifficulty
    /// </summary>
    public unsafe float GameDifficulty
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 496); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 496); }
    }

    /// <summary>
    /// IntProperty: GoreLevel
    /// </summary>
    public unsafe int GoreLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 500); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 500); }
    }

    /// <summary>
    /// FloatProperty: GameSpeed
    /// </summary>
    public unsafe float GameSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 504); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 504); }
    }

    /// <summary>
    /// ClassProperty: DefaultPawnClass
    /// </summary>
    public unsafe BmSDK.Class DefaultPawnClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 508); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 508); }
    }

    /// <summary>
    /// ClassProperty: HUDType
    /// </summary>
    public unsafe BmSDK.Class HUDType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 512); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 512); }
    }

    /// <summary>
    /// IntProperty: MaxSpectators
    /// </summary>
    public unsafe int MaxSpectators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 516); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 516); }
    }

    /// <summary>
    /// IntProperty: MaxSpectatorsAllowed
    /// </summary>
    public unsafe int MaxSpectatorsAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 520); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 520); }
    }

    /// <summary>
    /// IntProperty: NumSpectators
    /// </summary>
    public unsafe int NumSpectators
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 524); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 524); }
    }

    /// <summary>
    /// IntProperty: MaxPlayers
    /// </summary>
    public unsafe int MaxPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 528); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 528); }
    }

    /// <summary>
    /// IntProperty: MaxPlayersAllowed
    /// </summary>
    public unsafe int MaxPlayersAllowed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 532); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 532); }
    }

    /// <summary>
    /// IntProperty: NumPlayers
    /// </summary>
    public unsafe int NumPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 536); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 536); }
    }

    /// <summary>
    /// IntProperty: NumBots
    /// </summary>
    public unsafe int NumBots
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 540); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 540); }
    }

    /// <summary>
    /// IntProperty: NumTravellingPlayers
    /// </summary>
    public unsafe int NumTravellingPlayers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 544); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 544); }
    }

    /// <summary>
    /// IntProperty: CurrentID
    /// </summary>
    public unsafe int CurrentID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 548); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 548); }
    }

    /// <summary>
    /// StrProperty: DefaultPlayerName
    /// </summary>
    public unsafe BmSDK.FString DefaultPlayerName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 552); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 552); }
    }

    /// <summary>
    /// StrProperty: GameName
    /// </summary>
    public unsafe BmSDK.FString GameName
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 564); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 564); }
    }

    /// <summary>
    /// FloatProperty: FearCostFallOff
    /// </summary>
    public unsafe float FearCostFallOff
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 576); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 576); }
    }

    /// <summary>
    /// IntProperty: GoalScore
    /// </summary>
    public unsafe int GoalScore
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 580); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 580); }
    }

    /// <summary>
    /// IntProperty: MaxLives
    /// </summary>
    public unsafe int MaxLives
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 584); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 584); }
    }

    /// <summary>
    /// IntProperty: TimeLimit
    /// </summary>
    public unsafe int TimeLimit
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 588); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 588); }
    }

    /// <summary>
    /// ClassProperty: DeathMessageClass
    /// </summary>
    public unsafe BmSDK.Class DeathMessageClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 592); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 592); }
    }

    /// <summary>
    /// ClassProperty: GameMessageClass
    /// </summary>
    public unsafe BmSDK.Class GameMessageClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 596); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 596); }
    }

    /// <summary>
    /// ObjectProperty: BaseMutator
    /// </summary>
    public unsafe BmSDK.Engine.Mutator BaseMutator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Mutator>(Ptr + 600); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 600); }
    }

    /// <summary>
    /// ClassProperty: AccessControlClass
    /// </summary>
    public unsafe BmSDK.Class AccessControlClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 604); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 604); }
    }

    /// <summary>
    /// ObjectProperty: AccessControl
    /// </summary>
    public unsafe BmSDK.Engine.AccessControl AccessControl
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AccessControl>(Ptr + 608); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 608); }
    }

    /// <summary>
    /// ClassProperty: PlayerControllerClass
    /// </summary>
    public unsafe BmSDK.Class PlayerControllerClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 612); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 612); }
    }

    /// <summary>
    /// ClassProperty: PlayerReplicationInfoClass
    /// </summary>
    public unsafe BmSDK.Class PlayerReplicationInfoClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 616); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 616); }
    }

    /// <summary>
    /// ClassProperty: GameReplicationInfoClass
    /// </summary>
    public unsafe BmSDK.Class GameReplicationInfoClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 620); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 620); }
    }

    /// <summary>
    /// ObjectProperty: GameReplicationInfo
    /// </summary>
    public unsafe BmSDK.Engine.GameReplicationInfo GameReplicationInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.GameReplicationInfo>(Ptr + 624); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 624); }
    }

    /// <summary>
    /// FloatProperty: MaxIdleTime
    /// </summary>
    public unsafe float MaxIdleTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 628); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 628); }
    }

    /// <summary>
    /// FloatProperty: MaxTimeMargin
    /// </summary>
    public unsafe float MaxTimeMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 632); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 632); }
    }

    /// <summary>
    /// FloatProperty: TimeMarginSlack
    /// </summary>
    public unsafe float TimeMarginSlack
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 636); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 636); }
    }

    /// <summary>
    /// FloatProperty: MinTimeMargin
    /// </summary>
    public unsafe float MinTimeMargin
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 640); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 640); }
    }

    /// <summary>
    /// ArrayProperty: InactivePRIArray
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.PlayerReplicationInfo> InactivePRIArray
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.PlayerReplicationInfo>>(Ptr + 644); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 644); }
    }

    /// <summary>
    /// ArrayProperty: Pausers
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> Pausers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 656); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 656); }
    }

    /// <summary>
    /// ObjectProperty: OnlineSub
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem OnlineSub
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineSubsystem>(Ptr + 668); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 668); }
    }

    /// <summary>
    /// InterfaceProperty: GameInterface
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameInterface GameInterface
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.OnlineGameInterface>(Ptr + 672); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 672); }
    }

    /// <summary>
    /// ClassProperty: OnlineStatsWriteClass
    /// </summary>
    public unsafe BmSDK.Class OnlineStatsWriteClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 680); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 680); }
    }

    /// <summary>
    /// IntProperty: LeaderboardId
    /// </summary>
    public unsafe int LeaderboardId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 684); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 684); }
    }

    /// <summary>
    /// IntProperty: ArbitratedLeaderboardId
    /// </summary>
    public unsafe int ArbitratedLeaderboardId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 688); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 688); }
    }

    /// <summary>
    /// ClassProperty: OnlineGameSettingsClass
    /// </summary>
    public unsafe BmSDK.Class OnlineGameSettingsClass
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(Ptr + 692); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 692); }
    }

    /// <summary>
    /// StrProperty: ServerOptions
    /// </summary>
    public unsafe BmSDK.FString ServerOptions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 696); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 696); }
    }

    /// <summary>
    /// IntProperty: AdjustedNetSpeed
    /// </summary>
    public unsafe int AdjustedNetSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 708); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 708); }
    }

    /// <summary>
    /// FloatProperty: LastNetSpeedUpdateTime
    /// </summary>
    public unsafe float LastNetSpeedUpdateTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 712); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 712); }
    }

    /// <summary>
    /// IntProperty: TotalNetBandwidth
    /// </summary>
    public unsafe int TotalNetBandwidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 716); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 716); }
    }

    /// <summary>
    /// IntProperty: MinDynamicBandwidth
    /// </summary>
    public unsafe int MinDynamicBandwidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 720); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 720); }
    }

    /// <summary>
    /// IntProperty: MaxDynamicBandwidth
    /// </summary>
    public unsafe int MaxDynamicBandwidth
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 724); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 724); }
    }

    /// <summary>
    /// FloatProperty: StandbyRxCheatTime
    /// </summary>
    public unsafe float StandbyRxCheatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 728); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 728); }
    }

    /// <summary>
    /// FloatProperty: StandbyTxCheatTime
    /// </summary>
    public unsafe float StandbyTxCheatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 732); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 732); }
    }

    /// <summary>
    /// IntProperty: BadPingThreshold
    /// </summary>
    public unsafe int BadPingThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 736); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 736); }
    }

    /// <summary>
    /// FloatProperty: PercentMissingForRxStandby
    /// </summary>
    public unsafe float PercentMissingForRxStandby
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 740); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 740); }
    }

    /// <summary>
    /// FloatProperty: PercentMissingForTxStandby
    /// </summary>
    public unsafe float PercentMissingForTxStandby
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 744); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 744); }
    }

    /// <summary>
    /// FloatProperty: PercentForBadPing
    /// </summary>
    public unsafe float PercentForBadPing
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 748); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 748); }
    }

    /// <summary>
    /// FloatProperty: JoinInProgressStandbyWaitTime
    /// </summary>
    public unsafe float JoinInProgressStandbyWaitTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 752); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 752); }
    }

    /// <summary>
    /// ArrayProperty: GameInfoClassAliases
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameInfo.FGameClassShortName> GameInfoClassAliases
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameInfo.FGameClassShortName>>(Ptr + 756); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 756); }
    }

    /// <summary>
    /// StrProperty: DefaultGameType
    /// </summary>
    public unsafe BmSDK.FString DefaultGameType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 768); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 768); }
    }

    /// <summary>
    /// ArrayProperty: DefaultMapPrefixes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameInfo.FGameTypePrefix> DefaultMapPrefixes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameInfo.FGameTypePrefix>>(Ptr + 780); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 780); }
    }

    /// <summary>
    /// ArrayProperty: CustomMapPrefixes
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.Engine.GameInfo.FGameTypePrefix> CustomMapPrefixes
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.GameInfo.FGameTypePrefix>>(Ptr + 792); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 792); }
    }

    /// <summary>
    /// DelegateProperty: __CanUnpause__Delegate
    /// </summary>
    public unsafe System.IntPtr __CanUnpause__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 804); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 804); }
    }
}
