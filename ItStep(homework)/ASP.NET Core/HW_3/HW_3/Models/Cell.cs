namespace HW_3.Models;

public class Cell
{
    public bool IsMine { get; set; }
    public bool IsRevealed { get; set; }
    public int NeighborMines { get; set; }
}