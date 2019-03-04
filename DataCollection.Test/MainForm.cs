using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;

using Scouting.DataCollector;

namespace _2019_Scouting
{
	public partial class MainForm : Form
	{
		private const int kControllerCount = 8;
		private const int kButtonCount = 8;
		private Color kDefautlBkColor = Color.FromArgb(255, 240, 240, 240);

		Button[,] _btnArray = new Button[kControllerCount, kButtonCount];
		GroupBox[] _gbArray = new GroupBox[kControllerCount];

		Timer _PollingTimer;

		DataCollector _dataCollector;

		public MainForm()
		{
			InitializeComponent();

			FillControllArrays();
			cbMatchMode.Enabled = true;

			_dataCollector = new DataCollector();

			foreach (var controller in _dataCollector.Controllers)
			{
				if (controller == null)
					continue;

				var id = controller.ID;
				_gbArray[id].Enabled = true;
				_gbArray[id].Text = controller.PortName;

				switch (id)
				{
					case 0:
					case 7:
						_gbArray[id].BackColor = Color.GreenYellow;
						break;
					case 1:
					case 2:
					case 3:
						_gbArray[id].BackColor = Color.Red;
						break;
					case 4:
					case 5:
					case 6:
						_gbArray[id].BackColor = Color.RoyalBlue;
						break;
					default:
						break;
				}
			}
			_dataCollector.SetMode(MatchMode.Reset);

			cbMatchMode.SelectedIndex = 0;

			_PollingTimer = new Timer();
			_PollingTimer.Enabled = true;
			_PollingTimer.Interval = Convert.ToInt16(updnPolling.Value);
			_PollingTimer.Tick += new EventHandler(PollingEvent);
			_PollingTimer.Start();
		}

		private void updnPollingChanged(object sender, EventArgs e)
		{
			if (updnPolling.Value == 11) updnPolling.Value = 10;
			_PollingTimer.Interval = Convert.ToInt16(updnPolling.Value);
		}

		private void PollingEvent(Object myObject, EventArgs myEventArgs)
		{
			_PollingTimer.Enabled = false;
			for (var i=0; i < 8; i++)
			{
				var controller = _dataCollector.Controllers[i];
				if (controller == null)
					continue;

				controller.Poll();
				byte buttonsVal = controller.Buttons;
				for (int j = 0; j < kButtonCount; j++)
				{
					if ((buttonsVal & 0x01) == 1)
						_btnArray[i, j].BackColor = Color.LimeGreen;
					else
						_btnArray[i, j].BackColor = kDefautlBkColor;

					byte autonCount = controller.AutonCounts[j];
					byte teleopCount = controller.TeleopCounts[j];
					_btnArray[i, j].Text = $"Btn{j} {autonCount,2:d} {teleopCount,2:d}";

					buttonsVal >>= 1;
				}
			}
			_PollingTimer.Enabled = true;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			_dataCollector.SetMode(0);
			Application.Exit();
		}

		private void FillControllArrays()
		{
			_btnArray[0, 0] = btn01;
			_btnArray[0, 1] = btn02;
			_btnArray[0, 2] = btn03;
			_btnArray[0, 3] = btn04;
			_btnArray[0, 4] = btn05;
			_btnArray[0, 5] = btn06;
			_btnArray[0, 6] = btn07;
			_btnArray[0, 7] = btn08;

			_btnArray[1, 0] = btn11;
			_btnArray[1, 1] = btn12;
			_btnArray[1, 2] = btn13;
			_btnArray[1, 3] = btn14;
			_btnArray[1, 4] = btn15;
			_btnArray[1, 5] = btn16;
			_btnArray[1, 6] = btn17;
			_btnArray[1, 7] = btn18;

			_btnArray[2, 0] = btn21;
			_btnArray[2, 1] = btn22;
			_btnArray[2, 2] = btn23;
			_btnArray[2, 3] = btn24;
			_btnArray[2, 4] = btn25;
			_btnArray[2, 5] = btn26;
			_btnArray[2, 6] = btn27;
			_btnArray[2, 7] = btn28;

			_btnArray[3, 0] = btn31;
			_btnArray[3, 1] = btn32;
			_btnArray[3, 2] = btn33;
			_btnArray[3, 3] = btn34;
			_btnArray[3, 4] = btn35;
			_btnArray[3, 5] = btn36;
			_btnArray[3, 6] = btn37;
			_btnArray[3, 7] = btn38;

			_btnArray[4, 0] = btn41;
			_btnArray[4, 1] = btn42;
			_btnArray[4, 2] = btn43;
			_btnArray[4, 3] = btn44;
			_btnArray[4, 4] = btn45;
			_btnArray[4, 5] = btn46;
			_btnArray[4, 6] = btn47;
			_btnArray[4, 7] = btn48;

			_btnArray[5, 0] = btn51;
			_btnArray[5, 1] = btn52;
			_btnArray[5, 2] = btn53;
			_btnArray[5, 3] = btn54;
			_btnArray[5, 4] = btn55;
			_btnArray[5, 5] = btn56;
			_btnArray[5, 6] = btn57;
			_btnArray[5, 7] = btn58;

			_btnArray[6, 0] = btn61;
			_btnArray[6, 1] = btn62;
			_btnArray[6, 2] = btn63;
			_btnArray[6, 3] = btn64;
			_btnArray[6, 4] = btn65;
			_btnArray[6, 5] = btn66;
			_btnArray[6, 6] = btn67;
			_btnArray[6, 7] = btn68;

			_btnArray[7, 0] = btn71;
			_btnArray[7, 1] = btn72;
			_btnArray[7, 2] = btn73;
			_btnArray[7, 3] = btn74;
			_btnArray[7, 4] = btn75;
			_btnArray[7, 5] = btn76;
			_btnArray[7, 6] = btn77;
			_btnArray[7, 7] = btn78;

			_gbArray[0] = groupBox0;
			_gbArray[1] = groupBox1;
			_gbArray[2] = groupBox2;
			_gbArray[3] = groupBox3;
			_gbArray[4] = groupBox4;
			_gbArray[5] = groupBox5;
			_gbArray[6] = groupBox6;
			_gbArray[7] = groupBox7;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			cbMatchMode.SelectedIndex += 1;
		}

		private void cbMatchMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			var index = cbMatchMode.SelectedIndex;
			btnNext.Enabled = index < cbMatchMode.Items.Count - 1;
			_dataCollector.SetMode((MatchMode)index);
		}

	}	// MainForm Class

}	// namespace
