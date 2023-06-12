// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson8
{
    public static class NullChecking
    {
        public static void Operators(bool condition)
        {
            // Ternary operator
            var message = condition ? "Condition Exists" : "Condition Does not Exists";
            Console.WriteLine(message);

            string? name = null;
            string displayName = name ?? "Unknown";
            // If name is null, assign "Unknown" to displayName
            Console.WriteLine($"Null Coalescing: {nameof(displayName)} is {displayName}");

            // Null conditional
            int? nameLength = name?.Length;
            Console.WriteLine($"Null Conditional: {nameof(nameLength)} is {nameLength}");

            // Null coalescing assignment
            string? lastName = null;
            lastName ??= "White";
            Console.WriteLine($"Null Coalescing assignment: {nameof(lastName)} is {lastName}");

            // Null forgiving operator
            string? nullableName = null;
            try
            {
                int nullableNameLength = nullableName!.Length;
                Console.WriteLine($"Null forgiving operator: Length is {nullableNameLength}");
            }
            catch (Exception)
            {
                Console.WriteLine("Gracefully handling exception");
                throw;
            }
            
        }
    }
}
