using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        // properties
        public string Model { get; set; }
        public string Color { get; set; }
        public double Engine { get; set; }
        public int Speed { get; set; }
        public bool FuzzyDices { get; set; }
        public int DoorCount { get; set; }


        //parametrillinen konstruktori
        public Car()
        {
            FuzzyDices = true;
        }

        public Car(string model, string color, bool fuzzyDices)
        {
            Model = model;
            Color = color;
            FuzzyDices = fuzzyDices;
        }

        // don't create any constructor, so default one will be used

        // method to give more speed
        public void Accelerate()
        {
            Speed += 5;
        }

        // method to slow down
        public void Brake()
        {
            Speed -= 5;
        }
        
        // method to display car data
        public void PrintData()
        {
            Console.WriteLine("Car data : ");
            Console.WriteLine("- model : " + Model);
            Console.WriteLine("- color : " + Color);
            Console.WriteLine("- engine : " + Engine);
            Console.WriteLine("- speed : " + Speed);
            Console.WriteLine("- fuzzy dices : " + FuzzyDices);
            Console.WriteLine("- door count : " + DoorCount);
        }

        // destructor
        ~Car()
        {
            Console.WriteLine("Car object destroyed.");
        }
    }
}
