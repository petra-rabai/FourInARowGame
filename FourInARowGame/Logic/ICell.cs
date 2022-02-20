namespace FourInARowGame
{
    public interface ICell
    {
        string Color { get; set; }
        int Colum { get; set; }
        bool Occupied { get; set; }
        int Row { get; set; }
    }
}