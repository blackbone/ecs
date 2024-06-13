namespace ecs1;

public readonly struct Entity
{
    public readonly int id;
    public readonly ushort gen;
    
    public Entity(int id, ushort gen)
    {
        this.id = id;
        this.gen = gen;
    }
    
    public override string ToString() => $"e {id}[{gen}]";
}

public class World : IWorld<Entity>
{
    private struct ComponentWithFlag<T>
    {
        public bool flag;
        public T component;
    }

    private readonly Queue<int> freeEntityIds = new();
    private readonly Dictionary<Type, Array> components = new();
    
    private ushort[] gen;

    public World(int entityCount = 256) => Resize(entityCount);

    private void Resize(in int size)
    {
        var initialSize = gen?.Length ?? 0;
        if (initialSize >= size) return;

        Array.Resize(ref gen, size);
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
    public Entity CreateEntity()
    {
        if (freeEntityIds.Count == 0) Resize(gen.Length + 32);
        var entityId = freeEntityIds.Dequeue();
        return new Entity(entityId, gen[entityId]);
    }

    // CRUD [D]elete :: world
    public void DeleteEntity(in Entity entity)
    {
        if (gen[entity.id] != entity.gen) throw new Exception($"Entity {entity} is dead!");
        gen[entity.id]++;
    }

    // CRUD [C]reate :: entity
    public void AddComponent<T>(in Entity entity, in T c)
    {
        if (gen[entity.id] != entity.gen) throw new Exception($"Entity {entity} is dead!");
        
        ComponentWithFlag<T>[] storage;
        if (components.TryGetValue(typeof(T), out var array)) storage = (ComponentWithFlag<T>[])array;
        else components[typeof(T)] = storage = new ComponentWithFlag<T>[gen.Length];
        
        if (storage[entity.id].flag) throw new Exception($"Entity {entity.id} already has {typeof(T)}");
        storage[entity.id] = new ComponentWithFlag<T> { flag = true, component = c };
    }

    // CRUD [R]ead/[U]pdate :: entity
    public ref T GetComponent<T>(in Entity entity)
    {
        if (gen[entity.id] != entity.gen) throw new Exception($"Entity {entity} is dead!");

        ComponentWithFlag<T>[] storage;
        if (components.TryGetValue(typeof(T), out var array)) storage = (ComponentWithFlag<T>[])array;
        else components[typeof(T)] = storage = new ComponentWithFlag<T>[gen.Length];
        
        if (!storage[entity.id].flag) throw new Exception($"Entity {entity.id} has no {typeof(T)}");
        return ref storage[entity.id].component;
    }

    // CRUD [D]elete :: entity
    public void DeleteComponent<T>(in Entity entity)
    {
        if (gen[entity.id] != entity.gen) throw new Exception($"Entity {entity} is dead!");

        ComponentWithFlag<T>[] storage;
        if (components.TryGetValue(typeof(T), out var array)) storage = (ComponentWithFlag<T>[])array;
        else components[typeof(T)] = storage = new ComponentWithFlag<T>[gen.Length];

        if (!storage[entity.id].flag) throw new Exception($"Entity {entity.id} has no {typeof(T)}");
        storage[entity.id].flag = false;
        freeEntityIds.Enqueue(entity.id);
    }
}
