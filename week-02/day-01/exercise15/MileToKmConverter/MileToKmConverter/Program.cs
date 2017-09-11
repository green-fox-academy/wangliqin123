using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter distance in kilometers:");

            string input = Console.ReadLine();

            double number = Convert.ToInt32(input);
            double result = (double) (number * 0.65);

            Console.Write(number + result + "miles");

            Console.ReadLine();
        }
    }
}
