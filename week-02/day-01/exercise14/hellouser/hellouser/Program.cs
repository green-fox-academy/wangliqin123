using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Enter your name:";
            string name;

            Console.Write(message);

            name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!");

            Console.ReadLine();    
        }
    }
}