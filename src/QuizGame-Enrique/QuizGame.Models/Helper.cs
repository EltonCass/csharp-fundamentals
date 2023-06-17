using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame.Models
{
    internal class Helper
    {
        internal static string CollectionToString(IEnumerable<string> collection)
        {
            StringBuilder result = new StringBuilder();
            foreach (var choice in collection)
            {
                result.AppendLine(choice);
            }
            return result.ToString();
        }
    }
}
