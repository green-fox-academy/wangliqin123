using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumTheArray
{
    class Program
    {
        static void Main(string[] args)
        {
            SumArray(new int[] { 1, 2, 3, 4 });
            SumArray(args);

            Console.ReadLine();
        }

        public static void SumArray<T>(T[] array)
        {
            array.Sum();
        }
    }
}
