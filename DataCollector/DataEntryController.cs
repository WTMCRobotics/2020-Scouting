using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace Scouting.DataCollector
{
	public enum MatchMode
	{
		Reset,
		Waiting,
		Auton,
		Teleop,
		Done
	};

	public class DataEntryController
	{
		private const string kLatestVersion = "v0.5";

		public enum Status
		{
			Invalid,
			OldFirmware,
			BadID,
			OK
		};
		private enum Command
		{
			ModeReset,
			ModeWaiting,
			ModeAuton,
			ModeTeleop,
			ModeDone,

			ReadVersion,
			ReadSwitches,
			ReadMode,
			ReadButtons,
			ReadAuton,
			ReadTeleop,

			LEDOn,
			LEDOff,
			LEDToggle,
			LEDFlash
		};

		private SerialPort _port;
		private static readonly List<string> _command;

		public Status PortStatus { get; private set; }

		private string _version;
		private byte _id;
		private byte _buttons;

		public string Version { get { return _version; } }
		public byte ID { get { return _id; } }
		public byte Buttons { get { return _buttons; } }
		public string PortName { get; private set; }
		public MatchMode Mode { get; private set; }

		public byte[] AutonCounts { get; private set; }
		public byte[] TeleopCounts { get; private set; }

		// static constructor to create controller command arrays
		static DataEntryController()
		{
			_command = new List<string>
			{
				"MR", "MW", "MA", "MT", "MD",
				"RV", "RS", "RM", "RB", "RA", "RT",
				"L0", "L1", "LT", "LF",
			};
		}
		
		// contructor
		public DataEntryController(string portName)
		{
			PortName = portName;
			_port = new SerialPort(portName, 115200, Parity.None, 8, StopBits.One);
			_port.ReadTimeout = 100;
			_port.Open();
			
			AutonCounts = new byte[8];
			TeleopCounts = new byte[8];
			Mode = MatchMode.Reset;

			TestPort();
		}

		private void TestPort()
		{
			if (!QueryController(Command.ReadVersion, out _version))
				PortStatus = Status.Invalid;
			else if (Version != kLatestVersion)
				PortStatus = Status.OldFirmware;
			else if (!PollSwitches())
				PortStatus = Status.BadID;
			else if (ID > 7)
				PortStatus = Status.BadID;
			else
				PortStatus = Status.OK;
		}

		public void SetMatchMode(MatchMode mode)
		{
			switch (mode)
			{
				case MatchMode.Reset:	CommandController(Command.ModeReset); break;
				case MatchMode.Waiting: 	CommandController(Command.ModeWaiting); break;
				case MatchMode.Auton:	CommandController(Command.ModeAuton); break;
				case MatchMode.Teleop:	CommandController(Command.ModeTeleop); break;
				case MatchMode.Done:		CommandController(Command.ModeDone); break;
			}
			Mode = mode;
		}

		private void CommandController(Command cmd)
		{
			_port.Write(_command[(int)cmd].ToCharArray(), 0, 2);
		}

		private bool QueryController(Command cmd, out string response)
		{
			try
			{
				_port.Write(_command[(int)cmd].ToCharArray(), 0, 2);
				response = _port.ReadLine().TrimEnd('\r');
			}
			catch (TimeoutException)
			{
				response = "!";
			}

			return (response != "!");
		}

		public void Poll()
		{
			PollButtons();
			PollCounts();
		}

		public bool PollSwitches()
		{
			return PollByte(Command.ReadSwitches, ref _id);
		}

		public bool PollButtons()
		{
			return PollByte(Command.ReadButtons, ref _buttons);
		}

		private bool PollByte(Command cmd, ref byte value)
		{
			if (!QueryController(cmd, out string buttonStr))
				return false;

			if (!byte.TryParse(buttonStr, System.Globalization.NumberStyles.HexNumber, null, out byte btVal))
				return false;

			value = btVal;
			return true;
		}

		public void PollCounts()
		{
			if (!QueryController(Command.ReadAuton, out string csAutonCounts) || csAutonCounts.Length != 23)
				return;

			if (!QueryController(Command.ReadTeleop, out string csTeleopCounts) || csAutonCounts.Length != 23)
				return;

			UpdateCounts(csAutonCounts, AutonCounts);
			UpdateCounts(csTeleopCounts, TeleopCounts);

			return;
		}

		private void UpdateCounts(string csCounts, byte[] counts)
		{
			var csSplit = csCounts.Split(',');
			for (var i=0; i<8; i++)
			{
				if (!byte.TryParse(csSplit[i], System.Globalization.NumberStyles.HexNumber, null, out counts[i]))
				{
					counts[i] = 0;
				}
			}
			return;
		}

	}
}
