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

            Console.Write("Number of chickens: ");
            int chickennumb = Int32.Parse(Console.ReadLine());

            Console.Write("Number of pigs: ");
            int pignumb = Int32.Parse(Console.ReadLine());

            int legs = (chickennumb * 2) + (pignumb * 4);

            Console.WriteLine("number of all animal legs: {0}" , legs);

            Console.ReadLine();



            // Write a program that asks for two integers
        }   // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
    }        // It should print how many legs all the animals have

           
}
