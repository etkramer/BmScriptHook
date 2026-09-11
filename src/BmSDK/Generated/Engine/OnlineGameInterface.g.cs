#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineGameInterface<br/>
/// (size = 236)
/// (flags = 16403)
/// </summary>
public partial interface OnlineGameInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: OnJoinMigratedOnlineGameComplete
    /// </summary>
    public unsafe void OnJoinMigratedOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful);

    /// <summary>
    /// Function: OnMigrateOnlineGameComplete
    /// </summary>
    public unsafe void OnMigrateOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful);

    /// <summary>
    /// Function: OnRecalculateSkillRatingComplete
    /// </summary>
    public unsafe void OnRecalculateSkillRatingComplete(BmSDK.FName SessionName, bool bWasSuccessful);

    /// <summary>
    /// Function: AcceptGameInvite
    /// </summary>
    public unsafe bool AcceptGameInvite(byte LocalUserNum, BmSDK.FName SessionName);

    /// <summary>
    /// Function: ClearGameInviteAcceptedDelegate
    /// </summary>
    public unsafe void ClearGameInviteAcceptedDelegate(byte LocalUserNum, System.IntPtr GameInviteAcceptedDelegate);

    /// <summary>
    /// Function: AddGameInviteAcceptedDelegate
    /// </summary>
    public unsafe void AddGameInviteAcceptedDelegate(byte LocalUserNum, System.IntPtr GameInviteAcceptedDelegate);

    /// <summary>
    /// Function: OnGameInviteAccepted
    /// </summary>
    public unsafe void OnGameInviteAccepted(BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult InviteResult);

    /// <summary>
    /// Function: ClearArbitrationRegistrationCompleteDelegate
    /// </summary>
    public unsafe void ClearArbitrationRegistrationCompleteDelegate(System.IntPtr ArbitrationRegistrationCompleteDelegate);

    /// <summary>
    /// Function: AddArbitrationRegistrationCompleteDelegate
    /// </summary>
    public unsafe void AddArbitrationRegistrationCompleteDelegate(System.IntPtr ArbitrationRegistrationCompleteDelegate);

    /// <summary>
    /// Function: OnArbitrationRegistrationComplete
    /// </summary>
    public unsafe void OnArbitrationRegistrationComplete(BmSDK.FName SessionName, bool bWasSuccessful);

    /// <summary>
    /// Function: RegisterForArbitration
    /// </summary>
    public unsafe bool RegisterForArbitration(BmSDK.FName SessionName);

    /// <summary>
    /// Function: ClearEndOnlineGameCompleteDelegate
    /// </summary>
    public unsafe void ClearEndOnlineGameCompleteDelegate(System.IntPtr EndOnlineGameCompleteDelegate);

    /// <summary>
    /// Function: AddEndOnlineGameCompleteDelegate
    /// </summary>
    public unsafe void AddEndOnlineGameCompleteDelegate(System.IntPtr EndOnlineGameCompleteDelegate);

    /// <summary>
    /// Function: OnEndOnlineGameComplete
    /// </summary>
    public unsafe void OnEndOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful);

    /// <summary>
    /// Function: EndOnlineGame
    /// </summary>
    public unsafe bool EndOnlineGame(BmSDK.FName SessionName);

    /// <summary>
    /// Function: ClearStartOnlineGameCompleteDelegate
    /// </summary>
    public unsafe void ClearStartOnlineGameCompleteDelegate(System.IntPtr StartOnlineGameCompleteDelegate);

    /// <summary>
    /// Function: AddStartOnlineGameCompleteDelegate
    /// </summary>
    public unsafe void AddStartOnlineGameCompleteDelegate(System.IntPtr StartOnlineGameCompleteDelegate);

    /// <summary>
    /// Function: OnStartOnlineGameComplete
    /// </summary>
    public unsafe void OnStartOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful);

    /// <summary>
    /// Function: StartOnlineGame
    /// </summary>
    public unsafe bool StartOnlineGame(BmSDK.FName SessionName);

    /// <summary>
    /// Function: OnUnregisterPlayerComplete
    /// </summary>
    public unsafe void OnUnregisterPlayerComplete(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasSuccessful);

    /// <summary>
    /// Function: UnregisterPlayer
    /// </summary>
    public unsafe bool UnregisterPlayer(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);

    /// <summary>
    /// Function: OnRegisterPlayerComplete
    /// </summary>
    public unsafe void OnRegisterPlayerComplete(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasSuccessful);

    /// <summary>
    /// Function: RegisterPlayer
    /// </summary>
    public unsafe bool RegisterPlayer(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, bool bWasInvited);

    /// <summary>
    /// Function: GetResolvedConnectString
    /// </summary>
    public unsafe bool GetResolvedConnectString(BmSDK.FName SessionName, out BmSDK.FString ConnectInfo);

    /// <summary>
    /// Function: ClearJoinOnlineGameCompleteDelegate
    /// </summary>
    public unsafe void ClearJoinOnlineGameCompleteDelegate(System.IntPtr JoinOnlineGameCompleteDelegate);

    /// <summary>
    /// Function: AddJoinOnlineGameCompleteDelegate
    /// </summary>
    public unsafe void AddJoinOnlineGameCompleteDelegate(System.IntPtr JoinOnlineGameCompleteDelegate);

    /// <summary>
    /// Function: OnJoinOnlineGameComplete
    /// </summary>
    public unsafe void OnJoinOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful);

    /// <summary>
    /// Function: JoinOnlineGame
    /// </summary>
    public unsafe bool JoinOnlineGame(byte PlayerNum, BmSDK.FName SessionName, BmSDK.Engine.OnlineGameSearch.FOnlineGameSearchResult DesiredGame);

    /// <summary>
    /// Function: FreeSearchResults
    /// </summary>
    public unsafe bool FreeSearchResults(BmSDK.Engine.OnlineGameSearch Search = default);

    /// <summary>
    /// Function: GetGameSearch
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSearch GetGameSearch();

    /// <summary>
    /// Function: OnQosStatusChanged
    /// </summary>
    public unsafe void OnQosStatusChanged(int NumComplete, int NumTotal);

    /// <summary>
    /// Function: OnCancelFindOnlineGamesComplete
    /// </summary>
    public unsafe void OnCancelFindOnlineGamesComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: AddFindOnlineGamesCompleteDelegate
    /// </summary>
    public unsafe void AddFindOnlineGamesCompleteDelegate(System.IntPtr FindOnlineGamesCompleteDelegate);

    /// <summary>
    /// Function: OnFindOnlineGamesComplete
    /// </summary>
    public unsafe void OnFindOnlineGamesComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: FindOnlineGames
    /// </summary>
    public unsafe bool FindOnlineGames(byte SearchingPlayerNum, BmSDK.Engine.OnlineGameSearch SearchSettings);

    /// <summary>
    /// Function: ClearDestroyOnlineGameCompleteDelegate
    /// </summary>
    public unsafe void ClearDestroyOnlineGameCompleteDelegate(System.IntPtr DestroyOnlineGameCompleteDelegate);

    /// <summary>
    /// Function: AddDestroyOnlineGameCompleteDelegate
    /// </summary>
    public unsafe void AddDestroyOnlineGameCompleteDelegate(System.IntPtr DestroyOnlineGameCompleteDelegate);

    /// <summary>
    /// Function: OnDestroyOnlineGameComplete
    /// </summary>
    public unsafe void OnDestroyOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful);

    /// <summary>
    /// Function: DestroyOnlineGame
    /// </summary>
    public unsafe bool DestroyOnlineGame(BmSDK.FName SessionName);

    /// <summary>
    /// Function: GetGameSettings
    /// </summary>
    public unsafe BmSDK.Engine.OnlineGameSettings GetGameSettings(BmSDK.FName SessionName);

    /// <summary>
    /// Function: OnUpdateOnlineGameComplete
    /// </summary>
    public unsafe void OnUpdateOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful);

    /// <summary>
    /// Function: ClearCreateOnlineGameCompleteDelegate
    /// </summary>
    public unsafe void ClearCreateOnlineGameCompleteDelegate(System.IntPtr CreateOnlineGameCompleteDelegate);

    /// <summary>
    /// Function: AddCreateOnlineGameCompleteDelegate
    /// </summary>
    public unsafe void AddCreateOnlineGameCompleteDelegate(System.IntPtr CreateOnlineGameCompleteDelegate);

    /// <summary>
    /// Function: OnCreateOnlineGameComplete
    /// </summary>
    public unsafe void OnCreateOnlineGameComplete(BmSDK.FName SessionName, bool bWasSuccessful);

    /// <summary>
    /// Function: CreateOnlineGame
    /// </summary>
    public unsafe bool CreateOnlineGame(byte HostingPlayerNum, BmSDK.FName SessionName, BmSDK.Engine.OnlineGameSettings NewGameSettings);
}
