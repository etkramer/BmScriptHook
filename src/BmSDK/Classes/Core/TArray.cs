using System.Collections;
using BmSDK.Framework;

#pragma warning disable CS0169
#pragma warning disable CS0649

namespace BmSDK;

internal interface IArray
{
    IntPtr Ptr { get; }
}

/// <summary>
/// A resizable array of objects. Similar to <see cref="List{T}"/>, but can be used directly by the game.
/// </summary>
/// <typeparam name="TManaged">The type of elements in the array.
/// Should be either a managed primitive or a managed type.</typeparam>
public unsafe class TArray<TManaged> : IArray, IList<TManaged>, IDisposable
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct NativeData
    {
        public IntPtr AllocatorInstance;
        public int Num;
        public int Max;
    }

    internal ref NativeData Data => ref *(NativeData*)Ptr.ToPointer();

    public IntPtr Ptr { get; private set; } = IntPtr.Zero;

    private readonly bool _ownsMemory;

    public int Count => Data.Num;
    public int Capacity => Data.Max;
    public int Stride { get; } = MarshalUtil.GetSizeUnmanaged<TManaged>();

    public bool IsReadOnly => false;

    /// <summary>
    /// Creates a new TArray with C#-owned memory.
    /// </summary>
    public TArray(int capacity = 4)
    {
        Guard.Require(capacity >= 0, "Capacity cannot be negative");

        Ptr = Marshal.AllocHGlobal(sizeof(NativeData));
        _ownsMemory = true;

        Data.Num = 0;
        Data.Max = capacity;
        Data.AllocatorInstance =
            capacity > 0
                ? GameFunctions.AppRealloc(IntPtr.Zero, capacity * Stride, 8)
                : IntPtr.Zero;
    }

    /// <summary>
    /// Creates a managed wrapper around an existing native TArray.
    /// </summary>
    internal TArray(IntPtr ptr)
    {
        Ptr = ptr;
        _ownsMemory = false;
    }

    public TManaged this[int idx]
    {
        get =>
            MarshalUtil.ToManaged<TManaged>(
                Data.AllocatorInstance + (Guard.Bounds(idx, Count) * Stride)
            );
        set =>
            MarshalUtil.ToUnmanaged(
                value,
                Data.AllocatorInstance + (Guard.Bounds(idx, Count) * Stride)
            );
    }

    /// <summary>
    /// Removes the specified number of items from the end of the array.
    /// </summary>
    public void Pop(int numItems = 1)
    {
        if (numItems == 0)
        {
            return;
        }

        // Don't allow removing more items than actually exist.
        Guard.Require(numItems > 0, "Cannot pop a negative number of items");
        var newCount = Math.Max(Data.Num - numItems, 0);
        Resize(newCount);
    }

    /// <summary>
    /// Adds the given items to the end of the array.
    /// </summary>
    public void Push(params TManaged[] items)
    {
        // Resize array to fit new items.
        var oldCount = Count;
        var newCount = oldCount + items.Length;
        Resize(newCount);

        // Assign new items to array.
        for (var i = 0; i < items.Length; i++)
        {
            var idx = oldCount + i;
            MarshalUtil.ToUnmanaged(items[i], Data.AllocatorInstance + (idx * Stride));
        }
    }

    /// <summary>
    /// Resizes the array to the specified count, reallocating if necessary and filling empty values with zeroes.
    /// </summary>
    private void Resize(int newNum)
    {
        // Nothing to resize
        if (newNum == Data.Num)
        {
            return;
        }

        // Shrink array: simple reduce count
        if (newNum < Data.Num)
        {
            Data.Num = newNum;
            return;
        }

        // Grow array (within capacity): simple increase count
        if (newNum > Data.Num && newNum <= Data.Max)
        {
            Data.Num = newNum;
            return;
        }

        // Grow array (beyond capacity): reallocate array
        if (newNum > Data.Num)
        {
            // Calculate new capacity (next multiple of current capacity, or initial capacity of 4)
            var baseMax = Data.Max == 0 ? 4 : Data.Max;
            var newMax = ((newNum / baseMax) + 1) * baseMax;

            Data.AllocatorInstance = GameFunctions.AppRealloc(
                Data.AllocatorInstance,
                newMax * Stride,
                8
            );
            Data.Num = newNum;
            Data.Max = newMax;
        }
    }

    public void Dispose()
    {
        if (_ownsMemory && Ptr != IntPtr.Zero)
        {
            if (Data.AllocatorInstance != IntPtr.Zero)
            {
                GameFunctions.AppFree(Data.AllocatorInstance);
            }

            Marshal.FreeHGlobal(Ptr);
            Ptr = IntPtr.Zero;
        }
    }

    public IEnumerator<TManaged> GetEnumerator()
    {
        for (var i = 0; i < Count; i++)
        {
            yield return this[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public void Clear() => Resize(0);

    public bool Contains(TManaged item)
    {
        for (var i = 0; i < Count; i++)
        {
            if (this[i]?.Equals(item) ?? false)
            {
                return true;
            }
        }

        return false;
    }

    public void Add(TManaged item) => Push(item);

    public int IndexOf(TManaged item)
    {
        for (var i = 0; i < Count; i++)
        {
            if (this[i]?.Equals(item) ?? false)
            {
                return i;
            }
        }

        return -1;
    }

    public void Insert(int index, TManaged item)
    {
        if (index < 0 || index > Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (index == Count)
        {
            Add(item);
            return;
        }

        var oldCount = Count;
        Resize(oldCount + 1);

        for (var i = oldCount; i > index; i--)
        {
            this[i] = this[i - 1];
        }

        this[index] = item;
    }

    public bool Remove(TManaged item)
    {
        var index = IndexOf(item);
        if (index >= 0)
        {
            RemoveAt(index);
            return true;
        }

        return false;
    }

    public void RemoveAt(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        for (var i = index; i < Count - 1; i++)
        {
            this[i] = this[i + 1];
        }

        Resize(Count - 1);
    }

    public void CopyTo(TManaged[] array, int arrayIndex)
    {
        ArgumentNullException.ThrowIfNull(array);

        ArgumentOutOfRangeException.ThrowIfNegative(arrayIndex);

        if (array.Length - arrayIndex < Count)
        {
            throw new ArgumentException(
                "Destination array is not long enough to copy all the items in the collection. Check array index and length."
            );
        }

        for (var i = 0; i < Count; i++)
        {
            array[arrayIndex + i] = this[i];
        }
    }
}

public static unsafe class TArrayExtensions
{
    /// <summary>
    /// Creates a new Span over the array's native elements.
    /// </summary>
    public static Span<T> AsSpan<T>(this TArray<T> array)
        where T : unmanaged
    {
        Guard.Require(array.Stride == sizeof(T), "Managed and unmanaged element sizes disagree");
        return new Span<T>((void*)array.Data.AllocatorInstance, array.Count);
    }
}
