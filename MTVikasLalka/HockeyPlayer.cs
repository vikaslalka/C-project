using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTVikasLalka
{
    public class HockeyPlayer : Player
    {
        public int assists { get; set; }
        public int goals { get; set; }
        public HockeyPlayer()
        {
            playerType = PlayerType.HockeyPlayer;
        }

        

        public HockeyPlayer(int pid, String pn, String pt, int gp, int a, int g)
        {
            this.playerType = PlayerType.HockeyPlayer;
            this.playerID = pid;
            this.playerName = pn;
            this.playerTeam = pt;
            this.gamesPlayed = gp;
            this.assists = a;
            this.goals = g;
        }
        public override int points()
        {
            return assists + (goals * 2);
        }
        
    }
}
