// Copyright (c) 2023  Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson4
{
    internal static class Dynamic
    {
        public static void UseAsString(dynamic text)
        {
            var chars = string.Join(',', text.ToCharArray());
            Console.WriteLine(chars);
        }

        public static void PrintMe(dynamic value)
        {
            // dynamic and object both use the same structure but different resolution times
            Console.WriteLine($"PrintMe -dynamic- called with value: {value}");
        }

        //public static void PrintMe(object value)
        //{
        // dynamic and object both use the same structure but different resolution times,
        // that is why this does not count as overload
        //    Console.WriteLine($"PrintMe -object- called with value: {value}");
        //}
    }
}
