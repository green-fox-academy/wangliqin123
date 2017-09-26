using System;

namespace Inheritence
{
    class Mentor : Person
    {
        public string level;

        public Mentor()
        {
            level = "intermediate";
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm" + name + ", a" + age + "year old" + gender + level + "mentor.");
        }

        public new void GetGoal()
        {
            Console.WriteLine("Educate brilliant junior software developers.");
        }  
    }
}