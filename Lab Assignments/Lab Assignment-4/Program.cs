using System;

namespace Lab_Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double Ticket = 0;
            double Concession = 0;
            double Discount = 0;
            double discount1 = 0;
            double discount2 = 0;
            double discount3 = 0;

            int adults = 0;
            int children = 0;
            int seniors = 0;

            int numSmallSoda = 0;
            int numLargeSoda = 0;
            int numHotDog = 0;
            int numPopcorn = 0;
            int numCandy = 0;

            const double Ticket_Cost_Adult_Matinee = 5.99;
            const double Ticket_Cost_Child_Matinee = 3.99;
            const double Ticket_Cost_Senior_Matinee = 4.50;

            const double Ticket_Cost_Adult_Evening = 10.99;
            const double Ticket_Cost_Child_Evening = 6.99;
            const double Ticket_Cost_Senior_Evening = 8.50;

            const double costOfSmallSoda = 3.50;
            const double costOfLargeSoda = 5.99;
            const double costOfHotDog = 3.99;
            const double costOfPopcorn = 4.50;
            const double costOfCandy = 1.99;

            System.Console.Write("Is this for a evening? (y/n): ");
            bool isEvening = System.Console.ReadLine().ToLower().StartsWith("y");

            System.Console.WriteLine();
            System.Console.WriteLine("[Enter Ticket Info:]");

            System.Console.Write("Number of Adults: ");
            adults = int.Parse(System.Console.ReadLine());
            System.Console.Write("Number of Children: ");
            children = int.Parse(System.Console.ReadLine());
            System.Console.Write("Number of Seniors: ");
            seniors = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine();
            System.Console.WriteLine("[Enter Concession Info:]");

            System.Console.Write("Number of Small Sodas: ");
            numSmallSoda = int.Parse(System.Console.ReadLine());
            System.Console.Write("Number of Large Sodas: ");
            numLargeSoda = int.Parse(System.Console.ReadLine());
            System.Console.Write("Number of Hot Dogs: ");
            numHotDog = int.Parse(System.Console.ReadLine());
            System.Console.Write("Number of Popcorn: ");
            numPopcorn = int.Parse(System.Console.ReadLine());
            System.Console.Write("Number of Candies: ");
            numCandy = int.Parse(System.Console.ReadLine());

            Ticket += adults * (isEvening ? Ticket_Cost_Adult_Evening : Ticket_Cost_Adult_Matinee);
            Ticket += children * (isEvening ? Ticket_Cost_Child_Evening : Ticket_Cost_Child_Matinee);
            Ticket += seniors * (isEvening ? Ticket_Cost_Senior_Evening : Ticket_Cost_Senior_Matinee);

            Concession += numSmallSoda * costOfSmallSoda;
            Concession += numLargeSoda * costOfLargeSoda;
            Concession += numHotDog * costOfHotDog;
            Concession += numPopcorn * costOfPopcorn;
            Concession += numCandy * costOfCandy;


            System.Console.WriteLine();
            System.Console.WriteLine("[Discount Details:]");

            if (numPopcorn >= 1 && numLargeSoda >= 1)
            {
                discount1 = 2;  //$2 off of one movie ticket
                System.Console.WriteLine(" You got $2 off of one movie ticket for purchasing a popcorn and large soda. ");
            }
            else
            {

            }

            if (Ticket >= 3 && isEvening)
            {
                discount2 = costOfPopcorn * 1;
                System.Console.WriteLine(" You got 1 free bag of popcorn for purchasing 3 or more evening tickets. ");
            }
            else
            {

            }

            if (numCandy >= 3)
            {
                int freeCandies = numCandy / 4;
                discount3 = freeCandies * 1.99;
                System.Console.WriteLine(" You got 4th candy free for each 3 candies you bought. ");
            }
            else
            {

            }


            Discount = discount1 + discount2 + discount3;


            double TotalCost = Ticket + Concession - Discount;
            System.Console.WriteLine();
            System.Console.WriteLine("[Printing Cost Details:]");
            System.Console.WriteLine("Your ticket cost is: " + Ticket);
            System.Console.WriteLine("Your concession cost is: " + Concession);
            System.Console.WriteLine("Your total discount is: " + Discount);
            System.Console.WriteLine("Your total cost is: " + TotalCost);


            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to end" );
            System.Console.ReadKey();

        }
    }
}
