using System;
using System.Collections.Generic;

namespace Inheritence
{
    class Pallida
    {
        public string className;
        public List<Student> students;
        public List<Mentor> mentors;

        public Pallida(string className)
        {
            students = new List<Student>();
            mentors = new List<Mentor>();
            this.className = className;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("Pallida " + className + " class has " + students.Count + " students" + " and " + mentors.Count + " mentors.");
        }   
    }
}