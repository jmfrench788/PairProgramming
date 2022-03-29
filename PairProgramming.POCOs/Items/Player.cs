using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Player
    {
        public Player(){}

        public Player(int lives)
        {
            Lives = lives;
        }

        public int Lives{get; set;}
    }
