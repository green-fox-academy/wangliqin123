﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "text";
            Console.WriteLine(ChangeLetter(word));
            Console.ReadLine();
        }

        public static string  ChangeLetter(string word)
        {
            if (word.Length > 0)
            {
                return word.First().ToString().Replace('x', 'y') + ChangeLetter(word.Substring(1));
            }
            else
            {
                return word;
            }
        }   
    }
}