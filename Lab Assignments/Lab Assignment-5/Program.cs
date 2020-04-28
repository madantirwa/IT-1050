using System;

namespace Lab_Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] individuals = new Person[3];

            individuals[0] = new Person("Madan", "Tirwa");
            individuals[1] = new Person("Sarita", "Tirwa");
            individuals[2] = new Person("Sawan", "Tirwa");

            foreach (Person individual in individuals)
            {
                System.Console.WriteLine(individual.Print());
            }
        }
    }
}
