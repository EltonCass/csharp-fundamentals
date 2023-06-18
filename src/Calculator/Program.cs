using Calculator;
using Calculator.Exceptions;
using System.Text.RegularExpressions;

int recordsAmount;
RecordManager recordManager;

while (true)
{
    try
    {
        Console.Write("How many expressions do you need to evaluate? ");
        recordsAmount = Convert.ToInt32(Console.ReadLine());
        recordManager = new RecordManager(recordsAmount);
        break;
    }
    catch (FormatException ex)
    {
        // throw new NotIntException(ex.Message, ex);
        Console.WriteLine("The input provided is not an integer. Please try again.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The input provided is not positive. Please try again.");
    }
}

Evaluator evaluator = new Evaluator();
Validator validator = new Validator();

for (int i = 0; i < recordsAmount; i++)
{
    try
    {
        Console.Write("Enter a mathematical expression: ");
        string expression = Console.ReadLine();
        validator.ValidateExpression(expression);

        double result = evaluator.EvaluateExpression(expression);
        Console.WriteLine("Result: " + result);

        Record record = new Record(result, expression, DateTime.Now);
        recordManager.AddRecord(record, i);
    }
    catch (InvalidExpressionException)
    {
        Console.WriteLine("The expression must contain only numbers and operators (+ - * /). It also must begin and end with a number. Please try again.");
        i--;
    }
    catch (DivideByZeroException)
    {
        Console.WriteLine("Divisions by zero cannot be evaluated. Please try again.");
        i--;
    }
}

recordManager.PrintRecords();
