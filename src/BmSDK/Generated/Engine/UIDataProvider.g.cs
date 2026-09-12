#pragma warning disable CS0108
#pragma warning disable CS1591

namespace BmSDK.Engine;

/// <summary>
/// ABSTRACT Class: UIDataProvider<br/>
/// (size = 76)
/// (flags = 134217883)
/// </summary>
public partial class UIDataProvider : BmSDK.Engine.UIRoot, BmSDK.IGameObject
{
    static BmSDK.Class s_staticClass = null;
    public static BmSDK.Class StaticClass()
    {
        if (s_staticClass is null)
        {
            s_staticClass = StaticFindObjectChecked<Class>(null, null, "Engine.UIDataProvider", false);
            s_staticClass.AddToRoot();
        }
        return s_staticClass;
    }

    /// <summary>
    /// Gets the class default object as UIDataProvider.
    /// </summary>
    public static UIDataProvider DefaultObject => (UIDataProvider)StaticClass().DefaultObject;

    internal UIDataProvider() { }

    /// <summary>
    /// Constructs a new wrapper instance from the given object pointer.
    /// </summary>
    protected UIDataProvider(nint ptr) : base(ptr) { }

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Framework.IScriptComponent)"/>
    public void AttachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDataProvider>
        => ((GameObject)this).AttachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.AttachScriptComponent(Type)"/>
    public TComponent AttachScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider>, new()
        => (TComponent)((GameObject)this).AttachScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.HasScriptComponent(Framework.IScriptComponent)"/>
    public bool HasScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDataProvider>
        => ((GameObject)this).HasScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.HasScriptComponent(Type)"/>
    public bool HasScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider>
        => ((GameObject)this).HasScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponent(Type)"/>
    public TComponent GetScriptComponent<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider>
        => (TComponent)((GameObject)this).GetScriptComponent(typeof(TComponent));

    /// <inheritdoc cref="GameObject.GetScriptComponents(Type)"/>
    public System.Collections.Generic.IReadOnlyList<TComponent> GetScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider>
        => ((GameObject)this).GetScriptComponents(typeof(TComponent)).Cast<TComponent>().ToList();

    /// <inheritdoc cref="GameObject.DetachScriptComponent(Framework.IScriptComponent)"/>
    public void DetachScriptComponent<TComponent>(TComponent component)
        where TComponent : class, Framework.IScriptComponent<UIDataProvider>
        => ((GameObject)this).DetachScriptComponent((Framework.IScriptComponent)component);

    /// <inheritdoc cref="GameObject.DetachScriptComponents(Type)"/>
    public void DetachScriptComponents<TComponent>()
        where TComponent : class, Framework.IScriptComponent<UIDataProvider>
        => ((GameObject)this).DetachScriptComponents(typeof(TComponent));

    /// <summary>
    /// Function: RemovePropertyNotificationChangeRequest
    /// </summary>
    public unsafe virtual bool RemovePropertyNotificationChangeRequest(System.IntPtr InDelegate)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider.RemovePropertyNotificationChangeRequest", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDelegate, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: AddPropertyNotificationChangeRequest
    /// </summary>
    public unsafe virtual bool AddPropertyNotificationChangeRequest(System.IntPtr InDelegate, bool bAllowDuplicates = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider.AddPropertyNotificationChangeRequest", true);
        byte* paramsPtr = stackalloc byte[28];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(InDelegate, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(bAllowDuplicates, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: NotifyPropertyChanged
    /// </summary>
    public unsafe virtual void NotifyPropertyChanged(BmSDK.FName PropTag = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider.NotifyPropertyChanged", true);
        byte* paramsPtr = stackalloc byte[36];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropTag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// Function: GenerateFillerData
    /// </summary>
    public unsafe virtual BmSDK.FString GenerateFillerData(BmSDK.FString DataTag)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider.GenerateFillerData", true);
        byte* paramsPtr = stackalloc byte[24];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataTag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GenerateScriptMarkupString
    /// </summary>
    public unsafe virtual BmSDK.FString GenerateScriptMarkupString(BmSDK.FName DataTag)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider.GenerateScriptMarkupString", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataTag, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 8);
    }

    /// <summary>
    /// Function: SetFieldValue
    /// </summary>
    public unsafe virtual bool SetFieldValue(BmSDK.FString FieldName, BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue FieldValue, int ArrayIndex = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider.SetFieldValue", true);
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldValue, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayIndex, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 100);
    }

    /// <summary>
    /// Function: GetFieldValue
    /// </summary>
    public unsafe virtual bool GetFieldValue(BmSDK.FString FieldName, ref BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue FieldValue, int ArrayIndex = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider.GetFieldValue", true);
        byte* paramsPtr = stackalloc byte[104];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldValue, paramsPtr + 12);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayIndex, paramsPtr + 96);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        FieldValue = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIRoot.FUIProviderScriptFieldValue>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 100);
    }

    /// <summary>
    /// Function: AllowPublishingToField
    /// </summary>
    public unsafe virtual bool AllowPublishingToField(BmSDK.FString FieldName, int ArrayIndex = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider.AllowPublishingToField", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(FieldName, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(ArrayIndex, paramsPtr + 12);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: GetSupportedScriptFields
    /// </summary>
    public unsafe virtual void GetSupportedScriptFields(ref BmSDK.TArray<BmSDK.Engine.UIDataProvider.FUIDataProviderField> out_Fields)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider.GetSupportedScriptFields", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_Fields, paramsPtr + 0);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        out_Fields = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIDataProvider.FUIDataProviderField>>(paramsPtr + 0);
        return;
    }

    /// <summary>
    /// Function: ParseArrayDelimiter
    /// </summary>
    public unsafe virtual int ParseArrayDelimiter(ref BmSDK.FString DataTag)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider.ParseArrayDelimiter", true);
        byte* paramsPtr = stackalloc byte[16];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataTag, paramsPtr + 0);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        DataTag = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FString>(paramsPtr + 0);
        return BmSDK.Framework.MarshalUtil.ToManaged<int>(paramsPtr + 12);
    }

    /// <summary>
    /// Function: GetProviderFieldType
    /// </summary>
    public unsafe virtual bool GetProviderFieldType(BmSDK.FString DataTag, ref BmSDK.Engine.UIRoot.EUIDataProviderFieldType out_ProviderFieldType)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider.GetProviderFieldType", true);
        byte* paramsPtr = stackalloc byte[20];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(DataTag, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(out_ProviderFieldType, paramsPtr + 12);
        var oldFlags = funcManaged.FunctionFlags;
        var oldNative = funcManaged.iNative;
        funcManaged.FunctionFlags &= ~BmSDK.Function.EFunctionFlags.FUNC_Native;
        funcManaged.FunctionFlags |= BmSDK.Function.EFunctionFlags.FUNC_Defined;
        funcManaged.iNative = 0;
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        funcManaged.iNative = oldNative;
        funcManaged.FunctionFlags = oldFlags;
        out_ProviderFieldType = BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIRoot.EUIDataProviderFieldType>(paramsPtr + 12);
        return BmSDK.Framework.MarshalUtil.ToManaged<bool>(paramsPtr + 16);
    }

    /// <summary>
    /// Function: OnDataProviderPropertyChange
    /// </summary>
    public unsafe virtual void OnDataProviderPropertyChange(BmSDK.Engine.UIDataProvider SourceProvider, BmSDK.FName PropTag = default)
    {
        var funcManaged = BmSDK.GameObject.StaticFindObjectChecked<BmSDK.Function>(BmSDK.Function.StaticClass(), null, "Engine.UIDataProvider.OnDataProviderPropertyChange", true);
        byte* paramsPtr = stackalloc byte[12];
        BmSDK.Framework.MarshalUtil.ToUnmanaged(SourceProvider, paramsPtr + 0);
        BmSDK.Framework.MarshalUtil.ToUnmanaged(PropTag, paramsPtr + 4);
        BmSDK.Framework.GameFunctions.ProcessEvent(Ptr, funcManaged.Ptr, (nint)paramsPtr, 0);
        return;
    }

    /// <summary>
    /// ByteProperty: WriteAccessType
    /// </summary>
    public unsafe BmSDK.Engine.UIDataProvider.EProviderAccessType WriteAccessType
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIDataProvider.EProviderAccessType>(Ptr + 48); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 48); }
    }

    /// <summary>
    /// ArrayProperty: ProviderChangedNotifies
    /// </summary>
    public unsafe BmSDK.TArray<System.IntPtr> ProviderChangedNotifies
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<System.IntPtr>>(Ptr + 52); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 52); }
    }

    /// <summary>
    /// DelegateProperty: __OnDataProviderPropertyChange__Delegate
    /// </summary>
    public unsafe System.IntPtr __OnDataProviderPropertyChange__Delegate
    {
        get { return BmSDK.Framework.MarshalUtil.ToManaged<System.IntPtr>(Ptr + 64); }
        set { BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 64); }
    }

    /// <summary>
    /// Enum: EProviderAccessType
    /// </summary>
    public enum EProviderAccessType : byte
    {
        ACCESS_ReadOnly = 0,
        ACCESS_PerField = 1,
        ACCESS_WriteAll = 2,
        ACCESS_MAX = 3,
    }

    /// <summary>
    /// Struct: FUIDataProviderField
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial record struct FUIDataProviderField
    {
        /// <summary>
        /// NameProperty: FieldTag
        /// </summary>
        public unsafe BmSDK.FName FieldTag
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.FName>(Ptr + 0); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 0); }; }
        }

        /// <summary>
        /// ByteProperty: FieldType
        /// </summary>
        public unsafe BmSDK.Engine.UIRoot.EUIDataProviderFieldType FieldType
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.Engine.UIRoot.EUIDataProviderFieldType>(Ptr + 8); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 8); }; }
        }

        /// <summary>
        /// ArrayProperty: FieldProviders
        /// </summary>
        public unsafe BmSDK.TArray<BmSDK.Engine.UIDataProvider> FieldProviders
        {
            get { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; return BmSDK.Framework.MarshalUtil.ToManaged<BmSDK.TArray<BmSDK.Engine.UIDataProvider>>(Ptr + 12); }; }
            set { fixed (void* thisPtr = &this) { IntPtr Ptr = (IntPtr)thisPtr; BmSDK.Framework.MarshalUtil.ToUnmanaged(value, Ptr + 12); }; }
        }
    }
}
