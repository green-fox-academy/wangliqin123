using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Animals
{
    class Commands
    {
        private string path;
        private string newAnimal;
        private string[] text;
        private string line;
        private string word;

        public Commands()
        {
            path = @"./favourites.txt";
            word = "animal";          
        }

        public Commands(string newAnimal, string line, string[] text)
        {
            this.newAnimal = newAnimal;
            this.line = line;
            this.text = text;
        }

        public void Usage()
        {
            Console.WriteLine("```C# FavouriteAnimals [{0}] [{1}]```", word, word);
        }

        public void ListAnimals()
        {
            text = File.ReadAllLines(path);

            foreach (var line in text)
            {
                Console.WriteLine(line);
            }
        }

        public void RemoveAnimal(string line)
        {
            List<string> lines = new List<string>(File.ReadAllLines(path));
            lines.RemoveAt(int.Parse(line) - 1);
            File.WriteAllLines(path, lines);
        }

        public void AddAnimal(string newAnimal)
        {
            text = File.ReadAllLines(path);

            if (text.Contains(newAnimal))
            {
                Console.WriteLine("Cannot add beacause already exist.");
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(newAnimal);
                }
            }          
        }
    }
}