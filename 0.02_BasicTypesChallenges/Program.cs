using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._02_BasicTypesChallenges
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1 = 9;
            int number2 = 72;

            string myName = "Jay";
            string myRealName = "Andrew";

            bool myTruth = true;
            bool NotMyTruth = false;

            decimal myDecimal = 2.5543M;
            decimal givenChange = 9.534345M;

            string fullName = "Andrew" + " Sieg";
            Console.WriteLine(fullName);
            Console.ReadLine();

            string yearBorn = "2017";
            int.TryParse(yearBorn);


            //Gold
            string birthYear = "1990";
            int year = Convert.ToInt32(birthYear);
            Console.WriteLine(year);
            Console.ReadLine();


        }
    }
}
