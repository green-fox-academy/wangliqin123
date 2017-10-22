using System;
using System.Linq;

namespace OddAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var oddAverage = from oddAverageNumb in n
                             where oddAverageNumb % 2 != 0
                             select oddAverageNumb;
            Console.WriteLine(oddAverage.Average());

            var oddAverageWithLambda = n.Where(x => x % 2 != 0).Average();

            Console.WriteLine(oddAverageWithLambda);
            Console.ReadLine();
        }
    }
}   