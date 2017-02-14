using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hissi
{
    class Elevator
    {
        private int floor;
        private const int minFloor = 1;
        private const int maxFloor = 5;

        public int Floor {
            get { return floor;  }    
            set
            {
                if (value > (minFloor-1) && value < (maxFloor+1)) { floor = value; }
                else Console.WriteLine("Ei sellaista kerrosta olekaan!");     
            }
        }

        public Elevator()
        {
        }

    }
}
