using bench2;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Jobs;
using BenchmarkDotNet.Running;

var job = Job.Default
    .WithIterationCount(50)
    .WithNoAffinitize(true)
    .Apply();

IConfig config = DefaultConfig.Instance
    .WithOptions(ConfigOptions.DisableOptimizationsValidator)
    .WithOption(ConfigOptions.JoinSummary, true)
    .AddLogicalGroupRules(BenchmarkLogicalGroupRule.ByCategory);

new BenchmarkSwitcher([typeof(SoA), typeof(AoS), typeof(Hybrid)])
    .RunAll(config.AddJob(job));
