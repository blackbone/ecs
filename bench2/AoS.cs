using BenchmarkDotNet.Attributes;

namespace bench2;

[BenchmarkCategory(nameof(AoS))]
public class AoS : Benchmark
{
    struct Block {
        public Component1 c1;
        public Component1 c2;
        public Component1 c3;
        public Component1 c4;
        public Component1 c5;
        public Component1 c6;
        public Component1 c7;
        public Component1 c8;
        public Component1 c9;
        public Component1 c10;
        public Component1 c11;
        public Component1 c12;
        public Component1 c13;
        public Component1 c14;
        public Component1 c15;
        public Component1 c16;
        public Component1 c17;
        public Component1 c18;
        public Component1 c19;
        public Component1 c20;
    }

    private Block[] data;

    [GlobalSetup]
    public void GlobalSetup() => data = new Block[Count];

    [Benchmark]
    public void Step1()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
        }
    }

    [Benchmark]
    public void Step2()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
        }
    }

    [Benchmark]
    public void Step3()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
        }
    }
    
    [Benchmark]
    public void Step4()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
        }
    }

    [Benchmark]
    public void Step5()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
        }
    }
    
    [Benchmark]
    public void Step6()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
        }
    }
    
    [Benchmark]
    public void Step7()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
        }
    }
    
        
    [Benchmark]
    public void Step8()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
        }
    }
    
    [Benchmark]
    public void Step9()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
            d.c9.Value++;
        }
    }
    
    [Benchmark]
    public void Step10()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
            d.c9.Value++;
            d.c10.Value++;
        }
    }
        
    [Benchmark]
    public void Step11()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
            d.c9.Value++;
            d.c10.Value++;
            d.c11.Value++;
        }
    }
        
    [Benchmark]
    public void Step12()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
            d.c9.Value++;
            d.c10.Value++;
            d.c11.Value++;
            d.c12.Value++;
        }
    }
        
    [Benchmark]
    public void Step13()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
            d.c9.Value++;
            d.c10.Value++;
            d.c11.Value++;
            d.c12.Value++;
            d.c13.Value++;
        }
    }
        
    [Benchmark]
    public void Step14()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
            d.c9.Value++;
            d.c10.Value++;
            d.c11.Value++;
            d.c12.Value++;
            d.c13.Value++;
            d.c14.Value++;
        }
    }
        
    [Benchmark]
    public void Step15()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
            d.c9.Value++;
            d.c10.Value++;
            d.c11.Value++;
            d.c12.Value++;
            d.c13.Value++;
            d.c14.Value++;
            d.c15.Value++;
        }
    }
        
    [Benchmark]
    public void Step16()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
            d.c9.Value++;
            d.c10.Value++;
            d.c11.Value++;
            d.c12.Value++;
            d.c13.Value++;
            d.c14.Value++;
            d.c15.Value++;
            d.c16.Value++;
        }
    }
    
    [Benchmark]
    public void Step17()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
            d.c9.Value++;
            d.c10.Value++;
            d.c11.Value++;
            d.c12.Value++;
            d.c13.Value++;
            d.c14.Value++;
            d.c15.Value++;
            d.c16.Value++;
            d.c17.Value++;
        }
    }
    
    [Benchmark]
    public void Step18()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
            d.c9.Value++;
            d.c10.Value++;
            d.c11.Value++;
            d.c12.Value++;
            d.c13.Value++;
            d.c14.Value++;
            d.c15.Value++;
            d.c16.Value++;
            d.c17.Value++;
            d.c18.Value++;
        }
    }
    
    [Benchmark]
    public void Step19()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
            d.c9.Value++;
            d.c10.Value++;
            d.c11.Value++;
            d.c12.Value++;
            d.c13.Value++;
            d.c14.Value++;
            d.c15.Value++;
            d.c16.Value++;
            d.c17.Value++;
            d.c18.Value++;
            d.c19.Value++;
        }
    }
    
    [Benchmark]
    public void Step20()
    {
        var n = Count;
        for (var i = 0; i < n; i++) {
            ref var d = ref data[i];
            d.c1.Value++;
            d.c2.Value++;
            d.c3.Value++;
            d.c4.Value++;
            d.c5.Value++;
            d.c6.Value++;
            d.c7.Value++;
            d.c8.Value++;
            d.c9.Value++;
            d.c10.Value++;
            d.c11.Value++;
            d.c12.Value++;
            d.c13.Value++;
            d.c14.Value++;
            d.c15.Value++;
            d.c16.Value++;
            d.c17.Value++;
            d.c18.Value++;
            d.c19.Value++;
            d.c20.Value++;
        }
    }

    [IterationCleanup]
    public void IterationCleanup()
    {
        Array.Clear(data);
    }
}
