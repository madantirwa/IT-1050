using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Assignment_3
{
    class Student
    {
        private string Name;
        private Instructor Teacher;
        private int Grade;


        public Student(string name, Instructor teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
        }

        public void SetGrade(int grade)
        {
            this.Grade = 0;
            this.Grade += grade;
        }

        public void Print()
        {
            System.Console.Write("Student " + this.Name + " has a grade of " + this.Grade + " from ");
            Teacher.Print();

        }
    }
}
