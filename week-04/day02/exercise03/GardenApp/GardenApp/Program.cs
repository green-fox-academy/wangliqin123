using System;
using System.Collections.Generic;

namespace GardenApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Garden garden = new Garden();

            garden.PrintPlants();
            garden.WaterGarden();
            garden.PrintPlants();
            garden.WaterGarden();
            garden.PrintPlants();

            Console.ReadLine();
        }
    }
}