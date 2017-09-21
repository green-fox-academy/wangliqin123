using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "xilofon";

            Console.WriteLine(StarSeparator(word));
            Console.ReadLine();
        }

        public static string StarSeparator(string word)
        {
            if (word.Length > 0)
            {
                return word[0] + "*" + StarSeparator(word.Substring(1));
            }
            else
            {
                return word;
            }
        }
    }
}
