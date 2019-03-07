using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRCScouting
{
    public class Match
    {
		public int MatchNumber;

        public int[] BlueTeams = new int[3];
        public int[] RedTeams = new int[3];

        public Match(int matchNumber)
        {
			MatchNumber = matchNumber;

            for (int i = 0; i < 3; i++)
                BlueTeams[i] = 0;

            for (int i = 0; i < 3; i++)
                RedTeams[i] = 0;
        }
    }
}
