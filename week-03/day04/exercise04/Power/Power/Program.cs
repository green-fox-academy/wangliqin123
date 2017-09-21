using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseNum = 3;
            int n = 3;
            Console.WriteLine(Power(baseNum, n));
            Console.ReadLine();
        }

        public static int Power(int baseNum, int n)
        {
            if (n == 0)
            {
                return 1; 
            }
            else
            {
                return baseNum * Power(baseNum, n - 1);
            }
        }
    }
}