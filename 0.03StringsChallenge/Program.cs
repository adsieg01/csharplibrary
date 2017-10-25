using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._03StringsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            string empName = "John Jones";

            string date = DateTime.Today.ToShortDateString();

            Console.WriteLine($"Dear Mr. {empName} The date is {date}. I am currently learning C# and I will make you a millionaire if you hire me. Thanks.");
            

            //Bronze
            //Currency
            double cash = 563.3265;
            Console.WriteLine("{0:C}", cash);

            //Percentage

            //Phone Number
            int phoneNumber = 1234567890;
            string number1 = phoneNumber.ToString("(###) ### - ####");
            Console.WriteLine(number1);
            Console.ReadLine();

        }
    }
}
