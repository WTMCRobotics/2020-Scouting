using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FRCScouting
{
    public partial class Form1 : Form
    {
        private Schedule _schedule;
        private RobotData _robotData;

        public Form1()
        {
            InitializeComponent();
            _schedule = new Schedule();
            _schedule.LoadTestData();

            _robotData = new RobotData(_schedule.MatchList);
        
            _robotData.TestData(); //Loads test data for 1 match worth of data
            _robotData.LoadData(); //Loads data from match into text file
            _robotData.RetrieveData(); //Loads data from text file into RobotData.cs's _matchList
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create an unbound DataGridView by declaring a column count.
            dgvBlue.ColumnCount = 3;                //Blue Alliance Columns (1 for each team)
            dgvBlue.ColumnHeadersVisible = true;
            dgvBlue.RowCount = 9;                   //Blue Alliance Rows (1 for each thing we are tracking)
            dgvBlue.ColumnHeadersVisible = true;

            dgvRed.ColumnCount = 3;                 //Red Alliance Columns (1 for each team)
            dgvRed.ColumnHeadersVisible = true;
            dgvRed.RowCount = 9;                    //Red Alliance Rows (1 for each thing we are tracking) DYNAMIC
            dgvRed.ColumnHeadersVisible = true;

            // Set the column header style. CAN REDO THIS LATER
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Regular);

            dgvBlue.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvBlue.RowHeadersDefaultCellStyle = columnHeaderStyle;

            dgvRed.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
            dgvBlue.RowHeadersDefaultCellStyle = columnHeaderStyle;
           
            setTeam(1);
        }

        private void UpDownMatch_ValueChanged(object sender, EventArgs e)
        {
            int matchNumber = (int)(UpDownMatch.Value - 1);

            setTeam(matchNumber);
        }

        private void setTeam(int matchNumber)
        {
            dgvBlue.Columns[0].Name = _schedule.MatchList[matchNumber].BlueArr[0].ToString();
            dgvBlue.Columns[1].Name = _schedule.MatchList[matchNumber].BlueArr[1].ToString();
            dgvBlue.Columns[2].Name = _schedule.MatchList[matchNumber].BlueArr[2].ToString();

            dgvRed.Columns[0].Name = _schedule.MatchList[matchNumber].RedArr[0].ToString();
            dgvRed.Columns[1].Name = _schedule.MatchList[matchNumber].RedArr[1].ToString();
            dgvRed.Columns[2].Name = _schedule.MatchList[matchNumber].RedArr[2].ToString();
        }

        private void setRowNames() //Sets the names of the columns
        {
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
