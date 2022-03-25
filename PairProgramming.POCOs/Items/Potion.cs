using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Potion
    {
        public Potion(){}

        public Potion(int healthRestored)
        {
            HealthRestored = healthRestored;
        }

        public int HealthRestored{get; set;}
    }
