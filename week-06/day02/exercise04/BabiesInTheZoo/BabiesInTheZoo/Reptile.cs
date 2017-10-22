using System;

namespace BabiesInTheZoo
{
    class Reptile :Animal
    {
        private string thermoregulation = "cold-blooded";
        private string integument = "scute";

        public Reptile(string name)
        {
            this.name = name;
            this.age = 3;
        }

        public override void BabyInfo()
        {
            Console.WriteLine("My baby has {0} and she is {1}.", integument, thermoregulation);
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