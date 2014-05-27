using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPizzas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pie pizza = new Pie(12);

            double d = pizza.Diameter;
            double p = pizza.Price;

            pizza.Price = 13.99;
            pizza.Diameter = 12;
            pizza.Name = "Pepperoni";

            Console.WriteLine("{0}in",pizza.Diameter);
            Console.WriteLine(pizza.Name);
            Console.WriteLine(pizza.Price);

        }
    }
}
