using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Tree
    {
             
        int treeWaterAmount = 10;
        double waterAbsorb = 0.4;
    }

    public void TreeWatering(int treeWaterAmount)
    {
        if (treeWaterAmount < 10)
        {
            Console.WriteLine("Tree needs water");
        }
    }
}
