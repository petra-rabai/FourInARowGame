using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourInARowGame.Interfaces
{
    public interface IDisc
    {
        string discColor { get; set; }
        int availableDiscCount { get; set; }
        Dictionary<Tuple<int, string>,string> redDiscPack { get; set; }
        Dictionary<Tuple<int, string>, string> yellowDiscPack { get; set; }
        Tuple<int, string> redDisc { get; set; }
        Tuple<int, string> yellowDisc { get; set; }
        Dictionary<Tuple<int, string>, string> CreateRedDiscPack();
        Dictionary<Tuple<int, string>, string> CreateYellowDiscPack();
    }
}
