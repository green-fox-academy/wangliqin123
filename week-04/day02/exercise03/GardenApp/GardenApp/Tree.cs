using System;


namespace GardenApp
{
    class Tree : Plant
    {
        public Tree(string name) : base(name)
        {
            this.type = "tree";
            this.minWaterAmount = 10;
            this.waterAbsorb = 0.4f;
        }
    }
}