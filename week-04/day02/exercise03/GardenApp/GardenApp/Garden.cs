using System;
using System.Collections.Generic;

namespace GardenApp
{
    class Garden
    {
        List<Plant> plants = new List<Plant>();

        public void Add(Plant plant)
        {
            plants.Add(plant);
        }

        public int ThirstyCounter()
        {
            int thirstyPlants = 0;
            foreach (Plant plant in plants)
            {
                if (plant.IsThirsty())
                {
                    thirstyPlants++;
                }
            }
            return thirstyPlants;
        }

        public void Watering(int wateringNumber)
        {
            Console.WriteLine("Watering with {0}", wateringNumber);
            double waterPortion = wateringNumber / ThirstyCounter();
            foreach (Plant plant in plants)
            {
                if (plant.IsThirsty())
                {
                    plant.waterAmount += waterPortion * plant.absorb;
                }
            }
        }

        public void GetStatus()
        {
            foreach (Plant plant in plants)
            {
                if (plant.IsThirsty())
                {
                    Console.WriteLine("The {0} {1} needs water ", plant.color, plant.type);
                }
                else
                {
                    Console.WriteLine("The {0} {1} doesn't need water ", plant.color, plant.type);
                }
            }
        }
    }
}