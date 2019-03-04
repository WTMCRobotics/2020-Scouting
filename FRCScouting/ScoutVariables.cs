using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRCScouting
{
    class ScoutVariables //The variables we're scouting for. This changes every year so will need to come up with a way to do this dynamically
    {
        //Sandstorm variables
        public int SandstormHABlevel = 0;
        public int SandstormCargo = 0;
        public int SandstormHatch = 0;

        //Teleop variables
        public int TeleopCargo = 0;
        public int TeleopHatch = 0;
        public int TeleopRocketLevel = 0;
        public int TeleopHABlevel = 0;
        public int TeleopCargoDropped = 0;
        public int TeleopHatchDropped = 0;
    }
}
