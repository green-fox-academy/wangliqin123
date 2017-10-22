using System;

namespace BabiesInTheZoo
{
    public class Zoo
    {
        public static void Main(string[] args)
        {
            var reptile = new Reptile("Crocodile");
            var mammal = new Mammal("Koala");
            var bird = new Bird("Parrot");

            reptile.Greet();
            reptile.BabyInfo();
            mammal.Greet();
            mammal.BabyInfo();
            bird.Greet();
            bird.BabyInfo();

            Console.WriteLine("Who want a baby?");
            Console.WriteLine(reptile.GetName() + ", " + reptile.WantChild());
            Console.WriteLine(mammal.GetName() + ", " + mammal.WantChild());
            Console.WriteLine(bird.GetName() + ", " + bird.WantChild());

            Console.ReadLine();
        }
    }
}