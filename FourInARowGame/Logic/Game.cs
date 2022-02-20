using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame
{
    public class Game
    {
        public Game()
        {
            Screen = new SetupConsoleWindow();
            Content = new UIContent();
            PlayerOne = new Player();
            PlayerTwo = new Player();
            Machine = new Machine();
            GameMode = new string[2];
            GameMenu = new Dictionary<char, string>();
            Winner = String.Empty;
            ChoosedGameMenu = String.Empty;
            ChoosedGameMode = String.Empty;
        }

        public SetupConsoleWindow Screen { get; set; }
        public UIContent Content { get; set; }
        public Player PlayerOne { get; set; }
        public Player PlayerTwo { get; set; }
        public Machine Machine { get; set; }
        public string[] GameMode { get; set; }
        public Dictionary<char, string> GameMenu { get; set; } = new Dictionary<char, string>()
        {
            ['N'] = "New Game",
            ['S'] = "Save Game",
            ['L'] = "Load Game",
            ['T'] = "Statistics",
            ['A'] = "Author",
            ['R'] = "Game Rules",
            ['Q'] = "Quit"
        };
        public string Winner { get; set; }
        public string ChoosedGameMenu { get; set; }
        public string ChoosedGameMode { get; set; }



    }
}
