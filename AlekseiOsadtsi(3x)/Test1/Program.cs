using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        private static List<Students> newGroup;
        private static object students;

        static void Main(string[] args)
        {
            List<Students> studentslist = new List<Students>
            {
                new Students("Aleksei", "Petrov"),
                new Students("Oleg", "Golovin"),
                new Students("Jura", "Ovchiikov"),
                new Students("Elena", "Maliweva"),
                new Students("Darja", "Petrova")

            };

            for (int i=0; i < studentslist.Count; i++)
            {
                Console.WriteLine($"Students ID: {i + 1}\nName: {studentslist[i].FirstName}" +
                    $"\nLast name: {studentslist[i].LastName}\nisStudying: {studentslist[i].IsStudying}\n\n/////////////////\n");
            }

            Console.WriteLine("Please enter students name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter students last name: ");
            string lastName = Console.ReadLine();

            Students stud = new Students(firstName, lastName);

            Console.WriteLine("Enter group name: ");
            string name = Console.ReadLine();

            Group group = new Group(name);

            foreach (var line in studentslist)
            {
                group.AddToGroup(line);
            }

            Console.WriteLine(group.name);

            foreach (var person in group.newGroup)
            {
                Console.WriteLine(person);
            }

        }
    }
}
