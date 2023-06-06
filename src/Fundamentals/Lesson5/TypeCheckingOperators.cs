// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

public static class TypeCheckingOperators
{
    public static void UsingTypeOf()
    {
        // Local method
        void PrintType<T>() => Console.WriteLine(typeof(T));

        Console.WriteLine(typeof(List<string>)); // System.Collections.Generic.List`1[System.String]
        PrintType<int>(); // System.Int32
        PrintType<System.Int32>(); // System.Int32
        PrintType<Dictionary<int, char>>(); // System.Collections.Generic.Dictionary`2[System.Int32,System.Char]
        Console.WriteLine(typeof(Dictionary<,>));
    }
}