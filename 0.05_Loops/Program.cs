using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {   

           

            for (int i = 0; i < 11; i++)
            {
                if (i == 10)
                {
                    Console.WriteLine(i);
                    Console.WriteLine("Blast off!");
                }
                Console.ReadLine();
            }
        }
    }
}
