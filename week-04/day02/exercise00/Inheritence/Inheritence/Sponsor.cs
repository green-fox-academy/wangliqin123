using System;

namespace Inheritence
{
    class Sponsor : Person
    {
        public string company;
        public int hiredStudents;

        public Sponsor()
        {
            company = "Google";
            hiredStudents = 0;
        }

        public new void Introduce()
        {
            Console.WriteLine("Hi, I'm" + name + ", a" + age + "year old" + gender + "who represents" + company + "and hired"
                              + hiredStudents + "students so far.");
        }

        public new void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers.");
        }

        public void Hire()
        {
            Console.WriteLine(hiredStudents + 1);
        }  
    }
}