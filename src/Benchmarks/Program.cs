// Copyright (c)  Elton Cassas. All rights reserved.
// See LICENSE.txt

using BenchmarkDotNet.Running;

namespace Benchmarks
{
    internal class Program
    {
        static void Main(string[] _)
        {
            BenchmarkRunner.Run<SplitStringBenchmarks>();
            // BenchmarkRunner.Run<FibonacciPerformance>();
        }
    }
}