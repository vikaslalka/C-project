using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTVikasLalka
{
    public class BasketballPlayer : Player
    {
       public int fieldGoals { get; set; }
       public  int threePointers { get; set; }
        public BasketballPlayer() { playerType = PlayerType.BasketballPlayer; }
        public BasketballPlayer(int pid, String pn, String pt, int gp, int fg, int tp)
        {
            this.playerType = PlayerType.BasketballPlayer;
            this.playerID = pid;
            this.playerName = pn;
            this.playerTeam = pt;
            this.gamesPlayed = gp;
            this.fieldGoals = fg;
            this.threePointers = tp;
        }
        public override int points()
        {
            return (fieldGoals - threePointers) + (threePointers * 2);
        }
        
    }
}
