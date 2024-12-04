using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;

namespace bench2;

[BenchmarkCategory(nameof(Hybrid))]
public class Hybrid : Benchmark
{
    private const int BlockSize = 32;

    [StructLayout(LayoutKind.Explicit, Size = Component1.Size * BlockSize * 20)]
    public struct Block {
        [FieldOffset(Component1.Size * BlockSize * 0)] public Component1 c1;
        [FieldOffset(Component1.Size * BlockSize * 1)] public Component1 c2;
        [FieldOffset(Component1.Size * BlockSize * 2)] public Component1 c3;
        [FieldOffset(Component1.Size * BlockSize * 3)] public Component1 c4;
        [FieldOffset(Component1.Size * BlockSize * 4)] public Component1 c5;
        [FieldOffset(Component1.Size * BlockSize * 5)] public Component1 c6;
        [FieldOffset(Component1.Size * BlockSize * 6)] public Component1 c7;
        [FieldOffset(Component1.Size * BlockSize * 7)] public Component1 c8;
        [FieldOffset(Component1.Size * BlockSize * 8)] public Component1 c9;
        [FieldOffset(Component1.Size * BlockSize * 9)] public Component1 c10;
        [FieldOffset(Component1.Size * BlockSize * 10)] public Component1 c11;
        [FieldOffset(Component1.Size * BlockSize * 11)] public Component1 c12;
        [FieldOffset(Component1.Size * BlockSize * 12)] public Component1 c13;
        [FieldOffset(Component1.Size * BlockSize * 13)] public Component1 c14;
        [FieldOffset(Component1.Size * BlockSize * 14)] public Component1 c15;
        [FieldOffset(Component1.Size * BlockSize * 15)] public Component1 c16;
        [FieldOffset(Component1.Size * BlockSize * 16)] public Component1 c17;
        [FieldOffset(Component1.Size * BlockSize * 17)] public Component1 c18;
        [FieldOffset(Component1.Size * BlockSize * 18)] public Component1 c19;
        [FieldOffset(Component1.Size * BlockSize * 19)] public Component1 c20;
    }

    private Block[] blocks;

    [GlobalSetup]
    public void GlobalSetup()
    {
        var n = Count / BlockSize + 1;
        blocks = new Block[n];
        for (var i = 0; i < n; i++)
            blocks[i] = new Block();
    }

