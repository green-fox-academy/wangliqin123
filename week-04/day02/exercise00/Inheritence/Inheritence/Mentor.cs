using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Mentor
    {
        public string Name;
        public int Age;
        public string Gender;
        public string Level;

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm" + Name + ", a" + Age + "year old" + Gender + Level + "mentor.");
        }

        public void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }

        public Mentor(string Name, int Age, string Gender, string Level)
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Level = "intermediate";
        }
    }
}
