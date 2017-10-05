using System;

namespace GardenApp
{
    class Plant : Garden
    {
        string Name;
        protected string type;
        protected float minWaterAmount;
        protected float waterAbsorb;
        private float currentWaterAmount;

        public Plant(string name)
        {
            Name = name;
        }

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
            return String.Format("The {0} {1} {2} ", type, Name, needWater);
        }
    }  
}