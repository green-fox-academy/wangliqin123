using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteMultipleLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "apple";
            string path = "my-file.txt";
            int number = 5;

            FileWriter(word, path, number);
            Console.ReadLine();
        }

        public static void FileWriter(string word, string path, int number)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    for (int i = 0; i < number; i++)
                    {
                        writer.WriteLine(word);
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Cannot open this file");
            }
        }   
    }
}
