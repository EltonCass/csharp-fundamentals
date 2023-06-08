// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using Dumpify;

namespace Fundamentals.Lesson5
{
    internal static class Conversions
    {
        public static void ConvertTo()
        {
            var number = Convert.ToInt64("23");
            number.Dump();
            decimal @decimal = Convert.ToDecimal("23.4545");
            @decimal.Dump();
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

        public static void UserDefinedConversions()
        {
            var d = new Digit(7);

            byte number = d;
            number.Dump(); // output: 7

            Digit digit = (Digit)number;
            digit.Dump(); // output: 7
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
        private readonly byte _digit;

        public Digit(byte digit)
        {
            if (digit > 9)
            {
                throw new ArgumentOutOfRangeException(nameof(digit), "Digit cannot be greater than nine.");
            }
            _digit = digit;
        }

        public static implicit operator byte(Digit d) => d._digit;
        public static explicit operator Digit(byte b) => new Digit(b);

        public override string ToString() => $"{_digit}";
    }
}
