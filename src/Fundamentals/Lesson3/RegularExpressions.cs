// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using System.Text.RegularExpressions;

namespace Fundamentals.Lesson3
{
    public static class RegularExpressions
    {
        private const string _Pattern = @"([+\-*/])";

        public static bool RegexIsMatch(string input = "1/2")
        {
            return Regex.IsMatch(input, _Pattern, RegexOptions.Multiline);
        }

        public static string[] SplitByRegexMatched(string input = "1/2")
        {
            return Regex.Split(input, _Pattern);
        }
    }
}
