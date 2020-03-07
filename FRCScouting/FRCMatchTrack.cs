using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Scouting.DataCollector;

namespace FRCScouting
{
	public partial class FRCMatchTrack : Form
	{
		private const string WorkingDirectory = "";
		private const string ScheduleFileName = "Schedule.txt";
		private const string MatchDataFileName = "MatchData.csv";

		private readonly CDataCollector _dataCollector;
		private Timer _pollingTimer;

		private Schedule	_schedule;
		private RobotData	_robotData;
		private Analytics	_analytics;
		private readonly List<int>	_teamList = new List<int>();
		private readonly Dictionary<int, int> _buttonToScoreMap;

		static public List<string> ScoreArrayLabels = new List<string>()
		{
            "Auton line","Auton low ball","Auton high ball","Teleop low ball","Teleop high ball","Teleop hanging","Teleop detailed spin","Teleop long spin"  
			//"Auton HAB Level","Auton Cargo","Auton Hatch","Teleop Cargo","Teleop Hatch","Cargo Dropped","Hatches Dropped","Teleop HAB Level"
		};
		static public List<string> RankingGridLabels = new List<string>()
		{
            "Auton line","Auton low ball","Auton high ball","Teleop low ball","Teleop high ball","Teleop hanging","Teleop detailed spin","Teleop long spin","Perf. Factor","Match Score","Match RPs" 
			//"Auton HAB Level","Auton Cargo","Auton Hatch","Teleop Cargo","Teleop Hatch","Cargo Dropped","Hatches Dropped","Teleop HAB Level", "Perf. Factor" ,"Match Score", "Match RPs"
		};

		// constructor
		public FRCMatchTrack()
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

		private void MatchTrack_Load(object sender, EventArgs e)
		{
			_schedule = new Schedule();
			if (!_schedule.Load($"{WorkingDirectory}{ScheduleFileName}", _teamList))
			{
				Close();
				return;
			}

			_robotData = new RobotData();
			_robotData.LoadData($"{WorkingDirectory}{MatchDataFileName}");

			MatchModeCombo.SelectedIndex = 0;
			EditGroup.Enabled = false;

			_pollingTimer = new Timer();
			_pollingTimer.Enabled = true;
			_pollingTimer.Interval = Convert.ToInt16(250);
			_pollingTimer.Tick += new EventHandler(PollingEvent);

			_analytics = new Analytics();
			_analytics.Load(_robotData);

			InitializeRankingsTab();
			InitializeTeamTab();
            
            setTeam(0);
		}

		private void InitializeRankingsTab()
		{
			dataGridRankings.DataSource = _analytics.RankingTable;

			for (int i = 0; i < RankingGridLabels.Count; i++)
				dataGridRankings.Columns[i + 1].HeaderText = RankingGridLabels[i];

			for (int i = 0; i < dataGridRankings.Columns.Count; i++)
				dataGridRankings.Columns[i].Width = 55;
		}

		private void InitializeTeamTab()
		{
			foreach (var team in _teamList)
			{
				cbTeam.Items.Add(team);
			}
			cbTeam.SelectedIndex = 0;

			dataGridPerformance.DataSource = _analytics.MatchTable;

			for (int i = 0; i < RankingGridLabels.Count; i++)
				dataGridPerformance.Columns[i + 1].HeaderText = RankingGridLabels[i];

			for (int i = 0; i < dataGridPerformance.Columns.Count; i++)
				dataGridPerformance.Columns[i].Width = 55;
		}

        private int NegativeWraparound(int num, int max)
        {
            if (num >= 0) return num;
            else return NegativeWraparound(num + max, max);
        }

