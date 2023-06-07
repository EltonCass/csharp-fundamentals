// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;

namespace Benchmarks
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class FibonacciPerformance
    {
        [Benchmark]
        public static int FibonacciFor(int inputNum = 8)
        {
            if (inputNum <= 0) return 0;
            if (inputNum <= 2) return 1;

            int result = 0;
            int prev = 0;
            int next = 1;

            for (int counter = 2; counter <= inputNum; counter++)
            {
                result = prev + next;
                prev = next;
                next = result;
            }
            return result;
        }

        [Benchmark]
        public static int FibonacciRecursive(int position = 6)
        {
            if (position <= 1)
            {
                return position;
            }

            return FibonacciRecursive(position - 1) + FibonacciRecursive(position - 2);
        }
    }
}
