#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// Interface: UIDataStoreSubscriber<br/>
/// (size = 44)
/// (flags = 134234259)
/// </summary>
public partial interface UIDataStoreSubscriber : BmSDK.Interface
{
    /// <summary>
    /// Function: ClearBoundDataStores
    /// </summary>
    public unsafe void ClearBoundDataStores();

    /// <summary>
    /// Function: GetBoundDataStores
    /// </summary>
    public unsafe void GetBoundDataStores(ref BmSDK.TArray<BmSDK.Engine.UIDataStore> out_BoundDataStores);

    /// <summary>
    /// Function: NotifyDataStoreValueUpdated
    /// </summary>
    public unsafe void NotifyDataStoreValueUpdated(BmSDK.Engine.UIDataStore SourceDataStore, bool bValuesInvalidated, BmSDK.FName PropertyTag, BmSDK.Engine.UIDataProvider SourceProvider, int ArrayIndex);

    /// <summary>
    /// Function: RefreshSubscriberValue
    /// </summary>
    public unsafe bool RefreshSubscriberValue(int BindingIndex = default);

    /// <summary>
    /// Function: GetDataStoreBinding
    /// </summary>
    public unsafe BmSDK.FString GetDataStoreBinding(int BindingIndex = default);

    /// <summary>
    /// Function: SetDataStoreBinding
    /// </summary>
    public unsafe void SetDataStoreBinding(BmSDK.FString MarkupText, int BindingIndex = default);
}
