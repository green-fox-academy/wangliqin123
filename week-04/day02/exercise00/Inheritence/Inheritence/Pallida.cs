using System;
using System.Collections.Generic;

namespace Inheritence
{
    class Pallida
    {
        public string className;
        public List<Student> students;
        public List<Mentor> mentors;

        public Pallida()
        {
            List<Student> students = new List<Student>();
            List<Mentor> mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {

            students.Add(new Student());
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(new Mentor());
        }

        public void Info()
        {
            Console.WriteLine("Pallida Alpaga class has" + students.Count + "and" + mentors.Count + "mentors.");
        }   
    }
}