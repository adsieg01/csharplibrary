using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_InterviewPractice
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int i = 1; i <= 5; i++)
            {
                
              
            }
            Console.WriteLine("_____________________________________________________");
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
            Console.ReadLine(); 




        }
    }
}
