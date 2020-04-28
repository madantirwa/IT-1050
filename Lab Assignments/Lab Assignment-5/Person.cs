using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_Assignment_5
{
    class Person
    {
        public string FirstName;
        public string LastName;

        public Person(string theirFirstName, string theirLastName)
        {
            this.FirstName = theirFirstName;
            this.LastName = theirLastName;
        }

        public string Print()
        {
            return this.FirstName + " " + this.LastName;
        }
    }
}
