using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlekseiOsadtsi_3x_
{
    public class Persons
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ShoppingCart ShoppingCart { get; set; }

        public Persons(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
