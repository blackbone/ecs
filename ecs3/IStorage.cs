namespace ecs3;

interface IStorage<T>
{
    int Count { get; }

    ReadOnlySpan<T> All();
    ReadOnlySpan<int> AllEntities();

    // [C]reate
    void Add(in int entityIid, in T value);

    // [R]ead
    bool Has(in int entityIid);

    // [R]ead/[U]pdate
    ref T Ref(in int entityIid);

    // [D]elete
    void Remove(in int entityIid);
}