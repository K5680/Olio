using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labra3_teht4
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle datsun = new Vehicle();
            datsun.Name = "Jukkis";
            datsun.Speed = 79;
            datsun.Tyres = 4;

            datsun.PrintData();

            System.Console.ReadLine();
            
            datsun.Speed = 45;
            Console.WriteLine(datsun.ToString());

            System.Console.ReadLine();

        }
    }
}
