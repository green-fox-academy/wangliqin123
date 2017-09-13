using System;
using System.Text;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter's Law: It you expect, even when you take into account Hofstadter's Law.";

            StringBuilder quote1 = new StringBuilder(quote);
            Console.WriteLine(quote1.Insert(21 , "always takes longer than "));

            Console.ReadLine();
        }
    }
}