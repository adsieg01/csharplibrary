using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_Coditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter on a scale of 1-5 how you are feeling today.");
            Console.Write("Enter here: " );
            string feelingNumber = Console.ReadLine();

            if (feelingNumber == "1")
            {
                Console.WriteLine("That sucks");
            }
            else if (feelingNumber == "2")
            {
                Console.WriteLine("could be better");
            }
            else if (feelingNumber == "3")
            {
                Console.WriteLine("could be worse");
            }
            else if (feelingNumber == "4")
            {
                Console.WriteLine("Not bad!");
            }
            else if (feelingNumber == "5")
            {
                Console.WriteLine("Let's Party!");
            }
            else
            {
                Console.Write("Sorry I don't understand.");
            }



        }
    }
}
