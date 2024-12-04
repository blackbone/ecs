using BenchmarkDotNet.Attributes;

namespace bench2;

[BenchmarkCategory(nameof(SoA))]
public class SoA : Benchmark
{
    private Component1[] c1;
    private Component1[] c2;
    private Component1[] c3;
    private Component1[] c4;
    private Component1[] c5;
    private Component1[] c6;
    private Component1[] c7;
    private Component1[] c8;
    private Component1[] c9;
    private Component1[] c10;
    private Component1[] c11;
    private Component1[] c12;
    private Component1[] c13;
    private Component1[] c14;
    private Component1[] c15;
    private Component1[] c16;
    private Component1[] c17;
    private Component1[] c18;
    private Component1[] c19;
    private Component1[] c20;

    [GlobalSetup]
    public void GlobalSetup()
    {
        c1 = new Component1[Count];
        c2 = new Component1[Count];
        c3 = new Component1[Count];
        c4 = new Component1[Count];
        c5 = new Component1[Count];
        c6 = new Component1[Count];
        c7 = new Component1[Count];
        c8 = new Component1[Count];
        c9 = new Component1[Count];
        c10 = new Component1[Count];
        c11 = new Component1[Count];
        c12 = new Component1[Count];
        c13 = new Component1[Count];
        c14 = new Component1[Count];
        c15 = new Component1[Count];
        c16 = new Component1[Count];
        c17 = new Component1[Count];
        c18 = new Component1[Count];
        c19 = new Component1[Count];
        c20 = new Component1[Count];
    }

    [Benchmark]
    public void Step1()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
        {
            c1[i].Value++;
        }
    }

    [Benchmark]
    public void Step2()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
        {
            c1[i].Value++;
            c2[i].Value++;
        }
    }

    [Benchmark]
    public void Step3()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
        {
            c1[i].Value++;
            c2[i].Value++;
            c3[i].Value++;
        }
    }

    [Benchmark]
    public void Step4()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
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
        var n = Count;
        for (var i = 0; i < n; i++)
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
        var n = Count;
        for (var i = 0; i < n; i++)
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
        var n = Count;
        for (var i = 0; i < n; i++)
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
        var n = Count;
        for (var i = 0; i < n; i++)
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
        var n = Count;
        for (var i = 0; i < n; i++)
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
        var n = Count;
        for (var i = 0; i < n; i++)
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
    
    [Benchmark]
    public void Step11()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
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
            c11[i].Value++;
        }
    }
    
    [Benchmark]
    public void Step12()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
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
            c11[i].Value++;
            c12[i].Value++;
        }
    }
    
    [Benchmark]
    public void Step13()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
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
            c11[i].Value++;
            c12[i].Value++;
            c13[i].Value++;
        }
    }
    
    [Benchmark]
    public void Step14()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
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
            c11[i].Value++;
            c12[i].Value++;
            c13[i].Value++;
            c14[i].Value++;
        }
    }
    
    [Benchmark]
    public void Step15()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
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
            c11[i].Value++;
            c12[i].Value++;
            c13[i].Value++;
            c14[i].Value++;
            c15[i].Value++;
        }
    }
    
    [Benchmark]
    public void Step16()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
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
            c11[i].Value++;
            c12[i].Value++;
            c13[i].Value++;
            c14[i].Value++;
            c15[i].Value++;
            c16[i].Value++;
        }
    }
    
    [Benchmark]
    public void Step17()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
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
            c11[i].Value++;
            c12[i].Value++;
            c13[i].Value++;
            c14[i].Value++;
            c15[i].Value++;
            c16[i].Value++;
            c17[i].Value++;
        }
    }
    
    [Benchmark]
    public void Step18()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
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
            c11[i].Value++;
            c12[i].Value++;
            c13[i].Value++;
            c14[i].Value++;
            c15[i].Value++;
            c16[i].Value++;
            c17[i].Value++;
            c18[i].Value++;
        }
    }
    
    [Benchmark]
    public void Step19()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
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
            c11[i].Value++;
            c12[i].Value++;
            c13[i].Value++;
            c14[i].Value++;
            c15[i].Value++;
            c16[i].Value++;
            c17[i].Value++;
            c18[i].Value++;
            c19[i].Value++;
        }
    }
    
    [Benchmark]
    public void Step20()
    {
        var n = Count;
        for (var i = 0; i < n; i++)
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
            c11[i].Value++;
            c12[i].Value++;
            c13[i].Value++;
            c14[i].Value++;
            c15[i].Value++;
            c16[i].Value++;
            c17[i].Value++;
            c18[i].Value++;
            c19[i].Value++;
            c20[i].Value++;
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
        Array.Clear(c11);
        Array.Clear(c12);
        Array.Clear(c13);
        Array.Clear(c14);
        Array.Clear(c15);
        Array.Clear(c16);
        Array.Clear(c17);
        Array.Clear(c18);
        Array.Clear(c19);
        Array.Clear(c20);
    }
}
