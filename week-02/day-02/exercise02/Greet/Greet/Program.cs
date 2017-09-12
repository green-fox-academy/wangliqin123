using System;

namespace Greet
{
    class Program
    {
        static void Main(string[] args)
        {
            string al = "Greenfox";
            greet(al);
            Console.ReadLine();
        }

        public static void greet(string al)
        {
             Console.WriteLine("Greetings dear, " + al);
        }
            
            
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`
            
    }
}