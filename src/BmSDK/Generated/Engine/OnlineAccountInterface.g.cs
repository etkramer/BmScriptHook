#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: OnlineAccountInterface<br/>
/// (size = 56)
/// (flags = 16403)
/// </summary>
public partial interface OnlineAccountInterface : BmSDK.Interface
{
    /// <summary>
    /// Function: GetLocalAccountNames
    /// </summary>
    public unsafe bool GetLocalAccountNames(ref BmSDK.TArray<BmSDK.FString> Accounts);

    /// <summary>
    /// Function: DeleteLocalAccount
    /// </summary>
    public unsafe bool DeleteLocalAccount(BmSDK.FString UserName, BmSDK.FString Password = default);

    /// <summary>
    /// Function: RenameLocalAccount
    /// </summary>
    public unsafe bool RenameLocalAccount(BmSDK.FString NewUserName, BmSDK.FString OldUserName, BmSDK.FString Password = default);

    /// <summary>
    /// Function: CreateLocalAccount
    /// </summary>
    public unsafe bool CreateLocalAccount(BmSDK.FString UserName, BmSDK.FString Password = default);

    /// <summary>
    /// Function: ClearCreateOnlineAccountCompletedDelegate
    /// </summary>
    public unsafe void ClearCreateOnlineAccountCompletedDelegate(System.IntPtr AccountCreateDelegate);

    /// <summary>
    /// Function: AddCreateOnlineAccountCompletedDelegate
    /// </summary>
    public unsafe void AddCreateOnlineAccountCompletedDelegate(System.IntPtr AccountCreateDelegate);

    /// <summary>
    /// Function: OnCreateOnlineAccountCompleted
    /// </summary>
    public unsafe void OnCreateOnlineAccountCompleted(BmSDK.Engine.OnlineSubsystem.EOnlineAccountCreateStatus ErrorStatus);

    /// <summary>
    /// Function: CreateOnlineAccount
    /// </summary>
    public unsafe bool CreateOnlineAccount(BmSDK.FString UserName, BmSDK.FString Password, BmSDK.FString EmailAddress, BmSDK.FString ProductKey = default);
}
