using System;

namespace BabiesInTheZoo
{
    class Bird : Animal
    {
        private string integument = "plume";
        private int numberOfWings = 2;

        public Bird(string name)
        {
            this.name = name;
            this.age = 5;
        }

        public override void BabyInfo()
        {
            Console.WriteLine("My baby has {0} and she has {1} wings.", integument, numberOfWings);
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