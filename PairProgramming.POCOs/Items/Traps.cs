using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Traps
    {
        public Traps(){}

        public Traps(TrapType trapType, bool loseLife, bool backToStart, int scoreLost)
        {
            TrapType = trapType;
            LoseLife = loseLife;
            BackToStart = backToStart;
            ScoreLost = scoreLost;
        }

        public TrapType TrapType{get; set;}
        public bool BackToStart{get; set;}

        public bool LoseLife{get; set;}

        public int ScoreLost{get; set;}
    }
