using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsInList
{
    public class IsInList
    {
        public static void Main(string[] args)
        {
            var list = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16 };

            if (list.Contains(4) && list.Contains(8) && list.Contains(12) && list.Contains(16))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.ReadLine();  
        }
    }
}