using BmSDK.Framework;

namespace BmSDK;

public partial class Class
{
    [Flags]
    public enum EClassFlags
    {
        CLASS_Interface = 0x4000,
    }

    public bool IsInterface => ClassFlags.HasFlag(EClassFlags.CLASS_Interface);

    /// <summary>
    /// Property: FunctionFlags
    /// </summary>
    public unsafe EClassFlags ClassFlags
    {
        get => MarshalUtil.ToManaged<EClassFlags>(Ptr + 180);
        set => MarshalUtil.ToUnmanaged(value, (Ptr + 180).ToPointer());
    }

    /// <summary>
    /// Gets the default object for this class.
    /// </summary>
    public new unsafe GameObject DefaultObject
    {
        get
        {
            var ptr = GameFunctions.GetDefaultObject(Ptr, 0);
            return MarshalUtil.ToManaged<GameObject>(&ptr);
        }
    }

    /// <summary>
    /// Returns the matching Type object for this class.
    /// </summary>
    public Type GetManagedType() => MarshalUtil.GetManagedTypeForClassPtr(Ptr);

    /// <summary>
    /// Returns the matching Class object for the given type.
    /// </summary>
    public static Class FindByManagedType(Type type)
    {
        return StaticFindObjectChecked<Class>(
            null,
            null,
            StaticInit.GetClassPathForManagedType(type),
            false
        );
    }
}
