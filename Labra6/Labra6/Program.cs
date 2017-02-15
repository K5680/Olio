using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Linq;

namespace Labra6
{
    class Program
    {
        static void Main(string[] args)
        {

            double luotavien_maara = 10000;
            int nro = 0;
            int etunimen_pituus = 4;
            int sukunimen_pituus = 10;
            
            //arvonnan alustus
            var etunimi = new char[etunimen_pituus];
            var sukunimi = new char[sukunimen_pituus];
            var kirjaimet = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
            var random = new Random();

            //luodaan lista
            List<Person> lista = new List<Person>();
            
            // kellotus
            Stopwatch kello = new Stopwatch();
            kello.Start();

            do
            {
                nro++;
                //henkilöjen luonti
                for (int i = 0; i < etunimen_pituus; i++)
                {
                    etunimi[i] = kirjaimet[random.Next(kirjaimet.Length)];
                }
                var etu = new string(etunimi);

                for (int i = 0; i < sukunimen_pituus; i++)
                {
                    sukunimi[i] = kirjaimet[random.Next(kirjaimet.Length)];
                }

                var suku = new string(sukunimi);

                //lisätään henkilö listaan
                lista.Add(new Person { FirstName = etu, LastName = suku, Nro = nro });//etu, suku, nro));
                 
            } while (nro < luotavien_maara);
            //kellon pysäytys
            kello.Stop();
            Console.WriteLine("Tietojen luomiseen kulunut aika: " + kello.Elapsed + " <enter>");
            Console.ReadKey();

            kello.Start();
            //tietojen näyttäminen          
            //          foreach (Person person in lista)
            //          {
            //                Console.WriteLine(person.ToString());
            //          }


            //etsitään tuhatta eri "nimeä"
            string apustring;
            string etu2;
            double match = 0;
            for (int tuhat = 0; tuhat < 1000; tuhat++)
            {

                //arvotaan etsittävä sana
                for (int i = 0; i < etunimen_pituus; i++)
                {
                    etunimi[i] = kirjaimet[random.Next(kirjaimet.Length)];
                }
                etu2 = new string(etunimi);

                //etsitään sanaa
                //Console.WriteLine("Etsitään nimeä:  " + etu2);
                for (int i = 0; i < luotavien_maara; i++)
                {
                    apustring = lista[i].ToString();
                    if (apustring.Contains(etu2) == true)
                    {
                        Console.Write(".");
                        //             Console.Write("\n{0} <MATCH> -> {1}", etu2, lista[i]);
                        match++;
                    }
                    else
                    {
                         
                    }

                }
            }
            //jotta prosenttilasku onnistuu desimaalin kanssa, match ja luotavien_maara on doubleja
            Console.WriteLine("\n\nEtsimiseen kulunut aika: " + kello.Elapsed + "   Pareja löydetty: " + match + " <enter>");
            Console.WriteLine("\nOsumia " + match + " / " + luotavien_maara + " = " + (match/luotavien_maara)*100 +  "%");
            Console.ReadKey();

            
        }
    }
}
