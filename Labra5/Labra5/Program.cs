using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra5
{
    class Program
    {
        static void Main(string[] args)
        {
            Tyre nokia = new Tyre();
            nokia.Name = "Nokia";
            nokia.Model = "Hakkapeliitta";
            nokia.Size = "215R15";


            Vehicle datsun = new Vehicle();
            datsun.Model = "100A";
            datsun.Name = "Datsun";
            datsun.addTyre(nokia);

            string ootas = Console.ReadLine();

            Console.WriteLine(datsun.ToString());

            ootas = Console.ReadLine();


        }
    }
}
