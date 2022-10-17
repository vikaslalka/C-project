using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTVikasLalka
{
    public enum PlayerType
    {
        HockeyPlayer,
        BasketballPlayer,
        BaseballPlayer
    }
    public abstract class Player
    {
        public PlayerType playerType { get; set; }
        public int playerID { get; set; }
        public String playerName { get; set; }
        public String playerTeam { get; set; }
        public int gamesPlayed { get; set; }
        public abstract int points();

       


    }
}

