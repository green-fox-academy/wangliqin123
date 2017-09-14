using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementFinder
{
    public class ElementFinder
    {
        public static void Main(string[] args)
        {
            var List = new List<int> { 1, 2, 3, 4, 5 };

            if (List.Contains(7))
            {
                Console.WriteLine("Hooray");
            }
            else
            {
                Console.WriteLine("Noooooo");
            }

            Console.ReadLine();
        }
    }
}
