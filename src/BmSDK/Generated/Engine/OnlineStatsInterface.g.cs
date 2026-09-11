#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineStatsInterface<br/>
/// (size = 80)
/// (flags = 16403)
/// </summary>
public partial interface OnlineStatsInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: RegisterStatGuid
    /// </summary>
    public unsafe bool RegisterStatGuid(BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID, BmSDK.FString ClientStatGuid);

    /// <summary>
    /// Function: GetClientStatGuid
    /// </summary>
    public unsafe BmSDK.FString GetClientStatGuid();

    /// <summary>
    /// Function: ClearRegisterHostStatGuidCompleteDelegateDelegate
    /// </summary>
    public unsafe void ClearRegisterHostStatGuidCompleteDelegateDelegate(System.IntPtr RegisterHostStatGuidCompleteDelegate);

    /// <summary>
    /// Function: AddRegisterHostStatGuidCompleteDelegate
    /// </summary>
    public unsafe void AddRegisterHostStatGuidCompleteDelegate(System.IntPtr RegisterHostStatGuidCompleteDelegate);

    /// <summary>
    /// Function: OnRegisterHostStatGuidComplete
    /// </summary>
    public unsafe void OnRegisterHostStatGuidComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: RegisterHostStatGuid
    /// </summary>
    public unsafe bool RegisterHostStatGuid(BmSDK.FString HostStatGuid);

    /// <summary>
    /// Function: GetHostStatGuid
    /// </summary>
    public unsafe BmSDK.FString GetHostStatGuid();

    /// <summary>
    /// Function: WriteOnlinePlayerScores
    /// </summary>
    public unsafe bool WriteOnlinePlayerScores(BmSDK.FName SessionName, int LeaderboardId, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlinePlayerScore> PlayerScores);

    /// <summary>
    /// Function: OnFlushOnlineStatsComplete
    /// </summary>
    public unsafe void OnFlushOnlineStatsComplete(BmSDK.FName SessionName, bool bWasSuccessful);

    /// <summary>
    /// Function: FlushOnlineStats
    /// </summary>
    public unsafe bool FlushOnlineStats(BmSDK.FName SessionName);

    /// <summary>
    /// Function: WriteOnlineStats
    /// </summary>
    public unsafe bool WriteOnlineStats(BmSDK.FName SessionName, BmSDK.Engine.OnlineSubsystem.FUniqueNetId Player, BmSDK.Engine.OnlineStatsWrite StatsWrite);

    /// <summary>
    /// Function: FreeStats
    /// </summary>
    public unsafe void FreeStats(BmSDK.Engine.OnlineStatsRead StatsRead);

    /// <summary>
    /// Function: ClearReadOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe void ClearReadOnlineStatsCompleteDelegate(System.IntPtr ReadOnlineStatsCompleteDelegate);

    /// <summary>
    /// Function: AddReadOnlineStatsCompleteDelegate
    /// </summary>
    public unsafe void AddReadOnlineStatsCompleteDelegate(System.IntPtr ReadOnlineStatsCompleteDelegate);

    /// <summary>
    /// Function: OnReadOnlineStatsComplete
    /// </summary>
    public unsafe void OnReadOnlineStatsComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ReadOnlineStatsByRankAroundPlayer
    /// </summary>
    public unsafe bool ReadOnlineStatsByRankAroundPlayer(byte LocalUserNum, BmSDK.Engine.OnlineStatsRead StatsRead, int NumRows = default);

    /// <summary>
    /// Function: ReadOnlineStatsByRank
    /// </summary>
    public unsafe bool ReadOnlineStatsByRank(BmSDK.Engine.OnlineStatsRead StatsRead, int StartIndex = default, int NumToRead = default);

    /// <summary>
    /// Function: ReadOnlineStatsForFriends
    /// </summary>
    public unsafe bool ReadOnlineStatsForFriends(byte LocalUserNum, BmSDK.Engine.OnlineStatsRead StatsRead);

    /// <summary>
    /// Function: ReadOnlineStats
    /// </summary>
    public unsafe bool ReadOnlineStats(BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.Engine.OnlineStatsRead StatsRead);

    /// <summary>
    /// Function: ResetOnlineStatsForAllUsers
    /// </summary>
    public unsafe bool ResetOnlineStatsForAllUsers(int BoardID);

    /// <summary>
    /// Function: ResetOnlineStatsForUser
    /// </summary>
    public unsafe bool ResetOnlineStatsForUser(byte LocalUserNum, int BoardID);
}
