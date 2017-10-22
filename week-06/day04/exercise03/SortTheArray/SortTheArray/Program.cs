using System;
using System.Collections.Generic;
using System.Linq;

namespace SortTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            SortArray(new int[] { 10, 13, 7, 5, 2, 0, 5 });
            SortArray(args);

            Console.ReadLine();
        }

        public static void SortArray<T>(T[] array)
        {
            array = array.OrderByDescending(x => x).ToArray();

            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}