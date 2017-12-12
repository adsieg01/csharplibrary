using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18_WhiteBoard
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public Person(string last, string first, int age)
        {
            last = LastName;
            first = FirstName;
            age = Age;
        }

        public Person(string first, int age)
        {
            first = FirstName;
            age = Age;
        }

        

    }

}
