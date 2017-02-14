using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra4
{
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {
        }

        public Teacher(string firstName, string lastName, string room) : base(firstName, lastName)
        {
            Room = room;
        }

        public void TeacherMethod()
        {
            Console.WriteLine("Teacher");
        }

        public override string ToString()
        {
            return base.ToString() + " " + Room;
        }
    }
}
