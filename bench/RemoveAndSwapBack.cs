using System.Numerics;
using BenchmarkDotNet.Attributes;
using ecs3;

namespace bench;

public class RemoveAndSwapBack
{
    [Params(10_000, 100_000, 250_000)] public int Count { get; set; }
    
    private Storage3<Vector3> storage = new();
    private int[] randomIndices;
    
    [IterationSetup]
    public void Setup()
    {
        for (var i = 0; i < Count; i++)
            storage.Add(i, new Vector3());
        
        randomIndices = Enumerable.Range(0, Count).ToArray();
        System.Random.Shared.Shuffle(randomIndices);
    }
    
    [Benchmark]
    [InnerIterationCount(1)]
    public void Linear()
    {
        for (var i = 0; i < Count; i++)
            storage.Remove(i);
    }
    
    [Benchmark]
    [InnerIterationCount(1)]
    public void Random()
    {
        for (var i = 0; i < Count; i++)
            storage.Remove(randomIndices[i]);
    }
    
    [Benchmark]
    [InnerIterationCount(1)]
    public void Reverse()
    {
        for (var i = Count - 1; i >= 0; i--)
            storage.Remove(i);
    }
}