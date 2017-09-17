using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matchmaking
{
    public class Matchmaking
    {
        public static void Main(string[] args)
        {
            var girls = new List<string> { "Eve", "Ashley", "Bözsi", "Kat", "Jane" };
            var boys = new List<string> { "Joe", "Fred", "Béla", "Todd", "Neef", "Jeff" };
            var order = new List<string>();

            for (int i = 0; i < boys.Count; i++)
            {
                if (girls.Count > i)
                {
                    order.Add(girls[i]);
                }

                order.Add(boys[i]);
            }
            foreach (string name in order)
	            {
                 Console.Write(name);
	            }
            Console.ReadLine();
        }
    }
}