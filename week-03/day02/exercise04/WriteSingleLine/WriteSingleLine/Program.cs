﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WriteSingleLine
{
    class Program
    {
        static void Main(string[] args)
        {
                string path = "my-file.txt";
                using (StreamWriter writer = new StreamWriter(path))
                {
                      writer.WriteLine("Lorand Szilagyi");  
                }
        }
    }
}