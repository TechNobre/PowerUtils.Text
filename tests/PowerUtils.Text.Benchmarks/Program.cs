using BenchmarkDotNet.Running;
using PowerUtils.Text.Benchmarks.NetworkExtensionsBenchmarks;

internal class Program
{
    private static void Main(string[] _)
        => BenchmarkRunner.Run<CombineURLBenchmarks>();
}
