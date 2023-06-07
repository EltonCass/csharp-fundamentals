// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson3
{
    internal static class StringsManagement
    {
        public static void NameTransformer(string name)
        {
            Console.WriteLine("Original Name is " + name);
            Console.WriteLine("The length of the string is " + name.Length);
            Console.WriteLine("Name in UpperCase is " + name.ToUpper());
            Console.WriteLine("Does Name contains \"os\"? " + name.Contains("os"));
            Console.WriteLine("Replace \"a\" with \"x\"? " + name.Replace("a", "x"));
            Console.WriteLine("Name substring from 0-2 is " + name.Substring(0, 2));
        }

        public static void PrintRandomFacts(string randomString, int randomNumber)
        {
            // Using + to concatenate values
            Console.WriteLine("😊 Fact #" + randomNumber + ": " + randomString);
            // Using string format
            Console.WriteLine(string.Format("😎 Fact #{0}: {1}", randomNumber, randomString));

            // Using string concat
            var factText = "🤣 Fact #" + randomNumber + ": ";
            Console.WriteLine(string.Concat(factText, randomString));
            // Using string interpolation *
            Console.WriteLine($"😢 Fact #{randomNumber}: {randomString}");
            // Using string interpolation with verbatim
            Console.WriteLine($@"
//////
😅 Fact #{randomNumber}: {randomString}
//////");
        }

        public static void CheckStringsAreTheSame(string a, string b)
        {
            if (a.ToLower() == b.ToLower())
            //if (a == b)
            {
                Console.WriteLine("Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
        }

        public static void CheckStringsAreEqual(string a, string b)
        {
            if (a.Equals(b, StringComparison.OrdinalIgnoreCase))
            //if (a.Equals(b)) 
            {
                Console.WriteLine("Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
        }

        public static void CompareStrings(string a, string b)
        {
            // a : Hello
            // b : Hello
            //if (string.CompareOrdinal(a, b) == 0)
            if (string.Compare(a, b) == 0) 
            {
                Console.WriteLine("Strings are equal");
            }
            else
            {
                Console.WriteLine("Strings are not equal");
            }
        }

        public static void ParseFromString()
        {
            // Specifying values as strings
            var enabledText = "true";
            //var enabledText = "undeterminated";
            var ageText = "10";
            var currentBalanceText = "3000.20m";

            // Parsing to data types
            var enabled = bool.Parse(enabledText);
            var age = int.Parse(ageText);
            var currentBalance = decimal.Parse(currentBalanceText);

            // Using tryParse
            var parseSuccess = bool.TryParse(enabledText, out bool enabled2);
        }
    }
}
