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
            Console.Write("Enter number: ");
            int girlsnum = Int32.Parse(Console.ReadLine());

            Console.Write("Enter number: ");
            int boysnum = Int32.Parse(Console.ReadLine());

            if (girlsnum == 0)
            {
                Console.WriteLine("Sausage party");
            }
            else if ((girlsnum + boysnum) > 20)
            {
                if (girlsnum == boysnum)
                {
                    Console.WriteLine("The party is exellent!");
                }
                else if (girlsnum != boysnum)
                {
                    Console.WriteLine("Quite cool party!");
                }
            }
            else 
            {
                Console.WriteLine("Average party...");
            }

            Console.ReadLine();
        }
    }
}