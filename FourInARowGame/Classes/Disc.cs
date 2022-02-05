using FourInARowGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame.Classes
{
    public class Disc : IDisc
    {
        public string discColor { get; set ; }
        public int availableDiscCount { get; set; }
        public Dictionary<Tuple<int, string>, string> redDiscPack { get; set; } = new Dictionary<Tuple<int, string>, string>();
        public Dictionary<Tuple<int, string>, string> yellowDiscPack { get; set ; } = new Dictionary<Tuple<int, string>, string>();
        public Tuple<int, string> redDisc { get; set; }
        public Tuple<int, string> yellowDisc { get; set; }

        public Dictionary<Tuple<int, string>, string> CreateRedDiscPack()
        {
            discColor = "Red";
            availableDiscCount = 21;
            for (int i = 0; i < availableDiscCount; i++)
            {
                redDisc = new Tuple<int, string>(i, discColor);
                redDiscPack[redDisc] = i.ToString() + "-"+ discColor;
            }
            
            return redDiscPack;
        }

        public Dictionary<Tuple<int, string>, string> CreateYellowDiscPack()
        {
            discColor = "Yellow";
            availableDiscCount = 21;
            for (int i = 0; i < availableDiscCount; i++)
            {
                yellowDisc = new Tuple<int, string>(i, discColor);
                yellowDiscPack[yellowDisc] = i.ToString() + "-" + discColor;
            }
            return yellowDiscPack;
        }
    }
}
