using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16_QuizOne
{
    class Triangle : Shape
    {
        //Properties
       
        public int Base { get; set; }
        public int Height { get; set; }

        //Constructor
        public Triangle(int tbase, int theight)
        {
            this.Base = tbase;
            this.Height = theight;

        }

        //Methods
        public override double Area()
        {
            return this.Base*.5*(this.Height);
        }
    }
}
