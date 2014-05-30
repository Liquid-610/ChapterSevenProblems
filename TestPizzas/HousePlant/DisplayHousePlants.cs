using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HousePlant
{
    class DisplayHousePlants
    {
        static void Main(string[] args)
        {
            HousePlants houseplants, houseplants1, houseplants2;
            houseplants = new HousePlants();
            houseplants1 = new HousePlants();
            houseplants2 = new HousePlants();

            houseplants.Name = "Philodendron";
            houseplants.Price = 29.99;
            houseplants.Fed = true;

            houseplants1.Name = "Lilly";
            houseplants1.Price = 10.99;
            houseplants1.Fed = true;

            houseplants2.Name = "Tulip";
            houseplants2.Price = 22.99;
            houseplants2.Fed = false;


            Console.WriteLine(houseplants.Name);
            Console.WriteLine(houseplants.Price);
            Console.WriteLine(houseplants.Fed);

            Console.WriteLine(houseplants1.Name);
            Console.WriteLine(houseplants1.Price);
            Console.WriteLine(houseplants1.Fed);

            Console.WriteLine(houseplants2.Name);
            Console.WriteLine(houseplants2.Price);
            Console.WriteLine(houseplants2.Fed);

           

    }
}