    [Benchmark]
    public unsafe void Step1()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc1++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step2()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc1++;
                    rc2++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step3()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step4()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step5()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step6()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step7()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step8()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step9()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;
                var rc9 = &p->c9;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc9->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                    rc9++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step10()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;
                var rc9 = &p->c9;
                var rc10 = &p->c10;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc9->Value++;
                    rc10->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                    rc9++;
                    rc10++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step11()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;
                var rc9 = &p->c9;
                var rc10 = &p->c10;
                var rc11 = &p->c11;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc9->Value++;
                    rc10->Value++;
                    rc11->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                    rc9++;
                    rc10++;
                    rc11++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step12()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;
                var rc9 = &p->c9;
                var rc10 = &p->c10;
                var rc11 = &p->c11;
                var rc12 = &p->c12;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc9->Value++;
                    rc10->Value++;
                    rc11->Value++;
                    rc12->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                    rc9++;
                    rc10++;
                    rc11++;
                    rc12++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step13()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;
                var rc9 = &p->c9;
                var rc10 = &p->c10;
                var rc11 = &p->c11;
                var rc12 = &p->c12;
                var rc13 = &p->c13;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc9->Value++;
                    rc10->Value++;
                    rc11->Value++;
                    rc12->Value++;
                    rc13->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                    rc9++;
                    rc10++;
                    rc11++;
                    rc12++;
                    rc13++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step14()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;
                var rc9 = &p->c9;
                var rc10 = &p->c10;
                var rc11 = &p->c11;
                var rc12 = &p->c12;
                var rc13 = &p->c13;
                var rc14 = &p->c14;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc9->Value++;
                    rc10->Value++;
                    rc11->Value++;
                    rc12->Value++;
                    rc13->Value++;
                    rc14->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                    rc9++;
                    rc10++;
                    rc11++;
                    rc12++;
                    rc13++;
                    rc14++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step15()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;
                var rc9 = &p->c9;
                var rc10 = &p->c10;
                var rc11 = &p->c11;
                var rc12 = &p->c12;
                var rc13 = &p->c13;
                var rc14 = &p->c14;
                var rc15 = &p->c15;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc9->Value++;
                    rc10->Value++;
                    rc11->Value++;
                    rc12->Value++;
                    rc13->Value++;
                    rc14->Value++;
                    rc15->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                    rc9++;
                    rc10++;
                    rc11++;
                    rc12++;
                    rc13++;
                    rc14++;
                    rc15++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step16()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;
                var rc9 = &p->c9;
                var rc10 = &p->c10;
                var rc11 = &p->c11;
                var rc12 = &p->c12;
                var rc13 = &p->c13;
                var rc14 = &p->c14;
                var rc15 = &p->c15;
                var rc16 = &p->c16;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc9->Value++;
                    rc10->Value++;
                    rc11->Value++;
                    rc12->Value++;
                    rc13->Value++;
                    rc14->Value++;
                    rc15->Value++;
                    rc16->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                    rc9++;
                    rc10++;
                    rc11++;
                    rc12++;
                    rc13++;
                    rc14++;
                    rc15++;
                    rc16++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step17()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;
                var rc9 = &p->c9;
                var rc10 = &p->c10;
                var rc11 = &p->c11;
                var rc12 = &p->c12;
                var rc13 = &p->c13;
                var rc14 = &p->c14;
                var rc15 = &p->c15;
                var rc16 = &p->c16;
                var rc17 = &p->c17;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc9->Value++;
                    rc10->Value++;
                    rc11->Value++;
                    rc12->Value++;
                    rc13->Value++;
                    rc14->Value++;
                    rc15->Value++;
                    rc16->Value++;
                    rc17->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                    rc9++;
                    rc10++;
                    rc11++;
                    rc12++;
                    rc13++;
                    rc14++;
                    rc15++;
                    rc16++;
                    rc17++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step18()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;
                var rc9 = &p->c9;
                var rc10 = &p->c10;
                var rc11 = &p->c11;
                var rc12 = &p->c12;
                var rc13 = &p->c13;
                var rc14 = &p->c14;
                var rc15 = &p->c15;
                var rc16 = &p->c16;
                var rc17 = &p->c17;
                var rc18 = &p->c18;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc9->Value++;
                    rc10->Value++;
                    rc11->Value++;
                    rc12->Value++;
                    rc13->Value++;
                    rc14->Value++;
                    rc15->Value++;
                    rc16->Value++;
                    rc17->Value++;
                    rc18->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                    rc9++;
                    rc10++;
                    rc11++;
                    rc12++;
                    rc13++;
                    rc14++;
                    rc15++;
                    rc16++;
                    rc17++;
                    rc18++;
                }
            }
        }
    }
    
    [Benchmark]
    public unsafe void Step19()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;
                var rc9 = &p->c9;
                var rc10 = &p->c10;
                var rc11 = &p->c11;
                var rc12 = &p->c12;
                var rc13 = &p->c13;
                var rc14 = &p->c14;
                var rc15 = &p->c15;
                var rc16 = &p->c16;
                var rc17 = &p->c17;
                var rc18 = &p->c18;
                var rc19 = &p->c19;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc9->Value++;
                    rc10->Value++;
                    rc11->Value++;
                    rc12->Value++;
                    rc13->Value++;
                    rc14->Value++;
                    rc15->Value++;
                    rc16->Value++;
                    rc17->Value++;
                    rc18->Value++;
                    rc19->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                    rc9++;
                    rc10++;
                    rc11++;
                    rc12++;
                    rc13++;
                    rc14++;
                    rc15++;
                    rc16++;
                    rc17++;
                    rc18++;
                    rc19++;
                }
            }
        }
    }

    [Benchmark]
    public unsafe void Step20()
    {
        var n = Count / BlockSize;
        var i = 0;
        for (; i < n; i++)
            Iterate(ref blocks[i], BlockSize);

        var v = Count % BlockSize;
        Iterate(ref blocks[i], v);
        return;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        void Iterate(ref Block block, in int count)
        {
            fixed (Block* p = &block)
            {
                var rc1 = &p->c1;
                var rc2 = &p->c2;
                var rc3 = &p->c3;
                var rc4 = &p->c4;
                var rc5 = &p->c5;
                var rc6 = &p->c6;
                var rc7 = &p->c7;
                var rc8 = &p->c8;
                var rc9 = &p->c9;
                var rc10 = &p->c10;
                var rc11 = &p->c11;
                var rc12 = &p->c12;
                var rc13 = &p->c13;
                var rc14 = &p->c14;
                var rc15 = &p->c15;
                var rc16 = &p->c16;
                var rc17 = &p->c17;
                var rc18 = &p->c18;
                var rc19 = &p->c19;
                var rc20 = &p->c20;

                for (var j = 0; j < count; j++) {
                    rc1->Value++;
                    rc2->Value++;
                    rc3->Value++;
                    rc4->Value++;
                    rc5->Value++;
                    rc6->Value++;
                    rc7->Value++;
                    rc8->Value++;
                    rc9->Value++;
                    rc10->Value++;
                    rc11->Value++;
                    rc12->Value++;
                    rc13->Value++;
                    rc14->Value++;
                    rc15->Value++;
                    rc16->Value++;
                    rc17->Value++;
                    rc18->Value++;
                    rc19->Value++;
                    rc20->Value++;
                    rc1++;
                    rc2++;
                    rc3++;
                    rc4++;
                    rc5++;
                    rc6++;
                    rc7++;
                    rc8++;
                    rc9++;
                    rc10++;
                    rc11++;
                    rc12++;
                    rc13++;
                    rc14++;
                    rc15++;
                    rc16++;
                    rc17++;
                    rc18++;
                    rc19++;
                    rc20++;
                }
            }
        }
    }

    [IterationCleanup]
    public void IterationCleanup() {
        for (var i = 0; i < blocks.Length; i++)
            blocks[i] = default;
    }
}
