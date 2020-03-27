using System;

namespace Lab_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Person p2 = new Person();

            Console.WriteLine("[Person 1 Info]");
            p1.GetAnswers();
            Console.WriteLine();

            Console.WriteLine("[Person 2 Info]");
            p2.GetAnswers();
            Console.WriteLine();

            Console.WriteLine("[Printing Results]");
            p1.PrintNameAndAge();
            p2.PrintNameAndAge();
            p1.Spouse.PrintNameAndAge();
            p2.Spouse.PrintNameAndAge();
            Console.WriteLine();

            Console.WriteLine("Average Age: " + Person.AvgAge());

            Console.WriteLine();
            Console.WriteLine("Press any key to end! ");
            Console.ReadKey();
        }
    }
}
