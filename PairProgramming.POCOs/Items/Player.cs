using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Player
    {
        public Player(){}

        public Player(int lives, int score, bool hasKey)
        {
            Lives = lives;
            Score = score;
            HasKey = hasKey;
        }

        public int Lives{get; set;}

        public int Score{get; set;}

        public bool HasKey{get;set;}

        public void HasEnteredTrap(int livesLost, int scoreDown)
        {
            this.Lives -=livesLost;
            this.Score -= scoreDown;
        }

        public void EnteredSafeRoom(int scoreUp)
        {
            this.Score += scoreUp;
        }

        public void HasTheKey(bool gotKey)
        {
            this.HasKey = gotKey;
        }



    }
