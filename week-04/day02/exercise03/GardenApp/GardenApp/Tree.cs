using System;


namespace GardenApp
{
    class Tree : Plant
    {
        public Tree(int color)
        {
            this.type = "Tree";
            base.color = COLORS[color];
            this.minWaterAmount = 10;
            this.waterAbsorb = 0.4;
        }
    }
}