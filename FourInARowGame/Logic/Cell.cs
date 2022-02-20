using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame
{
    public class Cell : ICell
    {
        public Cell()
        {
            Colum = new int();
            Row = new int();
            Occupied = false;
            Color = String.Empty;            
        }
      
        public int Colum { get; set; }
        public int Row { get; set; }
        public bool Occupied { get; set; }
        public string Color { get; set; }

    }
}
