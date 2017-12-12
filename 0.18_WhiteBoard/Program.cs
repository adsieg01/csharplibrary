using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_WhiteBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a public method that accepts two names as parameters 
            //and then returns the full name by implementing concatenation

            string name (string FirstName, string LastName)
            {
                
                return FirstName + LastName;
            }
            Console.WriteLine(name("John ","Gates"));
            

            //Create a public method that accepts two numbers as parameters and then 
            //returns thier product

            int product (int NumberOne, int NumberTwo)
            {
                return NumberOne * NumberTwo;
            }
            Console.WriteLine(product(3, 6));

            Person person1 = new Person("craig", "Smith", 30);
            Person person2 = new Person("Annie", 20);

            //Write a doMath method that takes three parameters called 
            //operator / numOne / numTwo. The method should then return correct calculations
            //based upon the arguments.

            int doMath(string Operator, int FirstNumber, int SecondNumber)
            {
                a = .Add(FirstNumber, SecondNumber);
                
                return 
            }

            Console.ReadLine();

        }
    }
}
