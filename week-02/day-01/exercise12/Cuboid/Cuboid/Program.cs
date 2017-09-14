using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 3;
            double b = 3;
            double c = 3;

            double SurfaceArea = 6 * a * a;

            Console.WriteLine("Surface Area: {0}", SurfaceArea);

            double Volume = a * b * c;

            Console.WriteLine("Volume: {0}", Volume);

            Console.ReadLine();
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
        }
    }
}