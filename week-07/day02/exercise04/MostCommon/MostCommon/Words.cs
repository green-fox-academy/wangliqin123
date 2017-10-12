using System;
using System.Collections.Generic;
using System.IO;

namespace MostCommon
{
    class Words
    {
        private string path = @"./article.txt";
        private string text;

        public Words()
        {
            text = File.ReadAllText(path);
        }

        public void Usage()
        {
            Console.WriteLine("C# MostCommonWord [source]"); 
        }

        public void CountCommonWords()
        {         
            Dictionary<string, int> article = new Dictionary<string, int>();

            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                if (article.ContainsKey(word))
                {
                    article[word]++;
                }
                else
                {
                    article[word] = 1;
                }         
            }

            foreach (KeyValuePair<string, int> vocable in article)
            {
                if (vocable.Value > 1)
                {
                    Console.WriteLine("\"" + vocable.Key + "\"" + " " + vocable.Value);
                }
            }
        }
    }
}