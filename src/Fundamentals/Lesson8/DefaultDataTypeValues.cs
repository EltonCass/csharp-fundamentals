// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson8
{
    internal class DefaultDataTypeValues
    {
        internal bool Boolean { get; set; }
        internal int Age { get; set; }
        internal char Single { get; set; }
        internal char[] Chars { get; set; }
        internal string Name { get; set; }

        public void PrintDefaultValues()
        {

            Console.WriteLine(Boolean);
            Console.WriteLine(Age);
            Console.WriteLine(Single);
            Console.WriteLine(Chars);
            Console.WriteLine(Name);
        }
    }
}
