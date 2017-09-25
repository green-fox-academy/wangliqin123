using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    class Sponsor
    {
        public string Name;
        public int Age;
        public string Gender;
        public string Company;
        public int HiredStudents;

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm" + Name + ", a" + Age + "year old" + Gender + "who represents" + Company + "and hired"
                              + HiredStudents + "students so far.");
        }

        public void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            Console.WriteLine(HiredStudents + 1);
        }

        public Sponsor(string Name, int Age, string Gender, string Company)
        {
            Name = "Jane Doe";
            Age = 30;
            Gender = "female";
            Company = "Google";
            HiredStudents = 0;
        }
    }
}
