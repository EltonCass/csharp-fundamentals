// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson2
{
    internal static class Statements
    {
        public static void UsingVariables()
        {
            int year; // Declaration
            year = 2023; // Assignment
            //year = "2023";
            Console.WriteLine($"Variable ({nameof(year)}) declared, with type ({year.GetType()}) and value ({year})");

            int age = 29; // Declaration and assignment
            Console.WriteLine($"Variable ({nameof(age)}) declared, with type ({age.GetType()}) and value ({age})");
        }

        public static void UsingConstants()
        {
            // ### Constants
            double constantPi = Constants.Pi;
            // Syntaxis.Constants.Pi = 3;
            double constantGravity = Constants.Gravity;
            Constants.Gravity = 9.72;
            Console.WriteLine($"Gravity is {Constants.Gravity}");
        }

        public static void DoOperations()
        {
            Console.WriteLine($"Current value: {Constants.Gravity++}");
            Console.WriteLine($"Post adding {Constants.Gravity++}");
            Console.WriteLine($"Pre adding {++Constants.Gravity}");
            Console.WriteLine($"Is Gravity greater than 10? {Constants.Gravity > 10}");
        }

        public static void UsingImplicitTyping()
        {
            var name = "Robert White";
            //name = 11;
            name = "Robert Borh";
            Console.WriteLine($"Variable ({nameof(name)}) declared, with type ({name.GetType()}) and value ({name})");
        }
    }
}
