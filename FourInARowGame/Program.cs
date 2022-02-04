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
            Grid grid = new Grid();
            grid.DrawGrid(7,6);
        }
    }
}
