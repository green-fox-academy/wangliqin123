using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aj = {3, 4, 5, 6, 7};

            Array.Reverse(aj);

            foreach (var numb in aj)
	        {
                Console.Write("{0}," , numb);
	        }

            Console.ReadLine();
        }
    }
}
