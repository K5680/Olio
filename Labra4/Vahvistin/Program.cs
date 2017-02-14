using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahvistin
{
    class Program
    {
        static void Main(string[] args)
        {
            Amp vahvari = new Amp();
            int vola;

            do
            {
                Console.WriteLine("Anna äänenvoimakkuus (0-100): ");
                string ota_arvo = Console.ReadLine();

                bool result = Int32.TryParse(ota_arvo, out vola);
                if (result)
                {
                    vahvari.Volume = vola;

                } else Console.WriteLine("Koita painaa numeroita...");

                Console.WriteLine("Äänenvoimakkuus on :  {0}", vahvari.Volume);

            } while (vola != 111); //exit jos annetaan volumeksi 111

        }
    }
}
