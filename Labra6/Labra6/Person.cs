using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra6
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Nro { get; set; }


        public Person()
        {
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + Nro;
        }

    }
}
