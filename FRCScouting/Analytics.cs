using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;

namespace FRCScouting
{
	class Analytics
	{
		private AnalyticDS _dataSet;
		private AnalyticDS.MatchScoresDataTable _matchTable;
		private AnalyticDS.RankingScoresDataTable _rankingTable;

		public AnalyticDS.MatchScoresDataTable MatchTable { get{ return _matchTable; } }
		public AnalyticDS.RankingScoresDataTable RankingTable { get { return _rankingTable; } }

		private RobotData _robotData;
		public int[] CountWeights { get; }

		public Analytics()
		{
			_dataSet = new AnalyticDS();
			_matchTable = _dataSet.MatchScores;
			_rankingTable = _dataSet.RankingScores;

			CountWeights = new int[8];
			CountWeights[0] = 15;
			CountWeights[1] = 30;
			CountWeights[2] = 35;
			CountWeights[3] = 20;
			CountWeights[4] = -15;
			CountWeights[5] = 10;
			CountWeights[6] = 15;
			CountWeights[7] = -10;


			//int sum = 0;
			//for (int i = 0; i < 8; i++)
			//sum += CountWeights[i];

		}

		public void Load(RobotData robotData)
		{
			foreach (var matchData in robotData.MatchDataList)
			{
				var row = _matchTable.NewMatchScoresRow();
				row.Team = matchData.TeamNumber;
				row.Match = matchData.MatchNumber;
				row.Count0 = matchData.ScoreArray[0];
				row.Count1 = matchData.ScoreArray[1];
				row.Count2 = matchData.ScoreArray[2];
				row.Count3 = matchData.ScoreArray[3];
				row.Count4 = matchData.ScoreArray[4];
				row.Count5 = matchData.ScoreArray[5];
				row.Count6 = matchData.ScoreArray[6];
				row.Count7 = matchData.ScoreArray[7];
				row.Weighted = GetWeightedScore(matchData);
				row.Score	= matchData.Score;
				row.RPs		= matchData.RankingPoints;
				_matchTable.Rows.Add(row);
			}
			LoadTeamRankings();
		}

		public void LoadTeamRankings()
		{

			foreach (var matchRow in _dataSet.MatchScores)
			{
				var rankingRow = _rankingTable.FindByTeam(matchRow.Team);
				if (rankingRow == null)
				{
					rankingRow = _rankingTable.NewRankingScoresRow();
					rankingRow.Team = matchRow.Team;
					_rankingTable.Rows.Add(rankingRow);
				}
				rankingRow.Count0 += matchRow.Count0;
				rankingRow.Count1 += matchRow.Count1;
				rankingRow.Count2 += matchRow.Count2;
				rankingRow.Count3 += matchRow.Count3;
				rankingRow.Count4 += matchRow.Count4;
				rankingRow.Count5 += matchRow.Count5;
				rankingRow.Count6 += matchRow.Count6;
				rankingRow.Count7 += matchRow.Count7;
				rankingRow.Weighted += matchRow.Weighted;
				rankingRow.Score  += matchRow.Score;
				rankingRow.RPs	  += matchRow.RPs;
			}
		}

		private int GetWeightedScore(MatchData matchData)
		{
			int score = 0;
			for (int i=0; i<matchData.ScoreArray.Length; i++)
			{
				score += matchData.ScoreArray[i] * CountWeights[i];
			}
			return score;
		}
    }
}
