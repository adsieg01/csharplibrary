using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces
{
    class ListClass : IEnum, IList, ICollect
    {
        public void AddStuff()
        {
            Console.WriteLine("Add stuff to list");
        }

        public void CheckCompacity()
        {
            Console.WriteLine("Check compacity of list");
        }

        public void CheckCount()
        {
            Console.WriteLine("Checking count of list");
        }

        public void IterateOverCollection()
        {
            Console.WriteLine("Iterating over list");
        }

        public void RemoveStuff()
        {
            Console.WriteLine("Removing stuff from list");
        }
    }
}
