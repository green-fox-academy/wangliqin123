using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bunny1
{
    class Program
    {
        static void Main(string[] args)
        {    
            int bunny = 130;
            Console.WriteLine(Bunnies(bunny));
            Console.ReadLine();
        }
        public static int Bunnies(int bunny)
        {
            if (bunny > 0)
            {
                return 2 + Bunnies(--bunny); 
            }
            else
            {
                return bunny;
            }
        }
    }
}