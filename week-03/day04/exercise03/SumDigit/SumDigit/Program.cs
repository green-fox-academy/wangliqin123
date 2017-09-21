using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 126;

            Console.WriteLine(SumDigit(number));
            Console.ReadLine();
        }

        public static int SumDigit(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return number % 10 + SumDigit(number / 10);
            }
        }
    }
}