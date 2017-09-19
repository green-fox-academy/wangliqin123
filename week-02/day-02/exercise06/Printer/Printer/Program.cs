using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Please type in the expression:");
            string input = Console.ReadLine();
            int output;
            List<string> list = input.Split(' ').ToList();
            int a = Int32.Parse(list[1]);
            int b = Int32.Parse(list[2]);

            if (list[0] == "+") output = Add(a, b);

            else if (list[0] == "-") output = Diff(a, b);

            else if (list[0] == "*") output = Diff(a, b);

            else if (list[0] == "/") output = Div(a, b);

            else output = Mod(a, b);

            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
