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

		public int Score = 0;
		public int RankingPoints = 0;

		public int[] AutonScores { get; } = new int[8];
		public int[] TeleopScores { get; } = new int[8];
		public int[] ScoreArray {  get{ return AutonScores; } }

		public MatchData(int matchNum, int teamNum, string alliance)
        {
            MatchNumber = matchNum;
			TeamNumber = teamNum;
			Alliance = alliance;

			for (int i=0; i<8; i++)
			{
				AutonScores[i] = 0;
				TeleopScores[i] = 0;
			}

		}
    }
}
