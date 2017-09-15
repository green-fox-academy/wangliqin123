using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First word:");
            string firstword = Console.ReadLine();

            Console.Write("Second word:");
            string secondword = Console.ReadLine();

            bool isAnagram = Anagram(firstword, secondword);
            Console.WriteLine(isAnagram);
            Console.ReadLine();
        }
        public static bool Anagram(string firstword, string secondword)
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

