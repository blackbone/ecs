namespace ecs1;

public class World : IWorld<EntityId>
{
    private static ushort worldsCounter = 0;
    private static ushort Id => ++worldsCounter;
    
    private struct ComponentWithFlag<T>
    {
        public bool flag;
        public T component;
    }

    private readonly ushort id = Id;
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
    public EntityId CreateEntity()
    {
        if (freeEntityIds.Count == 0) Resize(gen.Length + 32);
        var entityId = freeEntityIds.Dequeue();
        return new EntityId(entityId, gen[entityId], id);
    }

    // CRUD [D]elete :: world
    public void DeleteEntity(in EntityId entity)
    {
        if (entity.worldId != id) throw new Exception($"Entity {entity} not belongs to world {this}!");
        if (gen[entity.id] != entity.gen) throw new Exception($"Entity {entity} is dead!");
        unchecked
        {
            gen[entity.id]++;
        }
    }

    // CRUD [C]reate :: entity
    public void AddComponent<T>(in EntityId entity, in T c)
    {
        if (entity.worldId != id) throw new Exception($"Entity {entity} not belongs to world {this}!");
        if (gen[entity.id] != entity.gen) throw new Exception($"Entity {entity} is dead!");
        
        ComponentWithFlag<T>[] storage;
        if (components.TryGetValue(typeof(T), out var array)) storage = (ComponentWithFlag<T>[])array;
        else components[typeof(T)] = storage = new ComponentWithFlag<T>[gen.Length];
        
        if (storage[entity.id].flag) throw new Exception($"Entity {entity.id} already has {typeof(T)}");
        storage[entity.id] = new ComponentWithFlag<T> { flag = true, component = c };
    }

    // CRUD [R]ead/[U]pdate :: entity
    public ref T GetComponent<T>(in EntityId entity)
    {
        if (entity.worldId != id) throw new Exception($"Entity {entity} not belongs to world {this}!");
        if (gen[entity.id] != entity.gen) throw new Exception($"Entity {entity} is dead!");

        ComponentWithFlag<T>[] storage;
        if (components.TryGetValue(typeof(T), out var array)) storage = (ComponentWithFlag<T>[])array;
        else components[typeof(T)] = storage = new ComponentWithFlag<T>[gen.Length];
        
        if (!storage[entity.id].flag) throw new Exception($"Entity {entity.id} has no {typeof(T)}");
        return ref storage[entity.id].component;
    }

    // CRUD [D]elete :: entity
    public void DeleteComponent<T>(in EntityId entity)
    {
        if (entity.worldId != id) throw new Exception($"Entity {entity} not belongs to world {this}!");
        if (gen[entity.id] != entity.gen) throw new Exception($"Entity {entity} is dead!");

        ComponentWithFlag<T>[] storage;
        if (components.TryGetValue(typeof(T), out var array)) storage = (ComponentWithFlag<T>[])array;
        else components[typeof(T)] = storage = new ComponentWithFlag<T>[gen.Length];

        if (!storage[entity.id].flag) throw new Exception($"Entity {entity.id} has no {typeof(T)}");
        storage[entity.id].flag = false;
        freeEntityIds.Enqueue(entity.id);
    }

    public override string ToString() => $"W:{id}";
}
