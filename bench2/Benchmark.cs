using BenchmarkDotNet.Attributes;

namespace bench2;

public abstract class Benchmark
{
    [Params(10_000_000)] public int Count { get; set; }
}
