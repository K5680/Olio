using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hissi
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int floor = rnd.Next(1, 6);

            Elevator hissen = new Elevator();
            hissen.Floor = floor;

            int minne;

            do
            {
                Console.WriteLine("Hissi on kerroksessa :  {0}", hissen.Floor);
                Console.WriteLine("Mihin kerrokseen haluat?  ");
                string minnemennään = Console.ReadLine();
                bool result = Int32.TryParse(minnemennään, out minne);

                if (result)
                {
                    //siirrä hissiä
                    hissen.Floor = minne;
                }
                else Console.WriteLine("söhön söhön");
                    



            } while (floor < 6);
        }
    }
}
