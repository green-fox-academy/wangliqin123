using System;

namespace DoubleItems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ag = { 3, 4, 5, 6, 7 };
            
            for (int i = 0; i < ag.Length; i++)
            {   
             Console.WriteLine(ag[i] *= 2);   
            }
            Console.ReadLine(); 
        }
    }
}