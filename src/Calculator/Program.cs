﻿object[,] records = new object[2, 3];

for (int i = 0; i < 2; i++)
{
    Console.Write("Enter a mathematical expression: ");
    string expression = Console.ReadLine();

    double result = EvaluateExpression(expression);
    Console.WriteLine("Result: " + result);

    records[i, 0] = result;
    records[i, 1] = expression;
    records[i, 2] = DateTime.Now;
}

int rowCount = records.GetLength(0);
int columnCount = records.GetLength(1);

for (int i = 0; i < rowCount; i++)
{
    for (int j = 0; j < columnCount; j++)
    {
        Console.Write(records[i, j] + "\t");
    }
    Console.WriteLine();
}

static double EvaluateExpression(string expression)
{
    double result = 0;
    double currentNumber = 0;
    int currentDecimal = 0;
    char lastOperator = '+';
    int breakpoint = 0;
    int operatorCounter = 0;
    bool isDecimal = false;
    string subExpression;

    int expressionLength = expression.Length;
    for (int i = 0; i < expressionLength; i++)
    {
        var c = expression[i];
        if (char.IsDigit(c))
        {
            if (isDecimal)
            {
                currentDecimal = currentDecimal * 10 + (c - '0');
            }
            else
            {
                currentNumber = currentNumber * 10 + (c - '0');
            }
        }
        else if (c == '.')
        {
            isDecimal = true;
        }
        else
        {
            if ((c == '*' || c == '/') && operatorCounter > 0)
            {
                if (expression[breakpoint] == '*' || expression[breakpoint] == '/')
                {
                    subExpression = expression[(breakpoint + 1)..];
                }
                else
                {
                    subExpression = expression[breakpoint..];
                }
                currentNumber = EvaluateExpression(subExpression);
                isDecimal = false;
                lastOperator = (lastOperator == '-') ? '+' : lastOperator;
                i = expressionLength;
            }
            else
            {
                ApplyOperator(ref isDecimal, ref result, ref currentNumber, ref currentDecimal, lastOperator);
                lastOperator = c;
                operatorCounter = (i != 0 && c != '*' && c != '/') ? operatorCounter + 1 : operatorCounter;
                breakpoint = i;
            }
        }
    }

    ApplyOperator(ref isDecimal, ref result, ref currentNumber, ref currentDecimal, lastOperator);

    return result;
}

static void ApplyOperator(ref bool isDecimal, ref double result, ref double currentNumber, ref int currentDecimal, char lastOperator)
{
    if (isDecimal)
    {
        double.TryParse(currentNumber + "." + currentDecimal, out currentNumber);
        isDecimal = false;
    }

    currentNumber = (lastOperator == '-') ? 0 - currentNumber : currentNumber;

    if (lastOperator == '*')
    {
        result *= currentNumber;
    }
    else if (lastOperator == '/')
    {
        result /= currentNumber;
    }
    else
    {
        result += currentNumber;
    }

    currentNumber = 0;
    currentDecimal = 0;
}