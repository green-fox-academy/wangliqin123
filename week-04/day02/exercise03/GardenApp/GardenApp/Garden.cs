using System;
using System.Collections.Generic;

namespace GardenApp
{
    class Garden
    {
        public List<Plant> plants;
        protected int water;

        public Garden()
        {
            this.water = 40;
            plants = new List<Plant>();
            plants.Add(new Flower(3));
            plants.Add(new Flower(0));
            plants.Add(new Tree(2));
            plants.Add(new Tree(1));
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