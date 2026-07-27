using BmSDK.Framework;

namespace BmSDK;

public partial class Property
{
    [Flags]
    public enum EPropertyFlags : ulong
    {
        CPF_Parm = 0x8,
        CPF_OptionalParm = 0x10,
        CPF_OutParm = 0x20,
        CPF_ReturnParm = 0x80,
        CPF_Net = 0x04000000,
        CPF_RepNotify = 0x100000000,
    }

    /// <summary>
    /// Property: ArrayDim
    /// </summary>
    public int ArrayDim
    {
        get => MarshalUtil.ToManaged<int>(Ptr + 48);
    }

    /// <summary>
    /// Property: PropertyFlags
    /// </summary>
    public unsafe EPropertyFlags PropertyFlags
    {
        get => MarshalUtil.ToManaged<EPropertyFlags>(Ptr + 52);
        set => MarshalUtil.ToUnmanaged(value, (Ptr + 52).ToPointer());
    }

    /// <summary>
    /// Property: ElementSize
    /// </summary>
    public ushort ElementSize
    {
        get => MarshalUtil.ToManaged<ushort>(Ptr + 52 + 4 + 4);
    }

    /// <summary>
    /// Property: Offset
    /// </summary>
    public ushort Offset
    {
        get => MarshalUtil.ToManaged<ushort>(Ptr + 52 + 4 + 4 + 2);
    }
}
