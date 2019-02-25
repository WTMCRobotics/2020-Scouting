/*
  Data Entry program for FIRST Robotics Competitions
	Serial Commands
	  Match Mode
		"MR"  reset - clear all counts
		"MW"  countdown - flash LED in prep for game starting
		"MA"  auton - enter auton mode
		"MT"  teleop - enter teleop mode 
		"MD"  done - finish match
	  Read data
		"RV"  read version string
		"RM"  read mode
		"RS"  read ID switches
		"RB"  read button data
		"RA"  read auton counts
		"RT"  read teleop counts
	  LED Control
		"L0"  LED Off
		"L1"  LED On
		"LT"  LED Toggle
		"LF"  LED Flash
*/

#define NUMBER_OF_BUTTONS 8
#define DEBOUNCE_LENGTH  14

char version[]  = "v0.3";

// LED Commands
enum
{
	ledOff,
	ledOn,
	ledToggle,
	ledFlash
};

// Match Modex
enum 
{
	matchReset	= 0,
	matchWait	= 1,
	matchAuton	= 2,
	matchTeleop	= 3,
	matchDone	= 4
};

bool _bFlashLED = false;
byte _matchMode = matchDone;

byte _buttons;
byte _switchData;
char _responseBuffer[64];
byte _autonCount[NUMBER_OF_BUTTONS];
byte _teleopCount[NUMBER_OF_BUTTONS];


void setup()
{
	// buttons
	pinMode(2, INPUT_PULLUP);
	pinMode(3, INPUT_PULLUP);
	pinMode(4, INPUT_PULLUP);
	pinMode(5, INPUT_PULLUP);
	pinMode(6, INPUT_PULLUP);
	pinMode(7, INPUT_PULLUP);
	pinMode(8, INPUT_PULLUP);
	pinMode(9, INPUT_PULLUP);

	// switches
	pinMode(10, INPUT_PULLUP);
	pinMode(11, INPUT_PULLUP);
	pinMode(12, INPUT_PULLUP);
	pinMode(13, OUTPUT);
	pinMode(19, OUTPUT);
	digitalWrite(19, HIGH);

	PollSwitches();

	Serial.begin(115200);
}

byte _presses;
byte _lastPresses;

void loop()
{
	static char ch;
	static uint32_t lastMillis = 0;
//	Serial.println(micros());

	DebounceButtons();
	PollButtons();

	if ((millis() - lastMillis) > 500)
	{
		lastMillis = millis();
		if (_bFlashLED)	
			SetLED(ledToggle);
	}
	
	ProcessSerialCommands();
}

void ProcessSerialCommands()
{
	if (Serial.peek() == -1)
		return;

	char ch = MakeUpper(Serial.read());
	switch (ch)
	{
		// read switches and buttons
	case 'M':
		switch (GetChar())
		{
		case 'R':	// reset
			ResetAllCounts();
			_matchMode = matchReset;
			break;
		case 'W':	// countdown
			SetLED(ledFlash);
			_matchMode = matchWait;
			break;
		case 'A':	// auton
			SetLED(ledOn);
			_matchMode = matchAuton;
			break;
		case 'T':	// teleop
			SetLED(ledOff);
			_matchMode = matchTeleop;
			break;
		case 'E':	// end of match
			SetLED(ledOff);
			_matchMode = matchDone;
			break;
		}
		break;

		// read 
	case 'R':
		char* buffer;
		switch (GetChar())
		{
		case 'V': buffer = version;							break;
		case 'M': buffer = GetModeResponse();				break;
		case 'S': buffer = GetByteResponse(_switchData);	break;
		case 'B': buffer = GetByteResponse(_buttons);	break;
		case 'A': buffer = GetCountResponse(_autonCount);	break;
		case 'T': buffer = GetCountResponse(_teleopCount);	break;
		}
		Serial.println(buffer);
		break;

		// control led
	case 'L':
		switch (GetChar())
		{
		case '0': SetLED(ledOff);		break;
		case '1': SetLED(ledOn);		break;
		case 'T': SetLED(ledToggle);	break;
		case 'F': SetLED(ledFlash);		break;
		}
		break;
	}
}

char MakeUpper(char ch)
{
	if (ch >= 'a' && ch <= 'z')
		return ch -= 0x20;
	else
		return ch;
}

