using System;
using System.Runtime.ExceptionServices;
using Microsoft.CodeAnalysis.CSharp.Scripting;
class Calculator
{

	static Dictionary<string, int> results = new Dictionary<string, int>();
	static void Main(string[] args)
	{
		string expression = "10-4/2*7*3"; //105/273
										  //int result = EvaluateExpression2(expression);
		int result2 = EvaluateExpression(expression);
		Console.WriteLine("El resultado es: " + result2);
	}

	static int EvaluateExpression(string expression)
	{
		var options = Microsoft.CodeAnalysis.Scripting.ScriptOptions.Default.AddReferences(typeof(int).Assembly);
		var result = CSharpScript.EvaluateAsync<int>(expression, options).Result;
		return result;
	}

	static int EvaluateExpression2(string expression)
	{
		expression = expression.Replace(" ", "");
		Console.WriteLine("Expresion length: " + expression.Length);
		string[] multiplicationAndDivision = expression.Split('+', '-');
		for (int i = 0; i < multiplicationAndDivision.Length; i++)
		{
			Console.WriteLine("MultipuicationAndDivision: " + multiplicationAndDivision[i]);
		}
		int result = EvaluateMultiplicationAndDivision(multiplicationAndDivision[0]);
		Console.WriteLine("Result " + result);

		for (int i = 1; i < multiplicationAndDivision.Length; i++)
		{
			//char operation = expression[multiplicationAndDivision[i - 1].Length];
			char operation = expression[(i - 1) * 3 + multiplicationAndDivision[i - 1].Length];
			Console.WriteLine("Operation: " + operation);

			int operand = EvaluateMultiplicationAndDivision(multiplicationAndDivision[i]);
			Console.WriteLine("Operand: " + operand);

			if (operation == '+')
				result += operand;
			else if (operation == '-')
				result -= operand;
		}
		return result;
	}

	static int EvaluateMultiplicationAndDivision(string expression)
	{
		int result = 0;
		string[] numbers = expression.Split('*', '/');
		for (int i = 0; i < numbers.Length; i++)
		{
			Console.WriteLine("Numbers: " + numbers[i]);
		}

		if (!int.TryParse(numbers[0], out result))
			throw new ArgumentException("Expresión inválida: " + expression);

		for (int i = 1; i < numbers.Length; i++)
		{
			char operation = expression[(i - 1) * 2 + numbers[i - 1].Length];
			int operand;

			if (!int.TryParse(numbers[i], out operand))
				throw new ArgumentException("Expresión inválida: " + expression);

			if (operation == '*')
				result *= operand;
			else if (operation == '/')
				result /= operand;
		}
		Console.WriteLine("REsult operations: " + result);
		return result;
	}
}
