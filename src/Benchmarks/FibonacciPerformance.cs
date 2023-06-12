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
        [Params(1, 10, 50)]
        public int Position { get; set; }

        [Benchmark]
        public int FibonacciFor()
        {
            if (Position <= 0) return 0;
            if (Position <= 2) return 1;

            int result = 0;
            int prev = 0;
            int next = 1;

            for (int counter = 2; counter <= Position; counter++)
            {
                result = prev + next;
                prev = next;
                next = result;
            }
            return result;
        }

        [Benchmark]
        public int RecursiveFibonacci()
        {
            return Fibonacci(Position);
        }

        [Benchmark]
        public int FibonacciMemoization()
        {
            return Fundamentals.Lesson2.T2.MemoFibonacci(Position);
        }

        private int Fibonacci(int position)
        {
            if (position <= 1)
            {
                return position;
            }

            return Fibonacci(position - 1) + Fibonacci(position - 2);
        }
    }
}
