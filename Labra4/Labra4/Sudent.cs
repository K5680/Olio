using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Sudent:Person
    {
        public string StudentID { get; set; }

        public Sudent()
        {
        }

        public Sudent(string firstName, string lastName, string studentID) : base(firstName, lastName)
        {
            StudentID = studentID;
        }

        public void StudentMethod()
        {
            Console.WriteLine("STudent");
        }

        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }
    }

}
