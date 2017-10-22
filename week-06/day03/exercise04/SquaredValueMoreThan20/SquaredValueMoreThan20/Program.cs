using System;
using System.Linq;

namespace SquaredValueMoreThan20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };
            var squares = from number in n
                          where number * number > 20
                          select number;

            var squaresWithLambda = n.Where(x => x * x > 20).Select(x => x);

            foreach (var number in squaresWithLambda)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}