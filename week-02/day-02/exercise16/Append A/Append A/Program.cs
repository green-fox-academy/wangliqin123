using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nimals = { "kuty", "macsk", "cic" };

            for (int i = 0; i < nimals.Length; i++)
            {
                Console.WriteLine(nimals[i] + "a");
            }
            Console.ReadLine();
        }
    }
}