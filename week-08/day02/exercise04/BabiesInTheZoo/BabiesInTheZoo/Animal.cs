using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabiesInTheZoo
{
    public abstract class Animal
    {
        protected string name;
        protected int age;
        protected string gender;
        protected string babyFrom;

        public abstract void Greet();
        public abstract string WantChild();
        public abstract string GetName();
        public abstract void Feed();

    }
}
