using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeSearcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type a word: ");
            string word = Console.ReadLine();

            string isPalindrome = CreatePalindrome(word);
            Console.WriteLine(isPalindrome);
            Console.ReadLine();

            char[] wordarray = word.ToCharArray();

                for (int i = 0; i < wordarray.Length-3; i++)
                {
                    for (int j = 1; j < wordarray.Length; i++)
                    {
                             
                    } 
                }

            string newword = new string(wordarray);

            var palindromlist = new List<string>(newword);

        public static string CreatePalindrome(string word)
        {
            string isPalindrome = word1;

            for (int i = word.Length - 1; i >= 0; i--)
            {
                isPalindrome = isPalindrome + word[i];
            }
            return (isPalindrome);

        }
        
    }
}