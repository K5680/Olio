﻿using System;
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

        private double salary; //koska "ylikirjoitetaan" employee -luokan salary-ominaisuus
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

        // override-määreellä piilotettu alkup. employee -luokan salary. New-määreellä ei toimi, mutta miksi?
        public override double Salary
        {
            get { return salary; }
            set
            {
                Console.WriteLine("Asetetaan pomo-luokan työntekijä.............");
                if (value < 0.1)
                {
                    Console.WriteLine("Palkaton kaveri?");
                }
                else if (value > 10000)
                {
                    Console.WriteLine("Onkohan 10000 riittävä näin pätevälle kaverille? Mutta olkoon...");
                    salary = value;
                }
                else
                {
                    salary = value;
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
