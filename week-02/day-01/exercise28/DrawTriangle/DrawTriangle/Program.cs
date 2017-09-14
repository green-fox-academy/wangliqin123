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
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }
            Console.ReadLine();
        }
    }
}