using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_arrays
{
    class Program
    {
        static void Main(string[] args)
        {   //Bronze
            string[] books = new string[3];
            books[0] = "Lord of the Rings";
            books[1] = "Harry Potter";
            books[2] = "Of Mice and Men";

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine(books[i]);
            }

            //Silver
            int[] numbers1 = new int[5] { 3, 4, 4, 5, 5 };
            int[] numbers2 = new int[5] { 7, 2, 43, 2, 12 };

            int[] numbers3 = new int[5];
            //could finish with for loop
            for (int i = 0; i < numbers3.Length; i++)
            {
                numbers3[i] = numbers1[i] + numbers2[i];
            }
            // Or finish with foreach loop
            foreach (int number in numbers3)
            {
                Console.WriteLine(number);
            }

            //Gold
            int[] randomNumbers = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rnd.Next();
            }

            foreach (int number in randomNumbers)
            {
                Console.WriteLine(number);
            }
          
            

             







        }
    }
}
