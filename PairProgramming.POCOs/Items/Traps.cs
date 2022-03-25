using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Traps
    {
        public Traps(){}

        public Traps(TrapType trapType, int loseHealth, bool backToStart)
        {
            TrapType = trapType;
            LoseHealth = loseHealth;
            BackToStart = backToStart;
        }

        public TrapType TrapType{get; set;}
        public int LoseHealth{get; set;}
        public bool BackToStart{get; set;}
    }
