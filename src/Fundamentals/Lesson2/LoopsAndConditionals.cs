// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson2
{
    internal static class LoopsAndConditionals
    {
        public static void Conditionals(bool condition)
        {
            if (condition)
            {
                Console.WriteLine("This is printed when true");
            }
            else 
            {
                Console.WriteLine("This is printed when false");
            }
        }

        public static void Conditionals(bool condition1, bool condition2)
        {
            if (condition1 && condition2)
            {
                Console.WriteLine("Both conditions are true");
            }
            else if (condition1 && !condition2)
            {
                Console.WriteLine("Condition 1 is true");
            }
            else if (!condition1 && condition2)
            {
                Console.WriteLine("Condition 2 is true");
            }
            else
            {
                Console.WriteLine("Both conditions are false");
            }

            //int combinedValue = (condition1 ? 1 : 0) + (condition2 ? 2 : 0);
            //switch (combinedValue)
            //{
            //    case 0:
            //        Console.WriteLine("Both conditions are false");
            //        break;
            //    case 1:
            //        Console.WriteLine("Only condition 1 is true");
            //        break;
            //    case 2:
            //        Console.WriteLine("Only condition 2 is true");
            //        break;
            //    case 3:
            //        Console.WriteLine("Both conditions are true");
            //        break;
            //}

            //switch ((condition1, condition2))
            //{
            //    case (true, false):
            //        Console.WriteLine("Only condition 1 is true");
            //        break;
            //    case (false, true):
            //        Console.WriteLine("Only condition 2 is true");
            //        break;
            //    case (true, true):
            //        Console.WriteLine("Both conditions are true");
            //        break;
            //    default:
            //        Console.WriteLine("Both conditions are false or other cases");
            //        break;
            //}
        }

        public static void CountFrom2000To2010()
        {
            for (int i = 2000; i <= 2010; i++)
            {
                Console.WriteLine("The Year is " + i);
            }

            var counter = 2000;
            while(counter <= 2010)
            {
                Console.WriteLine("The Year is " + counter);
                counter++;
            }
        }

        public static void CountUntil2010(int startingPoint = 2010)
        {
            do
            {
                Console.WriteLine("The Year is " + startingPoint);
                startingPoint++;
            } while (startingPoint <= 2010);
        }

        public static void PrintEachOddCharacter(string word)
        {
            Console.WriteLine("Odd chars are:");
            for (int i = 0; i < word.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write(word[i]);
                }
            }

            //var counter = 0;
            //foreach (var character in word)
            //{
            //    if (counter % 2 != 0)
            //    {
            //        Console.Write(word[i]);
            //    }
            //    counter++;
            //}
        }
    }
}
