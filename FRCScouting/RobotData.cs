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
                int teamNumber = _matchList[1].BlueArr[i];
                MatchData tempMatch = new MatchData(teamNumber,1,"Blue");

                for (int j = 0; j < 8; j++)
                {
                    tempMatch.ScoreArray[j] = random.Next(10);
                }
                RobotDataList.Add(tempMatch);
            }

            for (int i = 0; i < 3; i++)
            {
                int teamNumber = _matchList[1].RedArr[i];
                MatchData tempMatch = new MatchData(teamNumber,1,"Red");
                
                for (int j = 0; j < 8; j++)
                {
                    tempMatch.ScoreArray[j] = random.Next(10);
                }
                RobotDataList.Add(tempMatch);
            }
        }


        public void LoadData()// Backs up data to text file TODO: Generalize beyond test data
        {
            string path = @"C:\Users\Katie\Documents\Robotics\2019-Scouting\FRCScouting";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(path, "RobotDataBackUp.txt"), true))
                {
                    sw.WriteLine("Match Number,Team Number,Alliance,");

                    for (int i = 0; i < 6; i++)
                    {
                        var temp = RobotDataList.ElementAt(i);

                        //Console.Write($"{temp.MatchNumber},{temp.TeamNumber},{temp.Alliance},");
                        sw.Write($"{temp.MatchNumber},{temp.TeamNumber},{temp.Alliance},");

                        for (int j = 0; j < 8; j++)
                        {
                            //Console.Write($"{temp.ScoreArray.ElementAt(j)},");
                            sw.Write($"{temp.ScoreArray.ElementAt(j)},");
                        }
                        sw.Write('\n');
                    }
                }
            }
        }
        

        public void RetrieveData() // Retrieves data from text  WORKING ON THIS
        {
            var file = new System.IO.StreamReader("RobotDataBackUp.txt"); //Need to write an exception for if file is not found
            string line = "";
            int count = 1;

            file.ReadLine(); //So it skips line with key 
            while ((line = file.ReadLine()) != null) // Reads through the full file line by line
            {
                var words = line.Split(',');
                int matchNum = int.Parse(words[0]);
                var temp = RobotDataList.ElementAt(count);

                temp.MatchNumber = int.Parse(words[0]);
                temp.TeamNumber = int.Parse(words[1]);
                temp.Alliance = words[2];

                for (int i = 0; i < 8; i++)
                    temp.ScoreArray[i] = int.Parse(words[i + 3]);

                count++; 
            }

            Console.WriteLine("Retrieved Test Data");

            for (int i = 0; i < 6; i++)
            {
                var temp = RobotDataList.ElementAt(i);

                Console.Write($"{temp.MatchNumber},{temp.TeamNumber},{temp.Alliance},");

                for (int j = 0; j < 8; j++)
                    Console.Write($"{temp.ScoreArray.ElementAt(j)},");

                Console.Write('\n');
            }
        }
    }
}
