using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZero
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.Write("Enter a number: ");
             string numb = Console.ReadLine();
             int number = int.Parse(numb);
             Divide(number);
             Console.ReadLine();
        }
        static void Divide(int number)
         {
            try
            {
                Console.WriteLine(10 / number);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("fail");
            }
        }
    }
}
