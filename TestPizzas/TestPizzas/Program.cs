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
            Pie pizza = new Pie();

            double d = pizza.diameter;
            double p = pizza.price;

            pizza.price = 13.99;
            pizza.diameter = 12;
            pizza.name = "Pepperoni";

            Console.WriteLine("{0}in",pizza.diameter);
            Console.WriteLine(pizza.name);
            Console.WriteLine(pizza.price);

        }
    }
}
