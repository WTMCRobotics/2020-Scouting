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
            //_robotData = new RobotData();
            _robotData.TestData();
            _robotData.LoadData();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setTeam(1);
        }

        private void UpDownMatch_ValueChanged(object sender, EventArgs e)
        {
            int matchNumber = (int)(UpDownMatch.Value - 1);

            setTeam(matchNumber);
        }

        private void setTeam(int matchNumber)
        {
            tbBlue1.Text = _schedule.MatchList[matchNumber].BlueArr[0].ToString();
            tbBlue2.Text = _schedule.MatchList[matchNumber].BlueArr[1].ToString();
            tbBlue3.Text = _schedule.MatchList[matchNumber].BlueArr[2].ToString();

            tbRed1.Text = _schedule.MatchList[matchNumber].RedArr[0].ToString();
            tbRed2.Text = _schedule.MatchList[matchNumber].RedArr[1].ToString();
            tbRed3.Text = _schedule.MatchList[matchNumber].RedArr[2].ToString();
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
