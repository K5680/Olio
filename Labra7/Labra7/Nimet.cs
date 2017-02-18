using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra7
{
    class Nimet
    {
        private int määrä;

        public string Nimi { get; set; }
        public virtual int Määrä {
            get { return määrä;  }
        }

               
        // metodi
        public void Lisää()
        {
            määrä++;
        }



        public override string ToString()
        {
            return Nimi;
        }

        public Nimet()
        {
        }
    }
}
