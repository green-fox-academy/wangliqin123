using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruitstring = { "apple", "plum", "peach", "melone" };

            Printer(fruitstring);
            Console.ReadLine();
        }
        static void Printer(params string[] fruitstring)
        {
            foreach (string fruits in fruitstring)
            {
                Console.WriteLine(fruits);
            }

        }
    }
}    

