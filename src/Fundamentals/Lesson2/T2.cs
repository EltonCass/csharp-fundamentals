// Copyright (c) 2023  Elton Cassas. All rights reserved.
// See LICENSE.txt

namespace Fundamentals.Lesson2
{
    internal class T2
    {
        private static Dictionary<int, int> _memo = new Dictionary<int, int>();

        internal static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        internal static int MemoFibonacci(int n)
        {
            if (_memo.ContainsKey(n))
            {
                return _memo[n];
            }

            int result;
            if (n <= 1)
            {
                result = n;
            }
            else
            {
                result = Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            _memo[n] = result;
            return result;
        }
    }
}