		private void PollingEvent(Object myObject, EventArgs myEventArgs)
        {

			if (_dataCollector.Mode != MatchMode.Auton && 
				_dataCollector.Mode != MatchMode.Teleop && _dataCollector.Mode != MatchMode.Edit)
				return;

			_pollingTimer.Enabled = false;
            
			foreach (var controller in _dataCollector.Controllers)
			{
				if (controller == null) 
					continue;

				controller.Poll();

				DataGridView dataGrid = null;
				int colIndex = 0;
				if (controller.ID >= 1 && controller.ID <= 3)
				{
					dataGrid = RedGrid;
					colIndex = controller.ID-1;
				}
				else if (controller.ID >= 4 && controller.ID <= 6)
				{
					dataGrid = BlueGrid;
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

                    if (countIndex == 5 || countIndex == 6) //For Middle Buttons which work in both modes //TODO: Change this as our button setup this year is different
                    {
                        buttonCount = controller.AutonCounts[buttonID] + controller.TeleopCounts[buttonID];
                        if (_dataCollector.Mode == MatchMode.Edit)
                        {
                            buttonCount -= controller.EditCounts[buttonID & 0x0f];
                            buttonCount = NegativeWraparound(buttonCount, 10);
                        }

                        dataGrid[colIndex, countIndex].Value = buttonCount;
                    }

                    else if (_dataCollector.Mode == MatchMode.Auton)
                    {

                        if (buttonID < 0x10)

                        {
                            buttonCount = controller.AutonCounts[buttonID];

                            dataGrid[colIndex, countIndex].Value = buttonCount;

                        }
                    }
                    
                    
                    else if(_dataCollector.Mode == MatchMode.Edit)
                    {
                        if (buttonID < 0x10)

                        {
                            buttonCount = NegativeWraparound(controller.AutonCounts[buttonID] - controller.EditCounts[buttonID], 5); //TODO: update the max

                            dataGrid[colIndex, countIndex].Value = buttonCount;
                        }

                        if (buttonID >= 0x10)

                        {
                            buttonCount = NegativeWraparound(controller.TeleopCounts[buttonID & 0x0f] - controller.EditCounts[buttonID & 0x0f], 12); //TODO: Update the max
                            dataGrid[colIndex, countIndex].Value = buttonCount;

                        }
                    }
                    

                    else

                    {
                        if (buttonID >= 0x10)

                        {
                            buttonCount = controller.TeleopCounts[buttonID & 0x0f];

                            dataGrid[colIndex, countIndex].Value = buttonCount;

                        }
                    }

                    //dataGrid[colIndex, countIndex].Value = buttonCount;

                }
            }
            _pollingTimer.Enabled = true;
        }

        private void UpDownMatch_ValueChanged(object sender, EventArgs e)
        {
            setTeam(getMatchNumber());
        }

        private int getMatchNumber()
        {
            return (Convert.ToInt32(UpDownMatch.Value) -1);
        }

        private void setTeam(int matchNumber)
        {
			SetupMatchGrids(BlueGrid, _schedule.MatchList[matchNumber].BlueTeams);
			SetupMatchGrids(RedGrid, _schedule.MatchList[matchNumber].RedTeams);
        }

		private void SetupMatchGrids(DataGridView grid, int[] teamID)
		{
			grid.RowHeadersVisible = false;
			grid.ColumnCount = 4;
			grid.Rows.Clear();
			for (int i = 0; i < 3; i++)
			{
				grid.Columns[i+1].HeaderText = teamID[i].ToString();
				grid.Columns[i+1].Width = 75;
			}

			for (int j = 0; j < 8; j++)
			{
				string temp = "0";

				grid.Rows.Add(new string[4]
				{
					temp,temp,temp,temp
				});
				grid.Rows[j].Height = 30;
				grid.Rows[j].Cells[0].Value = ScoreArrayLabels[j];
			}
			grid.Columns[0].Width = 175;
			grid.ReadOnly = true;
		}

		private void cbMatchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = MatchModeCombo.SelectedIndex;
            btnNextMode.Enabled = index < MatchModeCombo.Items.Count - 1;
            _dataCollector.SetMode((MatchMode)index);
			EditGroup.Enabled = MatchModeCombo.Text == "Edit";
        }

        private void btn2NextMode_Click(object sender, EventArgs e)
        {
            MatchModeCombo.SelectedIndex += 1;
        }
        
