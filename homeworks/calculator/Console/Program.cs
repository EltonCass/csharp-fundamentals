using Calculator;
using Validator;
using System;

Operator calculator = new Operator();
Class1 validator = new Class1();
string input = "";

try
{
    while(!input.Equals("0"))
    {
        Console.WriteLine("Please enter an operation: ");
        input = Console.ReadLine();
        validator.validate(input);
        decimal output = calculator.Operation(input);
        Console.WriteLine($"The result of the operation is: {output}");
    }

}
catch(Exception e)
{
    Console.WriteLine("There is an error: ", e.Message);
}