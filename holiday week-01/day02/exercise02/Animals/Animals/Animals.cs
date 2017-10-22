using System;
using System.IO;

namespace Animals
{
    class Animals
    {
        private string path = @"./favourites.txt";
        private string text;

        public Animals()
        {
            text = File.ReadAllText(path);
        }

        public void Usage()
        {
            Console.WriteLine("```C# FavouriteAnimals [animal] [animal]```");
        }

        public void AddAnimal(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                for (int i = 0; i < args.Length; i++)
                {
                    if (!text.Contains(args[i]))
                    {
                        writer.WriteLine(args[i]);
                    }                                        
                }                    
            }           
        }
    }
}