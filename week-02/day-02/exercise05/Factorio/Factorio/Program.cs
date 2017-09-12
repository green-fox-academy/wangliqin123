using System;

namespace Factorio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            long fact = Factorio(number);
            Console.WriteLine("{0}! = {1}", number, fact);
            Console.ReadKey();
        }
        public static long Factorio(int number)
        {
            if (number == 0)

            {
                return 1;
            }
            return number * Factorio(number - 1);
        }
    }
}
