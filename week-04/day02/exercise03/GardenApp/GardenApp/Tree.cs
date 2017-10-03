using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Tree : Plant
    {
        public Tree(double waterAbsorb, int waterAmount)
        {
            this.waterAbsorb = 0.4;
            this.waterAmount = 10;
        }
    }
}