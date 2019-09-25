using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class TARgv18
    {
        public List<Students> Items { get; set; }

        public TARgv18()
        {
            Items = new List<Students>();
        }

        public void AddToList(Students stud)
        {
            Items.Add(stud);
        }
    }
}
