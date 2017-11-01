oleusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_Constructors_real
{
    class Student
    {
        public Student(string lastName, int grade)
        {
            this.LastName = lastName;
            this.Grade = grade;
        }

        public Student()
        {

        }

        public Student(string firstName)
        {
            this.FirstName = firstName;
        }

        //Constructor (Needs to be the same name as the class 0
        public Student(string firstName, string lastName, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        //Constructor 
        public Student(string firstName, string lastName, int age, int grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Grade = grade;
        }

        //Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Grade { get; set; }
        public int Age { get; set; }

       

    }
}
