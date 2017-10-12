using System;
using System.IO;

namespace Copy
{
    class Command
    {
        public void Usage()
        {
            Console.WriteLine("copy [source] [destination]");
        }

        public void CopyFile(string[] args)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(args[1]))
                {
                    writer.WriteLine(File.ReadAllText(args[0]));
                }
            }
            catch (Exception)
            {
                Console.WriteLine("No destination provided");
            }          
        }
    }
}