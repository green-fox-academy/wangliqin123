using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabiesInTheZoo
{
    class Bird : Animal
    {
        private string integument;
        private int wing;

        public Bird(string name)
        {
            this.name = name;
        }

        public override void Feed()
        {
            throw new NotImplementedException();
        }

        public override void Greet()
        {
            Console.WriteLine("Hello, I am a bird");
        }

        public override string GetName()
        {
            return name;
        }

        public override string WantChild()
        {
            return "want a child from an egg!";
        }
    }
}
