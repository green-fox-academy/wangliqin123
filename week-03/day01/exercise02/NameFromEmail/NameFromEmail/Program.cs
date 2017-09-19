using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameFromEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type your email address in the following format:firstName.lastName@exam.com: ");
            string address = Console.ReadLine();

            List<string> firstlast = NameFromEmail(address);
            Console.WriteLine(firstlast);
            Console.ReadLine();
        }

        public static string NameFromEmail(string address)
        {
            string link = address;
            var firstpart = link.Split('@');
            string user = firstpart[0];
            string domain = firstpart[1];

            string[] names = user.Split('.');
            string firstname = names[0];
            string lastname = names[1];
            List<string> firstlast = new List<string> {names[0], names[1] };

            return firstlast;
        }
    }
}
 