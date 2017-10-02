using System;

namespace Anagram
{
    public class AnagramClass
    {
        static void Main(string[] args)
        {
        }

        public bool IsAnagram(string input1, string input2)
        {
            string input1Low = input1.ToLower();
            string input2Low = input2.ToLower();
            char[] charArray1 = input1Low.ToCharArray();
            char[] charArray2 = input2Low.ToCharArray();
            Array.Sort(charArray1);
            Array.Sort(charArray2);

            if (input1.Length != input2.Length || input1 == string.Empty || input2 == string.Empty)
            {
                return false;
            }
            string newInput1 = new string(charArray1);
            string newInput2 = new string(charArray2);
            if (newInput1 == newInput2)
            {
                return true;
            }
            return false;
        }
    }
}