using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame.Interfaces
{
    public interface IPlayer
    {
       string choosedDiscColor { get; set; }
       string choosedMenu { get; set; }
       string choosedGameMode { get; set; }
       string consoleData { get; set; }
       string GetChoosedMenu();
       void ReadFromConsole();



    }
}
