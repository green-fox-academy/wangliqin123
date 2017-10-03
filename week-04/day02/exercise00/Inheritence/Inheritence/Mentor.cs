using System;

namespace Inheritence
{
    class Mentor : Person
    {
        public string level;

        public Mentor(string name, int age, string gender, string level)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.level = level;
        }

        public Mentor()
        {
            level = "intermediate";
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " " + level + " mentor.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Educate brilliant junior software developers.");
        }  
    }
}