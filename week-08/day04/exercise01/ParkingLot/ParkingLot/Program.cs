using System;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            Storage storage = new Storage();
            storage.CarFactory();

            foreach (Car car in storage.cars)
            {
                Console.WriteLine(car.Type);
                Console.WriteLine(car.Color);
            }

            var sameType = storage.cars.GroupBy(x => x.Type).ToDictionary(x => x.Key, x => x.Count());

            foreach (var car in sameType)
            {
                Console.WriteLine(car);
            }

            var sameColor = storage.cars.GroupBy(x => x.Color).ToDictionary(x => x.Key, x => x.Count());

            foreach (var car in sameColor)
            {
                Console.WriteLine(car);
            }

            var mostOccuringCar = (from car in storage.cars
                                group car by new { car.Type, car.Color } into mostOccuring
                                orderby mostOccuring.Count() descending
                                select new { mostOccuring.Key, Count = (from car in mostOccuring select car).Count()}).Take(1);

            foreach (var car in mostOccuringCar)
            {
                Console.WriteLine(car);
            }

            Console.ReadLine();
        }
    }
}