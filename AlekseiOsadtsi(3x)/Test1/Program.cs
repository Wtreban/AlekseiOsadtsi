using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        private static object taRgv18;

        static void Main(string[] args)
        {
            List<Students> studentslist = new List<Students>
            {
                new Students("Aleksei", "Petrov", "IsStudying"),
                new Students("Oleg", "Golovin", "IsStudying"),
                new Students("Jura", "Ovchiikov", "IsStudying"),

            };

            Console.WriteLine("Please enter students name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter students last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Please enter IsStudying: ");
            string isstudying = Console.ReadLine();

            Students student = new Students(firstName, lastName, isstudying);

            Console.WriteLine("Do you want to add "  + firstName  + " " + lastName + " " + "to the group TARgv18 ?");
            while (Console.ReadLine() == "Y")
            {
                string tARgv18 = string TARgv18;
                tARgv18.AddToList(student);
            }
            string TARgv18 = Console.ReadLine();
        }
    }
}
