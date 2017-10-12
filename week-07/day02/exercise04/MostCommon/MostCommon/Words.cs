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
        private string[] text;

        public Words()
        {
            text = File.ReadAllLines(path);
        }

        public void Usage()
        {
            Console.WriteLine("C# MostCommonWord [source]"); 
        }

        public void CountCommonWords()
        {           
            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach (string word in text)
            {
                if (dic.Keys.Contains(word))
                    dic[word] = dic[word]++;
                else
                    dic.Add(word, 1);
            }
            Console.WriteLine(dic.Max());
        }
    }
}
