﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee jukkis = new Employee("Jukka Poika", "Muusikko", 3000.50);
            Employee sukkis = new Employee("Sukka Poika", "Luuseri", 0.0);
            Employee pekkis = new Employee("Pekka Poika", "Huusisti", 1100.0);
            Boss pomo = new Boss("Pentti Puutalo","Henkilöstöjohtaja",10500,"Fiat 600",1000);

            Console.WriteLine(pomo.ToString());
            string odota = Console.ReadLine();

            Console.WriteLine(sukkis.ToString());
            odota = Console.ReadLine();
        }
    }
}