using System;

namespace Colors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] colors = new string[3][];
            colors [0] = new string[5] { "lime", "forest green", "olive", "pale green", "spring green" };
            colors[1] = new string[3] { "orange red", "red", "tomato" };
            colors[2] = new string[4] { "orchid", "violet", "pink", "hot pink" };

            for (int i = 0; i < colors.Length; i++)
            {
                for (int j = 0; j < colors[i].Length; j++)
                {
                    Console.WriteLine("" + colors[i][j]);
                }
            }
                Console.ReadLine();  
        }
    }
}