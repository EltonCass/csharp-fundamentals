// Copyright (c) 2023 Elton Cassas Aguayo. All rights reserved.
// See LICENSE.txt

global using Fundamentals.Lesson2;
global using Fundamentals.Lesson3;
global using Fundamentals.Lesson4;
global using Fundamentals.Lesson5;
using Dumpify;
using Dumpify.Config;
using Fundamentals.Lesson6;
using Fundamentals.Lesson6.Namespaces;
using Fundamentals.Lesson7;
using Fundamentals.Lesson8;
using MergeSortExample;
using System.Drawing;

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
// ExecuteLesson4();
// ExecuteLesson5();
// ExecuteLesson6();
// ExecuteLesson7();
// ExecuteLesson8();
UseAFSharpMergeSort();

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
    //Arrays.ArrayOperations();
    //Arrays.ModifyArray(100, 30, -4);
    //Enums.UsingEnums();
    //UsingObjects.PrintInput(DateTime.Now);
    //UsingObjects.PrintInput("Example");
    //UsingObjects.PrintInputs(new object[] { 2.13, 42.5, 44.2 });
    //UsingObjects.PrintInputs(new object[] { 2.13, "example", true });
    Dynamic.UseAsString("String");
    Dynamic.UseAsString(45);
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
    PrintLessonArtIntro(6);
    "✅ Namespaces".Dump();
    var lesson6 = new Example();
    lesson6.PrintEmployee();

    Example.PrintMathContent();
    "✅ AccessModifiers".Dump();
    var animalType = typeof(Animal);
    var nonPublicAnimalProperties = animalType
        .GetProperties(
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
        .Select(p => new {
            p.Name,
            IsGetAccessorPrivate = p.GetMethod?.IsPrivate,
            IsSetAccessorPrivate = p.SetMethod?.IsPrivate
        });
    nonPublicAnimalProperties.Dump();
    var dogType = typeof(Dog);
    var nonPublicDogProperties = dogType
        .GetProperties(
            System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
    nonPublicDogProperties[0].Dump();
}

static void ExecuteLesson7()
{
    PrintLessonArtIntro(7);
    "✅ Exceptions".Dump();
    var redColor = new ColorConfig { PropertyValueColor = new DumpColor(Color.Red) };
    try
    {
        TryCatch.WriteToFile();
    }
    catch (PathNotFoundException ex)
    {
        
        Console.WriteLine($"Exception details: {ex.Message}");
        ex.StackTrace.Dump(colors: redColor);
        Console.WriteLine($"Inner exception details");
        ex.InnerException?.Message.Dump(colors: redColor);
        ex.InnerException?.StackTrace.Dump(colors: redColor);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Exception details: {ex.Message}");
        ex.StackTrace.Dump(colors: redColor);
        Console.WriteLine($"Inner exception details");
        ex.InnerException?.Message.Dump(colors: redColor);
        ex.InnerException?.StackTrace.Dump(colors: redColor);
    }
    
}

static void ExecuteLesson8()
{
    PrintLessonArtIntro(8);
    "✅ Default data types".Dump();
    var defaultTpes = new DefaultDataTypeValues();
    defaultTpes.PrintDefaultValues();

    "✅ Null checking operators".Dump();
    NullChecking.Operators(true);

    "✅ Null object patterm".Dump();
    NullableObject.GetCustomers();
}

static void UseAFSharpMergeSort()
{
    "✅ Using FSharp algorithm".Dump();
    var numbers = new List<int> { 5, 2, 8, 1, 9, 3, 4, 10, 11 };

    // Call the MergeSort function from F# by converting the list to an F# list
    var sortedNumbers = MergeSort.mergeSort(MergeSort.fsharpList(numbers));

    // Print the sorted numbers
    foreach (var number in sortedNumbers)
    {
        Console.WriteLine(number);
    }
}

static void PrintLessonArtIntro(int lessonNumber) => Console.WriteLine(@$" Lesson {lessonNumber}
▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄
██░▄▄░█░▄▄█▄░▄████░▄▄▀█░▄▄█░▄▄▀█░▄▀█░██░
██░█▀▀█░▄▄██░█████░▀▀▄█░▄▄█░▀▀░█░█░█░▀▀░
██░▀▀▄█▄▄▄██▄█████░██░█▄▄▄█▄██▄█▄▄██▀▀▀▄
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
");
#endregion