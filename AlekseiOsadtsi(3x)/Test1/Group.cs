using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Group
    {
        public string name { get; set; }

        public List<Students> newGroup { get; set; }

        public Group(string name)   
        {
            this.name = name;
            newGroup = new List<Students>();
        }

        public int exeptionMethod()
        {
            int a = 0;
            return a;
        }

        public void AddToGroup (Students students)
        {
            newGroup.Add(students);
        }
    }
}
