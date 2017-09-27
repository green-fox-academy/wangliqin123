
namespace Fibonacci
{
    public class FiboClass
    {
        public double GetNthFibonacci(int n)
        {
            double nthFibonacci = 0;
            if (n == 2)
            {
                nthFibonacci = 1;
            }
            if (n <= 2)
            {
                return nthFibonacci;
            }

            double prevPrev = 0;
            double prev = 1;
            for (int i = 1; i < n - 1; i++)
            {
                nthFibonacci = prevPrev + prev;
                prevPrev = prev;
                prev = nthFibonacci;
            }
            return nthFibonacci;
        }
    }
}