char GetChar()
{
	while (Serial.peek() == -1);
	return MakeUpper(Serial.read());
}

void SetLED(int action)
{
	switch (action)
	{	
		case ledOn:
			_bFlashLED = false;
			digitalWrite(19, LOW);
			break;
		case ledOff:
			_bFlashLED = false;
			digitalWrite(19, HIGH);
			break;
		case ledToggle:
			digitalWrite(19, !digitalRead(19));
			break;
		case ledFlash:
			_bFlashLED = true;
			break;
		default:
			break;
	}
}

void PollButtons()
{
	static uint16_t lastData = 0;

	uint16_t presses  = (_buttons ^ lastData) & _buttons;	
	uint16_t releases = (_buttons ^ lastData) & ~_buttons;
	lastData = _buttons;

	_presses = presses;

	for (int i = 0; i < NUMBER_OF_BUTTONS; i++)
	{
		if (presses & 0x01 == 1)
		{
			if (_matchMode == matchAuton)
				_autonCount[i]++;
			else if (_matchMode == matchTeleop)
				_teleopCount[i]++;
		}
		presses = presses >> 1;
	}
}

void DebounceButtons()
{
	static uint16_t buttonHistory[8];
	static uint16_t debounceMask = (1 << DEBOUNCE_LENGTH) - 1;

	byte buttonBit = 0x01;
	byte buttonVal = 0;

	// get state of buttons
	if (!digitalRead(8)) buttonVal |= 0x01;
	if (!digitalRead(9)) buttonVal |= 0x02;
	if (!digitalRead(7)) buttonVal |= 0x04;
	if (!digitalRead(6)) buttonVal |= 0x08;
	if (!digitalRead(5)) buttonVal |= 0x10;
	if (!digitalRead(4)) buttonVal |= 0x20;
	if (!digitalRead(3)) buttonVal |= 0x40;
	if (!digitalRead(2)) buttonVal |= 0x80;

	for (int i = 0; i < NUMBER_OF_BUTTONS; i++)
	{
		buttonHistory[i] <<= 1;
		if ((buttonVal & 0x01) == 1)
		{
			buttonHistory[i] |= 0x0001;
			if ((buttonHistory[i] & debounceMask) == debounceMask)
			_buttons |= buttonBit;
		}
		else
		{
			buttonHistory[i] &= 0xfffe;
			if ((buttonHistory[i] & debounceMask) == 0x0000)
				_buttons &= ~buttonBit;
		}
		buttonVal >>= 1;	
		buttonBit <<= 1;
	}
}

uint16_t PollSwitches()
{
	uint8_t data = 0;
	if (!digitalRead(10)) data |= 0x01;
	if (!digitalRead(11)) data |= 0x02;
	if (!digitalRead(12)) data |= 0x04;
	return data;
}

void ResetAllCounts()
{
	for (int i = 0; i < NUMBER_OF_BUTTONS; i++)
	{
		_autonCount[i] = 0;
		_teleopCount[i] = 0;
	}
}

char* GetModeResponse()
{
	switch (_matchMode)
	{
		case matchReset:	return "Reset";		break;
		case matchWait:		return "Waiting";	break;
		case matchAuton:	return "Auton";		break;
		case matchTeleop:	return "Teleop";	break;
		case matchDone:		return "Done";		break;
	}
	return "\0";
}

char* GetByteResponse(uint16_t inputData)
{
	char* pBuffer = _responseBuffer;
	*pBuffer++ = Bin2Hex((inputData >> 4) & 0x0f);
	*pBuffer++ = Bin2Hex((inputData >> 0) & 0x0f);
	*pBuffer = '\0';
	return _responseBuffer;
}

char* GetCountResponse(byte* countBuf)
{
	char* pBuffer = _responseBuffer;
	for (int i = 0; i < NUMBER_OF_BUTTONS; i++)
	{
		byte count = *countBuf++;
		*pBuffer++ = Bin2Hex((count >> 4) & 0x0f);
		*pBuffer++ = Bin2Hex((count >> 0) & 0x0f);
		*pBuffer++ = ',';
	}
	*pBuffer = '\0';
	return _responseBuffer;
}

char Bin2Hex(byte inData)
{	
	inData &= 0x0f;
	return (inData <= 9) ? inData + '0' : inData - 10 + 'A';
}
