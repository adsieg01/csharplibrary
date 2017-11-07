﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces
{
    class ArrayClass : IEnum, IList, ICollect
    {
        public void AddStuff()
        {
            Console.WriteLine("Iterating over the array...");

        }

        public void CheckCompacity()
        {
            Console.WriteLine("You can't check the capacity of an array...");
        }

        public void CheckCount()
        {
            Console.WriteLine("Checking the count of the array...");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("Iterating over the array...");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Removed stuff from the array");
        }
    }
}
