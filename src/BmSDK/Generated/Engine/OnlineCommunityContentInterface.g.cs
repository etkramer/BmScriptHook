#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineCommunityContentInterface<br/>
/// (size = 104)
/// (flags = 16403)
/// </summary>
public partial interface OnlineCommunityContentInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: RateContent
    /// </summary>
    public unsafe void RateContent(byte PlayerNum, BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileToRate, int NewRating);

    /// <summary>
    /// Function: ClearGetContentPayloadCompleteDelegate
    /// </summary>
    public unsafe void ClearGetContentPayloadCompleteDelegate(System.IntPtr GetContentPayloadCompleteDelegate);

    /// <summary>
    /// Function: AddGetContentPayloadCompleteDelegate
    /// </summary>
    public unsafe void AddGetContentPayloadCompleteDelegate(System.IntPtr GetContentPayloadCompleteDelegate);

    /// <summary>
    /// Function: OnGetContentPayloadComplete
    /// </summary>
    public unsafe void OnGetContentPayloadComplete(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileDownloaded, BmSDK.TArray<byte> Payload);

    /// <summary>
    /// Function: GetContentPayload
    /// </summary>
    public unsafe bool GetContentPayload(byte PlayerNum, BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileDownloaded);

    /// <summary>
    /// Function: ClearDownloadContentCompleteDelegate
    /// </summary>
    public unsafe void ClearDownloadContentCompleteDelegate(System.IntPtr DownloadContentCompleteDelegate);

    /// <summary>
    /// Function: AddDownloadContentCompleteDelegate
    /// </summary>
    public unsafe void AddDownloadContentCompleteDelegate(System.IntPtr DownloadContentCompleteDelegate);

    /// <summary>
    /// Function: OnDownloadContentComplete
    /// </summary>
    public unsafe void OnDownloadContentComplete(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileDownloaded);

    /// <summary>
    /// Function: DownloadContent
    /// </summary>
    public unsafe bool DownloadContent(byte PlayerNum, BmSDK.Engine.OnlineSubsystem.FCommunityContentFile FileToDownload);

    /// <summary>
    /// Function: ClearUploadContentCompleteDelegate
    /// </summary>
    public unsafe void ClearUploadContentCompleteDelegate(System.IntPtr UploadContentCompleteDelegate);

    /// <summary>
    /// Function: AddUploadContentCompleteDelegate
    /// </summary>
    public unsafe void AddUploadContentCompleteDelegate(System.IntPtr UploadContentCompleteDelegate);

    /// <summary>
    /// Function: OnUploadContentComplete
    /// </summary>
    public unsafe void OnUploadContentComplete(bool bWasSuccessful, BmSDK.Engine.OnlineSubsystem.FCommunityContentFile UploadedFile);

    /// <summary>
    /// Function: UploadContent
    /// </summary>
    public unsafe bool UploadContent(byte PlayerNum, BmSDK.TArray<byte> Payload, BmSDK.Engine.OnlineSubsystem.FCommunityContentMetadata MetaData);

    /// <summary>
    /// Function: GetFriendsContentList
    /// </summary>
    public unsafe bool GetFriendsContentList(byte PlayerNum, BmSDK.Engine.OnlineSubsystem.FOnlineFriend Friend, ref BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile> ContentFiles);

    /// <summary>
    /// Function: ClearReadFriendsContentListCompleteDelegate
    /// </summary>
    public unsafe void ClearReadFriendsContentListCompleteDelegate(System.IntPtr ReadFriendsContentListCompleteDelegate);

    /// <summary>
    /// Function: AddReadFriendsContentListCompleteDelegate
    /// </summary>
    public unsafe void AddReadFriendsContentListCompleteDelegate(System.IntPtr ReadFriendsContentListCompleteDelegate);

    /// <summary>
    /// Function: OnReadFriendsContentListComplete
    /// </summary>
    public unsafe void OnReadFriendsContentListComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ReadFriendsContentList
    /// </summary>
    public unsafe bool ReadFriendsContentList(byte PlayerNum, BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FOnlineFriend> Friends, int StartAt = default, int NumToRead = default);

    /// <summary>
    /// Function: GetContentList
    /// </summary>
    public unsafe bool GetContentList(byte PlayerNum, ref BmSDK.TArray<BmSDK.Engine.OnlineSubsystem.FCommunityContentFile> ContentFiles);

    /// <summary>
    /// Function: ClearReadContentListCompleteDelegate
    /// </summary>
    public unsafe void ClearReadContentListCompleteDelegate(System.IntPtr ReadContentListCompleteDelegate);

    /// <summary>
    /// Function: AddReadContentListCompleteDelegate
    /// </summary>
    public unsafe void AddReadContentListCompleteDelegate(System.IntPtr ReadContentListCompleteDelegate);

    /// <summary>
    /// Function: OnReadContentListComplete
    /// </summary>
    public unsafe void OnReadContentListComplete(bool bWasSuccessful);

    /// <summary>
    /// Function: ReadContentList
    /// </summary>
    public unsafe bool ReadContentList(byte PlayerNum, int StartAt = default, int NumToRead = default);

    /// <summary>
    /// Function: Exit
    /// </summary>
    public unsafe void Exit();

    /// <summary>
    /// Function: Init
    /// </summary>
    public unsafe bool Init();
}
