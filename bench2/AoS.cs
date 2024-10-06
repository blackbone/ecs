using BenchmarkDotNet.Attributes;

namespace bench2;

using AllTypes = (Component1 _1, Component2 _2, Component3 _3, Component4 _4, Component5 _5, Component6 _6, Component7 _7, Component8 _8, Component9 _9, Component10 _10);

public class AoS
{
    [Params(10_000_000, 100_000_000)] public int Count { get; set; }

    private AllTypes[] c;

    [GlobalSetup]
    public void IterationSetup() => c = new AllTypes[Count];

    [Benchmark]
    public void Step1()
    {
        for (var i = 0; i < Count; i++)
        {
            ref var v = ref c[i];
            v._1.Value++;
        }
    }

    [Benchmark]
    public void Step2()
    {
        for (var i = 0; i < Count; i++)
        {
            ref var v = ref c[i];
            v._1.Value++;
            v._2.Value++;
        }
    }

    [Benchmark]
    public void Step3()
    {
        for (int i = 0; i < Count; i++)
        {
            ref var v = ref c[i];
            v._1.Value++;
            v._2.Value++;
            v._3.Value++;
        }
    }
    
    [Benchmark]
    public void Step4()
    {
        for (int i = 0; i < Count; i++)
        {
            ref var v = ref c[i];
            v._1.Value++;
            v._2.Value++;
            v._3.Value++;
            v._4.Value++;
        }
    }

    [Benchmark]
    public void Step5()
    {
        for (int i = 0; i < Count; i++)
        {
            ref var v = ref c[i];
            v._1.Value++;
            v._2.Value++;
            v._3.Value++;
            v._4.Value++;
            v._5.Value++;
        }
    }
    
    [Benchmark]
    public void Step6()
    {
        for (int i = 0; i < Count; i++)
        {
            ref var v = ref c[i];
            v._1.Value++;
            v._2.Value++;
            v._3.Value++;
            v._4.Value++;
            v._5.Value++;
            v._6.Value++;
        }
    }
    
    [Benchmark]
    public void Step7()
    {
        for (int i = 0; i < Count; i++)
        {
            ref var v = ref c[i];
            v._1.Value++;
            v._2.Value++;
            v._3.Value++;
            v._4.Value++;
            v._5.Value++;
            v._6.Value++;
            v._7.Value++;
        }
    }
    
        
    [Benchmark]
    public void Step8()
    {
        for (int i = 0; i < Count; i++)
        {
            ref var v = ref c[i];
            v._1.Value++;
            v._2.Value++;
            v._3.Value++;
            v._4.Value++;
            v._5.Value++;
            v._6.Value++;
            v._7.Value++;
            v._8.Value++;
        }
    }
    
    [Benchmark]
    public void Step9()
    {
        for (int i = 0; i < Count; i++)
        {
            ref var v = ref c[i];
            v._1.Value++;
            v._2.Value++;
            v._3.Value++;
            v._4.Value++;
            v._5.Value++;
            v._6.Value++;
            v._7.Value++;
            v._8.Value++;
            v._9.Value++;
        }
    }
    
    [Benchmark]
    public void Step10()
    {
        for (int i = 0; i < Count; i++)
        {
            ref var v = ref c[i];
            v._1.Value++;
            v._2.Value++;
            v._3.Value++;
            v._4.Value++;
            v._5.Value++;
            v._6.Value++;
            v._7.Value++;
            v._8.Value++;
            v._9.Value++;
            v._10.Value++;
        }
    }

    [IterationCleanup]
    public void IterationCleanup()
    {
        Array.Clear(c);
    }
}