using System.Text;

namespace Task2.Models;

public class Square : Shape
{
    public int Side { get; set; }

    public Square(int side, string color) : base(color)
    {
        Side = side;
    }

    public override string Draw()
    {
        var result = new StringBuilder();

        for (int i = 0; i < Side; i++)
        {
            for (int j = 0; j < Side; j++)
            {
                result.Append("* ");
            }
            result.AppendLine();
        }

        return result.ToString();
    }
}
