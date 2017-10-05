using System;

namespace GardenApp
{
    class Flower : Plant
    {
        public Flower(string name) : base(name)
        {       
            this.type = "flower";
            this.minWaterAmount = 5;
            this.waterAbsorb = 0.75f;  
        }
    }  
}