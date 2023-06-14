using Math;
using System;

Calculator calculator = new Calculator();

string[] inputs = { "word", "word csharp 25", "25+36*8"};

foreach (string input in inputs)
{
    try
    {
        calculator.Operation(input);
        Console.WriteLine("----------");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"An error has occurred: {ex.Message}");
        Console.WriteLine("Try again with other operation");
    }
}

//calculator.Operation("23*34+ 3 /8 + 33");
//Console.WriteLine("----------");
//calculator.Operation("23*34+ 3 /8 + 33-1");
//Console.WriteLine("----------");
//calculator.Operation("23*34+ 3 /8 + 33-5");