// See https://aka.ms/new-console-template for more information
namespace FibonacciSeq
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int input = 7;
            int result = Fibonacci(input);
            Console.WriteLine($"The Fibonacci sequence of input: {input} is {result}");
        }

        public static int Fibonacci(int inputNum)
        {
            if (inputNum <= 0) return 0;
            if (inputNum <= 2) return 1;

            int result = 0;
            int prev = 0;
            int next = 1;

            for (int counter = 2; counter <= inputNum; counter++)
            {
                result = prev + next;
                prev = next;
                next = result;
            }
            return result;
        }
    }
}



