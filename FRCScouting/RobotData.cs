using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;


namespace FRCScouting
{
    public class RobotData
    {
        public List<MatchData> MatchDataList;
        public int LastSavedIndex;
		public RobotData()
		{
            MatchDataList = new List<MatchData>();
            LastSavedIndex = 0;
		}

        //TODO: this
		public RobotData(List<Match> matchList)
        {
            LastSavedIndex = 0;
            //MatchDataList = matchList;
		}
        
        public void CreateRandomTestData(List<Match> matchList) // For testing
        {
			var random = new Random();
			MatchData matchData;
			foreach (var match in matchList)
			{
				var redTeamWins = random.Next(1) == 1;
				foreach (var team in match.BlueTeams)
				{
					matchData = new MatchData(match.MatchNumber, team, "Blue");
					for (int i = 0; i < 8; i++)
						matchData.ScoreArray[i] = random.Next(10);
					if (!redTeamWins)
					{
						matchData.Score = random.Next(100) + 200;
						matchData.RankingPoints = 1;
					}
					else
					{
						matchData.Score = random.Next(100) + 100;
						matchData.RankingPoints = 0;
					}
					MatchDataList.Add(matchData);
				}
				foreach (var team in match.RedTeams)
				{
					matchData = new MatchData(match.MatchNumber, team, "Red");
					for (int i = 0; i < 8; i++)
						matchData.ScoreArray[i] = random.Next(10);
					if (redTeamWins)
					{
						matchData.Score = random.Next(100) + 200;
						matchData.RankingPoints = 1;
					}
					else
					{
						matchData.Score = random.Next(100) + 100;
						matchData.RankingPoints = 0;
					}
					MatchDataList.Add(matchData);
				}
			}

			//foreach (var matchData in MatchDataList)
			//{
			//	for (int i=0; i<8; i++)
			//	{
			//		matchData.ScoreArray[i] = random.Next(10);
			//	}

			//}
        }

        public void SaveData(string dataFile, int matchNumber) // Backs up data to text file 
        {
            using (StreamWriter sw = new StreamWriter(dataFile, true)) // passing true makes it append rather than overwrite
            {
                
				sw.WriteLine("Match#,Team, Alliance, Count1, Count2, Count3, Count4, Count5, Count6, Count7, Count8, Score, RPs"); //TODO: Make this line print once for the entire file, not be appended every single time it's saved
                /*
                foreach (var matchData in MatchDataList) //TODO: Rework this loop
                {
                    sw.Write($"{matchData.MatchNumber},{matchData.TeamNumber},{matchData.Alliance}");

                  for (int i = 0; i < 8; i++)
                    {
                        sw.Write($",{matchData.ScoreArray[i]}");
                    }
					sw.Write($",{matchData.Score},{matchData.RankingPoints}");
                    sw.Write('\n');
                }
            */
            
                for (var i = LastSavedIndex; i < MatchDataList.Count; i++) //TODO: Test that this works after loading and restarting program... I have a feeling the index will be reset.....
                {
                    var testVar = i;
                    sw.Write($"{MatchDataList[i].MatchNumber},{MatchDataList[i].TeamNumber},{MatchDataList[i].Alliance}");
                    Console.WriteLine($"{MatchDataList[i].MatchNumber},{MatchDataList[i].TeamNumber},{MatchDataList[i].Alliance}");

                    for (int j = 0; j < 8; j++)
                    {
                        sw.Write($",{MatchDataList[i].ScoreArray[j]}"); 
                        Console.WriteLine($",{MatchDataList[i].ScoreArray[j]}");
                    }
                    sw.Write($",{MatchDataList[i].Score},{MatchDataList[i].RankingPoints}");
                    sw.Write('\n');
                }
                LastSavedIndex = MatchDataList.Count;
				sw.Close();
                
            }
        }
        
        public bool LoadData(string dataFile) // Retrieves data from .csv file
        {
			if (!File.Exists(dataFile))
			{
				MessageBox.Show($"Robot data file {dataFile} not found.",
								"FRC Scouting Program",
								MessageBoxButtons.OK);
				return false;
			}

			using (var file = new StreamReader(dataFile))
			{
				var line = "";
				var count = 1;

				// skip header line
				file.ReadLine();

				// Reads through the full file line by line
				while ((line = file.ReadLine()) != null) 
				{
					var words = line.Split(',');
                    var index = 0;
                    foreach (var word in words)
                    {
                        //System.Console.WriteLine($"<{word}>");
                        index++;
                    }
                   
                    var matchNumber	= int.Parse(words[0]);
					var teamNumber	= int.Parse(words[1]);
					var alliance	= words[2];
					var newMatchData = new MatchData(matchNumber, teamNumber, alliance);

					for (int i = 0; i < 8; i++){
                        newMatchData.ScoreArray[i] = int.Parse(words[i + 3]);
                    }

                    newMatchData.Score = int.Parse(words[11]);
					newMatchData.RankingPoints = int.Parse(words[12]);
					count++;

					MatchDataList.Add(newMatchData);
				}

				file.Close();

			}
			return true;

			/* FOR TESTING
            Console.WriteLine("Retrieved Test Data");

            for (int i = 0; i < 6; i++)
            {
                var temp = RobotDataList.ElementAt(i);

                Console.Write($"{temp.MatchNumber},{temp.TeamNumber},{temp.Alliance},");

                for (int j = 0; j < 8; j++)
                    Console.Write($"{temp.ScoreArray.ElementAt(j)},");

                Console.Write('\n');
            }
            */
		}
    }
}
