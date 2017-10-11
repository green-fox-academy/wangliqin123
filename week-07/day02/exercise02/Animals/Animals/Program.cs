using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Commands commands = new Commands();

            if (args.Length > 0)
            {
                commands.AddAnimal(args);            
            }         
            else
            {
                commands.Usage();
            }
        }
    }
}