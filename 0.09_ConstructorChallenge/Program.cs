using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ConstructorChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            Phone myPhone = new Phone("Apple", "iPhone");

            Console.WriteLine(myPhone);
            Console.ReadLine();

            Console.WriteLine($"I have a {myPhone.Make} { myPhone.Model}");

        }
    }
}
