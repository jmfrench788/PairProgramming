using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

    public class Player_Repo
    {
        private readonly List<Player> _playerDB = new List<Player>();
       

    public List<Player> GetPlayer()
    {
        return _playerDB;
    }

      

    public bool AddPlayerToDB(Player player)
    {
        if (player != null)
        {
            _playerDB.Add(player);
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool UpdatePlayer(int lives, int score)
    {
        foreach (var player in _playerDB)
            {
                int newScore = player.Score;
                int newLives = player.Lives;
                return true;
                
            }
            return false;
    }
}
