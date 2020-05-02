using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Exam
{
    class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            this.Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {

            double currentWeight = 0;
            foreach (Passenger passenger in Occupants)
            {
                currentWeight += passenger.Weight; //I couln't access (passenger.Weight) without having variable-Weight as public in class-Passenger.
            }
            return currentWeight;
        }

        public bool IsOverMaxCapacity()
        {
            return (GetCurrentWeight() > MaxWeight);
        }
    }
}
