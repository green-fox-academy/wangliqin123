using System;

namespace SumTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            SumArray(new int[] { 1, 2, 3, 4 });

            Console.ReadLine();
        }

        public static void SumArray<T>(T[] array)
        {
            dynamic sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
        }
    }
}