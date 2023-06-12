// Copyright (c) 2023  Elton Cassas. All rights reserved.
// See LICENSE.txt

using Dumpify;

namespace Fundamentals.Lesson4
{
    internal static class UsingObjects
    {
        public static void PrintInput(object input)
        {
            Console.WriteLine($"The input is: {input}");
            Console.WriteLine($"The hashcode is: {input.GetHashCode()}");
            Console.WriteLine($"The type is: {input.GetType()}");

            input.Dump();
        }

        public static void PrintInputs(object[] inputs) 
        {
            Console.WriteLine($"The array is: {string.Join(',', inputs)}");
            Console.WriteLine($"The count is: {inputs.Length}");
        }
    }
}
