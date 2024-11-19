namespace HW_3.Models;

public class Minesweeper
{
    public Cell[,] Board { get; private set; }
    public int Size { get; private set; }
    public int TotalMines { get; private set; }

    public Minesweeper(int size, int totalMines)
    {
        Size = size;
        TotalMines = totalMines;
        Board = new Cell[size, size];
        InitializeBoard();
    }

    private void InitializeBoard()
    {
        for (int i = 0; i < Size; i++)
        {
            for (int j = 0; j < Size; j++)
            {
                Board[i, j] = new Cell();
            }
        }

        Random random = new Random();
        int minesPlaced = 0;
        while (minesPlaced < TotalMines)
        {
            int x = random.Next(Size);
            int y = random.Next(Size);

            if (!Board[x, y].IsMine)
            {
                Board[x, y].IsMine = true;
                minesPlaced++;
                UpdateNeighborCounts(x, y);
            }
        }
    }

    private void UpdateNeighborCounts(int x, int y)
    {
        for (int i = x - 1; i <= x + 1; i++)
        {
            for (int j = y - 1; j <= y + 1; j++)
            {
                if (i >= 0 && j >= 0 && i < Size && j < Size && !(i == x && j == y))
                {
                    Board[i, j].NeighborMines++;
                }
            }
        }
    }
}