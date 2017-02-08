using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra3_teht4
{
    class Vehicle
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Tyres { get; set; }

        public void PrintData()
        {
            Console.WriteLine("Car Name : " + Name);
            Console.WriteLine("Speed : " + Speed);
            Console.WriteLine("Tyres: " + Tyres);
        }

        public override string ToString()
        {
            return "Name:" + Name + " Speed: " + Speed + " Tyres: " + Tyres;
        }
    }
}
