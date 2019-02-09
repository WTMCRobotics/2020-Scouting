using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

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

    public class RobotData
    {
        public List<MatchData> RobotDataList = new List<MatchData>();
        private List <Match> _matchList;
         
        public RobotData(List<Match> matchList)
        {
            _matchList = matchList;
        }
        
        public void TestData() //Loads one match worth of test data into RobotDataList
        {
            Random random = new Random();
            for(int i = 0; i < 3; i++)
            {
                MatchData tempMatch = new MatchData(6101,1,"Blue");

                for (int j = 0; j < 8; j++)
                {
                    tempMatch.ScoreArray[j] = random.Next(10);
                }
                RobotDataList.Add(tempMatch);
            }

            for (int i = 0; i < 3; i++)
            {
                MatchData tempMatch = new MatchData(5303,1,"Red");
                
                for (int j = 0; j < 8; j++)
                {
                    tempMatch.ScoreArray[j] = random.Next(10);
                }
                RobotDataList.Add(tempMatch);
            }
        }

        public void LoadData()// Backs up data to text file
        {
            StreamWriter sw = new StreamWriter("RobotDataBackUp.txt");

            Console.WriteLine("Match Number,Team Number,Alliance,");

            for(int i = 0; i < 6; i++)
            {
                var temp = RobotDataList.ElementAt(i);

                Console.Write($"{temp.MatchNumber},{temp.TeamNumber},{temp.Alliance},");
                
                for(int j = 0; j < 8; j++)
                    Console.Write($"{temp.ScoreArray.ElementAt(j)},");

                Console.Write('\n');
            }
        }
        //public void RetrieveData(); // Retrieves data from text file
    }
}
