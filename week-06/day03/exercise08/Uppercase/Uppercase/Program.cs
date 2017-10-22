using System;
using System.Linq;

namespace Uppercase
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "cAt";

            var findUpper = from character in word.ToArray()
                            where Char.IsUpper(character)
                            select character;

            var findUpperWithLambda = word.Where(x => char.IsUpper(x));

            foreach (var item in findUpperWithLambda)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}