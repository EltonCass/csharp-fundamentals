// Copyright (c) 2023 Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson2
{
    internal static class Methods
    {
        public static double CalculateYearlyIncome(int rawMonthlyIncome)
        {
            var tax = 0.12;
            var monthlyIncome = rawMonthlyIncome - (rawMonthlyIncome * tax);
            return monthlyIncome * 12;
        }

        public static double CalculateYearlyIncome(int rawMonthlyIncome, double tax, double bonus = 0.003)
        {
            var monthlyIncome = rawMonthlyIncome - (rawMonthlyIncome * tax) + (rawMonthlyIncome * bonus);
            return monthlyIncome * 12;
        }

        public static void DisplayAmountLeft(int outcome, int income)
        {
            Console.WriteLine("The amount left is: " + (income - outcome) + "$");
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }

        public static void DisplayYearlyIncome(int rawMonthlyIncome, double tax = 0.12)
            => Console.WriteLine("Yearly income : " + CalculateYearlyIncome(rawMonthlyIncome, tax) + "$");
    }
}
