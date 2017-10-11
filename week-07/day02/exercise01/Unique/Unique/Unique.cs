using System;
using System.Linq;

namespace Unique
{
    public class Unique
    {
        public static char[] UniqueCharacters(string inputWord)
        {
            return inputWord.Replace(" ", "").ToLower().ToCharArray().Distinct().ToArray();
        }
    }
}