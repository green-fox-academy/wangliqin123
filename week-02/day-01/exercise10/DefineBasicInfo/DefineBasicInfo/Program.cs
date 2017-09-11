using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Lorand";
            int age = 30;
            double height = 1.8;
            bool married = false;

            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height);

            if (married)
            {
                Console.WriteLine("married");
            }

            else
            {
                Console.WriteLine("not married");
            }

            Console.ReadLine();

        }
    }
}