using bench2;
using BenchmarkDotNet.Running;

var switcher = new BenchmarkSwitcher([typeof(AoS), typeof(SoA)]);
switcher.RunAll();