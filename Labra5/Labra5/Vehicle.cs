using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        private const int maxTyres = 4;
        private int TyresCount = 0;
        public Tyre[] Tyres { get; set; }


        public Vehicle()
        {
            Tyres = new Tyre[maxTyres];
        }


        public void addTyre(Tyre tyre)
        {
            if (TyresCount < maxTyres)
            {
                Tyres[TyresCount] = tyre;
                TyresCount++;
                Console.WriteLine("Tyre {0} added to vehicle {1} ", tyre.Name, Name);
            }
            else
            {
                Console.WriteLine("No more than 4 tyres, please.");
            }
        }

        public override string ToString()
        {
            string s = "Vechicle Name: " + Name + " Model:" + Model + "\nTyres:";
            foreach (Tyre tyre in Tyres)
            {
                if (tyre != null) s += "\n-" + tyre.ToString();
            }
            return s;
        }
    }

}
