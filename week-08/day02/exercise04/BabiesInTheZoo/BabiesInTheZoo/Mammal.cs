using System;

namespace BabiesInTheZoo
{
    class Mammal : Animal
    {
        private string integument = "hair";
        private string feedOfOffsprings = "breast";

        public Mammal(string name)
        {
            this.name = name;
            this.babyFrom = "want a child from my uterus!";
            this.age = 10;
        }

        public override void BabyInfo()
        {
            Console.WriteLine("My baby has {0} and I feed him from my {1}.", integument, feedOfOffsprings);
        }

        public override void Greet()
        {
            Console.WriteLine("Hello, I am {0} {1} years old {2}.", gender, age, name);
        }

        public override string GetName()
        {
            return name;
        }

        public override string WantChild()
        {
            return babyFrom;
        }
    }
}