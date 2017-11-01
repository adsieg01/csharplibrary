using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._14_Override
{
    class Circle : Shape
    {
        public int RadiusSize { get; set; }

        public Circle (int radius)
        {
            this.RadiusSize = radius; 
        }

        public override double Area()
        {
            return Math.Pow(RadiusSize, 2)*Math.PI;
        }

      

    }
}
