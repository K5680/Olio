using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a one car instance
            Car datsun = new Car();
            datsun.Model = "Datsun 100A";
            datsun.Color = "red";
            datsun.Engine = 1.0;
            datsun.Speed = 0;
            datsun.FuzzyDices = true;
            datsun.DoorCount = 2;
            // display car data
            datsun.PrintData();
            Console.ReadLine();
            // accelerate, change car's speed value
            datsun.Accelerate();
            // display car data again, notice changed speed value!
            datsun.PrintData();
            Console.ReadLine();

            //luodaan porsche parametrillisella konstruktorilla (ei kaikkia parametreja)
            Car porsche = new Car("Boxter", "green", false);
            porsche.PrintData();
            Console.ReadLine();

        }
    }
}
