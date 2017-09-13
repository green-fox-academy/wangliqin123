using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    public class SolarSystem
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
            "Neptune" };

            planetList.Insert(5 , "Saturn");

            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
                
            }
            Console.ReadLine();
        }
        
    }
}
