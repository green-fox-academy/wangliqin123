using System;
using System.Linq;
using System.Text;

namespace ConvertToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] letters = { 'c', 'a', 't' };

            var toStringQuery = String.Concat(
                                from character in letters
                                select character);

            var toStringWithLambda = String.Join("", letters.Select(x => x.ToString()));
            var toStringLambda = letters.Aggregate(new StringBuilder(), (a, b) => a.Append(b));

            Console.WriteLine(toStringQuery);
            Console.WriteLine(toStringWithLambda);
            Console.WriteLine(toStringLambda);

            Console.ReadLine();
        }
    }
}