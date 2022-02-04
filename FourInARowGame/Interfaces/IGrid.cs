using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame.Interfaces
{
    public interface IGrid
    {
        int gridColum { get; set; }
        int gridRow { get; set; }
        string cellStatus { get; set; }
        bool cellOccupied { get; set; }
        string GetCurrentCellStatus();
        void DrawGrid(int colum, int row);
    }
}
