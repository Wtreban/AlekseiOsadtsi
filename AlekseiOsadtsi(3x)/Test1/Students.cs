using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Students
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string IsStudying { get; set; }

        public TARgv18 TARgv18 { get; set; }

        public Students(string firstName, string lastName, string isstudying)
        {
            FirstName = firstName;
            LastName = lastName;
            IsStudying = isstudying;
        }
    }
}
