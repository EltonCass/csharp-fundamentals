using Dumpify;

namespace Calculator;

public class Operator
{
    private static Dictionary<string, string> _memo = new Dictionary<string, string>();
    private static List<string> keyOrder = new List<string>();

    public Operator()
    {
        _memo.Clear();
        keyOrder.Clear();
    }

    public decimal Operation(string input)
    {
        var multiplicationDivision = new char[] { '*', '/' };
        var additionSubstraction = new char[] { '+' };
        var operations = multiplicationDivision.Concat(additionSubstraction).ToArray();
        input = input.Replace(" ", "");
        input = input.Replace("-", "+-");
        // best case
        var retrievedNumbersString = input.Split(operations, StringSplitOptions.RemoveEmptyEntries);

        // group operations
        var operationExpressions = new string[retrievedNumbersString.Length - 1];
        var startingPosition = 0;
        for (int i = 0; i < retrievedNumbersString.Length - 1; i++)
        {
            var endPosition = retrievedNumbersString[i].Length + retrievedNumbersString[i + 1].Length + 1;
            operationExpressions.SetValue(input
                .Substring(startingPosition, endPosition), i);
            startingPosition += retrievedNumbersString[i].Length + 1;
        }

        var temporalResults = new decimal[retrievedNumbersString.Length];
        var index = 0;
        for (int i = 0; i < operationExpressions.Length; i++)
        {
            var hasMultiplication = operationExpressions[i].Contains("*");
            if (hasMultiplication || operationExpressions[i].Contains("/"))
            {
                var numbers = operationExpressions[i].Split(multiplicationDivision);
                var partialResult = hasMultiplication
                    ? decimal.Parse(numbers[0]) * decimal.Parse(numbers[1])
                    : decimal.Parse(numbers[0]) / decimal.Parse(numbers[1]);
                if (i != operationExpressions.Length - 1)
                {
                    var commonNumber = $"{operationExpressions[i + 1]
                        .Split($"{retrievedNumbersString[i + 1]}").Last()}";
                    operationExpressions[i + 1] = $"{partialResult}{commonNumber}";
                }
                else
                {
                    temporalResults.SetValue(partialResult, index);
                    index++;
                }
            }
            else
            {
                var addingNumbers = operationExpressions[i].Split("+");
                if (i != operationExpressions.Length - 1)
                {
                    temporalResults.SetValue(decimal.Parse(addingNumbers.First()), index);
                }
                else
                {
                    temporalResults.SetValue(decimal.Parse(addingNumbers.First()), index);
                    index++;
                    temporalResults.SetValue(decimal.Parse(addingNumbers.Last()), index);
                }
                index++;
            }
        }

        var result = temporalResults.Sum();
        if (keyOrder.Count == 2)
        {
            string firstKey = keyOrder[0];
            _memo.Remove(firstKey);
            keyOrder.RemoveAt(0);
            _memo.Add(input, DateTime.Now.ToString());
            keyOrder.Add(input);
        }
        else
        {
            _memo.Add(input, DateTime.Now.ToString());
            keyOrder.Add(input);
        }
        return result;
    }
}
