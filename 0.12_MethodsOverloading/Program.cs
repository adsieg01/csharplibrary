using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12_MethodsOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Player class with 
            // 1 attack methods that accept 3 different sets of parameters

            Player andrew = new Player();

            
            andrew.Attack(100);
            andrew.Attack(1000, "dusty stick");
            andrew.Attack(1000, "dusty stick", 9);


        }
    }
}
