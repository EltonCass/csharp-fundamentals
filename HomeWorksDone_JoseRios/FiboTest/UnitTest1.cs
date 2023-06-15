using FibonacciSeq;

namespace FiboTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingFibonacci()
        {
            Assert.AreEqual(0, Program.Fibonacci(-1));
            Assert.AreEqual(1, Program.Fibonacci(2));

            int fibo5 = Program.Fibonacci(5);
            int fibo6 = Program.Fibonacci(6);
            int fibo7 = Program.Fibonacci(7);

            Assert.AreEqual(5, fibo5);
            Assert.AreEqual(fibo5 + fibo6, fibo7);
        }
    }
}