using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._07_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Donut PaulDonut = new Donut();
            Donut KennDonut = new Donut();
            Donut AndrewDonut = new Donut();

            KennDonut.Filling = "Strawberry Jelly";
            KennDonut.Price = 0;
            KennDonut.Type = "Jelly";
            KennDonut.IsSpecial = false;

            PaulDonut.Filling = "Cherry Jelly";
            PaulDonut.Price = 7.99M;
            PaulDonut.Type = "Jelly";
            PaulDonut.IsSpecial = true;

            AndrewDonut.Filling = "None";
            AndrewDonut.Price = 2.99M;
            AndrewDonut.Type = "Round";
            AndrewDonut.IsSpecial = false;

            Console.WriteLine(PaulDonut);
            Console.WriteLine(PaulDonut.Filling);

        }
    }
}
