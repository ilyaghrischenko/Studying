using System.Text;

namespace Task2.Models;

public class Circle : Shape
{
    public int Radius { get; set; }

    public Circle(int radius, string color) : base(color)
    {
        Radius = radius;
    }

    public override string Draw()
    {
        var result = new StringBuilder();
        double thickness = 0.4; // Чем больше, тем "толще" круг
        double rIn = Radius - thickness;
        double rOut = Radius + thickness;

        for (int y = Radius; y >= -Radius; --y)
        {
            for (int x = -Radius; x < rOut; x++)
            {
                double value = x * x + y * y;
                if (value >= rIn * rIn && value <= rOut * rOut)
                {
                    result.Append("*");
                }
                else
                {
                    result.Append(" ");
                }
            }
            result.AppendLine();
        }

        return result.ToString();
    }
}
