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
    }
}
