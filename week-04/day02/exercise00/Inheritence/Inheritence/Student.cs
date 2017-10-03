using System;

namespace Inheritence
{
    class Student : Person
    {
        public string previousOrganization;
        public int skippedDays = 0;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;     
        }

        public Student()
        {
            previousOrganization = "The School of Life";        
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " from " +
                             previousOrganization + " who skipped " + skippedDays + " days from the course already.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Be a junior software developer.");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays += numberOfDays;
        }  
    }
}