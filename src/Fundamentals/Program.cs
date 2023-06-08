// Copyright (c) 2023 Elton Cassas Aguayo. All rights reserved.
// See LICENSE.txt

global using Fundamentals.Lesson2;
global using Fundamentals.Lesson3;
global using Fundamentals.Lesson4;
global using Fundamentals.Lesson5;
using Dumpify;

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

// ## Statements

//ExecuteLesson2();
// ExecuteLesson3();
//ExecuteLesson4();
ExecuteLesson5();
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
    PrintLessonArtIntro(5);
    // Debug Code
    "✅ Boxing and Unboxing".Dump();
    Boxing.BoxingAPrimitive();
    Boxing.AbstractArrayList();
    "✅ Conversions".Dump();
    Conversions.ConvertTo();
    Conversions.SafeParse("true", Types.boolean);
    Conversions.SafeParse("1", Types.integer);
    Conversions.SafeParse("2324.34", Types.doublet);

    Conversions.UserDefinedConversions();
    "✅ TypeChecking".Dump();
    TypeCheckingOperators.UsingTypeOf();
    TypeCheckingOperators.UsingIsAndAs();
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