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

            for (int i = colum; i >= 0; i--)
            {
                for (int j = 0; j < row; j++)
                {
                    Console.Write(" _____" + "\n" + "|     |" + "\n" + "|_____|");
                }

                Console.Write("\n");
            }

            //for (int i = 0; i < row; i++)
            //{
            //    Console.WriteLine(" ________ " + "\t" + " ________");
            //    Console.WriteLine("|        |" + "\t" + "|        |");
            //    Console.WriteLine("|________|" + "\t" + "|________|");
            //}

            // Console.Write(" _____" + "\n" + "|     |" + "\n" + "|_____|");

            Console.ReadLine();
        }

        public string GetCurrentCellStatus()
        {
            throw new NotImplementedException();
        }
    }
}
