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

            int luotavien_maara = 10000;
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
            double match = 0; // luotu doublena, jotta prosenttilasku toimii desimaalilla
            
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
                    apustring = lista[i].FirstName.ToString();// jos etu2 -stringi löytyy listan FirstName -sarakkeesta (jos FirstName jätetään pois, etsii stringiä kaikista "sanoista")
                    if (apustring.Contains(etu2) == true)
                    {
                        Console.Write(".");
//                        Console.Write("\n{0} <MATCH> -> {1}", etu2, lista[i]);
                        match++;
                    }

                }
            }
            //jotta prosenttilasku onnistuu desimaalin kanssa, muuttujien on oltava double tai muunnettava doubleksi
            Console.WriteLine("\n\nEtsimiseen kulunut aika: " + kello.Elapsed + "   Pareja löydetty: " + match + " <enter>");
            Console.WriteLine("\nOsumia " + match + " / " + luotavien_maara + " = " + (match/System.Convert.ToDouble(luotavien_maara))*100 +  "%");
            Console.ReadKey();

            kello.Reset();
            // Tehdään sama Dictionary-tyypillä
            kello.Start();
            Dictionary<string, Person> persons = new Dictionary<string, Person>();
            nro = 0;
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

                string nim = "nro"+nro;
                persons.Add(nim, new Person { FirstName = etu, LastName = suku, Nro = nro });//etu, suku, nro));
                
            } while (nro < luotavien_maara);
            kello.Stop();
            Console.WriteLine("Tietoja luotu: " + nro);
            Console.WriteLine("Tietojen luomiseen kulunut aika: " + kello.Elapsed + " <enter>");
            Console.ReadKey();


            kello.Reset();
            kello.Start();
            //etsitään tuhatta eri "nimeä" Dictionarystä
            match = 0;
            for (int tuhat = 0; tuhat < 1000; tuhat++)
            {
                //arvotaan etsittävä sana
                for (int i = 0; i < etunimen_pituus; i++)
                {
                    etunimi[i] = kirjaimet[random.Next(kirjaimet.Length)];
                }
                etu2 = new string(etunimi);

                // jos etu2 -stringi löytyy Dictionaryn FirstName -sarakkeesta
                foreach (Person person in persons.Values)
                {
                    if (person.FirstName == etu2)
                    {
                        Console.Write(".");
                        match++;
                    }
                    
                }
            }

            kello.Stop();
            Console.WriteLine("\n\nEtsimiseen kulunut aika: " + kello.Elapsed + "   Pareja löydetty: " + match + " <enter>");
            Console.WriteLine("\nOsumia " + match + " / " + luotavien_maara + " = " + (match / System.Convert.ToDouble(luotavien_maara)) * 100 + "%");
            

            Console.ReadKey();

        }
    }
}
