using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Assignment_3
{
    class Instructor
    {
        private string Name;
        private string CourseName;


        public Instructor(string name, string courseName)
        {
            this.Name = name;
            this.CourseName = courseName;
        }


        public void SetStudentGrade(Student Name, int Grade)
        {
            Name.SetGrade(Grade);
        }

        public void Print()
        {
            System.Console.WriteLine("Instructor " + this.Name + " who teaches " + this.CourseName + ".");
        }
    }
}
