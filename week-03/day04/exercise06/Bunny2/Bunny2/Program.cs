using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bunny = 10;

            Console.WriteLine(Bunnies(bunny));
            Console.ReadLine();
        }

        public static int Bunnies(int bunny)
        {
            if (bunny == 1)
            {
                return 2;
            }
            if (bunny % 2 == 0)
            {
                return 3 + Bunnies(--bunny);
            }
            else
            {
                return 2 + Bunnies(--bunny);
            }
        }
    }
}