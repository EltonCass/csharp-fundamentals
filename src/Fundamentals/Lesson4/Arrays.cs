// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Lesson4
{
    internal static class Arrays
    {
        public static int[] numbers = new[] { 1, 10, 30, 4, 5, 63, 7, 8, 9 };

        public static void ArrayOperations()
        {
            var reversedArray = numbers.Reverse();
            Console.WriteLine($"Original Array is {string.Join('|', numbers)}");

            Console.WriteLine($"Reversed array : {string.Join('|', reversedArray)}");

            Console.WriteLine($"Sorted Array is {string.Join('|', numbers.Order())}");
            
            Console.WriteLine($"Sum is {numbers.Sum()}");
        }

        public static void ModifyArray()
        {
            numbers.Append(100);
            numbers.Prepend(200);

            numbers.SetValue(-3, 2);
        }
    }
}
