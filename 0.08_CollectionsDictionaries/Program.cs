using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._08_CollectionsDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {


            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("Gladiator", 2000);
            dictionary.Add("A Beautiful Mind", 2001);
            dictionary.Add("Chicago", 2002);
            dictionary.Add("Lord of the Rings", 2003);
            dictionary.Add("The Aviator", 2004);
            dictionary.Add("CRASH", 2005);

            foreach ( var movie in dictionary)
            {
                Console.WriteLine(movie.Key);
            }


        }
    }
}
