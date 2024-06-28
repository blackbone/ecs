// See https://aka.ms/new-console-template for more information

using bench;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;

var switcher = new BenchmarkSwitcher([typeof(List), typeof(RemoveAndSwapBack)]);
switcher.RunAllJoined(DefaultConfig.Instance.WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest)));