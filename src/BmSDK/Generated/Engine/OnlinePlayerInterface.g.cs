#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlinePlayerInterface<br/>
/// (size = 296)
/// (flags = 16403)
/// </summary>
public partial interface OnlinePlayerInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetAchievements
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetAchievements(byte LocalUserNum, ref BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FAchievementDetails> Achievements, int TitleId = default);

    /// <summary>
    /// Function: ClearReadAchievementsCompleteDelegate
    /// </summary>
    public unsafe void ClearReadAchievementsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadAchievementsCompleteDelegate);

    /// <summary>
    /// Function: AddReadAchievementsCompleteDelegate
    /// </summary>
    public unsafe void AddReadAchievementsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadAchievementsCompleteDelegate);

    /// <summary>
    /// Function: OnReadAchievementsComplete
    /// </summary>
    public unsafe void OnReadAchievementsComplete(int TitleId);

    /// <summary>
    /// Function: ReadAchievements
    /// </summary>
    public unsafe bool ReadAchievements(byte LocalUserNum, int TitleId = default, bool bShouldReadText = default, bool bShouldReadImages = default);

    /// <summary>
    /// Function: ClearUnlockAchievementCompleteDelegate
    /// </summary>
    public unsafe void ClearUnlockAchievementCompleteDelegate(byte LocalUserNum, System.IntPtr UnlockAchievementCompleteDelegate);

    /// <summary>
    /// Function: AddUnlockAchievementCompleteDelegate
    /// </summary>
    public unsafe void AddUnlockAchievementCompleteDelegate(byte LocalUserNum, System.IntPtr UnlockAchievementCompleteDelegate);

    /// <summary>
    /// Function: OnUnlockAchievementComplete
    /// </summary>
    public unsafe void OnUnlockAchievementComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: UnlockAchievement
    /// </summary>
    public unsafe bool UnlockAchievement(byte LocalUserNum, int AchievementId);

    /// <summary>
    /// Function: OnFriendMessageReceived
    /// </summary>
    public unsafe void OnFriendMessageReceived(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId SendingPlayer, BmSDK.FString SendingNick, BmSDK.FString Message);

    /// <summary>
    /// Function: OnJoinFriendGameComplete
    /// </summary>
    public unsafe void OnJoinFriendGameComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: OnReceivedGameInvite
    /// </summary>
    public unsafe void OnReceivedGameInvite(byte LocalUserNum, BmSDK.FString InviterName);

    /// <summary>
    /// Function: OnFriendInviteReceived
    /// </summary>
    public unsafe void OnFriendInviteReceived(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId RequestingPlayer, BmSDK.FString RequestingNick, BmSDK.FString Message);

    /// <summary>
    /// Function: OnAddFriendByNameComplete
    /// </summary>
    public unsafe void OnAddFriendByNameComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: GetKeyboardInputResults
    /// </summary>
    public unsafe BmSDK.FString GetKeyboardInputResults(ref byte bWasCanceled);

    /// <summary>
    /// Function: ClearKeyboardInputDoneDelegate
    /// </summary>
    public unsafe void ClearKeyboardInputDoneDelegate(System.IntPtr InputDelegate);

    /// <summary>
    /// Function: AddKeyboardInputDoneDelegate
    /// </summary>
    public unsafe void AddKeyboardInputDoneDelegate(System.IntPtr InputDelegate);

    /// <summary>
    /// Function: OnKeyboardInputComplete
    /// </summary>
    public unsafe void OnKeyboardInputComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ShowKeyboardUI
    /// </summary>
    public unsafe bool ShowKeyboardUI(byte LocalUserNum, BmSDK.FString TitleText, BmSDK.FString DescriptionText, bool bIsPassword = default, bool bShouldValidate = default, BmSDK.FString DefaultText = default, int MaxResultLength = default);

    /// <summary>
    /// Function: SetOnlineStatus
    /// </summary>
    public unsafe void SetOnlineStatus(byte LocalUserNum, int StatusId, BmSDK.TArray<BmSDK.Engine.Settings.FLocalizedStringSetting> LocalizedStringSettings, BmSDK.TArray<BmSDK.Engine.Settings.FSettingsProperty> Properties);

    /// <summary>
    /// Function: GetFriendsList
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetFriendsList(byte LocalUserNum, ref BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend> Friends, int Count = default, int StartingAt = default);

    /// <summary>
    /// Function: ClearReadFriendsCompleteDelegate
    /// </summary>
    public unsafe void ClearReadFriendsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadFriendsCompleteDelegate);

    /// <summary>
    /// Function: AddReadFriendsCompleteDelegate
    /// </summary>
    public unsafe void AddReadFriendsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadFriendsCompleteDelegate);

    /// <summary>
    /// Function: OnReadFriendsComplete
    /// </summary>
    public unsafe void OnReadFriendsComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ReadFriendsList
    /// </summary>
    public unsafe bool ReadFriendsList(byte LocalUserNum, int Count = default, int StartingAt = default);

    /// <summary>
    /// Function: OnWritePlayerStorageComplete
    /// </summary>
    public unsafe void OnWritePlayerStorageComplete(byte LocalUserNum, bool bWasSuccessful);

    /// <summary>
    /// Function: GetPlayerStorage
    /// </summary>
    public unsafe BmSDK.Engine.OnlinePlayerStorage GetPlayerStorage(byte LocalUserNum);

    /// <summary>
    /// Function: OnReadPlayerStorageForNetIdComplete
    /// </summary>
    public unsafe void OnReadPlayerStorageForNetIdComplete(BmSDK.Engine.OnlineSubsystem.FUniqueNetId NetId, bool bWasSuccessful);

    /// <summary>
    /// Function: ClearReadPlayerStorageCompleteDelegate
    /// </summary>
    public unsafe void ClearReadPlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr ReadPlayerStorageCompleteDelegate);

    /// <summary>
    /// Function: AddReadPlayerStorageCompleteDelegate
    /// </summary>
    public unsafe void AddReadPlayerStorageCompleteDelegate(byte LocalUserNum, System.IntPtr ReadPlayerStorageCompleteDelegate);

    /// <summary>
    /// Function: OnReadPlayerStorageComplete
    /// </summary>
    public unsafe void OnReadPlayerStorageComplete(byte LocalUserNum, bool bWasSuccessful);

    /// <summary>
    /// Function: ReadPlayerStorage
    /// </summary>
    public unsafe bool ReadPlayerStorage(byte LocalUserNum, BmSDK.Engine.OnlinePlayerStorage PlayerStorage, int DeviceID = default);

    /// <summary>
    /// Function: OnWriteProfileSettingsComplete
    /// </summary>
    public unsafe void OnWriteProfileSettingsComplete(byte LocalUserNum, bool bWasSuccessful);

    /// <summary>
    /// Function: GetProfileSettings
    /// </summary>
    public unsafe BmSDK.Engine.OnlineProfileSettings GetProfileSettings(byte LocalUserNum);

    /// <summary>
    /// Function: ClearReadProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe void ClearReadProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate);

    /// <summary>
    /// Function: AddReadProfileSettingsCompleteDelegate
    /// </summary>
    public unsafe void AddReadProfileSettingsCompleteDelegate(byte LocalUserNum, System.IntPtr ReadProfileSettingsCompleteDelegate);

    /// <summary>
    /// Function: OnReadProfileSettingsComplete
    /// </summary>
    public unsafe void OnReadProfileSettingsComplete(byte LocalUserNum, bool bWasSuccessful);

    /// <summary>
    /// Function: ReadProfileSettings
    /// </summary>
    public unsafe bool ReadProfileSettings(byte LocalUserNum, BmSDK.Engine.OnlineProfileSettings ProfileSettings);

    /// <summary>
    /// Function: ClearFriendsChangeDelegate
    /// </summary>
    public unsafe void ClearFriendsChangeDelegate(byte LocalUserNum, System.IntPtr FriendsDelegate);

    /// <summary>
    /// Function: AddFriendsChangeDelegate
    /// </summary>
    public unsafe void AddFriendsChangeDelegate(byte LocalUserNum, System.IntPtr FriendsDelegate);

    /// <summary>
    /// Function: AddMutingChangeDelegate
    /// </summary>
    public unsafe void AddMutingChangeDelegate(System.IntPtr MutingDelegate);

    /// <summary>
    /// Function: ClearLoginCancelledDelegate
    /// </summary>
    public unsafe void ClearLoginCancelledDelegate(System.IntPtr CancelledDelegate);

    /// <summary>
    /// Function: AddLoginCancelledDelegate
    /// </summary>
    public unsafe void AddLoginCancelledDelegate(System.IntPtr CancelledDelegate);

    /// <summary>
    /// Function: OnLoginStatusChange
    /// </summary>
    public unsafe void OnLoginStatusChange(BmSDK.Engine.OnlineSubsystem.ELoginStatus NewStatus, BmSDK.Engine.OnlineSubsystem.FUniqueNetId NewId);

    /// <summary>
    /// Function: ClearLoginChangeDelegate
    /// </summary>
    public unsafe void ClearLoginChangeDelegate(System.IntPtr LoginDelegate);

    /// <summary>
    /// Function: AddLoginChangeDelegate
    /// </summary>
    public unsafe void AddLoginChangeDelegate(System.IntPtr LoginDelegate);

    /// <summary>
    /// Function: IsFriend
    /// </summary>
    public unsafe bool IsFriend(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);

    /// <summary>
    /// Function: CanShowPresenceInformation
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanShowPresenceInformation(byte LocalUserNum);

    /// <summary>
    /// Function: CanViewPlayerProfiles
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanViewPlayerProfiles(byte LocalUserNum);

    /// <summary>
    /// Function: CanPurchaseContent
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanPurchaseContent(byte LocalUserNum);

    /// <summary>
    /// Function: CanDownloadUserContent
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanDownloadUserContent(byte LocalUserNum);

    /// <summary>
    /// Function: CanPlayOnline
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EFeaturePrivilegeLevel CanPlayOnline(byte LocalUserNum);

    /// <summary>
    /// Function: IsOnlineAccount
    /// </summary>
    public unsafe bool IsOnlineAccount(byte LocalUserNum);

    /// <summary>
    /// Function: IsGuestLogin
    /// </summary>
    public unsafe bool IsGuestLogin(byte LocalUserNum);

    /// <summary>
    /// Function: GetPlayerNickname
    /// </summary>
    public unsafe BmSDK.FString GetPlayerNickname(byte LocalUserNum);

    /// <summary>
    /// Function: GetUniquePlayerId
    /// </summary>
    public unsafe bool GetUniquePlayerId(byte LocalUserNum, ref BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);

    /// <summary>
    /// Function: GetLoginStatus
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.ELoginStatus GetLoginStatus(byte LocalUserNum);

    /// <summary>
    /// Function: OnLogoutCompleted
    /// </summary>
    public unsafe void OnLogoutCompleted(bool bWasSuccessful);

    /// <summary>
    /// Function: ClearLoginFailedDelegate
    /// </summary>
    public unsafe void ClearLoginFailedDelegate(byte LocalUserNum, System.IntPtr LoginDelegate);

    /// <summary>
    /// Function: OnLoginFailed
    /// </summary>
    public unsafe void OnLoginFailed(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineServerConnectionStatus ErrorCode);

    /// <summary>
    /// Function: ShowLoginUI
    /// </summary>
    public unsafe bool ShowLoginUI(bool bShowOnlineOnly = default);

    /// <summary>
    /// Function: OnFriendsChange
    /// </summary>
    public unsafe void OnFriendsChange();

    /// <summary>
    /// Function: OnMutingChange
    /// </summary>
    public unsafe void OnMutingChange();

    /// <summary>
    /// Function: OnLoginCancelled
    /// </summary>
    public unsafe void OnLoginCancelled();

    /// <summary>
    /// Function: OnLoginChange
    /// </summary>
    public unsafe void OnLoginChange(byte LocalUserNum);
}
