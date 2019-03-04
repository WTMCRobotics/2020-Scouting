using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Timers;
using System.Diagnostics;
using System.Globalization;

namespace Scouting.DataCollector
{
    public class DataCollector
    {
		private const int kReadTimeout = 10;

		private DataEntryController[] _controllers;

		public DataEntryController[] Controllers { get { return _controllers; } }

		public DataCollector()
		{
			_controllers	= new DataEntryController[8];

			foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
			{
				if (Convert.ToInt16(portName.Substring(3)) <= 5)
					continue;

				var controller = new DataEntryController(portName);
				if (controller.PortStatus != DataEntryController.Status.OK)
					continue;

				_controllers[controller.ID] = controller;
			}
		}

		public byte GetButtons(uint id) { return _controllers[id].Buttons; }
		public byte[] GetAutonCount(uint id)  { return _controllers[id].AutonCounts; }
		public byte[] GetTeleopCount(uint id) { return _controllers[id].TeleopCounts; }

		public void PollControllers()
		{
			for (var i=0; i<8; i++)
			{
				if (_controllers[i] == null || 
					_controllers[i].PortStatus != DataEntryController.Status.OK)
					continue;

				_controllers[i].PollButtons();
			}
		}

		public void SetMode(MatchMode mode)
		{
			foreach (var controller in _controllers)
			{
				if (controller == null || controller.PortStatus != DataEntryController.Status.OK)
					continue;
				controller.SetMatchMode(mode);
			}

		}

	}
}
