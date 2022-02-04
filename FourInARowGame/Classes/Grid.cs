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

        public void DrawGrid(int colum, int row)
        {
          //  colum = gridColum;
            //row = gridRow;

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine(" ________ ");
                Console.WriteLine("|        |");
                Console.WriteLine("|________|");
                //Console.Write("\b");
                for (int j = 0; j < colum; j++)
                {
                    Console.Write(" ________ ");
                    Console.Write("|        |");
                    Console.Write("|________|");
                }

                Console.WriteLine("\t");
            }

            Console.ReadLine();
        }

        public string GetCurrentCellStatus()
        {
            throw new NotImplementedException();
        }
    }
}
