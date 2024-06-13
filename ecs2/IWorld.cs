namespace ecs1;

public interface IWorld<TEntity> 
{
    // [C]reate::Entity
    TEntity CreateEntity();

    // [D]elete::Entity
    void DeleteEntity(in TEntity entity);

    // [C]reate::Component
    void AddComponent<T>(in TEntity entity, in T componentData);

    // [R]ead / [U]pdate::Component
    ref T GetComponent<T>(in TEntity entity);

    // [D]elete::Component
    void DeleteComponent<T>(in TEntity entity);
}