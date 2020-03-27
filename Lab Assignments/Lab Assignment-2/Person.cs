using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Assignment_2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public double SumofAllAges;
        public static int Count;
        public static double SumOfAllAges;


        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public void PrintNameAndAge()
        {
            Console.WriteLine(GetFullName() + ", " + this.Age);
        }

        public void GetAnswers()
        {
            Console.Write("Enter Your First Name: ");
            this.FirstName = Console.ReadLine();

            Console.Write("Enter Your Last Name: ");
            this.LastName = Console.ReadLine();

            Console.Write("Enter Your Age: ");
            this.Age = int.Parse(Console.ReadLine());

            this.Spouse = new Person();

            Console.Write("Enter Your Spouse First Name: ");
            this.Spouse.FirstName = Console.ReadLine();

            this.Spouse.LastName = this.LastName;

            Console.Write("Enter Your Spouse Age: ");
            this.Spouse.Age = int.Parse(Console.ReadLine());

            Person.Count += 2;
            Person.SumOfAllAges += this.Age + this.Spouse.Age;
        }

        public static double AvgAge()
        {
            return (Person.SumOfAllAges / Person.Count);
        }

    }
}

