using bench2;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

var job = Job.Default
    .WithUnrollFactor(1)
    .WithIterationCount(10)
    .Apply();

IConfig config = DefaultConfig.Instance
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .WithOption(ConfigOptions.JoinSummary, true)
    .AddLogicalGroupRules(BenchmarkLogicalGroupRule.ByCategory);

new BenchmarkSwitcher([typeof(AoS), typeof(SoA), typeof(Hybrid)])
    .RunAll(config.AddJob(job));
