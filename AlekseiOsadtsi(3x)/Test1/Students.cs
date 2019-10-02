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

        public bool IsStudying { get; set; }

        public int PersonalCode  { get; set; }

        public object Base { get; internal set; }
        public object Group { get; internal set; }

        public Students(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            IsStudying = true;
        }

        internal object Split(char v)
        {
            throw new NotImplementedException();
        }
    }
}
