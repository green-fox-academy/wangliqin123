using System;

namespace Inheritence
{
    class Student : Person
    {
        public string previousOrganization;
        public int skippedDays;

        public Student()
        {
            previousOrganization = "The School of Life";
            skippedDays = 0;
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm" + name + ", a" + age + "year old" + gender + "from" +
                             previousOrganization + "who skipped" + skippedDays + "days from the course already.");
        }

        public new void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public void SkipDays()
        {
            Console.WriteLine(skippedDays);
        }  
    }
}