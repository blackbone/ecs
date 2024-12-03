using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;

namespace bench2;

[BenchmarkCategory(nameof(Hybrid))]
public class Hybrid : Benchmark
{
    private const int BlockSize = 32;

    [StructLayout(LayoutKind.Explicit, Size = (Component1.Size + Component2.Size + Component3.Size + Component4.Size + Component5.Size + Component6.Size + Component7.Size + Component9.Size + Component10.Size) * BlockSize)]
    public struct Block {
        [FieldOffset(0)]
        public Component1 c1;
        [FieldOffset(Component1.Size * BlockSize)]
        public Component2 c2;
        [FieldOffset((Component1.Size + Component2.Size) * BlockSize)]
        public Component3 c3;
        [FieldOffset((Component1.Size + Component2.Size + Component3.Size) * BlockSize)]
        public Component4 c4;
        [FieldOffset((Component1.Size + Component2.Size + Component3.Size + Component4.Size) * BlockSize)]
        public Component5 c5;
        [FieldOffset((Component1.Size + Component2.Size + Component3.Size + Component4.Size + Component5.Size) * BlockSize)]
        public Component6 c6;
        [FieldOffset((Component1.Size + Component2.Size + Component3.Size + Component4.Size + Component5.Size + Component6.Size) * BlockSize)]
        public Component7 c7;
        [FieldOffset((Component1.Size + Component2.Size + Component3.Size + Component4.Size + Component5.Size + Component6.Size + Component7.Size) * BlockSize)]
        public Component8 c8;
        [FieldOffset((Component1.Size + Component2.Size + Component3.Size + Component4.Size + Component5.Size + Component6.Size + Component7.Size + Component8.Size) * BlockSize)]
        public Component9 c9;
        [FieldOffset((Component1.Size + Component2.Size + Component3.Size + Component4.Size + Component5.Size + Component6.Size + Component7.Size + Component9.Size) * BlockSize)]
        public Component10 c10;
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

    [IterationCleanup]
    public void IterationCleanup() {
        for (var i = 0; i < blocks.Length; i++) {
            blocks[i].c1 = default;
            blocks[i].c2 = default;
            blocks[i].c3 = default;
            blocks[i].c4 = default;
            blocks[i].c5 = default;
            blocks[i].c6 = default;
            blocks[i].c7 = default;
            blocks[i].c8 = default;
            blocks[i].c9 = default;
            blocks[i].c10 = default;
        }
    }
}
