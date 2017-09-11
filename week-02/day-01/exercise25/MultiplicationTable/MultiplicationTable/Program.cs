using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value:");
            int n = int.Parse(Console.ReadLine());

            if (n == 0)
                return;

            for (int i = 1; i <= 10; i++)
                Console.WriteLine("{0} * {1} ={2}", n, i, n * i);

            Console.ReadLine();
        }
    }
}
