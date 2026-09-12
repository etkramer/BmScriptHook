#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineSuppliedUIInterface<br/>
/// (size = 56)
/// (flags = 16403)
/// </summary>
public partial interface OnlineSuppliedUIInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: ShowMatchmakingUI
    /// </summary>
    public unsafe bool ShowMatchmakingUI(byte SearchingPlayerNum, BmSDK.Engine.OnlineGameSearch SearchSettings, BmSDK.Engine.OnlineGameSettings GameSettings);

    /// <summary>
    /// Function: ClearShowOnlineStatsUICompleteDelegate
    /// </summary>
    public unsafe void ClearShowOnlineStatsUICompleteDelegate(System.IntPtr ShowOnlineStatsUICompleteDelegate);

    /// <summary>
    /// Function: AddShowOnlineStatsUICompleteDelegate
    /// </summary>
    public unsafe void AddShowOnlineStatsUICompleteDelegate(System.IntPtr ShowOnlineStatsUICompleteDelegate);

    /// <summary>
    /// Function: ShowOnlineStatsUI
    /// </summary>
    public unsafe bool ShowOnlineStatsUI(BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FUniqueNetId> Players, BmSDK.Engine.OnlineStatsRead StatsRead);

    /// <summary>
    /// Function: OnShowOnlineStatsUIComplete
    /// </summary>
    public unsafe void OnShowOnlineStatsUIComplete();
}
