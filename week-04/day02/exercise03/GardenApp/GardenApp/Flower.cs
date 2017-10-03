using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Flower : Plant
    {
        
        int flowerWaterAmount;
        double waterAbsorb = 0.75;

        public Flower()
        {
            this.flowerWaterAmount = 3;
        }

    }
}
