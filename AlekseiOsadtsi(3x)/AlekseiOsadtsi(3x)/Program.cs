using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlekseiOsadtsi_3x_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shop
            List<ClassFood> groceries = new List<ClassFood>
            {
                new ClassFood("banana", 1.2),
                new ClassFood("potatoes", 1),
                new ClassFood("icecream", 2.5),
            };

            //Client
            Console.WriteLine("Please enter your first name!");
            string firstName = Console.ReadLine();

            Console.WriteLine("Hi, " + firstName + "! Please enter your last name:");
            string lastName = Console.ReadLine();

            Persons client = new Persons(firstName, lastName);

            Console.WriteLine("Welcome to our shop, " + client);
            client.ShoppingCart = new ShoppingCart();

            ChooseFood(groceries, client);
            while (Console.ReadLine() == "Y")
            {
                ChooseFood(groceries, client);
            }
            double sum = client.ShoppingCart.CalculateSum();
            Console.WriteLine("Your total list is " + sum + " Thank you for visiting!");
        }

        private static void ChooseFood(List<ClassFood> groceries, Persons client)
        {
            Console.WriteLine("What do you want to buy?");
            string foodName = Console.ReadLine();
            ClassFood chosenFood = groceries.FirstOrDefault(x => x.Name == foodName);
            if (chosenFood == null)
            {
                Console.WriteLine("Excuse me, we don't have " + foodName + "in our shop");
            }
            else
            {
                Console.WriteLine("How much?");
                string amount = Console.ReadLine();
                int a;
                bool success = int.TryParse(amount, out a);
                while (!success)
                {
                    Console.WriteLine("Excuse me, amount should be integer value: ");
                    amount = Console.ReadLine();
                    success = int.TryParse(amount, out a);
                }
                client.ShoppingCart.AddToCart(chosenFood, a);
            }
            Console.WriteLine("Anything else? Y/N");
        }
    }
}
