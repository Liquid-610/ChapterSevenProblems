using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoSquares
{
    class Program
    {
        static void Main(string[] args)
        {
              Square[] oneside = new Square[10];


              for (int i = 0; i < oneside.Length; i++)
              {
                  oneside[i] = new Square(i + 10);
                  Console.WriteLine(oneside[i].Area);
              }
        }
    }
}
