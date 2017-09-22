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
            int number = 5;

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
}