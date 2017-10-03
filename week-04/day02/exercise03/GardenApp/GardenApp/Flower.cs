using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Flower : Plant
    {
        public Flower(double waterAbsorb, int waterAmount)
        {
            this.waterAbsorb = 0.75;
            this.waterAmount = 5;
        }
    }  
}