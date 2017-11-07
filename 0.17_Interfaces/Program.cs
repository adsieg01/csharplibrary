using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayClass exampleArrayClass = new ArrayClass();
            exampleArrayClass.CheckCompacity();

            ListClass exampleListClass = new ListClass();
            exampleListClass.CheckCompacity();
        }
    }
}
