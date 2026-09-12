#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlinePlayerInterfaceEx<br/>
/// (size = 80)
/// (flags = 16403)
/// </summary>
public partial interface OnlinePlayerInterfaceEx : BmSDK.Interface
{
    /// <summary>
    /// Function: GetTimeSinceGuideLastClosed
    /// </summary>
    public unsafe float GetTimeSinceGuideLastClosed();

    /// <summary>
    /// Function: CreateInfocastSystem
    /// </summary>
    public unsafe void CreateInfocastSystem();

    /// <summary>
    /// Function: ClearNewInfocastDelegate
    /// </summary>
    public unsafe void ClearNewInfocastDelegate(System.IntPtr InfocastDelegate);

    /// <summary>
    /// Function: AddNewInfocastDelegate
    /// </summary>
    public unsafe void AddNewInfocastDelegate(System.IntPtr InfocastDelegate);

    /// <summary>
    /// Function: OnNewInfocast
    /// </summary>
    public unsafe void OnNewInfocast(BmSDK.FString Infocast);

    /// <summary>
    /// Function: ShowGuideUI
    /// </summary>
    public unsafe bool ShowGuideUI();

    /// <summary>
    /// Function: ClearProfileDataChangedDelegate
    /// </summary>
    public unsafe void ClearProfileDataChangedDelegate(byte LocalUserNum, System.IntPtr ProfileDataChangedDelegate);

    /// <summary>
    /// Function: AddProfileDataChangedDelegate
    /// </summary>
    public unsafe void AddProfileDataChangedDelegate(byte LocalUserNum, System.IntPtr ProfileDataChangedDelegate);

    /// <summary>
    /// Function: OnProfileDataChanged
    /// </summary>
    public unsafe void OnProfileDataChanged();

    /// <summary>
    /// Function: IsDeviceValid
    /// </summary>
    public unsafe bool IsDeviceValid(int DeviceID, int SizeNeeded = default);

    /// <summary>
    /// Function: GetDeviceSelectionResults
    /// </summary>
    public unsafe int GetDeviceSelectionResults(byte LocalUserNum, ref BmSDK.FString DeviceName);

    /// <summary>
    /// Function: ClearDeviceSelectionDoneDelegate
    /// </summary>
    public unsafe void ClearDeviceSelectionDoneDelegate(byte LocalUserNum, System.IntPtr DeviceDelegate);

    /// <summary>
    /// Function: AddDeviceSelectionDoneDelegate
    /// </summary>
    public unsafe void AddDeviceSelectionDoneDelegate(byte LocalUserNum, System.IntPtr DeviceDelegate);

    /// <summary>
    /// Function: OnDeviceSelectionComplete
    /// </summary>
    public unsafe void OnDeviceSelectionComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ShowDeviceSelectionUI
    /// </summary>
    public unsafe bool ShowDeviceSelectionUI(byte LocalUserNum, int SizeNeeded, bool bForceShowUI = default, bool bManageStorage = default);

    /// <summary>
    /// Function: ShowContentMarketplaceUI
    /// </summary>
    public unsafe bool ShowContentMarketplaceUI(byte LocalUserNum, int CategoryMask = default, int OfferId = default);

    /// <summary>
    /// Function: ShowGamerCardUI
    /// </summary>
    public unsafe bool ShowGamerCardUI(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.FUniqueNetId PlayerID);
}
