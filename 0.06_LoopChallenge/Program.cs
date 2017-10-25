using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._06_LoopChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            while (n < 101)
            {
                if (n % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (n % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (n % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(n);
                }
                n += 1;
            }
        }
    }
}
