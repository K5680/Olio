using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7
{
    class Program
    {


        static void Main(string[] args)
        {
            // Tee ohjelma, joka lukee yksinkertaisesta tekstitiedosto nimet.txt 
            // henkilöitten nimiä ja kertoo montako nimeä löytyy ja montako kertaa kukin nimi esiintyy.
            // tallenne eri paikkaan -> file exist?
            
            int i = 0;
            //luodaan nimiä -oliolista
            List<Nimet> nimiä = new List<Nimet>();
            
            string hakemisto = "e:\\"; //Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            try
            {
                int[] esiintymiset = new int[30];

                string[] rivit = System.IO.File.ReadAllLines(hakemisto + @"\nimet.txt");  //luetaan tiedoston rivit taulukkoon
                int onkojo = 0; // muuttuja, jonka arvo 1, jos nimi on jo olemassa
                int a = 0;

                //käydään läpi kaikki tiedoston rivit
                while (i < rivit.Count())      // rivit.Count = montako riviä taulukossa
                {   
                    foreach (string rivi in rivit) // käydään läpi kaikki tiedoston rivit
                    {  
                        foreach (Nimet nimet in nimiä) // Olio-listan jokaisen nimen kohdalla verrataan nimeä olio-listan nimiin
                        {
                            if (nimet.ToString().Contains(rivi)) // jos oliolistan nimi sisältää tiedosto-listan nimen
                            {
                                onkojo = 1;    // Annetaan arvoksi 1 jottei sitä enää lisätä oliolistaan uudestaan
                                nimet.Lisää(); // mutta lisätään kyseisen nimen lukumäärää
                              //Console.WriteLine("Lisätty  " + nimet.Nimi + nimet.Määrä);
                            }
                        }

                        if (onkojo == 0) // jos vertailun jälkeen nähdään että nimeä ei ole jo oliolistalla, lisätään se
                        {
                            nimiä.Add(new Nimet { Nimi = rivi }); // lisätään nimi olioksi

                            foreach (Nimet nimet in nimiä)
                            {
                                if (nimet.ToString().Contains(rivi)) // jos oliolistan nimi sisältää tiedosto-listan nimen, annetaan arvoksi 1 jottei sitä enää lisätä oliolistaan uudestaan
                                {
                                    nimet.Lisää(); // lisätään kyseisen nimen lukumäärää
                                    Console.WriteLine("Löydetty nimi: " + rivi);
                                }
                            }
                            a++;
                        }
                        onkojo = 0;
                        i++;
                    }
                }
                Console.WriteLine("\nRivejä yhteensä: {0}    Nimiä yhteensä: {1} \n", rivit.Count(), a);

                // listataan nimet
                foreach (Nimet nimet in nimiä)
                {
                    Console.WriteLine("Nimiä " + nimet.Nimi + " löydetty " + nimet.Määrä + "kpl");
                }

                Console.ReadKey();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Tiedostoa ei löydy: (FileNotFoundException)");
                Console.ReadKey();
            }
        }
    }
}