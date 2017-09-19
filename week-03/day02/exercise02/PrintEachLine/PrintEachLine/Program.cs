﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "/my-file.txt";

            try
            {
                Console.WriteLine(File.ReadAllLines(path));
            }
            catch (Exception)
            {
                Console.WriteLine("Unable to read file: my-file.txt"); 
            }
            Console.ReadLine();
        }
    }
}
