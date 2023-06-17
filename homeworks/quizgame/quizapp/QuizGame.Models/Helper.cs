using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    internal static class Helper
    {
        internal static string EnumerableToString(IEnumerable<string> collection)
        {
            StringBuilder result = new StringBuilder();
            foreach (string choice in collection)
            {
                result.AppendLine(choice);
            }
            return result.ToString();
        }
    }
}
