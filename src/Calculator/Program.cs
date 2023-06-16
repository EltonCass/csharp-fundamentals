using Calculator;

Evaluator evaluator = new Evaluator();

Console.Write("How many expressions do you need to evaluate? ");
int.TryParse(Console.ReadLine(), out int recordsAmount);

RecordManager recordManager = new RecordManager(recordsAmount);

for (int i = 0; i < recordsAmount; i++)
{
    Console.Write("Enter a mathematical expression: ");
    string expression = Console.ReadLine();

    double result = evaluator.EvaluateExpression(expression);
    Console.WriteLine("Result: " + result);

    Record record = new Record(result, expression, DateTime.Now);
    recordManager.AddRecord(record, i);
}

recordManager.PrintRecords();
