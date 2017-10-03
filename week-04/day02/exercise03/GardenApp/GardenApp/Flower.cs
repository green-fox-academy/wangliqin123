using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenApp
{
    class Flower
    {
        
        int flowerWaterAmount;
        double waterAbsorb = 0.75;
    

        public Flower()
        {
            this.flowerWaterAmount = 3;
        }

        public void FlowerWatering(int flowerWaterAmount)
        {
            if (flowerWaterAmount < 5)
            {
            Console.WriteLine("Flower needs water");
            }
            else
            {
                    return (flowerWaterAmount + waterAbsorb);
            }
        }
    }
}
