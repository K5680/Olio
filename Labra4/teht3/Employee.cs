using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Employee
    {
        //Työntekijöiden osalta seuraavia tietoa: työntekijän nimi (Name), työntekijän ammatti (Profession) ja palkka (Salary). 
        //Samassa ohjelmassa johtajien tietoja (Boss), heillä on edellisten lisäksi myös auto (Car) ja palkkabonus (Bonus). 

        private string name;
        private string profession;
        private double salary;

        public string Name { get; set; }
        public string Profession { get; set; }
        public virtual double Salary
        {
            get { return salary; }
            set
            {
                Console.WriteLine("Asetetaan työntekijät.............");
                if (value < 0.1)
                {
                    Console.WriteLine("Palkaton kaveri?");
                }
                else if (value > 10000)
                {
                    Console.WriteLine("Älytön palkka! Mutta olkoon...");
                    salary = value;
                }
                else
                {
                    salary = value;
                }
            }
        }

        public Employee(string name, string profession, double salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }

        public override string ToString()
        {
            return "  Employee-tiedot:  " + Name + " " + Profession + " " + Salary;
        }

        public Employee()
        {
        }

    }
}
