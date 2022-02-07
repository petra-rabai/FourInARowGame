using FourInARowGame.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UIContent content = new UIContent();
            SetupConsoleWindow setupConsole = new SetupConsoleWindow();
            setupConsole.SetupConsoleScreen();
            content.InitializeGameMainScreen();

            Console.ReadLine();
        }
    }
}
