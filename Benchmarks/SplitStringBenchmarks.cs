// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Fundamentals.Lesson3;

namespace Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class SplitStringBenchmarks
    {
        [Benchmark]
        public void RegularExpressionBenchmark()
        {
            RegularExpressions.SplitByRegexMatched("1+4*4/34");
        }

        [Benchmark]
        public void StringMemberSplitBenchmark()
        {
            var operations = new char[] { '+', '*', '/' };
            "1+4*4/34".Split(operations);
        }
    }
}
