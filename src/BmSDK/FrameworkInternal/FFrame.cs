using BmSDK.Framework;

namespace BmSDK;

[StructLayout(LayoutKind.Sequential)]
internal unsafe struct FOutParmRec
{
    public IntPtr Property;
    public IntPtr PropAddr;
    public FOutParmRec* NextOutParm;
}

[StructLayout(LayoutKind.Explicit)]
internal unsafe record struct FFrame
{
    [FieldOffset(0x8)]
    public IntPtr Node;

    [FieldOffset(0xC)]
    public IntPtr Object;

    [FieldOffset(0x10)]
    public IntPtr Code;

    [FieldOffset(0x14)]
    public IntPtr Locals;

    [FieldOffset(0x18)]
    public IntPtr PreviousFrame;

    [FieldOffset(0x1C)]
    public IntPtr OutParms;

    public readonly Function GetFunction()
    {
        var nodePtr = Node;
        return MarshalUtil.ToManaged<Function>(&nodePtr);
    }

    /// <summary>
    /// Returns the address backing the given param. Out params are stored in the caller's memory
    /// and reached through the OutParms chain, so only regular params live in Locals.
    /// </summary>
    private readonly IntPtr GetParamAddr(Property prop)
    {
        if (!prop.PropertyFlags.HasFlag(Property.EPropertyFlags.CPF_OutParm))
        {
            return Locals + prop.Offset;
        }

        for (var rec = (FOutParmRec*)OutParms.ToPointer(); rec != null; rec = rec->NextOutParm)
        {
            if (rec->Property == prop.Ptr)
            {
                return rec->PropAddr;
            }
        }

        throw new InvalidOperationException(
            $"No out param record for '{prop.Name}' in {GetFunction().GetPathName()}"
        );
    }

    private static Type Deref(Type type) =>
        type.IsByRef ? Guard.NotNull(type.GetElementType()) : type;

    public readonly object?[] ParamsToManaged(Type[] managedTypes)
    {
        var props = GetFunction().EnumerateParams().ToArray();
        var args = new object?[props.Length];

        for (var i = 0; i < props.Length; i++)
        {
            args[i] = MarshalUtil.ToManaged(GetParamAddr(props[i]), Deref(managedTypes[i]));
        }

        return args;
    }

    /// <summary>
    /// Copies a redirector's by-ref arguments back into the memory the caller reads them from.
    /// </summary>
    public readonly void RefParamsToUnmanaged(Type[] managedTypes, object?[] args, int argOffset)
    {
        var props = GetFunction().EnumerateParams().ToArray();

        for (var i = 0; i < props.Length; i++)
        {
            if (managedTypes[i].IsByRef)
            {
                var addr = GetParamAddr(props[i]);
                MarshalUtil.ToUnmanaged(args[i + argOffset], addr, Deref(managedTypes[i]));
            }
        }
    }

    /// <summary>
    /// Copies params to or from a buffer laid out for a ProcessEvent call. Only out params travel
    /// back, since the rest are inputs the callee never writes.
    /// </summary>
    public readonly void CopyParams(IntPtr buffer, bool intoBuffer)
    {
        foreach (var prop in GetFunction().EnumerateParams())
        {
            var isOut = prop.PropertyFlags.HasFlag(Property.EPropertyFlags.CPF_OutParm);
            if (!intoBuffer && !isOut)
            {
                continue;
            }

            var addr = GetParamAddr(prop);
            var slot = buffer + prop.Offset;
            var size = prop.ArrayDim * prop.ElementSize;
            var (src, dest) = intoBuffer ? (addr, slot) : (slot, addr);
            Buffer.MemoryCopy(src.ToPointer(), dest.ToPointer(), size, size);
        }
    }
}
