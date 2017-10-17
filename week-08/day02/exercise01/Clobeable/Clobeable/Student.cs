using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clobeable
{
    class Student : ICloneable
    {
        string name;
        int age;
        string gender;
        string previousOrganization;

        public Student(string name, int age, string gender, string previousOrganization)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.previousOrganization = previousOrganization;
        }

        public void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " from " +
                             previousOrganization + " who skipped " + " days from the course already.");
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}