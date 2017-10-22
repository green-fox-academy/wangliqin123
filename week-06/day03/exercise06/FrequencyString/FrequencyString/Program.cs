using System;
using System.Linq;

namespace FrequencyString
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = "letter";

            var frequencyOfCharacters = from character in n                                    
                                     group character by character into chars
                                     select new { chars.Key, Count = chars.Count() };

            var frequency = n.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

            foreach (var item in frequency)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}