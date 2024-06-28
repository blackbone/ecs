using System.Runtime.CompilerServices;

namespace ecs3;

public class Storage2<T> : IStorage<T>
{
    private int[]? sparse;
    private int[]? dense;
    private T[]? data;

    public int Count { get; private set; }
    public ReadOnlySpan<T> All() => new(data, 0, Count);
    public ReadOnlySpan<int> AllEntities() => throw new NotImplementedException();

    public Storage2() => Resize(32, 32);
    
    public void Add(in int entityIid, in T value)
    {
        // ensure we have enought capacity in sparse and in data
        Resize((entityIid / 32 + 1) * 32, data!.Length == Count + 1 ? data.Length + 32 : data.Length);

        sparse![entityIid] = Count;
        dense![Count] = entityIid;
        data![Count] = value;
        Count++;
    }

    public bool Has(in int entityIid) => sparse![entityIid] != -1;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref T Ref(in int entityIid) => ref data![sparse![entityIid]];

    public void Remove(in int entityIid)
    {
        var arrayIndex = sparse![entityIid];
        Array.Copy(data!, arrayIndex + 1, data!, arrayIndex, Count - arrayIndex - 1);
    
        for (var i = arrayIndex; i < Count - 1; i++)
        {
            sparse![dense![i + 1]] = i;
            dense![i] = dense![i + 1];
        }

        Count--;
        sparse![entityIid] = -1;
        dense![Count] = -1;
    }

    private void Resize(in int sparseSize, in int dataSize)
    {
        if (sparse == null)
        {
            sparse = new int[sparseSize];
            dense = new int[sparseSize];
            Array.Fill(dense, -1);
            Array.Fill(sparse, -1);
            data = new T[dataSize];
            return;
        }
        
        var initialSparseSize = sparse!.Length;
        if (initialSparseSize < sparseSize)
        {
            Array.Resize(ref sparse, sparseSize);
            Array.Resize(ref dense, sparseSize);
            Array.Fill(sparse, -1, initialSparseSize, sparseSize - initialSparseSize);
            Array.Fill(dense, -1, initialSparseSize, sparseSize - initialSparseSize);
        }

        var initialDataSize = data!.Length;
        if (initialDataSize < dataSize)
            Array.Resize(ref data, dataSize);
    }
}