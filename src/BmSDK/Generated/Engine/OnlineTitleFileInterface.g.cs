#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineTitleFileInterface<br/>
/// (size = 56)
/// (flags = 16403)
/// </summary>
public partial interface OnlineTitleFileInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetTitleFileContents
    /// </summary>
    public unsafe bool GetTitleFileContents(BmSDK.FString Filename, ref BmSDK.TArray<byte> FileContents);

    /// <summary>
    /// Function: AddReadTitleFileCompleteDelegate
    /// </summary>
    public unsafe void AddReadTitleFileCompleteDelegate(System.IntPtr ReadTitleFileCompleteDelegate);

    /// <summary>
    /// Function: OnReadTitleFileComplete
    /// </summary>
    public unsafe void OnReadTitleFileComplete(bool bWasSuccessful, BmSDK.FString Filename);
}
