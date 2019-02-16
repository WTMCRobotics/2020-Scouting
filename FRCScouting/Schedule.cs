using System;
using System.Collections.Generic;

namespace FRCScouting
{
    public class Schedule //Schedule is within the Match class so it can access the private arrays
    {

        private List<Match> matchList = new List<Match>(); //Array that holds 80 qualifying Match objects
        private int count = 1;

        public List<Match> MatchList { get { return matchList; } set { } }

        public void LoadTestData()
        {
            //NOTE: text file needs to be in the debug folder for FRC Scouting
            var file = new System.IO.StreamReader("TestSchedule.txt"); //Need to write an exception for if file is not found
            string line = "";

            while ((count <= 80) && (line = file.ReadLine()) != null) // Reads through the full file line by line
            {
                var words = line.Split(' ', '\t');

                if (words.Length == 2) //Qual # line
                {
                    if (count != int.Parse(words[1]))
                        Console.WriteLine("File error: Match numbers do not match count.");
                    continue; //move to next iteration in loop
                }

                Match newMatch = new Match(); //Create a local object to temporarily store data

                for (int i = 0; i < 3; i++) //Load teams into red alliance
                    newMatch.RedArr[i] = int.Parse(words[i]);

                for (int i = 0; i < 3; i++) //Load teams into blue alliance
                    newMatch.BlueArr[i] = int.Parse(words[i + 3]);

                matchList.Add(newMatch); //Assign local object to its place in matchArray (index is match number)
                // Console.WriteLine("Run " + count); //For testing
                count++;
            }
            if (matchList.Count != 80)
                Console.WriteLine($"Only {matchList.Count} matches.");
            file.Close();
        }
    }
}
