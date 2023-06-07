// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

var initialized = false;
using var cts = new CancellationTokenSource();

Console.CancelKeyPress += (s, e) =>
{
    Console.WriteLine();
    var beforeColor = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("Cancelling...");
    Console.ForegroundColor = beforeColor;
    Console.WriteLine();
    cts.Cancel();

    if (initialized)
    {
        e.Cancel = false;
    }
};

Console.OutputEncoding = System.Text.Encoding.Unicode;

try
{
    Console.OutputEncoding = System.Text.Encoding.Unicode;

    initialized = true;

}
catch (OperationCanceledException)
{
    Console.WriteLine();
    Console.WriteLine("Canceled: Press Any key to exit.");
    Console.ReadKey();
}

//DoOperation("23+34*34");
//DoOperation("23 +34* 3 /8");
//DoOperation("23*34+ 3 /8");
DoOperation("23*34+ 3 /8 + 33-2");
Console.ReadLine();

static void DoOperation(string input)
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

    var temporalResults = new int[retrievedNumbersString.Length];
    var index = 0;
    for (int i = 0; i < operationExpressions.Length; i++)
    {
        var hasMultiplication = operationExpressions[i].Contains("*");
        if (hasMultiplication || operationExpressions[i].Contains("/"))
        {
            var numbers = operationExpressions[i].Split(multiplicationDivision);
            var partialResult = hasMultiplication
                ? int.Parse(numbers[0]) * int.Parse(numbers[1])
                : int.Parse(numbers[0]) / int.Parse(numbers[1]);
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
                temporalResults.SetValue(int.Parse(addingNumbers.First()), index);
            }
            else
            {
                temporalResults.SetValue(int.Parse(addingNumbers.First()), index);
                index++;
                temporalResults.SetValue(int.Parse(addingNumbers.Last()), index);
            }
            index++;
        }
    }

    var result = temporalResults.Sum();

    Console.WriteLine(result);
}
