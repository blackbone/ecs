namespace ecs1;

public class World : IWorld<int>
{
    private struct ComponentWithFlag<T>
    {
        public bool flag;
        public T component;
    }

    private readonly Queue<int> freeEntityIds = new();
    private readonly Dictionary<Type, Array> components = new();
    
    private bool[] isAlive;

    public World(int entityCount = 256) => Resize(entityCount);

    private void Resize(in int size)
    {
        var initialSize = isAlive?.Length ?? 0;
        if (initialSize >= size) return;

        Array.Resize(ref isAlive, size);
        foreach (var (key, componentStorage) in components)
        {
            var newArray = Array.CreateInstance(componentStorage.GetType().GetElementType()!, size);
            componentStorage.CopyTo(newArray, componentStorage.Length);
            components[key] = componentStorage;
        }
        
        for (var i = initialSize; i < size; i++)
            freeEntityIds.Enqueue(i);
    }

    // CRUD [C]reate :: world
    public int CreateEntity()
    {
        if (freeEntityIds.Count == 0) Resize(isAlive.Length + 32);
        var entity = freeEntityIds.Dequeue();
        isAlive[entity] = true;
        return entity;
    }

    // CRUD [D]elete :: world
    public void DeleteEntity(in int entity) => isAlive[entity] = false;

    // CRUD [C]reate :: entity
    public void AddComponent<T>(in int entityId, in T c)
    {
        ComponentWithFlag<T>[] storage;
        if (components.TryGetValue(typeof(T), out var array)) storage = (ComponentWithFlag<T>[])array;
        else components[typeof(T)] = storage = new ComponentWithFlag<T>[isAlive.Length];
        
        if (storage[entityId].flag) throw new Exception($"Entity {entityId} already has Component1");
        storage[entityId] = new ComponentWithFlag<T> { flag = true, component = c };
    }

    // CRUD [R]ead/[U]pdate :: entity
    public ref T GetComponent<T>(in int entityId)
    {
        ComponentWithFlag<T>[] storage;
        if (components.TryGetValue(typeof(T), out var array)) storage = (ComponentWithFlag<T>[])array;
        else components[typeof(T)] = storage = new ComponentWithFlag<T>[isAlive.Length];
        
        if (!storage[entityId].flag) throw new Exception($"Entity {entityId} has no Component1");
        return ref storage[entityId].component;
    }

    // CRUD [D]elete :: entity
    public void DeleteComponent<T>(in int entityId)
    {
        ComponentWithFlag<T>[] storage;
        if (components.TryGetValue(typeof(T), out var array)) storage = (ComponentWithFlag<T>[])array;
        else components[typeof(T)] = storage = new ComponentWithFlag<T>[isAlive.Length];

        if (!storage[entityId].flag) throw new Exception($"Entity {entityId} has no Component1");
        storage[entityId].flag = false;
        freeEntityIds.Enqueue(entityId);
    }
}
