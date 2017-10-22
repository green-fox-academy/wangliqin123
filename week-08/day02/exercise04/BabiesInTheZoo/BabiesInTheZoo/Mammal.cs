using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabiesInTheZoo
{
    class Mammal : Animal
    {
        private string integument;
        private string feedOfOffsprings;

        public Mammal(string name)
        {
            this.name = name;
        }

        public override void Feed()
        {
            throw new NotImplementedException();
        }

        public override void Greet()
        {
            Console.WriteLine("Hello, I am a mammal");
        }

        public override string GetName()
        {
            return name;
        }

        public override string WantChild()
        {
            return "want a child from my uterus!";
        }
    }
}
