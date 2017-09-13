using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reverse
{
    public class Reverse
    {
        public static void Main(string[] args)
        {

            string reversed = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            string updatereversed = "";

            for (int i=reversed.Length - 1; i >=0; i--)
            {
                updatereversed = updatereversed + reversed[i];
            }
            Console.WriteLine(updatereversed);
            Console.ReadLine();
        }
    }
}