using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._09_ConstructorChallenge
{
    class Phone
    {
        public Phone(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }

            public string Make { get; set; }
        public string Model { get; set; }


            
        }
    }
}
