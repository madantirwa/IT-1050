using System;

namespace Lab_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////////////////////////////////////////////////////////////////////////////////////
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;

            Console.Write("What is your first name? --> ");
            firstName = Console.ReadLine();
            Console.Write("What is your middle initial? --> ");
            middleInitial = Console.ReadLine();
            Console.Write("What is your last name? --> ");
            lastName = Console.ReadLine();
            fullName = (firstName + " " + middleInitial + " " + lastName);

            /////////////////////////////////////////////////////////////////////////////////////////////
            int age;
            bool isCitizen;
            bool canVote;

            Console.Write("What is your age? --> ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Are you a US citizen? --> ");
            isCitizen = Console.ReadLine().ToUpper().StartsWith("Y");
            Console.Write("Can you vote? --> ");
            canVote = Console.ReadLine().ToUpper().StartsWith("Y");

            /////////////////////////////////////////////////////////////////////////////////////////////
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            Console.Write("What is your height? (only feet part) --> ");
            heightFeet = int.Parse(Console.ReadLine());
            Console.Write("What is your height? (only inches part) --> ");
            heightInches = double.Parse(Console.ReadLine());
            totalHeightCM = (((12 * heightFeet) + (heightInches)) * 2.54);

            /////////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("Hello " + fullName);
            Console.WriteLine("Your height is " + totalHeightCM + "cm, and ");
            Console.WriteLine("Your voting status is " + canVote);
            Console.WriteLine("Press any key to end this program!");

            /////////////////////////////////////////////////////////////////////////////////////////////
        }
    }
}
