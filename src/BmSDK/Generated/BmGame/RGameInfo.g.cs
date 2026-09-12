#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.BmGame;

/// <summary>
/// Class: RGameInfo<br/>
/// (size = 1456)
/// (flags = 142606518)
/// </summary>
public partial class RGameInfo : BmSDK.BmGame.RGameInfoBase, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "BmGame.RGameInfo", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as RGameInfo.
    /// </summary>
    public static RGameInfo DefaultObject => (RGameInfo)StaticClass().DefaultObject;

    internal RGameInfo() { }

    /// <summary>
    /// Constructs a new RGameInfo
    /// </summary>
    public RGameInfo(System.Numerics.Vector3 Location = default, BmSDK.Rotator Rotation = default, BmSDK.Engine.Actor Template = null, BmSDK.GameObject Owner = null, BmSDK.GameObject Instigator = null, BmSDK.Engine.Level Level = null) : base(BmSDK.Framework.Game.SpawnActorInternal(StaticClass(), default, Location, Rotation, Template, Owner, Instigator, Level)) { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected RGameInfo(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<RGameInfo>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: Is3DTVPresent
    /// </summary>
    public unsafe virtual bool Is3DTVPresent()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Is3DTVPresent", true);
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
    /// Function: HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime
    /// </summary>
    public unsafe virtual BmSDK.GameObject HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HackToLoadAssetsAllTheTimeToSaveDVDSpaceAndStreamingTime", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.GameObject>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RiddlerIcons_AnyLeftToReveal
    /// </summary>
    public unsafe virtual bool RiddlerIcons_AnyLeftToReveal()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerIcons_AnyLeftToReveal", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: RiddlesLeftSpecificMapCheck
    /// </summary>
    public unsafe virtual bool RiddlesLeftSpecificMapCheck(BmSDK.FString MapName, BmSDK.FString RiddleMapName, bool CWAllow)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlesLeftSpecificMapCheck", true);
        byte* paramsPtr = stackalloc byte[80];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(RiddleMapName, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(CWAllow, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: RiddlerIcons_GetIndexListOfClosest
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem> RiddlerIcons_GetIndexListOfClosest(BmSDK.FString MapName, int atX, int atY, int atZ, int MaxWanted)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerIcons_GetIndexListOfClosest", true);
        byte* paramsPtr = stackalloc byte[100];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxWanted, paramsPtr + 24);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem>>(paramsPtr + 28);
    }

    /// <summary>
    /// Function: RiddlerIcons_GetIndexListForNearestToLoc
    /// </summary>
    public unsafe virtual BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem> RiddlerIcons_GetIndexListForNearestToLoc(BmSDK.FString MapName, int atX, int atY, int atZ, int MaxWanted, bool bHiddenOnly)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RiddlerIcons_GetIndexListForNearestToLoc", true);
        byte* paramsPtr = stackalloc byte[152];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atX, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atY, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(atZ, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(MaxWanted, paramsPtr + 24);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bHiddenOnly, paramsPtr + 28);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FIndexDistItem>>(paramsPtr + 32);
    }

    /// <summary>
    /// Function: SortByIndexDist
    /// </summary>
    public unsafe virtual int SortByIndexDist(BmSDK.BmGame.RGameInfo.FIndexDistItem A, BmSDK.BmGame.RGameInfo.FIndexDistItem B)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SortByIndexDist", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: ToggleDebugCamera
    /// </summary>
    public unsafe virtual void ToggleDebugCamera()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ToggleDebugCamera", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnregisterHelicopter
    /// </summary>
    public unsafe virtual void UnregisterHelicopter(BmSDK.BmGame.RHelicopterBase OldHeli)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UnregisterHelicopter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(OldHeli, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RegisterHelicopter
    /// </summary>
    public unsafe virtual void RegisterHelicopter(BmSDK.BmGame.RHelicopterBase NewHeli)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RegisterHelicopter", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewHeli, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetSmokeScreenCoverValue
    /// </summary>
    public unsafe virtual float GetSmokeScreenCoverValue(System.Numerics.Vector3 WorldPos, ref byte bFireExtinguisher)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetSmokeScreenCoverValue", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(WorldPos, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bFireExtinguisher, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        bFireExtinguisher = BmSDK.Framework.MarshalUtil.ToManaged<byte>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: UpdateObjectiveMarkerVisibility
    /// </summary>
    public unsafe virtual void UpdateObjectiveMarkerVisibility()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateObjectiveMarkerVisibility", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ActivateObjectiveMarker
    /// </summary>
    public unsafe virtual void ActivateObjectiveMarker(BmSDK.FName roomName, bool show)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ActivateObjectiveMarker", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(roomName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(show, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDialogueManager
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RDialogueManager GetDialogueManager()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetDialogueManager", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDialogueManager>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ShouldSpawnAtStartSpot
    /// </summary>
    public unsafe override bool ShouldSpawnAtStartSpot(BmSDK.Engine.Controller Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ShouldSpawnAtStartSpot", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: EndGame
    /// </summary>
    public unsafe override void EndGame(BmSDK.Engine.PlayerReplicationInfo Winner, BmSDK.FString Reason)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.EndGame", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Winner, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Reason, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RoundEnded
    /// </summary>
    public unsafe virtual void RoundEnded()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RoundEnded", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: RatePlayerStart
    /// </summary>
    public unsafe override float RatePlayerStart(BmSDK.Engine.PlayerStart P, byte Team, BmSDK.Engine.Controller Player)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.RatePlayerStart", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Team, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Player, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GameOver
    /// </summary>
    public unsafe virtual void GameOver(float TimeTillFade = default, bool PlayerDied = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GameOver", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TimeTillFade, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PlayerDied, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PlayerDied
    /// </summary>
    public unsafe virtual void PlayerDied(BmSDK.BmGame.RPlayerController PC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PlayerDied", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostLogin
    /// </summary>
    public unsafe override void PostLogin(BmSDK.Engine.PlayerController NewPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PostLogin", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: HandleSeamlessTravelPlayer
    /// </summary>
    public unsafe override void HandleSeamlessTravelPlayer(ref BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HandleSeamlessTravelPlayer", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        C = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Controller>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: HandleLobby
    /// </summary>
    public unsafe virtual void HandleLobby(BmSDK.BmGame.RPlayerController LobbyPC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HandleLobby", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyPC, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ShowLobby
    /// </summary>
    public unsafe virtual bool ShowLobby(BmSDK.BmGame.RPlayerController LobbyTarget)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ShowLobby", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(LobbyTarget, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: Game_ExitToFrontend
    /// </summary>
    public unsafe virtual void Game_ExitToFrontend()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_ExitToFrontend", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_PauseExitToFrontend
    /// </summary>
    public unsafe virtual void Game_PauseExitToFrontend()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_PauseExitToFrontend", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_Retry
    /// </summary>
    public unsafe virtual void Game_Retry()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_Retry", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_Restart
    /// </summary>
    public unsafe virtual void Game_Restart()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_Restart", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_ExitGame
    /// </summary>
    public unsafe virtual void Game_ExitGame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_ExitGame", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_Continue
    /// </summary>
    public unsafe virtual void Game_Continue()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_Continue", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: Game_StartGameAt
    /// </summary>
    public unsafe virtual void Game_StartGameAt(BmSDK.FString AtName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Game_StartGameAt", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AtName, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetDefaultPlayerClass
    /// </summary>
    public unsafe override BmSDK.Class GetDefaultPlayerClass(BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetDefaultPlayerClass", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Class>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetPlayerCharacterIndex
    /// </summary>
    public unsafe virtual int GetPlayerCharacterIndex(BmSDK.Engine.Controller C)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPlayerCharacterIndex", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(C, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: SpawnDefaultPawnFor
    /// </summary>
    public unsafe override BmSDK.Engine.Pawn SpawnDefaultPawnFor(BmSDK.Engine.Controller NewPlayer, BmSDK.Engine.NavigationPoint StartSpot)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SpawnDefaultPawnFor", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewPlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartSpot, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.Pawn>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: GetURLParam
    /// </summary>
    public unsafe virtual BmSDK.FString GetURLParam(BmSDK.FString Named)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetURLParam", true);
        byte* paramsPtr = stackalloc byte[52];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Named, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: HasURLParam
    /// </summary>
    public unsafe virtual bool HasURLParam(BmSDK.FString Named)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.HasURLParam", true);
        byte* paramsPtr = stackalloc byte[32];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Named, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetGameTimePlayedString
    /// </summary>
    public unsafe virtual BmSDK.FString GetGameTimePlayedString()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetGameTimePlayedString", true);
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
    /// Function: GetGameTimePlayed
    /// </summary>
    public unsafe override float GetGameTimePlayed()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetGameTimePlayed", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsFrontend
    /// </summary>
    public unsafe virtual bool IsFrontend()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsFrontend", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsChallengeMode
    /// </summary>
    public unsafe virtual bool IsChallengeMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsChallengeMode", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsStoryMode
    /// </summary>
    public unsafe virtual bool IsStoryMode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsStoryMode", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: FindPredatorVolumeFor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPredatorVolume FindPredatorVolumeFor(BmSDK.Engine.Actor TestActor)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FindPredatorVolumeFor", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TestActor, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPredatorVolume>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: TriggerHostageEndOfWaveEvents
    /// </summary>
    public unsafe virtual void TriggerHostageEndOfWaveEvents()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.TriggerHostageEndOfWaveEvents", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: ResetRoom
    /// </summary>
    public unsafe virtual void ResetRoom()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ResetRoom", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UnhookRoomState
    /// </summary>
    public unsafe virtual void UnhookRoomState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UnhookRoomState", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: SetNewRoomAIState
    /// </summary>
    public unsafe virtual void SetNewRoomAIState(BmSDK.BmGame.RBMRoomAIState NewState)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SetNewRoomAIState", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewState, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: UpdateGameWindConfig
    /// </summary>
    public unsafe virtual void UpdateGameWindConfig(BmSDK.BmGame.RGameInfo.FRBasicWindConfig NewWind)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateGameWindConfig", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NewWind, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpPawnLevelVol
    /// </summary>
    public unsafe virtual void DumpPawnLevelVol()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DumpPawnLevelVol", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpRoomState
    /// </summary>
    public unsafe virtual void DumpRoomState()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DumpRoomState", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpDialogueCoord
    /// </summary>
    public unsafe virtual void DumpDialogueCoord()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DumpDialogueCoord", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: DumpAllNav
    /// </summary>
    public unsafe virtual void DumpAllNav()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DumpAllNav", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: MakeTerrified
    /// </summary>
    public unsafe virtual void MakeTerrified()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.MakeTerrified", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BarkDewedge
    /// </summary>
    public unsafe virtual void BarkDewedge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.BarkDewedge", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: BarkWTF
    /// </summary>
    public unsafe virtual void BarkWTF()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.BarkWTF", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TannoyFinished
    /// </summary>
    public unsafe virtual void TannoyFinished(BmSDK.BmGame.RGameInfo.ThugResponseType ResponseType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.TannoyFinished", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ResponseType, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: InformVillainsOfVentEntry
    /// </summary>
    public unsafe virtual bool InformVillainsOfVentEntry(BmSDK.Engine.Pawn VentPlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.InformVillainsOfVentEntry", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(VentPlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: InformVillainsPostGrapple
    /// </summary>
    public unsafe virtual bool InformVillainsPostGrapple(BmSDK.Engine.Pawn GrapplePlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.InformVillainsPostGrapple", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: InformVillainsOfGrapple
    /// </summary>
    public unsafe virtual bool InformVillainsOfGrapple(BmSDK.Engine.Pawn GrapplePlayer, System.Numerics.Vector3 TargetHidePointLocation, bool bForcingBatmanHidden = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.InformVillainsOfGrapple", true);
        byte* paramsPtr = stackalloc byte[60];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TargetHidePointLocation, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bForcingBatmanHidden, paramsPtr + 16);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 20);
    }

    /// <summary>
    /// Function: IsShootingSourceGarg
    /// </summary>
    public unsafe virtual bool IsShootingSourceGarg(BmSDK.Engine.Pawn GrapplePlayer, BmSDK.BmGame.RBMAIController AIC)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsShootingSourceGarg", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(AIC, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: PlayerIsOnVantageBeingShotByThug
    /// </summary>
    public unsafe virtual bool PlayerIsOnVantageBeingShotByThug(BmSDK.BmGame.RPawnPlayer GrapplePlayer)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PlayerIsOnVantageBeingShotByThug", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(GrapplePlayer, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: DoVisibilityHack
    /// </summary>
    public unsafe virtual void DoVisibilityHack()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DoVisibilityHack", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: FindStartleThugFromPoint
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnVillain FindStartleThugFromPoint(System.Numerics.Vector3 StartleCentre)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FindStartleThugFromPoint", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartleCentre, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnVillain>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: DoPostRenderLogic
    /// </summary>
    public unsafe virtual void DoPostRenderLogic(BmSDK.Engine.Canvas Canvas)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.DoPostRenderLogic", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Canvas, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetWindAtPoint
    /// </summary>
    public unsafe virtual System.Numerics.Vector3 GetWindAtPoint(System.Numerics.Vector3 ObjectPosition, System.Numerics.Vector3 ObjectVelocity)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetWindAtPoint", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectPosition, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ObjectVelocity, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 24);
    }

    /// <summary>
    /// Function: UpdateGlobalWind
    /// </summary>
    public unsafe virtual void UpdateGlobalWind(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.UpdateGlobalWind", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
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
    /// Function: Tick
    /// </summary>
    public unsafe override void Tick(float DeltaTime)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Tick", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DeltaTime, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CanSpawnPawn
    /// </summary>
    public unsafe virtual bool CanSpawnPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CanSpawnPawn", true);
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
    /// Function: PawnSpawned
    /// </summary>
    public unsafe virtual void PawnSpawned()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PawnSpawned", true);
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
    /// Function: Killed
    /// </summary>
    public unsafe override void Killed(BmSDK.Engine.Controller Killer, BmSDK.Engine.Controller KilledPlayer, BmSDK.Engine.Pawn KilledPawn, BmSDK.Class DamageType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.Killed", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Killer, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPlayer, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(KilledPawn, paramsPtr + 8);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageType, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: LoadPC
    /// </summary>
    public unsafe virtual void LoadPC(BmSDK.FName PCName = default, int DamageLevel = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.LoadPC", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PCName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DamageLevel, paramsPtr + 8);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GoStartMatch
    /// </summary>
    public unsafe virtual void GoStartMatch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GoStartMatch", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GetPlayerPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer GetPlayerPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPlayerPawn", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: ResetPlayerStartPoints
    /// </summary>
    public unsafe virtual void ResetPlayerStartPoints()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.ResetPlayerStartPoints", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: CheckToStartMatch
    /// </summary>
    public unsafe virtual void CheckToStartMatch()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CheckToStartMatch", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: TimedStartGame
    /// </summary>
    public unsafe virtual void TimedStartGame()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.TimedStartGame", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: OnLevelChange
    /// </summary>
    public unsafe virtual void OnLevelChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.OnLevelChange", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreCommitMapChange
    /// </summary>
    public unsafe override void PreCommitMapChange(BmSDK.FString PreviousMapName, BmSDK.FString NextMapName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PreCommitMapChange", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PreviousMapName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(NextMapName, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: IsCombatChallenge
    /// </summary>
    public unsafe virtual bool IsCombatChallenge()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsCombatChallenge", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: CreateStatsLogging
    /// </summary>
    public unsafe virtual void CreateStatsLogging()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.CreateStatsLogging", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PostCommitMapChange
    /// </summary>
    public unsafe override void PostCommitMapChange()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PostCommitMapChange", true);
        byte* paramsPtr = stackalloc byte[0];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: PreBeginPlay
    /// </summary>
    public unsafe override void PreBeginPlay()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.PreBeginPlay", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: AllowCheats
    /// </summary>
    public unsafe override bool AllowCheats(BmSDK.Engine.PlayerController P)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.AllowCheats", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(P, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetDifficulty
    /// </summary>
    public unsafe virtual int GetDifficulty()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetDifficulty", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsGadgetAction
    /// </summary>
    public unsafe virtual bool IsGadgetAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsGadgetAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsStunAction
    /// </summary>
    public unsafe virtual bool IsStunAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsStunAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsSpecialAction
    /// </summary>
    public unsafe virtual bool IsSpecialAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsSpecialAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsRepeatedAction
    /// </summary>
    public unsafe virtual bool IsRepeatedAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsRepeatedAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsTakedownAction
    /// </summary>
    public unsafe virtual bool IsTakedownAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsTakedownAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsCombatKOAction
    /// </summary>
    public unsafe virtual bool IsCombatKOAction(BmSDK.BmGame.RGameInfo.EGameAction Action)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsCombatKOAction", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Action, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: WaitToBankXP
    /// </summary>
    public unsafe virtual bool WaitToBankXP()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.WaitToBankXP", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: IsCurrentPredZoneAlerted
    /// </summary>
    public unsafe virtual bool IsCurrentPredZoneAlerted()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsCurrentPredZoneAlerted", true);
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
    /// Function: FindProjectileArc
    /// </summary>
    public unsafe virtual bool FindProjectileArc(BmSDK.Engine.Actor TraceActor, ref System.Numerics.Vector3 ThrowVelocity, ref float FlightTime, System.Numerics.Vector3 StartPoint, System.Numerics.Vector3 Target)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.FindProjectileArc", true);
        byte* paramsPtr = stackalloc byte[48];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(TraceActor, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ThrowVelocity, paramsPtr + 4);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FlightTime, paramsPtr + 16);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(StartPoint, paramsPtr + 20);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Target, paramsPtr + 32);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        ThrowVelocity = BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(paramsPtr + 4);
        FlightTime = BmSDK.Framework.MarshalUtil.ToManaged<float>(paramsPtr + 16);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 44);
    }

    /// <summary>
    /// Function: SecuROMProtectionCheck4
    /// </summary>
    public unsafe virtual int SecuROMProtectionCheck4(int A, int B)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SecuROMProtectionCheck4", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(A, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(B, paramsPtr + 4);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SecuROMProtectionCheck3
    /// </summary>
    public unsafe virtual int SecuROMProtectionCheck3()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SecuROMProtectionCheck3", true);
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
    /// Function: SecuROMProtectionCheck2
    /// </summary>
    public unsafe virtual bool SecuROMProtectionCheck2()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SecuROMProtectionCheck2", true);
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
    /// Function: SecuROMProtectionCheck1
    /// </summary>
    public unsafe virtual bool SecuROMProtectionCheck1()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.SecuROMProtectionCheck1", true);
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
    /// Function: GetLanguageForScriptCode
    /// </summary>
    public unsafe virtual BmSDK.FString GetLanguageForScriptCode()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetLanguageForScriptCode", true);
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
    /// Function: GetPlyrPawn
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPawnPlayer GetPlyrPawn()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPlyrPawn", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPawnPlayer>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetPC
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RPlayerController GetPC()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetPC", true);
        byte* paramsPtr = stackalloc byte[4];
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetNumLocalPlayers
    /// </summary>
    public unsafe virtual int GetNumLocalPlayers()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetNumLocalPlayers", true);
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
    /// Function: GetLevelVolumeFor
    /// </summary>
    public unsafe virtual BmSDK.BmGame.RLevelVolume GetLevelVolumeFor(BmSDK.GameObject Obj)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetLevelVolumeFor", true);
        byte* paramsPtr = stackalloc byte[8];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Obj, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RLevelVolume>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetStoryIndex
    /// </summary>
    public unsafe virtual int GetStoryIndex(int Id)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetStoryIndex", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsStoryPresent
    /// </summary>
    public unsafe virtual bool IsStoryPresent(int Id)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsStoryPresent", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Id, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: IsAStoryAvailable
    /// </summary>
    public unsafe virtual bool IsAStoryAvailable(ref int Count)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsAStoryAvailable", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(Count, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        Count = BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 4);
    }

    /// <summary>
    /// Function: GetStoryCount
    /// </summary>
    public unsafe virtual int GetStoryCount()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetStoryCount", true);
        byte* paramsPtr = stackalloc byte[4];
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 0);
    }

    /// <summary>
    /// Function: GetIsSaveInProgress
    /// </summary>
    public unsafe virtual bool GetIsSaveInProgress()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetIsSaveInProgress", true);
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
    /// Function: GetSaveGameSize
    /// </summary>
    public unsafe virtual int GetSaveGameSize()
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.GetSaveGameSize", true);
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
    /// Function: IsDLCInstalled
    /// </summary>
    public unsafe virtual bool IsDLCInstalled(BmSDK.FString DLCBundleName)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "BmGame.RGameInfo.IsDLCInstalled", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DLCBundleName, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Struct: FStoryDLCItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FStoryDLCItem
    {
        /// <summary>
        /// IntProperty: PackId
        /// </summary>
        public unsafe int PackId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// IntProperty: PersistentSaveSlotId
        /// </summary>
        public unsafe int PersistentSaveSlotId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// StrProperty: BaseCharacter
        /// </summary>
        public unsafe BmSDK.FString BaseCharacter
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: NewGameStart
        /// </summary>
        public unsafe BmSDK.FString NewGameStart
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }
    }

    /// <summary>
    /// Struct: FMapElementsItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 48)]
    public partial record struct FMapElementsItem
    {
        /// <summary>
        /// StrProperty: ItemType
        /// </summary>
        public unsafe BmSDK.FString ItemType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: ItemSubType
        /// </summary>
        public unsafe BmSDK.FString ItemSubType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StrProperty: ItemName
        /// </summary>
        public unsafe BmSDK.FString ItemName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: X
        /// </summary>
        public unsafe int X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: Y
        /// </summary>
        public unsafe int Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: Z
        /// </summary>
        public unsafe int Z
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }
    }

    /// <summary>
    /// Struct: FMapElements
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FMapElements
    {
        /// <summary>
        /// StrProperty: MapName
        /// </summary>
        public unsafe BmSDK.FString MapName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: Base
        /// </summary>
        public unsafe int Base
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Count
        /// </summary>
        public unsafe int Count
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FIndexDistItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial record struct FIndexDistItem
    {
        /// <summary>
        /// IntProperty: Index
        /// </summary>
        public unsafe int Index
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }
    }

    /// <summary>
    /// Struct: FMapHackOWLoc
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 52)]
    public partial record struct FMapHackOWLoc
    {
        /// <summary>
        /// StrProperty: SubName
        /// </summary>
        public unsafe BmSDK.FString SubName
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// IntProperty: X
        /// </summary>
        public unsafe int X
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: Y
        /// </summary>
        public unsafe int Y
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// IntProperty: Z
        /// </summary>
        public unsafe int Z
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// IntProperty: SubX
        /// </summary>
        public unsafe int SubX
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: SubY
        /// </summary>
        public unsafe int SubY
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: SubZ
        /// </summary>
        public unsafe int SubZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// FloatProperty: Distance
        /// </summary>
        public unsafe float Distance
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StrProperty: FlagCheck
        /// </summary>
        public unsafe BmSDK.FString FlagCheck
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FMapItem
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 124)]
    public partial record struct FMapItem
    {
        /// <summary>
        /// StrProperty: Row
        /// </summary>
        public unsafe BmSDK.FString Row
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// IntProperty: PackId
        /// </summary>
        public unsafe int PackId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// IntProperty: SId
        /// </summary>
        public unsafe int SId
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }

        /// <summary>
        /// IntProperty: Mask1
        /// </summary>
        public unsafe int Mask1
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// IntProperty: Mask2
        /// </summary>
        public unsafe int Mask2
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 40); }; }
        }

        /// <summary>
        /// IntProperty: RFCMask
        /// </summary>
        public unsafe int RFCMask
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 44); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 44); }; }
        }

        /// <summary>
        /// StrProperty: ScriptRef
        /// </summary>
        public unsafe BmSDK.FString ScriptRef
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// StrProperty: Start
        /// </summary>
        public unsafe BmSDK.FString Start
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// BoolProperty: bPredator
        /// </summary>
        public unsafe bool bPredator
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// BoolProperty: bNotCustom
        /// </summary>
        public unsafe bool bNotCustom
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 72); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 72); }; }
        }

        /// <summary>
        /// ArrayProperty: Modifiers
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers> Modifiers
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EChallengeModifiers>>(Ptr + 76); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 76); }; }
        }

        /// <summary>
        /// ArrayProperty: CampaignEntry
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapCampaignEntry> CampaignEntry
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapCampaignEntry>>(Ptr + 88); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 88); }; }
        }

        /// <summary>
        /// ArrayProperty: DefaultChallengeScores
        /// </summary>
        public unsafe BmSDK.TArray<int> DefaultChallengeScores
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<int>>(Ptr + 100); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 100); }; }
        }

        /// <summary>
        /// ArrayProperty: DefaultChallengeActions
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> DefaultChallengeActions
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 112); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 112); }; }
        }
    }

    /// <summary>
    /// Struct: FMapCampaignEntry
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FMapCampaignEntry
    {
        /// <summary>
        /// IntProperty: Id
        /// </summary>
        public unsafe int Id
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: EStasisLevel
    /// </summary>
    public enum EStasisLevel : byte
    {
        STASISLEVEL_Normal = 0,
        STASISLEVEL_Cheap = 1,
        STASISLEVEL_SuperCheap = 2,
        STASISLEVEL_MAX = 3,
    }

    /// <summary>
    /// Struct: FFloorCorrectionConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 44)]
    public partial record struct FFloorCorrectionConfig
    {
        /// <summary>
        /// StructProperty: Standing
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig Standing
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: Moving
        /// </summary>
        public unsafe BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig Moving
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.FFloorMovementCorrectionConfig>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// BoolProperty: OnCeiling
        /// </summary>
        public unsafe bool OnCeiling
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }

        /// <summary>
        /// BoolProperty: CatwomanCrawlingHack
        /// </summary>
        public unsafe bool CatwomanCrawlingHack
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40) & 2) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 40); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 40); }; }
        }
    }

    /// <summary>
    /// Struct: FFloorMovementCorrectionConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FFloorMovementCorrectionConfig
    {
        /// <summary>
        /// FloatProperty: Along
        /// </summary>
        public unsafe float Along
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// FloatProperty: Up
        /// </summary>
        public unsafe float Up
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: Down
        /// </summary>
        public unsafe float Down
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// FloatProperty: Orientation
        /// </summary>
        public unsafe float Orientation
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// FloatProperty: OrientationPivotZ
        /// </summary>
        public unsafe float OrientationPivotZ
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FRWindState
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 68)]
    public partial record struct FRWindState
    {
        /// <summary>
        /// StructProperty: WindVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 WindVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: SourceVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 SourceVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// StructProperty: SourceAcceleration
        /// </summary>
        public unsafe System.Numerics.Vector3 SourceAcceleration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// StructProperty: TargetVelocity
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetVelocity
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 36); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 36); }; }
        }

        /// <summary>
        /// StructProperty: TargetAcceleration
        /// </summary>
        public unsafe System.Numerics.Vector3 TargetAcceleration
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 48); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }; }
        }

        /// <summary>
        /// FloatProperty: TotalInterpolationTime
        /// </summary>
        public unsafe float TotalInterpolationTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 60); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 60); }; }
        }

        /// <summary>
        /// FloatProperty: RemainingInterpolationTime
        /// </summary>
        public unsafe float RemainingInterpolationTime
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 64); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }; }
        }
    }

    /// <summary>
    /// Struct: FRWindConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial record struct FRWindConfig
    {
        /// <summary>
        /// BoolProperty: IsApplyWind
        /// </summary>
        public unsafe bool IsApplyWind
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WindVelocityCentre
        /// </summary>
        public unsafe System.Numerics.Vector3 WindVelocityCentre
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: WindVelocityRadius
        /// </summary>
        public unsafe float WindVelocityRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }

        /// <summary>
        /// FloatProperty: MaxWindAccelerationRadius
        /// </summary>
        public unsafe float MaxWindAccelerationRadius
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 20); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 20); }; }
        }

        /// <summary>
        /// FloatProperty: MinTargetChangePeriod
        /// </summary>
        public unsafe float MinTargetChangePeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 24); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 24); }; }
        }

        /// <summary>
        /// FloatProperty: MaxTargetChangePeriod
        /// </summary>
        public unsafe float MaxTargetChangePeriod
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 28); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 28); }; }
        }

        /// <summary>
        /// FloatProperty: WindForceCoefficient
        /// </summary>
        public unsafe float WindForceCoefficient
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 32); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 32); }; }
        }
    }

    /// <summary>
    /// Struct: FRBasicWindConfig
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FRBasicWindConfig
    {
        /// <summary>
        /// BoolProperty: IsApplyWind
        /// </summary>
        public unsafe bool IsApplyWind
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 0); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 0); }; }
        }

        /// <summary>
        /// StructProperty: WindDirection
        /// </summary>
        public unsafe System.Numerics.Vector3 WindDirection
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<System.Numerics.Vector3>(Ptr + 4); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 4); }; }
        }

        /// <summary>
        /// FloatProperty: WindBlusteryness
        /// </summary>
        public unsafe float WindBlusteryness
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 16); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Enum: ThugResponseType
    /// </summary>
    public enum ThugResponseType : byte
    {
        TRS_None = 0,
        TRS_Ambient = 1,
        TRS_MAX = 2,
    }

    /// <summary>
    /// Enum: GameCombatCameraType
    /// </summary>
    public enum GameCombatCameraType : byte
    {
        GCCT_BrawlComatCamera = 0,
        GCCT_CorridorCombatCamera = 1,
        GCCT_HighCombatCamera = 2,
        GCCT_MAX = 3,
    }

    /// <summary>
    /// Struct: FSoundSurface
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 4)]
    public partial record struct FSoundSurface
    {
        /// <summary>
        /// ObjectProperty: SurfaceType
        /// </summary>
        public unsafe BmSDK.Engine.AkSwitchName SurfaceType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.AkSwitchName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }
    }

    /// <summary>
    /// Enum: CameraLookAtSpeed
    /// </summary>
    public enum CameraLookAtSpeed : byte
    {
        CLASP_Slow = 0,
        CLASP_Fast = 1,
        CLASP_VeryFast = 2,
        CLASP_VerySlow = 3,
        CLASP_MAX = 4,
    }

    /// <summary>
    /// Enum: CameraLookAtStrength
    /// </summary>
    public enum CameraLookAtStrength : byte
    {
        CLAS_ForceCamera = 0,
        CLAS_ForceUntilLookAtNeutral = 1,
        CLAS_LookAtWeakNoDrag = 2,
        CLAS_LookAtWeak = 3,
        CLAS_MAX = 4,
    }

    /// <summary>
    /// Enum: CameraLookAtType
    /// </summary>
    public enum CameraLookAtType : byte
    {
        CLAT_NoLookAt = 0,
        CLAT_LookAtRotation = 1,
        CLAT_LookAtLocation = 2,
        CLAT_LookAtActor = 3,
        CLAT_MAX = 4,
    }

    /// <summary>
    /// Enum: ECombatLockType
    /// </summary>
    public enum ECombatLockType : byte
    {
        ECLT_None = 0,
        ECLT_Thugs = 1,
        ECLT_Lunatics = 2,
        ECLT_MAX = 3,
    }

    /// <summary>
    /// Enum: EChallengeModifiers
    /// </summary>
    public enum EChallengeModifiers : byte
    {
        CMod_None = 0,
        CMod_Neg_ExtremeEnemies = 1,
        CMod_Neg_TimeLimit = 2,
        CMod_Neg_IncreasedAggression = 3,
        CMod_Neg_DecreasedHealth = 4,
        CMod_Neg_ProtectiveAura = 5,
        CMod_Neg_DangerZones = 6,
        CMod_Neg_OneHandTied = 7,
        CMod_Neg_ScatteredWeapons = 8,
        CMod_Pos_ReplenishingHealth = 9,
        CMod_Pos_TakedownProjectiles = 10,
        CMod_Pos_SuperPowered = 11,
        CMod_Pos_FreeMedal = 12,
        CMod_MAX = 13,
    }

    /// <summary>
    /// Enum: EChallengeModifierType
    /// </summary>
    public enum EChallengeModifierType : byte
    {
        EChallengeModifier_None = 0,
        EChallengeModifier_Example1 = 1,
        EChallengeModifier_Example2 = 2,
        EChallengeModifier_MAX = 3,
    }

    /// <summary>
    /// Enum: EChallengeCharacter
    /// </summary>
    public enum EChallengeCharacter : byte
    {
        ECCID_Batman = 0,
        ECCID_BatmanArmoured = 1,
        ECCID_Joker = 2,
        ECCID_MAX = 3,
    }

    /// <summary>
    /// Enum: EChallengeMode
    /// </summary>
    public enum EChallengeMode : byte
    {
        ECMID_Combat = 0,
        ECMID_CombatEndurance = 1,
        ECMID_Predator = 2,
        ECMID_MAX = 3,
    }

    /// <summary>
    /// Enum: EAchievementID
    /// </summary>
    public enum EAchievementID : byte
    {
        EACID_None = 0,
        EACID_Im_Batman = 1,
        EACID_Saved_Catwoman = 2,
        EACID_Saved_Church_Hostages = 3,
        EACID_Get_in_steelmill = 4,
        EACID_Defeated_Lieutenant = 5,
        EACID_Shut_off_Jammers = 6,
        EACID_Gladiator_Pit = 7,
        EACID_Defeated_Grundy = 8,
        EACID_Entered_WonderCity = 9,
        EACID_Defeated_Ras = 10,
        EACID_Defeated_Freeze = 11,
        EACID_Got_Beaten_by_Joker = 12,
        EACID_Confronted_Strange = 13,
        EACID_Defeated_Clayface = 14,
        EACID_Deadshot_Stash = 15,
        EACID_Stopped_Deadshot = 16,
        EACID_Stopped_Hush = 17,
        EACID_Competed_Azrael = 18,
        EACID_Found_Bane = 19,
        EACID_Stopped_Bane = 20,
        EACID_Zsasz_Phone = 21,
        EACID_Stopped_Zsasz = 22,
        EACID_Stopped_Mad_Hatter = 23,
        EACID_Saved_Nora = 24,
        EACID_Complete_AR = 25,
        EACID_All_Gadgets = 26,
        EACID_Save_All_Bullies = 27,
        EACID_Riddler_Church = 28,
        EACID_Riddler_Room_1 = 29,
        EACID_Riddler_Room_2 = 30,
        EACID_Riddler_Room_3 = 31,
        EACID_Riddler_Room_4 = 32,
        EACID_Riddler_Room_5 = 33,
        EACID_Stopped_Riddler = 34,
        EACID_Ranked_Challenges_All_Bronze = 35,
        EACID_Ranked_Challenges_All_Silver = 36,
        EACID_Ranked_Challenges_All_Gold = 37,
        EACID_Campaigns_All_Bronze = 38,
        EACID_Campaigns_All_Silver = 39,
        EACID_Campaigns_All_Gold = 40,
        EACID_Flawless_Freeflow_Fighter = 41,
        EACID_New_Game_PLUS = 42,
        EACID_5_Times_Around_Tower = 43,
        EACID_Pay_Respects = 44,
        EACID_12_Calendar_Stories = 45,
        EACID_Azrael_Catch = 46,
        EACID_40_Combo = 47,
        EACID_Perfect_Freeflow = 48,
        EACID_5_Gadgets_Fight = 49,
        EACID_Perfect_Knight = 50,
        EACID_CW_Steal_Two_Face = 51,
        EACID_CW_Ivy = 52,
        EACID_CW_Tyger_vault = 53,
        EACID_CW_Loot = 54,
        EACID_CW_Ranked_Challenges_All_Gold = 55,
        EACID_CW_Campaigns_All_Gold = 56,
        EACID_ROBIN_Ranked_Challenges_All_Gold = 57,
        EACID_ROBIN_Campaigns_All_Gold = 58,
        EACID_NW_Ranked_Challenges_All_Gold = 59,
        EACID_NW_Campaigns_All_Gold = 60,
        EACID_PDLC_1 = 61,
        EACID_PDLC_2 = 62,
        EACID_PDLC_3 = 63,
        EACID_PDLC_4 = 64,
        EACID_PDLC_5 = 65,
        EACID_PDLC_6 = 66,
        EACID_PDLC_7 = 67,
        EACID_PDLC_8 = 68,
        EACID_PDLC_9 = 69,
        EACID_PDLC_10 = 70,
        EACID_MAX = 71,
    }

    /// <summary>
    /// Enum: SContexts
    /// </summary>
    public enum SContexts : byte
    {
        SContexts_OVERWORLD = 0,
        SContexts_COURT = 1,
        SContexts_CHURCH = 2,
        SContexts_STEEL = 3,
        SContexts_MUSEUM = 4,
        SContexts_UNDERWORLD = 5,
        SContexts_GCPD = 6,
        SContexts_RIDDLER = 7,
        SContexts_IVYLAIR = 8,
        SContexts_CW = 9,
        SContexts_ZSASZ = 10,
        SContexts_NORA = 11,
        SContexts_MADHATTER = 12,
        SContexts_BANE = 13,
        SContexts_HUSH = 14,
        SContexts_MAX = 15,
    }

    /// <summary>
    /// Enum: EContexts
    /// </summary>
    public enum EContexts : byte
    {
        EContexts_CHALLENGE = 0,
        EContexts_Nothing = 1,
        EContexts_CHALLENGETYPE = 2,
        EContexts_STORYTYPE = 3,
        EContexts_Replay = 4,
        EContexts_MAX = 5,
    }

    /// <summary>
    /// Enum: EPresenceID
    /// </summary>
    public enum EPresenceID : byte
    {
        EPresence_Idle = 0,
        EPresence_Frontend = 1,
        EPresence_Story = 2,
        EPresence_Challenge = 3,
        EPresence_Replay = 4,
        EPresence_MAX = 5,
    }

    /// <summary>
    /// Enum: EComboMoveType
    /// </summary>
    public enum EComboMoveType : byte
    {
        ECMT_Strike = 0,
        ECMT_PowerStrike = 1,
        ECMT_Counter = 2,
        ECMT_Stun = 3,
        ECMT_SuperStun = 4,
        ECMT_Evade = 5,
        ECMT_Redirect = 6,
        ECMT_ProjectileCounter = 7,
        ECMT_AerialAttack = 8,
        ECMT_DirectedAerialAttack = 9,
        ECMT_GroundTakedown = 10,
        ECMT_BeatdownStart = 11,
        ECMT_BeatdownStrike = 12,
        ECMT_BeatdownFinish = 13,
        ECMT_BladeComboCounter = 14,
        ECMT_SuperBladeComboCounter = 15,
        ECMT_ElectricFloor = 16,
        ECMT_TitanStrike = 17,
        ECMT_TitanRideStrike = 18,
        ECMT_TitanRideShockwave = 19,
        ECMT_TitanRideCharge = 20,
        ECMT_TitanFinish = 21,
        ECMT_TitanBerserk = 22,
        ECMT_LieutenantFinish = 23,
        ECMT_Takedown = 24,
        ECMT_Batarang = 25,
        ECMT_Batclaw = 26,
        ECMT_BatclawSlam = 27,
        ECMT_SmokePellet = 28,
        ECMT_REC = 29,
        ECMT_Freeze = 30,
        ECMT_Gel = 31,
        ECMT_BMDisarmAndDestroy = 32,
        ECMT_BMBatswarm = 33,
        ECMT_BMGroupGroundKO = 34,
        ECMT_CWProjectile = 35,
        ECMT_CWBullwhip = 36,
        ECMT_CWGroupTrip = 37,
        ECMT_CWGroupAttack = 38,
        ECMT_CWCaltrops = 39,
        ECMT_RBProjectile = 40,
        ECMT_RBStickyBomb = 41,
        ECMT_RBZipKick = 42,
        ECMT_RBShieldCharge = 43,
        ECMT_RBThrow = 44,
        ECMT_RBThrowRingOut = 45,
        ECMT_RBThrowKnockdown = 46,
        ECMT_RBGroupAttack = 47,
        ECMT_NWProjectile = 48,
        ECMT_NWGroupElectrify = 49,
        ECMT_NWGroupAttack = 50,
        ECMT_NWGroupStun = 51,
        ECMT_NWDart = 52,
        ECMT_NWDartHeadShot = 53,
        ECMT_NWStick = 54,
        ECMT_Slide = 55,
        ECMT_MAX = 56,
    }

    /// <summary>
    /// Enum: RagdollStunType
    /// </summary>
    public enum RagdollStunType : byte
    {
        RAGSTUN_Generic = 0,
        RAGSTUN_Batarang = 1,
        RAGSTUN_BatClaw = 2,
        RAGSTUN_GlideKick = 3,
        RAGSTUN_LineLaunchKick = 4,
        RAGSTUN_SwingKick = 5,
        RAGSTUN_Throw = 6,
        RAGSTUN_PounceAttack = 7,
        RAGSTUN_CaltropsTrap = 8,
        RAGSTUN_BoomerangBatarang = 9,
        RAGSTUN_DropAttack = 10,
        RAGSTUN_GelWeaponCrate = 11,
        RAGSTUN_SlideAttack = 12,
        RAGSTUN_GlideBoostTackle = 13,
        RAGSTUN_ControllableBatarang = 14,
        RAGSTUN_GelMine = 15,
        RAGSTUN_RECArmouredBlast = 16,
        RAGSTUN_RicochetStick = 17,
        RAGSTUN_ElectroBlast = 18,
        RAGSTUN_WristDart = 19,
        RAGSTUN_ShieldBash = 20,
        RAGSTUN_ShieldBlockAndBash = 21,
        RAGSTUN_ZipKick = 22,
        RAGSTUN_StickyBomb = 23,
        RAGSTUN_RasFade = 24,
        RAGSTUN_WhipTrip = 25,
        RAGSTUN_FreezeLadder = 26,
        RAGSTUN_IceThugPush = 27,
        RAGSTUN_MAX = 28,
    }

    /// <summary>
    /// Enum: EGameAction
    /// </summary>
    public enum EGameAction : byte
    {
        GA_None = 0,
        GA_Takedown_CombatTakedown = 1,
        GA_Takedown_CombatRedirect = 2,
        GA_Takedown_CombatRailing = 3,
        GA_Takedown_CombatStrike = 4,
        GA_Takedown_CombatWall = 5,
        GA_Takedown_CombatShocked = 6,
        GA_Takedown_Fallen = 7,
        GA_Takedown_GrabStanding = 8,
        GA_Takedown_GrabFloor = 9,
        GA_Takedown_GrabGrate = 10,
        GA_Takedown_GrabCorner = 11,
        GA_Takedown_HangAttack = 12,
        GA_Takedown_GlideKick = 13,
        GA_Takedown_GlassAttack = 14,
        GA_Takedown_VentAttack = 15,
        GA_Takedown_LedgeAttack = 16,
        GA_KO = 17,
        GA_KO_Knife = 18,
        GA_KO_Pipe = 19,
        GA_KO_StunStick = 20,
        GA_KO_Shield = 21,
        GA_KO_Armoured = 22,
        GA_KO_Ninja = 23,
        GA_KO_CombatGun = 24,
        GA_KO_PredatorGun = 25,
        GA_KO_Sniper = 26,
        GA_KO_Lieutenant = 27,
        GA_KO_Lunatic = 28,
        GA_Rescue = 29,
        GA_EvidenceTrailOver = 30,
        GA_Pickup = 31,
        GA_Pickup_Map = 32,
        GA_Pickup_Tape = 33,
        GA_Cipher_Found = 34,
        GA_Riddle_Solved = 35,
        GA_DestroyTeeth = 36,
        GA_VenomHenchmanDefeated = 37,
        GA_SP_InitialDiscovery = 38,
        GA_BossGrundyPhaseOver = 39,
        GA_BossGrundyPhaseOver_Hard = 40,
        GA_BossJokerPhaseOver = 41,
        GA_BossClayfacePhaseOver = 42,
        GA_DropOnThug = 43,
        GA_ScareThug = 44,
        GA_SP_FurtherDiscovery = 45,
        GA_Stun_Batarang = 46,
        GA_Combo_XP_Multiplier = 47,
        GA_Combat_QuickStrike = 48,
        GA_Combat_HeavyStrike = 49,
        GA_Combat_ComboStrike = 50,
        GA_Combat_Counter = 51,
        GA_Combat_Redirect = 52,
        GA_Combat_Evade = 53,
        GA_Combat_Stun = 54,
        GA_Grab_Henchman = 55,
        GA_Gadget_Grapple = 56,
        GA_Gadget_Grapple_Rescue = 57,
        GA_Gadget_Grapple_AnyTime = 58,
        GA_Gadget_Grapple_Failed = 59,
        GA_Gadget_Batarang180Flip = 60,
        GA_Gadget_Batarang = 61,
        GA_Gadget_SonicBatarang = 62,
        GA_Gadget_ExplosiveGel = 63,
        GA_Gadget_BatClaw = 64,
        GA_Gadget_Resonator = 65,
        GA_Gadget_BroadcastAnalyser = 66,
        GA_Gadget_ControllableBatarang = 67,
        GA_Gadget_RoundTheBackarang = 68,
        GA_Gadget_MagneticBlast = 69,
        GA_Gadget_MagneticBlastRepel = 70,
        GA_Gadget_FreezeSpray = 71,
        GA_Gadget_SmokeBomb = 72,
        GA_Gadget_JammerGadget = 73,
        GA_Gadget_LineLauncherTightRope = 74,
        GA_Gadget_LineLauncher_IfNotFired = 75,
        GA_Gadget_BatarangBrake = 76,
        GA_Gadget_LineLauncher = 77,
        GA_Gadget_CombatBatClaw = 78,
        GA_Gadget_CombatBatarang = 79,
        GA_Gadget_Detonator = 80,
        GA_Gadget_Bullwhip = 81,
        GA_Gadget_CombatBullwhip = 82,
        GA_Gadget_BullwhipCombatDisarm = 83,
        GA_Gadget_Staff = 84,
        GA_Gadget_ShieldBash = 85,
        GA_Gadget_SticksAreaStun = 86,
        GA_Gadget_SticksRicochet = 87,
        GA_Gadget_WristDart = 88,
        GA_Gadget_StickyBomb = 89,
        GA_Gadget_ZipKick = 90,
        GA_Gadget_QuickBatarang = 91,
        GA_Gadget_QuickGel = 92,
        GA_Gadget_QuickDetonate = 93,
        GA_Gadget_QuickClaw = 94,
        GA_Gadget_QuickFreeze = 95,
        GA_Gadget_QuickMagBlast = 96,
        GA_Gadget_DetonateGel = 97,
        GA_Gadget_QuickBullwhip = 98,
        GA_Gadget_DoubleLineLauncher_Tutorial = 99,
        GA_EnygmaScreen_Tutorial = 100,
        GA_SilentPredatorCamera = 101,
        GA_InvestigateMode = 102,
        GA_MapOpened = 103,
        GA_Zoom = 104,
        GA_UnZoom = 105,
        GA_Agility_Climb = 106,
        GA_Agility_ClimbDown = 107,
        GA_Agility_Shimmy = 108,
        GA_Agility_DiveThroughWindow = 109,
        GA_Agility_WalkOnRailing = 110,
        GA_Agility_Swing = 111,
        GA_Agility_Slide = 112,
        GA_Agility_Jump = 113,
        GA_Agility_CwSwingToCeiling = 114,
        GA_Agility_CwJumpToCeiling = 115,
        GA_Agility_CwUsedCeilingGrate = 116,
        GA_InvisiblePredator_Crouch = 117,
        GA_InvisiblePredator_CornerCover = 118,
        GA_InvisiblePredator_TunnelGrate = 119,
        GA_InvisiblePredator_HangMode = 120,
        GA_InvisiblePredator_JumpFromVantagePoint = 121,
        GA_InvisiblePredator_SwingToVantagePoint = 122,
        GA_InvisiblePredator_InstantSmokeBomb = 123,
        GA_TakedownBeginTakedown = 124,
        GA_Died = 125,
        GA_PredatorChallenge_WallKill = 126,
        GA_PredatorChallenge_BatarangThenTakedown = 127,
        GA_PredatorChallenge_GlideKickThenTakedown = 128,
        GA_PredatorChallenge_1Wall3Kills = 129,
        GA_PredatorChallenge_2Walls2Kills = 130,
        GA_PredatorChallenge_3Walls3Kills = 131,
        GA_PredatorChallenge_LineLaunchKickThroughWindow = 132,
        GA_PredatorChallenge_BatclawOverLedge = 133,
        GA_PredatorChallenge_Batclaw3OverLedge = 134,
        GA_PredatorChallenge_LineLaunch2People = 135,
        GA_PredatorChallenge_LineLaunch3People = 136,
        GA_PredatorChallenge_Hit3WithSteerableBatarang = 137,
        GA_PredatorChallenge_SonicBatarangKill = 138,
        GA_PredatorChallenge_3BatarangHit = 139,
        GA_PredatorChallenge_LineLauncherKill = 140,
        GA_PredatorChallenge_GrateThenGrab = 141,
        GA_PredatorChallenge_PullOutFloorFrom1 = 142,
        GA_PredatorChallenge_PullOutFloorFrom2 = 143,
        GA_PredatorChallenge_PullOutFloorFrom3 = 144,
        GA_PredatorChallenge_SilentTakedown = 145,
        GA_PredatorChallenge_LedgeTakedown = 146,
        GA_PredatorChallenge_CornerTakedown = 147,
        GA_PredatorChallenge_GlassTakedown = 148,
        GA_PredatorChallenge_HangingTakedown = 149,
        GA_PredatorChallenge_DropTakedown = 150,
        GA_PredatorChallenge_PunchArmedThug = 151,
        GA_PredatorChallenge_UltraBatclawWallKill = 152,
        GA_PredatorChallenge_ScareThug = 153,
        GA_PredatorChallenge_GooStun = 154,
        GA_PredatorChallenge_TakedownVIPFirst = 155,
        GA_PredatorChallenge_Punch3DifferentThugs = 156,
        GA_PredatorChallenge_NoDamage = 157,
        GA_PredatorChallenge_TakedownVIPLast = 158,
        GA_PredatorChallenge_UpLadderOntoGel = 159,
        GA_PredatorChallenge_HangingTakeDownThroughGlass = 160,
        GA_PredatorChallenge_QuickSilentTakedown = 161,
        GA_PredatorChallenge_ReverseChokeTakedown = 162,
        GA_PredatorChallenge_FromAboveTakedown = 163,
        GA_PredatorChallenge_DoubleLedgeTakedown = 164,
        GA_PredatorChallenge_DoubleHeadTakedown = 165,
        GA_PredatorChallenge_DoubleVantagePointTakedown = 166,
        GA_PredatorChallenge_LineLauncherTakedown = 167,
        GA_PredatorChallenge_SwingKickThenTakedown = 168,
        GA_PredatorChallenge_FractureWallTakedown = 169,
        GA_PredatorChallenge_InvertedCeilingTakedown = 170,
        GA_PredatorChallenge_PounceKOThenTakedown = 171,
        GA_PredatorChallenge_CaltropKOThenTakedown = 172,
        GA_PredatorChallenge_PullFromCatwalkTakedown = 173,
        GA_PredatorChallenge_BoomerangBatarangTakedown = 174,
        GA_PredatorChallenge_GelCrateThenTakedown = 175,
        GA_PredatorChallenge_BatclawDisarmThenKO = 176,
        GA_PredatorChallenge_BatclawThroughWindow = 177,
        GA_PredatorChallenge_LineLaunchKick = 178,
        GA_PredatorChallenge_DropAttackFromTightRope = 179,
        GA_PredatorChallenge_DoubleLineLaunchKick = 180,
        GA_PredatorChallenge_RECScareThugs = 181,
        GA_PredatorChallenge_RECArmouredBowlingBall = 182,
        GA_PredatorChallenge_FreezeTakedown = 183,
        GA_PredatorChallenge_FreezeClusterDoubleTakedown = 184,
        GA_PredatorChallenge_FreezeProximityThenTakedown = 185,
        GA_PredatorChallenge_SmokeBombTakedown = 186,
        GA_PredatorChallenge_BeatDownTakedown = 187,
        GA_PredatorChallenge_SlideThenTakedown = 188,
        GA_PredatorChallenge_DiveBombThenTakedown = 189,
        GA_PredatorChallenge_Shockwave3Enemies = 190,
        GA_PredatorChallenge_VentTakedown = 191,
        GA_PredatorChallenge_FloorGrateTakedown = 192,
        GA_PredatorChallenge_Combo3 = 193,
        GA_PredatorChallenge_Combo8 = 194,
        GA_PredatorChallenge_BatarangBoostArmouredThug = 195,
        GA_PredatorChallenge_BatarangBoostKO = 196,
        GA_PredatorChallenge_HangTakedownOnJammer = 197,
        GA_PredatorChallenge_MineDetonateOnMineLayer = 198,
        GA_PredatorChallenge_CombatFloorKO = 199,
        GA_PredatorChallenge_FloorGrab = 200,
        GA_PredatorChallenge_PunchKO = 201,
        GA_PredatorChallenge_EscrimaStick1 = 202,
        GA_PredatorChallenge_EscrimaStick2 = 203,
        GA_PredatorChallenge_RemoteElectricalBlast1 = 204,
        GA_PredatorChallenge_RemoteElectricalBlast2 = 205,
        GA_PredatorChallenge_RemoteElectricalBlast3 = 206,
        GA_PredatorChallenge_WristDart1 = 207,
        GA_PredatorChallenge_WristDart2 = 208,
        GA_PredatorChallenge_WristDart3 = 209,
        GA_PredatorChallenge_BulletShield1 = 210,
        GA_PredatorChallenge_BulletShield2 = 211,
        GA_PredatorChallenge_BulletShield3 = 212,
        GA_PredatorChallenge_ZipKick1 = 213,
        GA_PredatorChallenge_ZipKick2 = 214,
        GA_PredatorChallenge_ZipKick3 = 215,
        GA_PredatorChallenge_StickyBomb1 = 216,
        GA_PredatorChallenge_StickyBomb2 = 217,
        GA_PredatorChallenge_StickyBomb3 = 218,
        GA_PredatorChallenge_WhipDisarm = 219,
        GA_PredatorChallenge_CwBeatDownTakedown = 220,
        GA_PredatorChallenge_PullSniperFromCatwalkTakedown = 221,
        GA_PredatorChallenge_WeaponJam = 222,
        GA_PredatorChallenge_SonicBatarangTakedown = 223,
        GA_PredatorChallenge_RECOverLedge = 224,
        GA_PredatorChallenge_GelCeiling = 225,
        GA_PredatorChallenge_BatarangDistract = 226,
        GA_PredatorChallenge_FireExtinguisherTakedown = 227,
        GA_PredatorChallenge_WindowTakedown = 228,
        GA_PredatorChallenge_BatarangThenTakedownCW = 229,
        GA_PredatorChallenge_BatarangThenTakedownRB = 230,
        GA_PredatorChallenge_BatarangThenTakedownNW = 231,
        GA_PredatorChallenge_BatarangDistractCW = 232,
        GA_PredatorChallenge_BatarangDistractRB = 233,
        GA_PredatorChallenge_BatarangDistractNW = 234,
        GA_PredatorChallenge_FireExtinguisherTakedownCW = 235,
        GA_PredatorChallenge_FireExtinguisherTakedownRB = 236,
        GA_PredatorChallenge_FireExtinguisherTakedownNW = 237,
        GA_PredatorChallenge_BatarangBoostKORB = 238,
        GA_PredatorChallenge_WhipTripThenTakedown = 239,
        GA_PredatorChallenge_FallingTakedown = 240,
        GA_PredatorChallenge_WristDartOverLedge = 241,
        GA_PredatorChallenge_StickyBombOverLedge = 242,
        GA_PredatorChallenge_CornerTakedownKO = 243,
        GA_PredatorChallenge_MineExplosionKO = 244,
        GA_PredatorChallenge_TakedownProjectileKO = 245,
        GA_Combat_CounterStart = 246,
        GA_AzraelGlyphScanned = 247,
        GA_InterrogatedThug = 248,
        GA_ScannedInterrogateThug = 249,
        GA_TitanRideStarted = 250,
        GA_SuperStun = 251,
        GA_StruckStunStickThug = 252,
        GA_LieutenantHitWithREC = 253,
        GA_ChallengeMedalGained = 254,
        GA_Max = 255,
    }

    /// <summary>
    /// Enum: ELive_LiveError
    /// </summary>
    public enum ELive_LiveError : byte
    {
        EL_None = 0,
        EL_LoginLost = 1,
        EL_LoginChanged = 2,
        EL_NotConnected = 3,
        EL_Connected = 4,
        EL_ConnectionDropped = 5,
        EL_NoNetworkConnection = 6,
        EL_ServiceUnavailable = 7,
        EL_UpdateRequired = 8,
        EL_ServersTooBusy = 9,
        EL_DuplicateLoginDetected = 10,
        EL_InvalidUser = 11,
        EL_PS3NotConnected = 12,
        EL_PS3NotLoggedIn = 13,
        EL_DLCInvalidated = 14,
        EL_DLCNewContent = 15,
        EL_MAX = 16,
    }

    /// <summary>
    /// Enum: EGS_Reason
    /// </summary>
    public enum EGS_Reason : byte
    {
        EGS_None = 0,
        EGS_StoryExit = 1,
        EGS_StoryComplete = 2,
        EGS_Challenge_Lost = 3,
        EGS_Challenge_Won = 4,
        EGS_MAX = 5,
    }

    /// <summary>
    /// Enum: EGameModes
    /// </summary>
    public enum EGameModes : byte
    {
        EGM_Frontend = 0,
        EGM_Story = 1,
        EGM_Challenge = 2,
        EGM_MAX = 3,
    }

    /// <summary>
    /// Enum: ELeaderboardColumns
    /// </summary>
    public enum ELeaderboardColumns : byte
    {
        ELBC_Medal = 0,
        ELBC_Score = 1,
        ELBC_RatingScore = 2,
        ELBC_MAX = 3,
    }

    /// <summary>
    /// Enum: StreamedCombatWeaponTypes
    /// </summary>
    public enum StreamedCombatWeaponTypes : byte
    {
        COMBATWEAPON_None = 0,
        COMBATWEAPON_Rifle = 1,
        COMBATWEAPON_Knife = 2,
        COMBATWEAPON_Bottle = 3,
        COMBATWEAPON_Pipe = 4,
        COMBATWEAPON_Bat = 5,
        COMBATWEAPON_Shield = 6,
        COMBATWEAPON_StunStick = 7,
        COMBATWEAPON_MAX = 8,
    }

    /// <summary>
    /// Enum: StreamedPredWeaponTypes
    /// </summary>
    public enum StreamedPredWeaponTypes : byte
    {
        PREDWEAPON_Rifle = 0,
        PREDWEAPON_Shotgun = 1,
        PREDWEAPON_Sniper = 2,
        PREDWEAPON_None = 3,
        PREDWEAPON_MAX = 4,
    }

    /// <summary>
    /// Enum: VocalPriority
    /// </summary>
    public enum VocalPriority : byte
    {
        EVP_Default = 0,
        EVP_Low = 1,
        EVP_Medium = 2,
        EVP_High = 3,
        EVP_Highest = 4,
        EVP_DuckAllOther = 5,
        EVP_MAX = 6,
    }

    /// <summary>
    /// Enum: VocalType
    /// </summary>
    public enum VocalType : byte
    {
        EVT_Emote = 0,
        EVT_Bark = 1,
        EVT_Speech = 2,
        EVT_MAX = 3,
    }

    /// <summary>
    /// Struct: FInterrogationData
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 20)]
    public partial record struct FInterrogationData
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: InterrogationIndex
        /// </summary>
        public unsafe byte InterrogationIndex
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }

        /// <summary>
        /// ByteProperty: NumInterrogations
        /// </summary>
        public unsafe byte NumInterrogations
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 13); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 13); }; }
        }

        /// <summary>
        /// BoolProperty: bRepeatForever
        /// </summary>
        public unsafe bool bRepeatForever
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16) & 1) != 0; }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 16); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 16); }; }
        }
    }

    /// <summary>
    /// Struct: FLevelStartDefinition
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FLevelStartDefinition
    {
        /// <summary>
        /// StrProperty: Name
        /// </summary>
        public unsafe BmSDK.FString Name
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// StrProperty: LevelNames
        /// </summary>
        public unsafe BmSDK.FString LevelNames
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }

    /// <summary>
    /// ObjectProperty: GameplayEventsWriter
    /// </summary>
    public unsafe BmSDK.BmGame.RGameplayEventsHydra GameplayEventsWriter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameplayEventsHydra>(Ptr + 892); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 892); }
    }

    /// <summary>
    /// ArrayProperty: DebugLevelStarts
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelStartDefinition> DebugLevelStarts
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FLevelStartDefinition>>(Ptr + 896); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 896); }
    }

    /// <summary>
    /// ArrayProperty: InterrogationInfo
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FInterrogationData> InterrogationInfo
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FInterrogationData>>(Ptr + 908); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 908); }
    }

    /// <summary>
    /// ArrayProperty: AllThugScarableCrows
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RCrowsBase> AllThugScarableCrows
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RCrowsBase>>(Ptr + 920); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 920); }
    }

    /// <summary>
    /// IntProperty: CrowTimeSliceIndex
    /// </summary>
    public unsafe int CrowTimeSliceIndex
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 932); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 932); }
    }

    /// <summary>
    /// ArrayProperty: GADuplicateList_Main
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GADuplicateList_Main
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 936); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 936); }
    }

    /// <summary>
    /// ArrayProperty: GADuplicateList_Dup
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction> GADuplicateList_Dup
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.EGameAction>>(Ptr + 948); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 948); }
    }

    /// <summary>
    /// InlineArray{ByteProperty}: FloorTakedownChallengeAction
    /// </summary>
    public InlineArray<BmSDK.BmGame.RGameInfo.EGameAction> FloorTakedownChallengeAction => new(28, Ptr + 960, 1, this);

    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_0
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 960); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 960); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_1
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 961); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 961); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_2
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 962); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 962); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_3
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 963); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 963); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_4
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 964); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 964); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_5
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 965); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 965); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_6
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 966); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 966); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_7
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 967); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 967); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_8
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 968); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 968); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_9
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 969); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 969); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_10
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 970); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 970); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_11
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 971); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 971); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_12
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 972); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 972); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_13
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 973); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 973); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_14
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 974); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 974); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_15
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 975); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 975); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_16
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 976); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 976); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_17
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 977); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 977); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_18
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 978); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 978); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_19
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 979); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 979); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_20
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 980); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 980); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_21
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 981); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 981); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_22
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 982); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 982); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_23
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 983); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 983); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_24
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 984); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 984); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_25
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 985); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 985); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_26
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 986); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 986); }
    }
    /// <summary>
    /// ByteProperty: FloorTakedownChallengeAction
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameAction FloorTakedownChallengeAction_27
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameAction>(Ptr + 987); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 987); }
    }

    /// <summary>
    /// ByteProperty: GameMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EGameModes GameMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EGameModes>(Ptr + 988); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 988); }
    }

    /// <summary>
    /// ByteProperty: ChallengeMode
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeMode ChallengeMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeMode>(Ptr + 989); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 989); }
    }

    /// <summary>
    /// ByteProperty: ChallengeCharacter
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EChallengeCharacter ChallengeCharacter
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EChallengeCharacter>(Ptr + 990); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 990); }
    }

    /// <summary>
    /// ByteProperty: StasisLevel
    /// </summary>
    public unsafe BmSDK.BmGame.RGameInfo.EStasisLevel StasisLevel
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RGameInfo.EStasisLevel>(Ptr + 991); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 991); }
    }

    /// <summary>
    /// ByteProperty: ReplayId
    /// </summary>
    public unsafe byte ReplayId
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<byte>(Ptr + 992); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 992); }
    }

    /// <summary>
    /// ObjectProperty: AIManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMAIManager AIManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMAIManager>(Ptr + 996); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 996); }
    }

    /// <summary>
    /// ObjectProperty: CombatManager
    /// </summary>
    public unsafe BmSDK.BmGame.RBMCombatManager CombatManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMCombatManager>(Ptr + 1000); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1000); }
    }

    /// <summary>
    /// ObjectProperty: CrowdManager
    /// </summary>
    public unsafe BmSDK.BmGame.RCrowdManager CrowdManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RCrowdManager>(Ptr + 1004); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1004); }
    }

    /// <summary>
    /// ObjectProperty: DialogueManager
    /// </summary>
    public unsafe BmSDK.BmGame.RDialogueManager DialogueManager
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RDialogueManager>(Ptr + 1008); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1008); }
    }

    /// <summary>
    /// ComponentProperty: CurrentRoomAIState
    /// </summary>
    public unsafe BmSDK.BmGame.RBMRoomAIState CurrentRoomAIState
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMRoomAIState>(Ptr + 1012); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1012); }
    }

    /// <summary>
    /// ObjectProperty: CombatDialogueCoordinator
    /// </summary>
    public unsafe BmSDK.BmGame.RBMDialogueCoordinator CombatDialogueCoordinator
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RBMDialogueCoordinator>(Ptr + 1016); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1016); }
    }

    /// <summary>
    /// ObjectProperty: CachedPC
    /// </summary>
    public unsafe BmSDK.BmGame.RPlayerController CachedPC
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RPlayerController>(Ptr + 1020); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1020); }
    }

    /// <summary>
    /// BoolProperty: bHead2Head
    /// </summary>
    public unsafe bool bHead2Head
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 1) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 1) : (currentMask & ~1); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bStoryDLC
    /// </summary>
    public unsafe bool bStoryDLC
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 2) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 2) : (currentMask & ~2); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bSavingStartPoints
    /// </summary>
    public unsafe bool bSavingStartPoints
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 4) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 4) : (currentMask & ~4); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bDemoBuild
    /// </summary>
    public unsafe bool bDemoBuild
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 8) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 8) : (currentMask & ~8); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bShowChaseStartPos
    /// </summary>
    public unsafe bool bShowChaseStartPos
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 16) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 16) : (currentMask & ~16); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bM8VantageVisibilityHack
    /// </summary>
    public unsafe bool bM8VantageVisibilityHack
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 32) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 32) : (currentMask & ~32); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bOneHitKill
    /// </summary>
    public unsafe bool bOneHitKill
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 64) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 64) : (currentMask & ~64); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bNoGadgets
    /// </summary>
    public unsafe bool bNoGadgets
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 128) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 128) : (currentMask & ~128); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bSilentTakeDownOnly
    /// </summary>
    public unsafe bool bSilentTakeDownOnly
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 256) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 256) : (currentMask & ~256); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bNoGrapple
    /// </summary>
    public unsafe bool bNoGrapple
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 512) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 512) : (currentMask & ~512); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bNoInvestigateMode
    /// </summary>
    public unsafe bool bNoInvestigateMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 1024) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 1024) : (currentMask & ~1024); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bUseLowLineLauncherHeight
    /// </summary>
    public unsafe bool bUseLowLineLauncherHeight
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 2048) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 2048) : (currentMask & ~2048); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: LevelLoadedAndReady
    /// </summary>
    public unsafe bool LevelLoadedAndReady
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 4096) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 4096) : (currentMask & ~4096); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bSuspendAllDeadGameOver
    /// </summary>
    public unsafe bool bSuspendAllDeadGameOver
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 8192) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 8192) : (currentMask & ~8192); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bDoCombatGrapnelToVpointArriveCheck
    /// </summary>
    public unsafe bool bDoCombatGrapnelToVpointArriveCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 16384) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 16384) : (currentMask & ~16384); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: EnableBigHeadMode
    /// </summary>
    public unsafe bool EnableBigHeadMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 32768) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 32768) : (currentMask & ~32768); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bSplitscreenCaptureMode
    /// </summary>
    public unsafe bool bSplitscreenCaptureMode
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 65536) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 65536) : (currentMask & ~65536); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: bPreventPauseOnControllerRemoval
    /// </summary>
    public unsafe bool bPreventPauseOnControllerRemoval
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 131072) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 131072) : (currentMask & ~131072); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: SavedOWDTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedOWDTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 262144) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 262144) : (currentMask & ~262144); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: SavedMuseumTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedMuseumTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 524288) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 524288) : (currentMask & ~524288); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// BoolProperty: SavedUnderTriedForSecretsLeftCheck
    /// </summary>
    public unsafe bool SavedUnderTriedForSecretsLeftCheck
    {
        get { return (BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024) & 1048576) != 0; }
        set { var currentMask = BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1024); var newMask = value ? (currentMask | 1048576) : (currentMask & ~1048576); BmSDK.Framework.MarshalUtil.ToUnmanaged<int>(newMask, Ptr + 1024); }
    }

    /// <summary>
    /// IntProperty: ChallengeID
    /// </summary>
    public unsafe int ChallengeID
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1028); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1028); }
    }

    /// <summary>
    /// FloatProperty: SessionTimePlayed
    /// </summary>
    public unsafe float SessionTimePlayed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1032); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1032); }
    }

    /// <summary>
    /// FloatProperty: FootstepNoiseDist
    /// </summary>
    public unsafe float FootstepNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1036); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1036); }
    }

    /// <summary>
    /// FloatProperty: WalkFootstepNoiseDist
    /// </summary>
    public unsafe float WalkFootstepNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1040); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1040); }
    }

    /// <summary>
    /// FloatProperty: TakedownNoiseDist
    /// </summary>
    public unsafe float TakedownNoiseDist
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1044); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1044); }
    }

    /// <summary>
    /// FloatProperty: ChaseCheatTime
    /// </summary>
    public unsafe float ChaseCheatTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1048); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1048); }
    }

    /// <summary>
    /// FloatProperty: RBSmashSpeedAlertThreshold
    /// </summary>
    public unsafe float RBSmashSpeedAlertThreshold
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1052); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1052); }
    }

    /// <summary>
    /// FloatProperty: BingBongTimer
    /// </summary>
    public unsafe float BingBongTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1056); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1056); }
    }

    /// <summary>
    /// FloatProperty: GunStartleTimer
    /// </summary>
    public unsafe float GunStartleTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1060); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1060); }
    }

    /// <summary>
    /// StructProperty: CurrentWindState
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FRWindState CurrentWindState
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FRWindState>(Ptr + 1064);

    /// <summary>
    /// StructProperty: CurrentWindConfig
    /// </summary>
    public unsafe ref BmSDK.BmGame.RGameInfo.FRWindConfig CurrentWindConfig
        => ref BmSDK.Framework.MarshalUtil.AsRef<BmSDK.BmGame.RGameInfo.FRWindConfig>(Ptr + 1132);

    /// <summary>
    /// FloatProperty: CurrentRainIntensity
    /// </summary>
    public unsafe float CurrentRainIntensity
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1168); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1168); }
    }

    /// <summary>
    /// ArrayProperty: ObjectiveMarkers
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RObjectiveMarker> ObjectiveMarkers
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RObjectiveMarker>>(Ptr + 1172); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1172); }
    }

    /// <summary>
    /// IntProperty: VisibleObjectiveMarker
    /// </summary>
    public unsafe int VisibleObjectiveMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1184); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1184); }
    }

    /// <summary>
    /// IntProperty: HighestPriorityNonCustomObjectiveMarker
    /// </summary>
    public unsafe int HighestPriorityNonCustomObjectiveMarker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1188); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1188); }
    }

    /// <summary>
    /// ArrayProperty: ActiveSmokeScreens
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RSmokeScreen> ActiveSmokeScreens
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RSmokeScreen>>(Ptr + 1192); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1192); }
    }

    /// <summary>
    /// ArrayProperty: PredVolumeList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RPredatorVolume> PredVolumeList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RPredatorVolume>>(Ptr + 1204); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1204); }
    }

    /// <summary>
    /// ArrayProperty: LoadedAllTheTimeOnPCToSaveDVDSpace
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.GameObject> LoadedAllTheTimeOnPCToSaveDVDSpace
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.GameObject>>(Ptr + 1216); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1216); }
    }

    /// <summary>
    /// FloatProperty: PredChaseTime
    /// </summary>
    public unsafe float PredChaseTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1228); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1228); }
    }

    /// <summary>
    /// ArrayProperty: LevelTransitions
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RLevelTransition> LevelTransitions
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RLevelTransition>>(Ptr + 1232); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1232); }
    }

    /// <summary>
    /// ObjectProperty: PatrolGunDefaultAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PatrolGunDefaultAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1244); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1244); }
    }

    /// <summary>
    /// ObjectProperty: PatrolGunUpAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PatrolGunUpAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1248); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1248); }
    }

    /// <summary>
    /// ObjectProperty: ManDownPeekAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager ManDownPeekAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1252); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1252); }
    }

    /// <summary>
    /// ObjectProperty: GuardPointAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager GuardPointAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1256); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1256); }
    }

    /// <summary>
    /// ObjectProperty: ReloadAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager ReloadAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1260); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1260); }
    }

    /// <summary>
    /// ObjectProperty: TutThugAimingAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager TutThugAimingAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1264); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1264); }
    }

    /// <summary>
    /// ObjectProperty: PerimOutAnimTracker
    /// </summary>
    public unsafe BmSDK.BmGame.RRepeatAnimManager PerimOutAnimTracker
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.BmGame.RRepeatAnimManager>(Ptr + 1268); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1268); }
    }

    /// <summary>
    /// FloatProperty: LastExclaimTime
    /// </summary>
    public unsafe float LastExclaimTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1272); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1272); }
    }

    /// <summary>
    /// IntProperty: LastExclaimPriority
    /// </summary>
    public unsafe int LastExclaimPriority
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1276); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1276); }
    }

    /// <summary>
    /// FloatProperty: CombatGrapnelToVPointStartTime
    /// </summary>
    public unsafe float CombatGrapnelToVPointStartTime
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1280); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1280); }
    }

    /// <summary>
    /// IntProperty: FramesUntilNextPawnSpawn
    /// </summary>
    public unsafe int FramesUntilNextPawnSpawn
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1284); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1284); }
    }

    /// <summary>
    /// ArrayProperty: ActiveHelicopters
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RHelicopterBase> ActiveHelicopters
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RHelicopterBase>>(Ptr + 1288); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1288); }
    }

    /// <summary>
    /// FloatProperty: ICStasisRange
    /// </summary>
    public unsafe float ICStasisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1300); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1300); }
    }

    /// <summary>
    /// FloatProperty: FullStasisRange
    /// </summary>
    public unsafe float FullStasisRange
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1304); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1304); }
    }

    /// <summary>
    /// IntProperty: SkinMode
    /// </summary>
    public unsafe int SkinMode
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1308); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1308); }
    }

    /// <summary>
    /// StrProperty: SkinWhoBase
    /// </summary>
    public unsafe BmSDK.FString SkinWhoBase
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1312); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1312); }
    }

    /// <summary>
    /// StrProperty: SkinStartString
    /// </summary>
    public unsafe BmSDK.FString SkinStartString
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1324); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1324); }
    }

    /// <summary>
    /// IntProperty: PlayFromChosenSlot
    /// </summary>
    public unsafe int PlayFromChosenSlot
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1336); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1336); }
    }

    /// <summary>
    /// ArrayProperty: ChallengeMapList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapItem> ChallengeMapList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapItem>>(Ptr + 1340); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1340); }
    }

    /// <summary>
    /// ArrayProperty: SubMapLocList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapHackOWLoc> SubMapLocList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapHackOWLoc>>(Ptr + 1352); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1352); }
    }

    /// <summary>
    /// ArrayProperty: MapElementList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElements> MapElementList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElements>>(Ptr + 1364); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1364); }
    }

    /// <summary>
    /// ArrayProperty: MapElementItemList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElementsItem> MapElementItemList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FMapElementsItem>>(Ptr + 1376); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1376); }
    }

    /// <summary>
    /// ArrayProperty: StoryDLCList
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.BmGame.RGameInfo.FStoryDLCItem> StoryDLCList
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.BmGame.RGameInfo.FStoryDLCItem>>(Ptr + 1388); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1388); }
    }

    /// <summary>
    /// FloatProperty: DebugForceGarbageTimer
    /// </summary>
    public unsafe float DebugForceGarbageTimer
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1400); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1400); }
    }

    /// <summary>
    /// ArrayProperty: DLCBundlesInstalled
    /// </summary>
    public unsafe BmSDK.TArray<BmSDK.FString> DLCBundlesInstalled
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.FString>>(Ptr + 1404); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1404); }
    }

    /// <summary>
    /// FloatProperty: CameraMovementSpeed
    /// </summary>
    public unsafe float CameraMovementSpeed
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<float>(Ptr + 1416); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1416); }
    }

    /// <summary>
    /// IntProperty: helicopterSequenceNumber
    /// </summary>
    public unsafe int helicopterSequenceNumber
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1420); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1420); }
    }

    /// <summary>
    /// StrProperty: deathMovieOverride
    /// </summary>
    public unsafe BmSDK.FString deathMovieOverride
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(Ptr + 1424); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1424); }
    }

    /// <summary>
    /// IntProperty: SavedMapIndexForSecretsLeftCheck
    /// </summary>
    public unsafe int SavedMapIndexForSecretsLeftCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1436); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1436); }
    }

    /// <summary>
    /// IntProperty: SavedSecretIndexForSecretsLeftCheck
    /// </summary>
    public unsafe int SavedSecretIndexForSecretsLeftCheck
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<int>(Ptr + 1440); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1440); }
    }

    /// <summary>
    /// DelegateProperty: __SortByIndexDist__Delegate
    /// </summary>
    public unsafe System.IntPtr __SortByIndexDist__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 1444); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 1444); }
    }
}
