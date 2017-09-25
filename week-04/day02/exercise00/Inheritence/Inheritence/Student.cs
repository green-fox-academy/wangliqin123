using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Student
    {
        public string Name;
        public int Age;
        public string Gender;
        public string PreviousOrganization;
        public int SkippedDays;

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm" + Name + ", a" + Age + "year old" + Gender + "from" +
                             PreviousOrganization + "who skipped" + SkippedDays + "days from the course already.");
        }

        public void GetGoal()
        {
            Console.WriteLine("Be a junior software developer.");
        }

        public void SkipDays(numberOfDays)
        {
            Console.WriteLine(SkippedDays + numberOfDays);
        }
        public Student(string Name, int Age, string Gender, string PreviousOrganization)
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            PreviousOrganization = "The School of Life";
            SkippedDays = 0;
        }
    }
}
