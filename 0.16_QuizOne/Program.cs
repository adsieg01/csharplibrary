using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_QuizOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle newTriangle = new Triangle(8,4);

            Console.WriteLine($"Area = {newTriangle.Area()}");

            Triangle newTriangle2 = new Triangle(3, 1);

            Console.WriteLine($"Area = {newTriangle2.Area()}");

            Triangle newTriangle3 = new Triangle(6, 6);

            Console.WriteLine($"Area = {newTriangle3.Area()}");

            Triangle newTriangle4 = new Triangle(3, 4);

            Console.WriteLine($"Area = {newTriangle4.Area()}");

            Triangle newTriangle5 = new Triangle(10, 40);

            Console.WriteLine($"Area = {newTriangle5.Area()}");
        }
    }
}
