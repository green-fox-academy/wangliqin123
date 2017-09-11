using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 3;
            
            Console.WriteLine(a + 10);

            int b = 100;
            

            Console.WriteLine(b -7);

            int c = 44;
            

            Console.WriteLine(c * 2);

            int d = 125;
            

            Console.WriteLine(d / 5);

            int e = 8;
            

            Console.WriteLine(e * e * e);

            int f1 = 123;
            int f2 = 345;

            if (f1 > f2)

            {
                Console.WriteLine(true);
            }

            else
            {   
                Console.WriteLine(false);
            }

            int g1 = 350;
            int g2 = 200;

            if (g2*2 > g1)

            {
                Console.WriteLine(true);
            }

            else
            {
                Console.WriteLine(false);
            }

            long h = 1357988018575474;

            if (h % 11 == 0)

            {
                Console.WriteLine(true);
            }

            else
            {
                Console.WriteLine(false);
            }
            
            int i1 = 10;
            int i2 = 3;

            if ((i1 > i2 * i2) && (i1 < i2 * i2 * i2))

            {
                Console.WriteLine(true);
            }

            else
            {
                Console.WriteLine(false);
            }
            
            int j = 1521;

            if ((j % 3 == 0) || (j % 5 ==0))

            {
                Console.WriteLine(true);
            }

            else
            {
                Console.WriteLine(false);
            }
            
            string k = "Apple";
          
            Console.WriteLine("{0}{0}{0}{0}",k);

            Console.ReadLine();
        }
    }
}