using System;

namespace Lab_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part 1 - String Concatenation

            Console.Write("What is your first name? --> ");
            string firstName = Console.ReadLine();

            Console.Write("What is your middle initial? --> ");
            string middleInitial = Console.ReadLine();

            Console.Write("What is your last name? --> ");
            string lastName = Console.ReadLine();

            string fullName = (firstName + " " + middleInitial + " " + lastName);

            #endregion
            //////////////////////////////////////////////////////////////
            #region Part 2 - Arithmetic Expression

            Console.Write("What is your age? --> ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("What is your height? (only feet part) --> ");
            int heightFeetOnly = int.Parse(Console.ReadLine());

            Console.Write("What is your height? (only inches part) --> ");
            double heightInchesOnly = double.Parse(Console.ReadLine());

            const int inchesPerFt = 12;
            const double cmPerInch = 2.54;

            double heightFtToInches = (heightFeetOnly * inchesPerFt) + heightInchesOnly;
            double totalHeightCM = (heightFtToInches * cmPerInch);

            #endregion
            //////////////////////////////////////////////////////////////
            #region Part 3 - Boolean Expression

            Console.Write("Are you a US citizen? --> ");
            bool isCitizen = Console.ReadLine().ToUpper().StartsWith("Y");

            bool canVote = age >= 18 && isCitizen;

            #endregion
            /////////////////////////////////////////////////////////////
            #region Print

            Console.WriteLine("Hello " + fullName);
            Console.WriteLine("Your height in cm is " + totalHeightCM + "cm, and ");
            Console.WriteLine("Your voting eligibility is " + canVote);
            Console.WriteLine("Press any key to end this program!");

            #endregion
        }
    }
}
