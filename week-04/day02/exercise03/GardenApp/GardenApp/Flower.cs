using System;

namespace GardenApp
{
    class Flower : Plant
    {
        public Flower(int color)
        {
            this.type = "Flower";
            base.color = COLORS[color];
            this.minWaterAmount = 5;
            this.waterAbsorb = 0.75;  
        }
    }  
}