using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSquares
{
    class Square
    {
         private int side;
         private double area;
        

         public Square(int length)
         {
             side = length;
             area = length * length;
         }

         public int Side
         {
             get
             {
                 return side;
             }
             

             
         }

        public double Area
        {
            get
            {
                return area;
            }

            
    }
}
