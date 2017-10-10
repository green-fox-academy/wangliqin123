using System;
using System.Linq;

namespace Unique
{
    public class Unique
    {
        public static char[] UniqueCharacters(string inputWord)
        {
            char[] letters = inputWord.Replace(" ", "").ToLower().ToCharArray().Distinct().ToArray();

            foreach (var character in letters)
            {
                Console.Write("\"{0}\", ", character);
            }
            return letters;
        }
    }
}