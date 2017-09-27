using NUnit.Framework;
using Fibonacci;

namespace FibonacciTest
{
    [TestFixture]
    public class FiboClassTest
    {
        FiboClass fiboClass = new FiboClass();

        [Test]
        public void GetNthFibonacciTest()
        {
            int n = 2;
            int output = 1;

            Assert.AreEqual(output, fiboClass.GetNthFibonacci(n));
        }

        [Test]
        public void GetNthFibonacciTestFalse()
        {
            int n = 2;
            int output = 2;

            Assert.AreEqual(output, fiboClass.GetNthFibonacci(n));
        }
    }
}