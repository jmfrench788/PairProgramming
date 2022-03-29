using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Cube
    {
        public Cube(){}

        public Cube(TrapType trap, int healthLost, int scoreLost, bool reset)
        {
            Trap = trap;
            HealthLost = healthLost;
            ScoreLost = scoreLost;
            Reset = reset;
        }

        public TrapType Trap {get; set;}
        public int HealthLost {get; set;}
        public int ScoreLost {get; set;}
        public bool Reset {get; set;}

    }
