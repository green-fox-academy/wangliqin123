using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Dictionary<string, int> dic = new Dictionary<string, int>();

            string[] words = text.Split(' ');

            foreach (string word in words)
            {
                if (dic.ContainsKey(word))
                {
                    dic[word]++;
                }
                else
                {
                    dic[word] = 1;
                }         
            }

            foreach (KeyValuePair<string, int> szavak in dic)
            {
                if (szavak.Value > 1)
                {
                    Console.WriteLine("\"" + szavak.Key + "\"" + " " + szavak.Value);
                }
            }
        }
    }
}