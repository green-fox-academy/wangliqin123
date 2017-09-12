using System;

namespace Doubling
{
    class Program
    {
        static void Main(string[] args)
        {
            int ak = 123;
            doubling (ak);
            Console.ReadKey();
        }
 
        public static void doubling(int ak)
        {
            Console.WriteLine(ak * 2);
        }

        // - Create an integer variable named `ak` and assign the value `123` to it
        // - Create a function called `doubling` that doubles it's input parameter
        // - Print the result of `doubling(ak)`


    }
}
