// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using Dumpify;

namespace Fundamentals.Lesson4
{
    public static class Arrays
    {
        public static int[] Numbers = new[] { 1, 10, 30, 4, 5, 63, 7, 8, 9 };

        public static void ArrayOperations()
        {
            var reversedArray = Numbers.Reverse();
            Console.WriteLine($"Original Array is {string.Join('|', Numbers)}");

            Console.WriteLine($"Reversed array : {string.Join('|', reversedArray)}");

            Console.WriteLine($"Sorted Array is {string.Join('|', Numbers.Order())}");
            
            Console.WriteLine($"Sum is {Numbers.Sum()}");

            Numbers.Dump();
        }

        public static void ModifyArray(int initialValue, int finalValue, int inBetweenValue)
        {
            //Numbers.Prepend(initialValue);
            //var num2 = Numbers.Prepend(initialValue);

            Numbers[0] = initialValue;
            //Numbers.Append(finalValue);
            Numbers[Numbers.Length -1] = finalValue;

            Numbers.SetValue(inBetweenValue, 2);

            "🏛".Dump();
            Numbers.Dump();
        }
    }
}
