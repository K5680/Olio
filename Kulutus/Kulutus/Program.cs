using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*  Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa. Tee ohjelma,
 *  joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan 
 *  bensan määrän sekä bensaan menevän rahan määrän. */


namespace Kulutus
{
    class Program
    {
        static void Main(string[] args)
        {
            string matka;
            double kulutus = 7.02;
            double hinta = 1.595;

            // kysytään käyttäjältä matkan pituus
            Console.WriteLine("Keskikulutus on " + kulutus + " l/km ja polttoaineen hinta " + hinta + ".  Näppäile matkan pituus: ");
            matka = System.Convert.ToString(System.Console.ReadLine());

            // lasketaan bensankulutus ja kustannukset
            Console.WriteLine("matka: " + System.Convert.ToInt32(matka) + "km \n" + 
                "polttoainetta kului: " + (System.Convert.ToInt32(matka) * (kulutus/100)) + " litraa \n" +
                "rahaa paloi: " + hinta * System.Convert.ToInt32(matka) * (kulutus / 100) + " euroa.");

            do
            { } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        
    }
}
