// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

using Dumpify;
using Fundamentals.Lesson6;

public static class TypeCheckingOperators
{
    public static void UsingTypeOf()
    {
        // Local method
        void PrintType<T>() => typeof(T).Dump();

        typeof(List<string>).Dump(); // System.Collections.Generic.List`1[System.String]
        PrintType<int>(); // System.Int32
        PrintType<System.Int32>(); // System.Int32
        PrintType<Dictionary<int, char>>(); // System.Collections.Generic.Dictionary`2[System.Int32,System.Char]
        Console.WriteLine(typeof(Dictionary<int, char>));
        typeof(Dictionary<,>).Dump();
        Console.WriteLine(typeof(Dictionary<,>));
    }

    public static void UsingIsAndAs()
    {
        var dog = new Dog();
        $"Is Dog an animal {(dog is Animal)}".Dump();

        object stringExampleObj = "Example";
        $"Is {nameof(stringExampleObj)} a string? {stringExampleObj is string}".Dump();

        object obj = "1";
        var text = obj as string;
        if (text is not null)
        {
            $"The object is a string: {text}".Dump();
        }
        else
        {
            "The object is not a string.".Dump();
        }
    }
}