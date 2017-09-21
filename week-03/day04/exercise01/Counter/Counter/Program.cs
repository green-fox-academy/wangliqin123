using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {
        int number = 200;

        Console.WriteLine(Counter(number));
        Console.ReadLine();
        }

        public static int Counter(int number)
        {
            if (number == 0)
            {
                return 0;
            }
            else
            {
                return Counter(number - 1);
            }
        }
    }
}