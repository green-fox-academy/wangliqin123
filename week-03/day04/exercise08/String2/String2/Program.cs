using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Please type a word with letter 'x' :");
            string word = Console.ReadLine();
            Console.WriteLine(RemoveX(word));
            Console.ReadLine();
        }

        public static string RemoveX(string word)
        {
            if (word.Length > 0)
            {
                return word[0].ToString().Trim('x') + RemoveX(word.Substring(1));
            }
            else
            {
                return word;
            }
        }
    }
}
