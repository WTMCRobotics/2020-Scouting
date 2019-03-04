using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRCScouting
{
    public class MatchData //Arduino will be writing to 6 of MatchData objects each match
    {
        public int TeamNumber = 0;
        public int MatchNumber = 0;
        public string Alliance = "";
        public int[] ScoreArray = new int[8];

        public MatchData(int teamNum, int matchNum, string alliance)
        {
            TeamNumber = teamNum;
            MatchNumber = matchNum;
            Alliance = alliance;
        }
    }
}
