using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ConsoleChallengeFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone myPhone = new Phone("Apple", "iPhone");

           

            Console.WriteLine($"I have an {myPhone.Make} { myPhone.Model}");
            Console.ReadLine();

            myPhone.PrintPhone();
        }
    }
}
