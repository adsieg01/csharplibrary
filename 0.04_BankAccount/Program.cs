using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._04_BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Bank Account Balance");
            Console.ReadLine();

            string balance = Console.ReadLine();
           int realNumber = Convert.ToInt32(balance);
          

            if (realNumber > 10000)
            {
                Console.WriteLine("You're rich");
                Console.ReadLine();
            }
            else if (realNumber < 10000)
            {
                Console.WriteLine("You're poor");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Entry");
                Console.ReadLine();
            }
        }
    }
}
