using System;
using System.Collections.Generic;

namespace GardenApp
{
    class Garden
    {
        List<Plant> plants;
        protected float water;

        public Garden()
        {
            this.water = 40;
            plants = new List<Plant>();
            plants.Add(new Flower("yellow"));
            plants.Add(new Flower("blue"));
            plants.Add(new Tree("purple"));
            plants.Add(new Tree("orange"));
 
        }

        public void PrintPlants()
        {
            foreach (Plant plant in plants)
            {
                Console.WriteLine(plant.PlantInfo());
            }
        }

        public void WaterGarden()
        {
            for (int i = 0; i < plants.Count; i++)
            {
                plants[i].Watering();
                plants[i].IsPlantThirsty();
            }
            Console.WriteLine("Watering with {0}", water);
        }
        
    }
}