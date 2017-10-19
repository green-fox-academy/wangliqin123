using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Storage
    {
        Random random = new Random();
        public List<Car> cars = new List<Car>();

        public void CarFactory()
        {
            for (int i = 1; i <= 256; i++)
            {
                cars.Add(new Car((CarColor)random.Next(0, 8), (CarType)random.Next(0, 8)));
            }
        }  
    }
}