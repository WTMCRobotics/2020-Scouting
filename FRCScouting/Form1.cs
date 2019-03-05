using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Scouting.DataCollector;

namespace FRCScouting
{
    public partial class Form1 : Form
    {
        private Schedule _schedule;
        private RobotData _robotData;
        private DataCollector _dataCollector;
        Timer _PollingTimer;

        public Form1()
        {
            InitializeComponent();
            _schedule = new Schedule();
            _schedule.LoadTestData();

            _robotData = new RobotData(_schedule.MatchList);
            //_robotData = new RobotData();
            _robotData.TestData(); //Loads test data for 1 match worth of data
            _robotData.LoadData(); //Loads data from match into text file
                                   //_robotData.RetrieveData(); //Loads data from text file into RobotData.cs's _matchList

            _dataCollector = new DataCollector();
            _PollingTimer = new Timer();
            _PollingTimer.Enabled = true;
            _PollingTimer.Interval = Convert.ToInt16(1000);
            _PollingTimer.Tick += new EventHandler(PollingEvent);

        }

        //TODO: Define the labels that correspond ot the Score Array Variables
        static public List<string> ScoreArrayLabels = new List<string>()
        {
            "HAB Level","Cargo","Hatch","Rocket Level","Cargo","Hatch", "Cargo Dropped","Hatches Dropped","HAB Level"
        };

        private void PollingEvent(Object myObject, EventArgs myEventArgs)
        {
            _PollingTimer.Enabled = false;

            for (var i = 0; i < 3; i++)
            {
                //var activeControllers = _dataCollector.Controllers.Where(item => item != null);
                
                var controller = _dataCollector.Controllers[i];
                if (controller == null)
                    continue;

                controller.Poll();
                
                    #region Blue Table
                    for (int j = 0; j < _robotData.RobotDataList[0].ScoreArray.Length; j++)
                    {
                        dgvBlue[i,j].Value = controller.AutonCounts[j].ToString();
                    
                        dgvBlue.Rows[i].HeaderCell.Value = ScoreArrayLabels[i];
                    }

                #endregion
              
            }
            _PollingTimer.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Blue Table
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < _robotData.RobotDataList[0].ScoreArray.Length; j++)
                {
                    string temp = "0";

                    dgvBlue.Rows.Add(new string[3] //ISSUE HERE
                    {
                            temp,temp,temp
                    });

                    dgvBlue.Rows[j].HeaderCell.Value = ScoreArrayLabels[j];
                }

            }
            #endregion
             
            /*
            #region Blue Table
            dgvBlue.ColumnCount = 3;
            for (int i = 0; i < 3; i++)
            {
                dgvBlue.Columns[i].Name = _schedule.MatchList[0].BlueArr[i].ToString();

            }

            for (int i = 0; i < _robotData.RobotDataList[0].ScoreArray.Length; i++)
            {
                dgvBlue.Rows.Add(new string[3]
                {
                    _robotData.RobotDataList[0].ScoreArray[i].ToString(),_robotData.RobotDataList[1].ScoreArray[i].ToString(),_robotData.RobotDataList[2].ScoreArray[i].ToString(),

                });
                dgvBlue.Rows[i].HeaderCell.Value = ScoreArrayLabels[i];
            }

            dgvBlue.ReadOnly = true;
            dgvBlue.RowHeadersVisible = true;

            #endregion
            */

            //#region Red Table
            //dgvRed.ColumnCount = 3;
            //for (int i = 0; i < 3; i++)
            //{
            //    dgvRed.Columns[i].Name = _schedule.MatchList[0].RedArr[i].ToString();

            //}

            //for (int i = 0; i < _robotData.RobotDataList[0].ScoreArray.Length; i++)
            //{
            //    dgvRed.Rows.Add(new string[3]
            //    {
            //        _robotData.RobotDataList[3].ScoreArray[i].ToString(),_robotData.RobotDataList[4].ScoreArray[i].ToString(),_robotData.RobotDataList[5].ScoreArray[i].ToString(),

            //    });
            //    dgvRed.Rows[i].HeaderCell.Value = ScoreArrayLabels[i];
            //}

            //dgvRed.ReadOnly = true;
            //dgvRed.RowHeadersVisible = true;

            //#endregion

            setTeam(0);
        }

        private void UpDownMatch_ValueChanged(object sender, EventArgs e)
        {
            int matchNumber = (int)(UpDownMatch.Value - 1);

            setTeam(matchNumber);
        }

        private void setTeam(int matchNumber)
        {
            #region Blue Table
            dgvBlue.ColumnCount = 3;
            dgvBlue.Rows.Clear();
            for (int i = 0; i < 3; i++)
            {
                dgvBlue.Columns[i].Name = _schedule.MatchList[matchNumber].BlueArr[i].ToString();
                var data = _robotData.RobotDataList.Where(x => x.MatchNumber == matchNumber && x.Alliance == "Blue" && x.TeamNumber.ToString() == dgvBlue.Columns[i].Name).Select(b => b.ScoreArray[0]).ToString();
            }

            /*
            for (int i = 0; i < _robotData.RobotDataList[0].ScoreArray.Length; i++)
            {
                dgvBlue.Rows.Add(new string[3]
                {
                    //TODO: Make the data actually update when you change the match number. BUT it appears that the load function does not work.
                    _robotData.RobotDataList[0].ScoreArray[i].ToString(),_robotData.RobotDataList[1].ScoreArray[i].ToString(),_robotData.RobotDataList[2].ScoreArray[i].ToString(),
                    

                });
          
                dgvBlue.Rows[i].HeaderCell.Value = ScoreArrayLabels[i];
            }
            */

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

            for (int i = 0; i < _robotData.RobotDataList[0].ScoreArray.Length; i++)
            {
                dgvRed.Rows.Add(new string[3]
                {
                    _robotData.RobotDataList[3].ScoreArray[i].ToString(),_robotData.RobotDataList[4].ScoreArray[i].ToString(),_robotData.RobotDataList[5].ScoreArray[i].ToString(),

                });
                dgvRed.Rows[i].HeaderCell.Value = ScoreArrayLabels[i];
            }

            dgvRed.ReadOnly = true;
            dgvRed.RowHeadersVisible = true;
            dgvRed.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            #endregion

        }

        private void tbMatchNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn1NextMatch_Click(object sender, EventArgs e)
        {

        }
    }
}