using System;
using System.Collections.Generic;
using System.Text;

namespace Final_Exam
{
    class Passenger
    {
        private string Name;
        public double Weight; //I couldn't access passenger.Weight in Elevator class with out having this public

        public Passenger(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }
    }
}
