using System;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 4;
            int num3 = 5;
            sum (num1, num2, num3);
            Console.ReadKey();
            
            Console.ReadLine();
        }

        public static void sum(int num1, int num2, int num3)
        {
            Console.WriteLine(num1 + num2 + num3);

        }
    }
}
