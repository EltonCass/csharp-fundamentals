// Copyright (c)  Elton Cassas. All rights reserved.
// See LICENSE.txt

using BenchmarkDotNet.Running;
using Fundamentals.Lesson6;

namespace Benchmarks
{
    internal class Program
    {
        static void Main(string[] _)
        {
            BenchmarkRunner.Run<SplitStringBenchmarks>();
            //BenchmarkRunner.Run<FibonacciPerformance>();

            var cat = new Animal();
            var dog = new Dog();

            //var catAge = cat.Age;
            //cat.Grow(3);
            dog.UpdateAge(5);
        }
    }
}