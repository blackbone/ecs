using System.Runtime.CompilerServices;

namespace ecs3;

public class Storage1<T> : IStorage<T>
{
    private bool[]? has;
    private T[]? data;

    public int Count { get; private set; }
    public ReadOnlySpan<T> All() => throw new NotImplementedException();
    public ReadOnlySpan<int> AllEntities() => throw new NotImplementedException();

    public Storage1() => Resize(32);
    
    public void Add(in int entityIid, in T value)
    {
        if (entityIid >= has!.Length) Resize((entityIid / 32 + 1) * 32);

        data![entityIid] = value;
        has![entityIid] = true;
        Count++;
    }

    public bool Has(in int entityIid) => entityIid < has!.Length && has[entityIid];

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public ref T Ref(in int entityIid) => ref data![entityIid];

    public void Remove(in int entityIid)
    {
        if (entityIid >= has!.Length) return;

        has[entityIid] = false;
        Count--;
    }

    private void Resize(in int size)
    {
        if (has == null)
        {
            has = new bool[size];
            data = new T[size];
            return;
        }
        
        var initialSize = has?.Length ?? 0;
        if (initialSize >= size) return;
        
        Array.Resize(ref has, size);
        Array.Resize(ref data, size);
    }
}