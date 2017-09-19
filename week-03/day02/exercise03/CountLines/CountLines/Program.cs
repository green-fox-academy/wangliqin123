using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CountLines
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineCount;
            string filename;

            Console.Write("Enter a filename: ");
            filename = Console.ReadLine();
            lineCount = TakesName(filename);

            Console.WriteLine(lineCount);
            Console.ReadLine();
        }

        public static int TakesName(string filename)
        {
            int lineCount = 0;
            try
            {
                String[] content = File.ReadAllLines(filename);
                lineCount = content.Count();
            } catch (Exception)
            {}
            return lineCount;
        }
    }
}
