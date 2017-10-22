using System;
using System.Linq;

namespace Squared
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var positives = from positiveNumber in n
                             where positiveNumber > 0
                             select positiveNumber * positiveNumber;          

            var positivesWithLambda = n.Where(x => x > 0).Select(x => x * x);

            foreach (var number in positives)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}