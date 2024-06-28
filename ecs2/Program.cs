using System.Numerics;
using ecs1;

// var world = new World();
// var entity = world.CreateEntity();
// world.DeleteEntity(entity);
// world.AddComponent(entity, new Vector3());


var world1 = new World();
var world2 = new World();
var entity = world1.CreateEntity();
world2.AddComponent(entity, new Vector3());
