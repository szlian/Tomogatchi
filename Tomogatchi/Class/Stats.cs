using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomogatchi.Class
{
    public class Stats
    {
        private int hunger;
        private int energy;

        public int Hunger
        {
            //Asegurar que el funcion hunger,
            //su valor no sea mayor 100 ni menor 0
            get { return hunger; }
            set { if (value < 0) hunger = 0;
                else if (value > 100) hunger = 100;
                else hunger = value;
            }
        }

        public int Energy
        {
            //Asegurar que el funcion Energy,
            //su valor no sea mayor 100 ni menor 0
            get { return energy; }
            set
            {
                if (value < 0) energy = 0;
                else if (value > 100) energy = 100;
                else energy = value;
            }
        }
    }
}
