using System;

namespace AppendA
{
    class Program
    {
        static void Main(string[] args)
        {
            string am = "kuty";
            appendA(am);
            Console.ReadLine();
        }
        public static void appendA(string am)
        {
            Console.WriteLine(am + "a");
        }  
    }
}