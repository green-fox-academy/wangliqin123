using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.Write("Enter the starting limit: ");
            int value1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the final limit: ");
            int value2 = int.Parse(Console.ReadLine());

            int value = random.Next(value1, value2);
            int guess = 0;
            bool correct = false;

            Console.WriteLine("I've the number between {0}-{1}.", value1, value2);
          
            while (!correct)
            {
                Console.Write("Guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    continue;
                }
                if (guess < value)
                {
                    Console.WriteLine("Too low.");
                }
                else if (guess > value)
                {
                    Console.WriteLine("Too high.");
                }
                else
                {
                    correct = true;
                    Console.WriteLine("Congratulations. You won!");
                }
            }
            Console.ReadLine();
        }
    }
}   