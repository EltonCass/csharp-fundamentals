// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using System.Text.RegularExpressions;

namespace Fundamentals.Lesson3
{
    internal static class RegularExpressions
    {
        private const string _Pattern = "[+-*/]+?";

        public static void RegexIsMatch(string input = "1/2")
        {
            var isMatch = Regex.IsMatch(input, _Pattern);
            var matchedString = Regex.Match(input, _Pattern);

            Regex.
        }


    }
}
