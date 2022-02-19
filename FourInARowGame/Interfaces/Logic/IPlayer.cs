﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame.Interfaces
{
    public interface IPlayer
    {
        string playerName { get; set; }
        string choosedDiscColor { get; set; }
        int availableDiscCount { get; set; }
        bool firstPlayer { get; set; }
        string GetName();
        string GetDiscColor();
    }
}
