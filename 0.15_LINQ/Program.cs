using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creat new array of instructors 
            string[] instructors = { "Jay", "Paul", "Kenn", "Dave", "Auri" };

            //Set up the query
            IEnumerable<string> query = from i in instructors
                                        where i.Length == 4
                                        select i;

            //Loop through the array using the query 
            foreach (string name in query)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("\n");
            //Example 2
            IEnumerable<Employee> employees = new List<Employee>()
            {
                new Employee {ID=1,Name="Johnboy",HireDate=new DateTime(2016,3,5)},
                new Employee {ID=2,Name="Old Gregg",HireDate=new DateTime(2016,6,23)},
                new Employee {ID=3,Name="Minnie Pearl",HireDate=new DateTime(2009,11,4)},
                new Employee {ID=4,Name="Andy Griffith",HireDate=new DateTime(2011,9,1)},
                new Employee {ID=5,Name="Boba Fett",HireDate=new DateTime(2015,8,8)}
            };

            IEnumerable<Employee> query2 = from e in employees
                                          where e.HireDate.Year == 2016
                                          orderby e.Name ascending
                                          select e;

            foreach (Employee employee in query2)
            {
                Console.WriteLine(employee.Name);
            }



        }
    }
}
