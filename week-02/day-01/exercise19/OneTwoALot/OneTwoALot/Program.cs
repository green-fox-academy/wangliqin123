using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            Int32.TryParse(input, out int i);

            if (i <= 0)
            {
                Console.WriteLine("Not enough");
            }

            else if (i == 1)
            {
                Console.WriteLine("One");
            }

            else if (i == 2)
            {
                Console.WriteLine("Two");
            }

            else
            {
                Console.WriteLine("A lot");
            }

            Console.ReadLine();

        }
    }
}
