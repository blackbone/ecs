using System.Runtime.InteropServices;

namespace ecs1;

[StructLayout(LayoutKind.Sequential)]
public readonly struct EntityId : IEquatable<EntityId>
{
    public static readonly EntityId Invalid = new(0, 0, 0);
    
    internal readonly int id;
    internal readonly ushort gen;
    internal readonly ushort worldId; // [!code ++]
    
    public EntityId(int id, ushort gen, ushort worldId)
    {
        this.id = id;
        this.gen = gen;
        this.worldId = worldId;
    }
    
    public bool Equals(EntityId other) => id == other.id && gen == other.gen && worldId == other.worldId;

    public override bool Equals(object? obj) => obj is EntityId other && Equals(other);
    public override int GetHashCode() => HashCode.Combine(id, gen);
    public override string ToString() => $"E:{worldId}-{id}[{gen}]";
    public static bool operator ==(EntityId a, EntityId b) => a.Equals(b);
    public static bool operator !=(EntityId a, EntityId b) => !a.Equals(b);
}