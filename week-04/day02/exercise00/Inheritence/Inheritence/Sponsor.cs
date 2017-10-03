using System;

namespace Inheritence
{
    class Sponsor : Person
    {
        public string company;
        public int hiredStudents = 0;

        public Sponsor(string name, int age, string gender, string company)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.company = company;
        }

        public Sponsor()
        {
            company = "Google";
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " who represents " + company + " and hired "
                              + hiredStudents + " students so far.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("My goal is: Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            hiredStudents++;
        }  
    }
}