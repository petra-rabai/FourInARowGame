using FourInARowGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame.Classes
{
    public class Player : IPlayer
    {
        public string choosedDiscColor { get; set; }
        public string choosedMenu { get; set; }
        public string choosedGameMode { get; set; }
        public string consoleData { get; set; }

        public string GetChoosedMenu()
        {
            ReadFromConsole();
            choosedMenu = consoleData;
            return choosedMenu;
        }

        public void ReadFromConsole()
        {
            consoleData = Console.ReadLine();
        }
    }
}
