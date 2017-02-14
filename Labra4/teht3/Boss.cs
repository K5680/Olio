using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Boss : Employee
    {

        //Työntekijöiden osalta seuraavia tietoa: työntekijän nimi (Name), työntekijän ammatti (Profession) ja palkka (Salary). 
        //Samassa ohjelmassa johtajien tietoja (Boss), heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus). 

        private string car;
        private double bonus;

        public string Car { get; set; }
        public double Bonus
        {
            get { return bonus; }
            set
            {
                if (value > -0.1)
                {
                    bonus = value;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + "       BOSS-tiedot: " + Car + " " + Bonus;
        }

        public Boss(string name, string profession, double salary, string car, double bonus) 
            : base(name, profession, salary)
        {
            Car = car;
            Bonus = bonus;
        }
    }
}
