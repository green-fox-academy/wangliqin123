using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Person
    {
        public string Name;
        public int Age;
        public string Gender;

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm" + Name + ", a" + Age + "year old" + Gender + ".");
        }

        public void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }
        
        public Person(string Name, int Age, string Gender)
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
        }
    }

}
 