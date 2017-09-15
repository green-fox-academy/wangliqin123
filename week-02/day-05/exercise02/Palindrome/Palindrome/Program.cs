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
            Console.Write("Type a word: ");
            string word= Console.ReadLine();

            string isPalindrome = CreatePalindrome(word);
            Console.WriteLine(isPalindrome);
            Console.ReadLine();
        }
        public static string CreatePalindrome(string word)
        {
            string isPalindrome = word;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                isPalindrome = isPalindrome + word[i];
            }
            return (isPalindrome);
        }
    }
}