// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson5
{
    internal static class Converters
    {
        public static void ConvertTo()
        {
            var number = Convert.ToInt64("23");
        }

        public static void UserDefinedConversions()
        {
            var d = new Digit(7);

            byte number = d;
            Console.WriteLine(number);  // output: 7

            Digit digit = (Digit)number;
            Console.WriteLine(digit);  // output: 7
        }

        public static void SafeParse(string value, Types type)
        {
            switch (type)
            {
                case Types.integer:
                    int.TryParse(value, out int result);
                    Console.WriteLine(result);
                    break;
                case Types.boolean:
                    bool.TryParse(value, out bool boolResult);
                    Console.WriteLine(boolResult);
                    break;
                case Types.doublet:
                    Console.WriteLine(Convert.ToDouble(value));
                    break;
            }
        }
    }

    enum Types
    {
        integer,
        boolean,
        doublet
    }

    public readonly struct Digit
    {
        private readonly byte digit;

        public Digit(byte digit)
        {
            if (digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit), "Digit cannot be greater than nine.");
            }
            this.digit = digit;
        }

        public static implicit operator byte(Digit d) => d.digit;
        public static explicit operator Digit(byte b) => new Digit(b);

        public override string ToString() => $"{digit}";
    }
}
