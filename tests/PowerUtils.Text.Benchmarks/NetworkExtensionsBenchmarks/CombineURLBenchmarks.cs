using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace PowerUtils.Text.Benchmarks.NetworkExtensionsBenchmarks
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class CombineURLBenchmarks
    {
        private const string BASE_URL = "http://localhost";

        private readonly string[] _segments = new string[] { "fake1", "fake2", "fake3" };


        [Benchmark(Baseline = true)]
        public void CombineURL_Implementation()
            => NetworkExtensions.CombineURL(BASE_URL, _segments);


        [Benchmark]
        public void CombineURL_WithURLAndForeach()
            => _combineURL_WithURLAndForeach(BASE_URL, _segments);

        private static string _combineURL_WithURLAndForeach(string root, params string[] segments)
        {
            if(string.IsNullOrWhiteSpace(root))
            {
                throw new ArgumentException("The root URL cannot be null or WhiteSpace", nameof(root));
            }

            if(segments == null || segments.Length == 0)
            {
                return root;
            }

            var uri = new Uri(root);

            foreach(var segment in segments)
            {
                if(string.IsNullOrWhiteSpace(segment))
                {
                    continue;
                }

                uri = new Uri(uri, segment);
            }

            return uri.AbsoluteUri;
        }



        [Benchmark]
        public void CombineURL_WithURLAndFor()
            => _combineURL_WithURLAndFor(BASE_URL, _segments);

        private static string _combineURL_WithURLAndFor(string root, params string[] segments)
        {
            if(string.IsNullOrWhiteSpace(root))
            {
                throw new ArgumentException("The root URL cannot be null or WhiteSpace", nameof(root));
            }

            if(segments == null || segments.Length == 0)
            {
                return root;
            }

            var uri = new Uri(root);

            for(var count = 0; count < segments.Length; count++)
            {
                if(string.IsNullOrWhiteSpace(segments[count]))
                {
                    continue;
                }

                uri = new Uri(uri, segments[count]);
            }

            return uri.AbsoluteUri;
        }
    }
}
