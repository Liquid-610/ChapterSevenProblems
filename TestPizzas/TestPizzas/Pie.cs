using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestPizzas
{
    class Pie
    {
        private double diameter;
        private string name;
        private double price;

        public Pie(double Diameter)
        {
            this.Diameter = diameter;
        }

        public Pie(string Name)
        {
            this.Name = name;
        }

        public double Diameter
        {
            get
            {
                return diameter = 12;
            }

            set
            {
                diameter = value;
            }
        }

              public double Price
          {
            get
            {
                return price = 13.99;
            }

            set 
            {
                price = value;
            }
          }

              public string Name
              {
                  get
                  {
                      return name;
                  }

                  set
                  {
                      name = value;
                  }
              }
    

        }

    }

