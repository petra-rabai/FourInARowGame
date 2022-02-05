using FourInARowGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame.Classes
{
    public class Grid : IGrid
    {
        public int gridColum { get; set; } = 7;
        public int gridRow { get; set; } = 6;
        public string cellStatus { get; set; }
        public bool cellOccupied { get; set; }
        public int[,] gridCellPosition { get; set; }

        public void DrawGrid(int colum, int row)
        {
            
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < colum; j++)
                {
                    Console.Write(" " + "|" + gridCellPosition[j,i] + "|" + " ");
                }

                Console.Write("\n");
                Console.Write("\n");
                
            }

            Console.ReadLine();
        }

        public string GetCurrentCellStatus()
        {
            throw new NotImplementedException();
        }

        public int[,] InitializeGridCellPosition()
        {
            gridCellPosition = new int[gridColum, gridRow];
            return gridCellPosition;
        }
    }
}