        private void btnSaveMatchData_Click(object sender, EventArgs e) 
        {
            for (int i = 0; i < 3; i++) // LOAD RED
            {
                var tempMatchData = new MatchData(0,0,"Red");

                tempMatchData.MatchNumber = getMatchNumber() + 1;

                tempMatchData.TeamNumber = Convert.ToInt32(_schedule.MatchList[getMatchNumber()].RedTeams[i].ToString());
                 

                #region Blue Table
                for (int j = 0; j < 8; j++)
                {   
                    tempMatchData.ScoreArray[j] = Convert.ToInt32(BlueGrid[i, j].Value);
                }
                #endregion

                _robotData.MatchDataList.Add(tempMatchData);
            }

            for (int i = 0; i < 3; i++) // LOAD BLUE
            {
                var temp = new MatchData(0, 0, "Blue");

                temp.MatchNumber = getMatchNumber() + 1;

                temp.TeamNumber = Convert.ToInt32(_schedule.MatchList[getMatchNumber()].BlueTeams[i].ToString());
                
                #region Blue Table
                for (int j = 0; j < 8; j++)
                {
                    temp.ScoreArray[j] = Convert.ToInt32(BlueGrid[i, j].Value);
                }
                #endregion

                _robotData.MatchDataList.Add(temp);
            }
            //Change button color to signal that data has been loaded
            SaveButton.BackColor = Color.Green;
            _robotData.SaveData($"{WorkingDirectory}{MatchDataFileName}", (getMatchNumber() + 1));
        }

		private void cbTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			int team = (int)cbTeam.SelectedItem;
			_analytics.MatchTable.DefaultView.RowFilter = $"Team = {team}";
		}

		private void udRedRPs_ValueChanged(object sender, EventArgs e)
		{

		}

		private void udRedScore_ValueChanged(object sender, EventArgs e)
		{

		}

		private void udBlueRPs_ValueChanged(object sender, EventArgs e)
		{

		}

		private void udBlueScore_ValueChanged(object sender, EventArgs e)
		{

		}

        private void resetMatchDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mbResult =  MessageBox.Show("Are you sure you want to reset all the data in MatchFile.csv?",
                            "FRCScouting",
                            MessageBoxButtons.OKCancel);
            if (mbResult == DialogResult.Cancel)
                return;

            _robotData.MatchDataList.Clear();
            _robotData.SaveData($"{WorkingDirectory}{MatchDataFileName}", (getMatchNumber() + 1));
        }

        private void btnLoadMatchData_Click(object sender, EventArgs e)
        {
            _robotData.LoadData($"{WorkingDirectory}{MatchDataFileName}");
        }

        private void btnNextMatch_Click(object sender, EventArgs e)
        {
            SaveButton.BackColor = Color.Beige;
            UpDownMatch.Value++;
          
            MatchModeCombo.SelectedIndex = 0;
            _dataCollector.SetMode(MatchMode.Reset);
            
            setTeam(getMatchNumber());
        }

        private void dgvBlue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

		private void FRCMatchTrack_Resize(object sender, EventArgs e)
		{
			BlueGrid.Width = (BlueGrid.Parent.Width - 25) / 2;
		}

		
		private void DecreaseButton_Click(object sender, EventArgs e)
		{
			if (!int.TryParse((string)_selectedCell.Value, out var cellVal))
				cellVal = 0;
			if (cellVal > 0)
				cellVal--;
			_selectedCell.Value = cellVal.ToString();

		}

		private void IncreaseButton_Click(object sender, EventArgs e)
		{
			if (!int.TryParse((string)_selectedCell.Value, out var cellVal))
				cellVal = 0;
			if (cellVal < 100)
				cellVal++;
			_selectedCell.Value = cellVal.ToString();
		}

		private void BlueGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private DataGridView _selectedGrid;
		private DataGridViewCell _selectedCell;
		private void Grid_SelectionChanged(object sender, EventArgs e)
		{
			var grid = (DataGridView)sender;
			if (_selectedCell != null)
				_selectedCell.Selected = false;
			_selectedGrid = grid;
			_selectedCell = grid.CurrentCell;

			var editEnabled = MatchModeCombo.Text == "Edit" && _selectedCell.ColumnIndex > 0;
			IncreaseButton.Enabled = editEnabled;
			DecreaseButton.Enabled = editEnabled;
		}
	}

}