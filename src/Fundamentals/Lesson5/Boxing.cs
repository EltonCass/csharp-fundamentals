// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using Dumpify;
using System.Collections;

namespace Fundamentals.Lesson5
{
    internal static class Boxing
    {
        public static void BoxingAPrimitive()
        {
            int number = 10; // Value type

            // Boxing: Converting a value type to an object reference
            object boxedNumber = number;

            // Unboxing: Converting an object reference back to a value type
            int unboxedNumber = (int)boxedNumber;

            $"Boxed Number: { boxedNumber}".Dump();
            boxedNumber.Dump();
            $"Unboxed Number: {unboxedNumber}".Dump();
        }

        public static void AbstractArrayList()
        {
            ArrayList list = new ArrayList();

            // Adding different types of data to the ArrayList
            list.Add("John");         // Adding a string (reference type)
            list.Add(25);             // Adding an int (value type, gets boxed)
            list.Add(DateTime.Now);   // Adding a DateTime (value type, gets boxed)

            // Accessing and casting the elements from the ArrayList
            string name = (string)list[0];           // Casting to string
            int age = (int)list[1];                  // Unboxing and casting to int
            DateTime date = (DateTime)list[2];       // Unboxing and casting to DateTime

            $"Name: {name}".Dump();
            $"Age: {age}".Dump();
            $"Date: {date}".Dump();

            list.Dump();
        }
    }
}
