// Copyright (c) 2023 Elton Cassas Aguayo. All rights reserved.
// See LICENSE.txt

global using Fundamentals.Lesson2;
global using Fundamentals.Lesson3;
global using Fundamentals.Lesson4;
global using Fundamentals.Lesson5;
global using Fundamentals.Lesson6;
global using Fundamentals.Lesson7;
global using Fundamentals.Lesson8;

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
};

Console.OutputEncoding = System.Text.Encoding.Unicode;

// ## Comments
// Single Line Comment

/*  This 
    is 
    a 
    Multi 
    Line 
    Comment
*/

// ## Statements
PrintLessonArtIntro(2);
int year; // Declaration
year = 2023; // Assignment
//year = "2023"; // This will result in error

int age = 29; // Declaration and assignment

// ### Constants
double constantPi = Fundamentals.Lesson2.Constants.Pi;
// Syntaxis.Constants.Pi = 3;
double constantGravity = Fundamentals.Lesson2.Constants.Gravity;
Fundamentals.Lesson2.Constants.Gravity = 9.72;

// ## Operations
Console.WriteLine("Post adding");
Console.WriteLine(Constants.Gravity++);
Console.WriteLine("Pre adding");
Console.WriteLine(++Constants.Gravity);
Console.WriteLine("Is Gravity greater than 10?");
Console.WriteLine(Constants.Gravity > 10);

// ## Implicit typing
var name = "Robert White";
//name = 11; // This will result in error since the data type is a string
name = "Robert Borh";
Console.WriteLine(name);

//ExecuteLesson2();
//ExecuteLesson3();
//ExecuteLesson4();
//ExecuteLesson5();
//ExecuteLesson6();
//ExecuteLesson7();
//ExecuteLesson8();

Console.ReadKey();

#region Helpers
static void ExecuteLesson2()
{
    PrintLessonArtIntro(2);
    // Debug Code
    Statements.UsingVariables();
    Statements.UsingConstants();
    Statements.DoOperations();
    Statements.UsingImplicitTyping();

    LoopsAndConditionals.Conditionals(true);
    LoopsAndConditionals.Conditionals(true, false);
    LoopsAndConditionals.CountFrom2000To2010();
    LoopsAndConditionals.CountUntil2010(2000);
    LoopsAndConditionals.PrintEachOddCharacter("This is a test sample");

    Methods.CalculateYearlyIncome(20000, 0.2333);
    Methods.CalculateYearlyIncome(20000, 0.023, 0.01);
    Methods.Factorial(6);
}

static void ExecuteLesson3()
{
    PrintLessonArtIntro(3);
    // Debug Code

    DataTypes.UsingBuiltInDataTypes();
    DataTypes.CalculateBMI(100f, 1.8f);
    DataTypes.UsingDateTime();
    DataTypes.UsingTimeSpan();

    StringsManagement.NameTransformer("Luis Lorenzt");
    StringsManagement.PrintRandomFacts("You need 4 weeks of testing yourself to understand the base of a concept", new Random().Next());

    StringsManagement.CompareStrings("C# introduction", "C# INTRODUCTION");
    StringsManagement.CheckStringsAreTheSame("C# introduction", "C# INTRODUCTION");
    StringsManagement.CheckStringsAreEqual("C# introduction", "C# INTRODUCTION");

    RegularExpressions.RegexIsMatch();
}

static void ExecuteLesson4()
{
    PrintLessonArtIntro(4);
    // Debug Code
    Arrays.ArrayOperations();
    Arrays.ModifyArray(100, 30, -4);
    Enums.UsingEnums();
    UsingObjects.PrintInput(DateTime.Now);
    UsingObjects.PrintInputs(new object[] { 2.13, 42.5, 44.2 });
    Dynamic.UseAsString("String");
}

static void ExecuteLesson5()
{

}

static void ExecuteLesson6()
{

}

static void ExecuteLesson7()
{

}

static void ExecuteLesson8()
{

}

static void PrintLessonArtIntro(int lessonNumber) => Console.WriteLine(@$" Lesson {lessonNumber}
▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
██░▄▄░█░▄▄█▄░▄████░▄▄▀█░▄▄█░▄▄▀█░▄▀█░██░
██░█▀▀█░▄▄██░█████░▀▀▄█░▄▄█░▀▀░█░█░█░▀▀░
██░▀▀▄█▄▄▄██▄█████░██░█▄▄▄█▄██▄█▄▄██▀▀▀▄
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
#endregion