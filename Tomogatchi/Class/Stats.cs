using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tomogatchi.UI;

namespace Tomogatchi.Class
{
    public class Stats
    {
        public int hunger;
        public int energy;
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

        // || es OR, && es AND
        public int Health
        {
            get
            {
                if (hunger > 80 || energy < 20)
                    return 20; 
                if (hunger > 50 || energy < 40)
                    return 50;
                return 100; 
            }
        }
        public bool IsDead
        {
            get { return hunger >= 100 || energy <= 0; }
        }

        public Stats()
        {
            Hunger = 50;
            Energy = 80;
        }

        public void ShowStats()
        {
            Console.WriteLine(Messages.STATS_HUNGER, Hunger);
            Console.WriteLine(Messages.STATS_ENERGY, Energy);
            Console.WriteLine(Messages.STATS_HEALTH, Health);
        }
    }
}
