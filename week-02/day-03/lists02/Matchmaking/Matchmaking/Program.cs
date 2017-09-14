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

            
           
            order.AddRange(girls());
            order.AddRange(boys());
            
            
            
            //girls.Concat(boys);
                //order.AddRange(girls);
            //order.AddRange(boys);
            ////girls.Count + boys.Count;


            //order = girls.Concat(boys).ToList();
            foreach (string name in order)
	            {
                 Console.Write(order);
	            }
            
            

            Console.ReadLine();
        }
    }
}