using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 20;

            Console.WriteLine(NumberAdder(number));
            Console.ReadLine();
        }

        public static int NumberAdder(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return number + NumberAdder(number - 1);
            }
        }
    }

    // Given a non-negative int n, return the sum of its digits recursively (no loops). 
    // Note that mod (%) by 10 yields the rightmost digit (126 % 10 is 6), while 
    // divide (/) by 10 removes the rightmost digit (126 / 10 is 12).
}