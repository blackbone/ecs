namespace ecs3;

public static class Extensions
{
    public static void RemoveAndSwapBack<T>(in T[] array, in int index, ref int count)
        => array[index] = array[--count];
}