using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Program
    {
        public void Main(string[] args)
        {
            int firstWaterAmount = 40;
            int secondWaterAmount = 70;

            Tree tree = new Tree();
            Flower flower = new Flower();
            flower.FlowerWatering();
        }
    }
}
