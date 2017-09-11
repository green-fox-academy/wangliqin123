using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("enter a number");

            while (int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine(i % 2 == 0 ? "even" : "odd");
            }
            Console.ReadLine();
        }
    }
}