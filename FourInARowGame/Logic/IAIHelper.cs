using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame
{
    public interface IAIHelper
    {
        string AIColor { get; set; }
        int AIDiscCount { get; set; }
        bool AIBoolean { get; set; }
        string DiscColorChooser();
        int SetDiscCount();
        bool SetFirstPlayer();
    }
}
