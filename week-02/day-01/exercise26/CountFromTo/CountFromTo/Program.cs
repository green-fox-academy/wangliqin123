using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.Write("Enter number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            if (num2 < num)
            {
                
                Console.WriteLine("The second number should be bigger");
            }

            for (int i = num; i < num2; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}