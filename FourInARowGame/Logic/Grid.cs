using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame
{
    public class Grid : IGrid
    {
        public Grid()
        {
            Size = new int[2];
            PositionMatrix = new int[0, 0];
            Cell = new Cell();
        }

        public int[] Size { get; set; } = new int[2];
        public Cell Cell { get; set; }
        public int[,] PositionMatrix { get; set; }

        public int[] GetSize()
        {
            UIContent content = new UIContent();
            content.InitializeBoradSizeOption();

            int colum = Convert.ToInt32(Console.ReadLine() + "\n");
            int row = Convert.ToInt32(Console.ReadLine() + "\n");

            Size[0] = colum;
            Size[1] = row;

            return Size;
        }

        public int[,] CreatePositionMatrix(int[] size)
        {
            PositionMatrix = new int[size[0], size[1]];

            return PositionMatrix;
        }

        public void DrawGrid()
        {
            for (int i = 0; i < Size[1]; i++)
            {
                for (int j = 0; j < Size[0]; j++)
                {
                    Console.Write($" |{PositionMatrix[j, i]}| ");
                }

                Console.Write("\n");
                Console.Write("\n");
            }
        }
    }
}
