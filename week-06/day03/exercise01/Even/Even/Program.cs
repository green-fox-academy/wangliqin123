using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var evenNumbers = from evenNumb in n
                              where evenNumb % 2 == 0
                              select evenNumb;

            var evenNumbersWithLambda = n.Where(x => x % 2 == 0);

            foreach (var even in evenNumbersWithLambda)
            {
                Console.WriteLine(even);   
            }
            Console.ReadLine();
        }
    }
}
