using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number 1: ");
            int numb = Int32.Parse(Console.ReadLine());

            Console.Write("Number 2: ");
            int numb2 = Int32.Parse(Console.ReadLine());

            if (numb > numb2)
            {
                
                Console.WriteLine(numb);
            }

            else
            {
                Console.WriteLine(numb2);
            }

            Console.ReadLine();
        }
    }
}
