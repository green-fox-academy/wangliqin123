using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string source = "your-file.txt";
            string target = "my-file.txt";
            
            ReadCopy(source, target);
            Console.ReadLine();
        }

        private static void ReadCopy(string source, string target)
        {
            using (StreamWriter writer = new StreamWriter(target))
            {
                writer.WriteLine(File.ReadAllLines(source));
            }
            if (true)
            {

            }
        } 
    }
    // It should return a boolean that shows if the copy was successful
}
