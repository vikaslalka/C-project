using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTVikasLalka
{
    public class BaseballPlayer : Player
    {
        public int runs { get; set; }
        public int homeRuns { get; set; }
        public BaseballPlayer() { playerType = PlayerType.BaseballPlayer; }
        public BaseballPlayer(int pid, String pn, String pt, int gp, int r, int hr)
        {
            this.playerType = PlayerType.BaseballPlayer;
            this.playerID = pid;
            this.playerName = pn;
            this.playerTeam = pt;
            this.gamesPlayed = gp;
            this.runs = r;
            this.homeRuns = hr;
        }
        public override int points()
        {
            return (runs - homeRuns) + (homeRuns * 2);
        }
        
    }
}
