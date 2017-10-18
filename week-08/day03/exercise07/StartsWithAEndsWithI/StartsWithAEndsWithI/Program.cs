using System;
using System.Linq;

namespace StartsWithAEndsWithI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var startsA = from word in cities
                          where word.StartsWith("A")
                          where word.EndsWith("I")
                          select word;

            var startsAWithLambda = cities.Where(x => x.StartsWith("A")).Where(x => x.EndsWith("I"));

            foreach (var item in startsAWithLambda)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}