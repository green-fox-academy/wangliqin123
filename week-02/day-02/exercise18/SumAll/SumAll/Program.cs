using System;

namespace SumAll
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ai = { 3, 4, 5, 6, 7 };

            for (int i = 1; i < ai.Length; i++)
            {
                ai[0] += ai[i];
            }
            Console.WriteLine(ai[0]);

            Console.ReadLine();
        }
    }
}
