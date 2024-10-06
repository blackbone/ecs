using BenchmarkDotNet.Attributes;

namespace bench2;

public class SoA
{
    [Params(10_000_000, 100_000_000)] public int Count { get; set; }

    private Component1[] c1;
    private Component2[] c2;
    private Component3[] c3;
    private Component4[] c4;
    private Component5[] c5;
    private Component6[] c6;
    private Component7[] c7;
    private Component8[] c8;
    private Component9[] c9;
    private Component10[] c10;

    [GlobalSetup]
    public void IterationSetup()
    {
        c1 = new Component1[Count];
        c2 = new Component2[Count];
        c3 = new Component3[Count];
        c4 = new Component4[Count];
        c5 = new Component5[Count];
        c6 = new Component6[Count];
        c7 = new Component7[Count];
        c8 = new Component8[Count];
        c9 = new Component9[Count];
        c10 = new Component10[Count];
    }

    [Benchmark]
    public void Step1()
    {
        for (int i = 0; i < Count; i++)
        {
            c1[i].Value++;
        }
    }

    [Benchmark]
    public void Step2()
    {
        for (int i = 0; i < Count; i++)
        {
            c1[i].Value++;
            c2[i].Value++;
        }
    }

    [Benchmark]
    public void Step3()
    {
        for (int i = 0; i < Count; i++)
        {
            c1[i].Value++;
            c2[i].Value++;
            c3[i].Value++;
        }
    }

    [Benchmark]
    public void Step4()
    {
        for (int i = 0; i < Count; i++)
        {
            c1[i].Value++;
            c2[i].Value++;
            c3[i].Value++;
            c4[i].Value++;
        }
    }

    [Benchmark]
    public void Step5()
    {
        for (int i = 0; i < Count; i++)
        {
            c1[i].Value++;
            c2[i].Value++;
            c3[i].Value++;
            c4[i].Value++;
            c5[i].Value++;
        }
    }

    [Benchmark]
    public void Step6()
    {
        for (int i = 0; i < Count; i++)
        {
            c1[i].Value++;
            c2[i].Value++;
            c3[i].Value++;
            c4[i].Value++;
            c5[i].Value++;
            c6[i].Value++;
        }
    }

    [Benchmark]
    public void Step7()
    {
        for (int i = 0; i < Count; i++)
        {
            c1[i].Value++;
            c2[i].Value++;
            c3[i].Value++;
            c4[i].Value++;
            c5[i].Value++;
            c6[i].Value++;
            c7[i].Value++;
        }
    }

    [Benchmark]
    public void Step8()
    {
        for (int i = 0; i < Count; i++)
        {
            c1[i].Value++;
            c2[i].Value++;
            c3[i].Value++;
            c4[i].Value++;
            c5[i].Value++;
            c6[i].Value++;
            c7[i].Value++;
            c8[i].Value++;
        }
    }

    [Benchmark]
    public void Step9()
    {
        for (int i = 0; i < Count; i++)
        {
            c1[i].Value++;
            c2[i].Value++;
            c3[i].Value++;
            c4[i].Value++;
            c5[i].Value++;
            c6[i].Value++;
            c7[i].Value++;
            c8[i].Value++;
            c9[i].Value++;
        }
    }

    [Benchmark]
    public void Step10()
    {
        for (int i = 0; i < Count; i++)
        {
            c1[i].Value++;
            c2[i].Value++;
            c3[i].Value++;
            c4[i].Value++;
            c5[i].Value++;
            c6[i].Value++;
            c7[i].Value++;
            c8[i].Value++;
            c9[i].Value++;
            c10[i].Value++;
        }
    }

    [IterationCleanup]
    public void IterationCleanup()
    {
        Array.Clear(c1);
        Array.Clear(c2);
        Array.Clear(c3);
        Array.Clear(c4);
        Array.Clear(c5);
        Array.Clear(c6);
        Array.Clear(c7);
        Array.Clear(c8);
        Array.Clear(c9);
        Array.Clear(c10);
    }
}