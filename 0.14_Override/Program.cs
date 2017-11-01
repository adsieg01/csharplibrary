using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            Square newSquare = new Square(4);

            Console.WriteLine($"Area = {newSquare.Area()}");

            Circle newCircle = new Circle(3);

            Console.WriteLine($"Area = {newCircle.Area()}");
        }
    }
}
