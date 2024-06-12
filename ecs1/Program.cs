using System.Numerics;
using ecs1;

var world = new World();

var entity = world.CreateEntity();
world.AddComponent(entity, new Position());
world.AddComponent(entity, new Velocity { value = Vector3.UnitY });
world.DeleteComponent<Velocity>(entity);
world.DeleteComponent<Position>(entity);
world.DeleteEntity(entity);

struct Position
{
    public Vector3 value;
}

public struct Velocity
{
    public Vector3 value;
}
