using System;

namespace TakesLonger
{
    public class TakesLonger
    {
        public static void Main(string[] args)
        {
            string quote = "Hofstadter\'s Law: It you expect, even when you take into account Hofstadter\'s Law.";

            quote = quote.Insert(21, "always takes longer than ");

            Console.WriteLine(quote);
            Console.ReadLine();
        }
    }
}