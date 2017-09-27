using System;

namespace Anagram
{
    public class AnagramClass
    {
        public bool IsAnagram(string firstword, string secondword)
        {
            if (firstword.Length != secondword.Length)
            {
                return false;
            }
            char[] first = firstword.ToCharArray();
            char[] second = secondword.ToCharArray();

            Array.Sort(first);
            Array.Sort(second);

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}