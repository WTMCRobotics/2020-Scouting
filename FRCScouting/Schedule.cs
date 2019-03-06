using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace FRCScouting
{
    public class Schedule //Schedule is within the Match class so it can access the private arrays
    {

        private List<Match> matchList = new List<Match>(); //Array that holds 80 qualifying Match objects
        private int matchNumber = 1;

        public List<Match> MatchList { get { return matchList; } set { } }

		public bool Load(string scheduleFile, List<int> teamList)
		{
			if (!File.Exists(scheduleFile))
			{
				MessageBox.Show($"Schedule file {scheduleFile} not found. Closing program!",
								"FRC Scouting Program",
								MessageBoxButtons.OK);
				return false;
			}

			//NOTE: text file needs to be in the debug folder for FRC Scouting
			using (var file = new System.IO.StreamReader(scheduleFile)) //Need to write an exception for if file is not found
			{
				string line = "";
				int lineNumber = 0;
				while ((matchNumber <= 80) && (line = file.ReadLine()) != null) // Reads through the full file line by line
				{
					lineNumber++;

					var words = line.Split(' ', '\t');

					if (words.Length == 2) //Qual # line
					{
						if (matchNumber != int.Parse(words[1]))
						{
							MessageBox.Show("File error: Match numbers do not match count. Closing program!",
											"FRC Scouting Program",
											MessageBoxButtons.OK);
							return false;
						}
					}

					Match newMatch = new Match(matchNumber); //Create a local object to temporarily store data

					line = file.ReadLine();
					words = line.Split(' ', '\t');

					for (int i = 0; i < 6; i++)
					{
						var team = int.Parse(words[i]);
						if (!teamList.Contains(team))
							teamList.Add(team);
					}


					for (int i = 0; i < 3; i++) //Load teams into red alliance
						newMatch.RedTeams[i] = int.Parse(words[i]);

					for (int i = 0; i < 3; i++) //Load teams into blue alliance
						newMatch.BlueTeams[i] = int.Parse(words[i + 3]);

					matchList.Add(newMatch); //Assign local object to its place in matchArray (index is match number)
											 // Console.WriteLine("Run " + count); //For testing
					matchNumber++;
				}
				if (matchList.Count != 80)
				{
					MessageBox.Show($"Only {matchList.Count} matches. Closing program!",
									"FRC Scouting Program",
									MessageBoxButtons.OK);
					return false;
				}
				file.Close();
			}

			teamList.Sort();

			return true;
		}
    }

}
