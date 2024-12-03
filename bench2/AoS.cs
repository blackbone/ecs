using BenchmarkDotNet.Attributes;

namespace bench2;

[BenchmarkCategory(nameof(AoS))]
public class AoS : Benchmark
{
    struct Block {
        public Component1 c1;
        public Component2 c2;
        public Component3 c3;
        public Component4 c4;
        public Component5 c5;
        public Component6 c6;
        public Component7 c7;
        public Component8 c8;
        public Component9 c9;
        public Component10 c10;
    }

    private Block[] data;

    [GlobalSetup]
    public void GlobalSetup() => data = new Block[Count];

    [Benchmark]
    public void Step1()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            data[i].c1.Value++;
        }
    }

    [Benchmark]
    public void Step2()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            data[i].c1.Value++;
            data[i].c2.Value++;
        }
    }

    [Benchmark]
    public void Step3()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            data[i].c1.Value++;
            data[i].c2.Value++;
            data[i].c3.Value++;
        }
    }
    
    [Benchmark]
    public void Step4()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            data[i].c1.Value++;
            data[i].c2.Value++;
            data[i].c3.Value++;
            data[i].c4.Value++;
        }
    }

    [Benchmark]
    public void Step5()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            data[i].c1.Value++;
            data[i].c2.Value++;
            data[i].c3.Value++;
            data[i].c4.Value++;
            data[i].c5.Value++;
        }
    }
    
    [Benchmark]
    public void Step6()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            data[i].c1.Value++;
            data[i].c2.Value++;
            data[i].c3.Value++;
            data[i].c4.Value++;
            data[i].c5.Value++;
            data[i].c6.Value++;
        }
    }
    
    [Benchmark]
    public void Step7()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            data[i].c1.Value++;
            data[i].c2.Value++;
            data[i].c3.Value++;
            data[i].c4.Value++;
            data[i].c5.Value++;
            data[i].c6.Value++;
            data[i].c7.Value++;
        }
    }
    
        
    [Benchmark]
    public void Step8()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            data[i].c1.Value++;
            data[i].c2.Value++;
            data[i].c3.Value++;
            data[i].c4.Value++;
            data[i].c5.Value++;
            data[i].c6.Value++;
            data[i].c7.Value++;
            data[i].c8.Value++;
        }
    }
    
    [Benchmark]
    public void Step9()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            data[i].c1.Value++;
            data[i].c2.Value++;
            data[i].c3.Value++;
            data[i].c4.Value++;
            data[i].c5.Value++;
            data[i].c6.Value++;
            data[i].c7.Value++;
            data[i].c8.Value++;
            data[i].c9.Value++;
        }
    }
    
    [Benchmark]
    public void Step10()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            data[i].c1.Value++;
            data[i].c2.Value++;
            data[i].c3.Value++;
            data[i].c4.Value++;
            data[i].c5.Value++;
            data[i].c6.Value++;
            data[i].c7.Value++;
            data[i].c8.Value++;
            data[i].c9.Value++;
            data[i].c10.Value++;
        }
    }

    [IterationCleanup]
    public void IterationCleanup()
    {
        Array.Clear(data);
    }
}
