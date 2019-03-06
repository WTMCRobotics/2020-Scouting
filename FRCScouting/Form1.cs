using System;
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
		private const string WorkingDirectory = "";
		private const string ScheduleFileName = "Schedule.txt";
		private const string MatchDataFileName = "MatchData.csv";

		private Schedule _schedule;
        private RobotData _robotData;
		private Analytics _analytics;
        private CDataCollector _dataCollector;
		private List<int> _teamList = new List<int>();
		private Dictionary<int, int> _buttonToScoreMap;
        Timer _PollingTimer;

		static public List<string> ScoreArrayLabels = new List<string>()
		{
			"Auton HAB Level","Auton Cargo","Auton Hatch","Teleop Cargo","Teleop Hatch","Cargo Dropped","Hatches Dropped","Teleop HAB Level"
		};

		public Form1()
        {
            InitializeComponent();

			// Maps physical buttons to scoring counts
			//	Auton buttons 0x00-0x07
			//	Teleop buttons 0x10-0x17
			_buttonToScoreMap = new Dictionary<int, int>
			{
				{ 0x00, 0 },    // Auton HAB Level
				{ 0x02, 1 },    // Auton Cargo
				{ 0x05, 2 },	// Auton Hatch
				{ 0x03, 5 },	// Dropped Cargo
				{ 0x06, 6 },	// Dropped Hatch

				{ 0x14, 3 },    // Teleop Cargo
				{ 0x17, 4 },    // Teleop Hatch
				//{ 0x13, 5 },    // Dropped Cargo
				//{ 0x16, 6 },    // Dropped Hatch
				{ 0x11, 7 }		// Teleop HAB Level
			};

			_dataCollector = new CDataCollector();
			_dataCollector.SetMode(MatchMode.Reset);

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			_schedule = new Schedule();
			if (!_schedule.Load($"{WorkingDirectory}{ScheduleFileName}", _teamList))
			{
				Close();
				return;
			}

			_robotData = new RobotData();
			//_robotData.CreateRandomTestData(_schedule.MatchList);
			//_robotData.SaveData($"{WorkingDirectory}{MatchDataFileName}");
			_robotData.LoadData($"{WorkingDirectory}{MatchDataFileName}");

			cbMatchMode.SelectedIndex = 0;
			
			_PollingTimer = new Timer();
			_PollingTimer.Enabled = true;
			_PollingTimer.Interval = Convert.ToInt16(1000);
			_PollingTimer.Tick += new EventHandler(PollingEvent);

			_analytics = new Analytics();
			_analytics.Load(_robotData);

			dataGridAnalytics.DataSource = _analytics.AnalyticTable;
			for (int i = 0; i < ScoreArrayLabels.Count; i++)
			{
				dataGridAnalytics.Columns[i + 1].HeaderText = ScoreArrayLabels[i];
				dataGridAnalytics.Columns[i + 1].Width = 60;
			}


			setTeam(0);
		}

		private void PollingEvent(Object myObject, EventArgs myEventArgs)
        {

			if (_dataCollector.Mode != MatchMode.Auton && 
				_dataCollector.Mode != MatchMode.Teleop)
				return;

			_PollingTimer.Enabled = false;


			foreach (var controller in _dataCollector.Controllers)
			{
				if (controller == null) 
					continue;

				controller.Poll();

				DataGridView dataGrid = null;
				int colIndex = 0;
				if (controller.ID >= 1 && controller.ID <= 3)
				{
					dataGrid = dgvRed;
					colIndex = controller.ID-1;
				}
				else if (controller.ID >= 4 && controller.ID <= 6)
				{
					dataGrid = dgvBlue;
					colIndex = controller.ID - 4;
				}
				else
				{
					continue;
				}

				foreach (var buttonID in _buttonToScoreMap.Keys)
				{
					// get selected button's count from controller
					var countIndex = _buttonToScoreMap[buttonID];
					int buttonCount = 0;
					if (countIndex == 5 || countIndex == 6)
					{
						buttonCount = controller.AutonCounts[buttonID] + controller.TeleopCounts[buttonID];
					}
					else if (_dataCollector.Mode == MatchMode.Auton)
					{
						if (buttonID < 0x10)
							buttonCount = controller.AutonCounts[buttonID];
					}
					else
					{
						if (buttonID >= 0x10)
							buttonCount = controller.TeleopCounts[buttonID & 0x0f];
					}

					dataGrid[colIndex, countIndex].Value = buttonCount;
				}
			}
            _PollingTimer.Enabled = true;
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
			SetupMatchGrids(dgvBlue, _schedule.MatchList[matchNumber].BlueTeams);
			SetupMatchGrids(dgvRed, _schedule.MatchList[matchNumber].RedTeams);

			//         #region Blue Table
			//         dgvBlue.ColumnCount = 3;
			//         dgvBlue.Rows.Clear();
			//         for (int i = 0; i < 3; i++)
			//         {
			//             dgvBlue.Columns[i].Name = _schedule.MatchList[matchNumber].BlueTeams[i].ToString();
			//	dgvBlue.Columns[i].Width = 50;
			//	//var data = _robotData.RobotDataList.Where(x => x.MatchNumber == matchNumber && x.Alliance == "Blue" && x.TeamNumber.ToString() == dgvBlue.Columns[i].Name).Select(b => b.ScoreArray[0]).ToString();
			//}

			//for (int j = 0; j < _robotData.MatchDataList[0].ScoreArray.Length; j++)
			//         {
			//             string temp = "hello";

			//             dgvBlue.Rows.Add(new string[3] 
			//	{
			//                 temp,temp,temp
			//             });
			//	dgvBlue.Rows[j].Height = 30;
			//             dgvBlue.Rows[j].HeaderCell.Value = ScoreArrayLabels[j];
			//         }
			//dgvBlue.RowHeadersWidth = 150;
			//         dgvBlue.ReadOnly = true;
			//         dgvBlue.RowHeadersVisible = true;

			//         #endregion

			//#region Red Table
			//dgvRed.ColumnCount = 3;
   //         dgvRed.Rows.Clear();
   //         for (int i = 0; i < 3; i++)
   //         {
   //             dgvRed.Columns[i].Name = _schedule.MatchList[matchNumber].RedTeams[i].ToString();
			//	dgvRed.Columns[i].Width = 50;
			//}

			//for (int i = 0; i < _robotData.MatchDataList[0].ScoreArray.Length; i++)
   //         {
   //             dgvRed.Rows.Add(new string[3]
   //             {
   //                 _robotData.MatchDataList[3].ScoreArray[i].ToString(),_robotData.MatchDataList[4].ScoreArray[i].ToString(),_robotData.MatchDataList[5].ScoreArray[i].ToString(),

   //             });
   //             dgvRed.Rows[i].HeaderCell.Value = ScoreArrayLabels[i];
   //         }
			//dgvRed.RowHeadersWidth = 150;
			//dgvRed.ReadOnly = true;
   //         dgvRed.RowHeadersVisible = true;

			//#endregion

		}

		private void SetupMatchGrids(DataGridView grid, int[] teamID)
		{
			grid.ColumnCount = 3;
			grid.Rows.Clear();
			for (int i = 0; i < 3; i++)
			{
				grid.Columns[i].Name = teamID[i].ToString();
				grid.Columns[i].Width = 50;
				//var data = _robotData.RobotDataList.Where(x => x.MatchNumber == matchNumber && x.Alliance == "Blue" && x.TeamNumber.ToString() == dgvBlue.Columns[i].Name).Select(b => b.ScoreArray[0]).ToString();
			}

			for (int j = 0; j < _robotData.MatchDataList[0].ScoreArray.Length; j++)
			{
				string temp = "hello";

				grid.Rows.Add(new string[3]
				{
					temp,temp,temp
				});
				grid.Rows[j].Height = 30;
				grid.Rows[j].HeaderCell.Value = ScoreArrayLabels[j];
			}
			grid.RowHeadersWidth = 150;
			grid.ReadOnly = true;
			grid.RowHeadersVisible = true;
		}

		private void cbMatchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbMatchMode.SelectedIndex;
            btnNextMode.Enabled = index < cbMatchMode.Items.Count - 1;
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

                        temp.TeamNumber = Convert.ToInt32(_schedule.MatchList[getMatchNumber()].RedTeams[i].ToString());
                 
                        sw.Write($"{temp.MatchNumber},{temp.TeamNumber},{temp.Alliance},");

                        #region Blue Table
                        for (int j = 0; j < _robotData.MatchDataList[0].ScoreArray.Length; j++)
                        {   
                            temp.ScoreArray[i] = Convert.ToInt32(dgvBlue[i, j].Value);
                            
                            sw.Write($"{temp.ScoreArray[i]},");
                        }
                        #endregion

                        _robotData.MatchDataList.Add(temp);
                            sw.Write('\n');
                    }

                    for (int i = 0; i < 3; i++) // LOAD BLUE
                    {
                        var temp = new MatchData(0, 0, "Blue");

                        temp.MatchNumber = getMatchNumber();

                        temp.TeamNumber = Convert.ToInt32(_schedule.MatchList[getMatchNumber()].BlueTeams[i].ToString());

                        sw.Write($"{temp.MatchNumber},{temp.TeamNumber},{temp.Alliance},");

                        #region Blue Table
                        for (int j = 0; j < _robotData.MatchDataList[0].ScoreArray.Length; j++)
                        {
                            temp.ScoreArray[i] = Convert.ToInt32(dgvBlue[i, j].Value);

                            sw.Write($"{temp.ScoreArray[i]},");
                        }
                        #endregion

                        _robotData.MatchDataList.Add(temp);
                        sw.Write('\n');
                    }
                }
            }
            //Change button color to signal that data has been loaded
            btnLoadData.BackColor = Color.Green;
        }
	}
}