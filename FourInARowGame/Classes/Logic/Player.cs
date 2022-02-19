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
        public string playerName { get; set; }
        public string choosedDiscColor { get; set; }
        public int availableDiscCount { get; set; }
        public bool firstPlayer { get; set; }

        public string GetDiscColor()
        {
            
            return choosedDiscColor;
        }

        public string GetName()
        {
            UIContent content = new UIContent();
            
            content.InitializeGetPlayerName();
            playerName = Console.ReadLine();

            return playerName;
        }
    }
}
