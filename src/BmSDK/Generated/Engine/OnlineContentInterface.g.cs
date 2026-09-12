#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineContentInterface<br/>
/// (size = 104)
/// (flags = 16403)
/// </summary>
public partial interface OnlineContentInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: OnWriteSaveGameDataComplete
    /// </summary>
    public unsafe void OnWriteSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName);

    /// <summary>
    /// Function: OnReadSaveGameDataComplete
    /// </summary>
    public unsafe void OnReadSaveGameDataComplete(bool bWasSuccessful, byte LocalUserNum, int DeviceID, BmSDK.FString FriendlyName, BmSDK.FString Filename, BmSDK.FString SaveFileName);

    /// <summary>
    /// Function: GetAvailableDownloadCounts
    /// </summary>
    public unsafe void GetAvailableDownloadCounts(byte LocalUserNum, ref int NewDownloads, ref int TotalDownloads);

    /// <summary>
    /// Function: OnQueryAvailableDownloadsComplete
    /// </summary>
    public unsafe void OnQueryAvailableDownloadsComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: GetContentList
    /// </summary>
    public unsafe BmSDK.Engine.OnlineSubsystem.EOnlineEnumerationReadState GetContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, ref BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineContent> ContentList);

    /// <summary>
    /// Function: ClearContentList
    /// </summary>
    public unsafe void ClearContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType);

    /// <summary>
    /// Function: ReadContentList
    /// </summary>
    public unsafe bool ReadContentList(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, int DeviceID = default);

    /// <summary>
    /// Function: ClearReadContentComplete
    /// </summary>
    public unsafe void ClearReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate);

    /// <summary>
    /// Function: AddReadContentComplete
    /// </summary>
    public unsafe void AddReadContentComplete(byte LocalUserNum, BmSDK.Engine.OnlineSubsystem.EOnlineContentType ContentType, System.IntPtr ReadContentCompleteDelegate);

    /// <summary>
    /// Function: OnReadContentComplete
    /// </summary>
    public unsafe void OnReadContentComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ClearContentChangeDelegate
    /// </summary>
    public unsafe void ClearContentChangeDelegate(System.IntPtr ContentDelegate, byte LocalUserNum = default);

    /// <summary>
    /// Function: AddContentChangeDelegate
    /// </summary>
    public unsafe void AddContentChangeDelegate(System.IntPtr ContentDelegate, byte LocalUserNum = default);

    /// <summary>
    /// Function: OnContentChange
    /// </summary>
    public unsafe void OnContentChange();
}
