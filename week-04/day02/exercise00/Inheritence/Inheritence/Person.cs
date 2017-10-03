using System;

namespace Inheritence
{
    class Person
    {
        protected string name;
        protected int age;
        protected string gender;

        public Person(string name, int age, string gender)
        {
            this.age = age;
            this.name = name;
            this.gender = gender;
        }

        public Person()
        {
            name = "Jane Doe";
            age = 30;
            gender = "female";
        }

        public virtual void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + ".");
        }

        public virtual void GetGoal()
        {
            Console.WriteLine("My goal is: Live for the moment.");
        }  
    }
} 