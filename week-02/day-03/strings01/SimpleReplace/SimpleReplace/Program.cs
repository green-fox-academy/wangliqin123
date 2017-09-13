using System;

namespace SimpleReplace
{
    public class SimpleReplace
    {
        public static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";

            Console.WriteLine(example.Replace("dishwasher", "galaxy"));

            Console.ReadLine();
        }
    }
}