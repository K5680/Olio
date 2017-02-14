using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vahvistin
{
    class Amp
    {
        private int volume;
        private const int maxVol = 100;
        private const int minVol = 0;
        
        public int Volume {
            get { return volume; }
            set
            {

                if (value < minVol)
                {
                    Console.WriteLine("Väänsit liian pienelle.");
                }
                else if (value > maxVol)
                {
                    Console.WriteLine("Taisit vääntää nupin nurin...");
                }
                else
                {
                    volume = value;
                }

            }
        }        

        public Amp()
        {
        }


    }
}
