namespace FourInARowGame
{
    public interface IGrid
    {
        Cell Cell { get; set; }
        int[,] PositionMatrix { get; set; }
        int[] Size { get; set; }

        int[,] CreatePositionMatrix(int[] size);
        int[] GetSize();
    }
}