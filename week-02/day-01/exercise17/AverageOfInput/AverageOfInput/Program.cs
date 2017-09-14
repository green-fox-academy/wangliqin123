using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number 1: ");
            int numb1 = Int32.Parse(Console.ReadLine());

            Console.Write("number 2: ");
            int numb2 = Int32.Parse(Console.ReadLine());

            Console.Write("number 3: ");
            int numb3 = Int32.Parse(Console.ReadLine());

            Console.Write("number 4: ");
            int numb4 = Int32.Parse(Console.ReadLine());

            Console.Write("number 5: ");
            int numb5 = Int32.Parse(Console.ReadLine());

            int sum = numb1 + numb2 + numb3 + numb4 + numb5;
            int average = sum / 5;

            Console.Write("Sum: {0} Average: {1}", sum , average);
            
            Console.ReadLine();
            
        }
    }
}
