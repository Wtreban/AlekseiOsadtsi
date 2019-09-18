using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlekseiOsadtsi_3x_
{
    public class ClassFood
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public ClassFood(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
