using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("girls number: " + num);

            Console.Write("Enter number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("boys number: " + num2);

            Console.WriteLine("The party is excellent!");

            if (num = num2)  num + num2 > 20);
            {
                Console.WriteLine("Quite cool party!");
            }

            Console.ReadLine();
            

           
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
        }
    }
}