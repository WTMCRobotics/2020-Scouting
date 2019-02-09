using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FRCScouting
{
    public class Match
    {
        public int[] BlueArr = new int[3];
        public int[] RedArr = new int[3];
        
        public Match()
        {
            for (int i = 0; i < 3; i++)
                BlueArr[i] = 0;

            for (int i = 0; i < 3; i++)
                RedArr[i] = 0;
        }
    }
}
