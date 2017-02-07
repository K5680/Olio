using System;
/// @this version by VV
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
/// 

class BlackJack
{
    static void Main()
    {
        string vastaus;
        int myNumber;
        int theirNumber = 0;
        int poistu = 0;
        Random arpo = new Random();

        // pääsilmukka
        while (poistu == 0) {
            myNumber = arpo.Next(1, 21); // arvotaan numero

            // silmukkaa jatketaan, kunnes on annettu kelvollinen numero tai poistuttu
             while ((theirNumber < 1 || theirNumber > 21) && poistu == 0) 
            {   
                System.Console.WriteLine("*** BlackJack! Revisited ***    Type X or EXIT to exit.");
                System.Console.Write("Can you beat my number? Enter any number between 1-21: ");

                // otetaan vastaus-merkkijonoon käyttäjän syöte
                vastaus = System.Convert.ToString(System.Console.ReadLine());
                if (vastaus.Equals("x", StringComparison.OrdinalIgnoreCase) || vastaus.Equals("exit", StringComparison.OrdinalIgnoreCase)) {
                    poistu++;
                };

                // ei jatketa silmukkaa tästä pidemmälle, jos ollaan poistumassa
                if (poistu > 0) continue;

                // tarkistetaan, että vastaus on kelvollinen int-tyyppiseksi, jos ei niin herjaillaan
                if (int.TryParse(vastaus, out theirNumber))
                {
                    // käännetään string intiksi
                    theirNumber = System.Convert.ToInt32(vastaus);
                }
                else
                {   // käyttäjä näpytteli mitä sattuu, ei jatketaan silmukkaa loppuun
                    Console.WriteLine("That was not a number, try again...");
                    continue;
                }

                //comparing that given umber is valid
                if (theirNumber < 1 || theirNumber > 21)
                {
                    Console.WriteLine("The given number is out of limits, try again.");
                }

                //comparing
                if (theirNumber >= myNumber && theirNumber <= 21)
                {
                    System.Console.WriteLine("You win.");
                }
                else
                {   //häviö, kerrotaan oikea luku
                    System.Console.WriteLine("You lose. The right number was " + myNumber);
                }
            };
      
            //nollataan arvonta seuraavaa kierrosta varten
            theirNumber = 0;
        }

        // odotetaan vielä esc lopussa
        Console.WriteLine("Press ESC to leave");
        do
        {  } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

    }
}