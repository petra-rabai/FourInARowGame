using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame
{
    public class AIHelper : IAIHelper
    {
        public string AIColor { get; set; }
        public int AIDiscCount { get; set; }
        public bool AIBoolean { get; set; }

        public string DiscColorChooser()
        {
            string[] discColor = new string[2];
            discColor[0] = "Red";
            discColor[1] = "Yellow";
            Random color = new Random();
            AIColor = discColor[color.Next(discColor.Length)];

            return AIColor;
        }

        public int SetDiscCount()
        {
            AIDiscCount = 21;

            return AIDiscCount;
        }

        public bool SetFirstPlayer()
        {
            bool[] trueOrfalse = new bool[2];
            trueOrfalse[0] = true;
            trueOrfalse[1] = false;
            Random boolean = new Random();
            AIBoolean = trueOrfalse[boolean.Next(trueOrfalse.Length)];

            return AIBoolean;
        }
    }
}
