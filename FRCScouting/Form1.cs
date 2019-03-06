﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Scouting.DataCollector;

namespace FRCScouting
{
    public partial class Form1 : Form
    {
        private Schedule _schedule;
        private RobotData _robotData;
        private DataCollector _dataCollector;
        private System.Windows.Forms.ComboBox cbMatchMode;
        Timer _PollingTimer;

        public Form1()
        {
            InitializeComponent();
            _schedule = new Schedule();
            _schedule.LoadTestData();

            _robotData = new RobotData(_schedule.MatchList);
            _robotData.TestData(); //Loads test data for 1 match worth of data
            //_robotData.LoadData(); //Loads data from match into text file
                                   //_robotData.RetrieveData(); //Loads data from text file into RobotData.cs's _matchList

            _dataCollector = new DataCollector();
            cbMatchMode.Enabled = true;

            _dataCollector.SetMode(MatchMode.Reset);
            cbMatchMode.SelectedIndex = 0;
            
            _PollingTimer = new Timer();
            _PollingTimer.Enabled = true;
            _PollingTimer.Interval = Convert.ToInt16(1000);
            _PollingTimer.Tick += new EventHandler(PollingEvent);
            
        }

        static public List<string> ScoreArrayLabels = new List<string>()
        {
            "Auton HAB Level","Auton Cargo","Auton Hatch","Teleop Cargo","Teleop Hatch","Cargo Dropped","Hatches Dropped","Teleop HAB Level"
        };

        private void PollingEvent(Object myObject, EventArgs myEventArgs)
        {
            _PollingTimer.Enabled = false;

            for (var i = 0; i < 4; i++)
            {
                //var activeControllers = _dataCollector.Controllers.Where(item => item != null);
                
                var controller = _dataCollector.Controllers[i];
                if (controller == null)
                    continue;

                controller.Poll();

                #region Red Table
                for (int j = 0; j < _robotData.RobotDataList[0].ScoreArray.Length; j++)
                {
                    dgvRed[i -1, j].Value = controller.TotalCounts[j].ToString();

                    dgvRed.Rows[i].HeaderCell.Value = ScoreArrayLabels[i];
                }
                #endregion
                
            }

            for(int i = 0; i < 4; i++)
            {
                var controller = _dataCollector.Controllers[i + 4];
                if (controller == null)
                    continue;

                controller.Poll();

                #region Blue Table
                for (int j = 0; j < _robotData.RobotDataList[0].ScoreArray.Length; j++)
                {
                    dgvBlue[i, j].Value = controller.TotalCounts[j].ToString();

                    dgvBlue.Rows[i].HeaderCell.Value = ScoreArrayLabels[i];
                }
                #endregion
            }

            _PollingTimer.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setTeam(0);
        }

        private void UpDownMatch_ValueChanged(object sender, EventArgs e)
        {
            int matchNumber = (int)(UpDownMatch.Value - 1);

            setTeam(matchNumber);
        }

        private int getMatchNumber()
        {
            return (Convert.ToInt32(UpDownMatch.Value));
        }

        private void setTeam(int matchNumber)
        {
            #region Blue Table
            dgvBlue.ColumnCount = 3;
            dgvBlue.Rows.Clear();
            for (int i = 0; i < 3; i++)
            {
                dgvBlue.Columns[i].Name = _schedule.MatchList[matchNumber].BlueArr[i].ToString();
                //var data = _robotData.RobotDataList.Where(x => x.MatchNumber == matchNumber && x.Alliance == "Blue" && x.TeamNumber.ToString() == dgvBlue.Columns[i].Name).Select(b => b.ScoreArray[0]).ToString();
            }

            #region Blue Table

            for (int j = 0; j < _robotData.RobotDataList[0].ScoreArray.Length; j++)
            {
                string temp = "hello";

                dgvBlue.Rows.Add(new string[3]
                {
                    temp,temp,temp
                });

                dgvBlue.Rows[j].HeaderCell.Value = ScoreArrayLabels[j];
            }
            #endregion

            dgvBlue.ReadOnly = true;
            dgvBlue.RowHeadersVisible = true;
            dgvBlue.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            #endregion
   
            #region Red Table
            dgvRed.ColumnCount = 3;
            dgvRed.Rows.Clear();
            for (int i = 0; i < 3; i++)
            {
                dgvRed.Columns[i].Name = _schedule.MatchList[matchNumber].RedArr[i].ToString();
            }

            string temp2 = "heckle yeah";
            for (int i = 0; i < _robotData.RobotDataList[0].ScoreArray.Length; i++)
            {
                dgvRed.Rows.Add(new string[3]
                {
                    //_robotData.RobotDataList[3].ScoreArray[i].ToString(),_robotData.RobotDataList[4].ScoreArray[i].ToString(),_robotData.RobotDataList[5].ScoreArray[i].ToString(),
                    temp2,temp2,temp2
                });
                dgvRed.Rows[i].HeaderCell.Value = ScoreArrayLabels[i];
            }

            dgvRed.ReadOnly = true;
            dgvRed.RowHeadersVisible = true;
            dgvRed.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            #endregion

        }

        private void cbMatchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbMatchMode.SelectedIndex;
            btn2NextMode.Enabled = index < cbMatchMode.Items.Count - 1;
            _dataCollector.SetMode((MatchMode)index);
        }

        private void btn2NextMode_Click(object sender, EventArgs e)
        {
            cbMatchMode.SelectedIndex += 1;
        }
        

        private void btnLoadData_Click(object sender, EventArgs e) 
        {
            string path = @"C:\Users\Katie\Documents\Robotics\2019-Scouting\FRCScouting"; //UPDATE PATH FOR YOUR OWN COMPUTER

            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(Path.Combine(path, "RobotDataBackUp.txt"), true))
                {
                    for (int i = 0; i < 3; i++) // LOAD RED
                    {
                        var temp = new MatchData(0,0,"Red");

                        temp.MatchNumber = getMatchNumber();

                        temp.TeamNumber = Convert.ToInt32(_schedule.MatchList[getMatchNumber()].RedArr[i].ToString());
                 
                        sw.Write($"{temp.MatchNumber},{temp.TeamNumber},{temp.Alliance},");

                        #region Blue Table
                        for (int j = 0; j < _robotData.RobotDataList[0].ScoreArray.Length; j++)
                        {   
                            temp.ScoreArray[i] = Convert.ToInt32(dgvBlue[i, j].Value);
                            
                            sw.Write($"{temp.ScoreArray[i]},");
                        }
                        #endregion

                        _robotData.RobotDataList.Add(temp);
                            sw.Write('\n');
                    }

                    for (int i = 0; i < 3; i++) // LOAD BLUE
                    {
                        var temp = new MatchData(0, 0, "Blue");

                        temp.MatchNumber = getMatchNumber();

                        temp.TeamNumber = Convert.ToInt32(_schedule.MatchList[getMatchNumber()].BlueArr[i].ToString());

                        sw.Write($"{temp.MatchNumber},{temp.TeamNumber},{temp.Alliance},");

                        #region Blue Table
                        for (int j = 0; j < _robotData.RobotDataList[0].ScoreArray.Length; j++)
                        {
                            temp.ScoreArray[i] = Convert.ToInt32(dgvBlue[i, j].Value);

                            sw.Write($"{temp.ScoreArray[i]},");
                        }
                        #endregion

                        _robotData.RobotDataList.Add(temp);
                        sw.Write('\n');
                    }
                }
            }
            //Change button color to signal that data has been loaded
            btnLoadData.BackColor = Color.Green;
        }
    }
}