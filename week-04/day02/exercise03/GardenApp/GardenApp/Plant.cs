using System;

namespace GardenApp
{
    class Plant : Garden
    {
        protected static readonly string[] COLORS = new string[] { "blue", "orange", "purple", "yellow" };
        public string color;
        protected string type;
        protected int minWaterAmount;
        protected double waterAbsorb;
        private double currentWaterAmount;   

        public bool IsPlantThirsty()
        {  
            return currentWaterAmount < minWaterAmount;
        }

        public void Watering()
        {
            currentWaterAmount += water * waterAbsorb;
        }

        public string PlantInfo()
        {
            string needWater = IsPlantThirsty() ? "needs water." : "doesnt need water.";
            string type = waterAbsorb == 0.75 ? "flower" : "tree";
            return String.Format("The {0} {1} {2}", type, color, needWater);
        }
    }  
}