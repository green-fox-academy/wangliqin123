using System;
using System.Linq;

namespace Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyOfNumbers = from number in n
                                     orderby number ascending
                                     group number by number into uniqeNumber
                                     select new { uniqeNumber.Key, Count = uniqeNumber.Count() };

            var frequency = n.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach (var item in frequencyOfNumbers)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}