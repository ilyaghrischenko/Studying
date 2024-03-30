using static System.Console;

public struct RGB
{
    private byte _red;
    private byte _green;
    private byte _blue;

    public RGB(byte red, byte green, byte blue)
    {
        if ((red < 0 || red > 255) || (green < 0 || green > 255) || (blue < 0 || blue > 255))
        {
            throw new ArgumentOutOfRangeException("Invalid RGB values");
        }

        _red = red;
        _green = green;
        _blue = blue;
    }

    public void ToHex()
    {
        string hex = $"#{_red:X2}{_green:X2}{_blue:X2}";
        WriteLine($"Hex: {hex}");
    }
    public void ToHSL()
    {
        double r = _red / 255.0;
        double g = _green / 255.0;
        double b = _blue / 255.0;

        double cmax = Math.Max(r, Math.Max(g, b));
        double cmin = Math.Min(r, Math.Min(g, b));
        double delta = cmax - cmin;

        double hue = 0;
        double saturation = 0;
        double lightness = (cmax + cmin) / 2.0;

        if (delta != 0)
        {
            saturation = delta / (1 - Math.Abs(2 * lightness - 1));

            if (cmax == r)
                hue = 60 * (((g - b) / delta) % 6);
            else if (cmax == g)
                hue = 60 * (((b - r) / delta) + 2);
            else
                hue = 60 * (((r - g) / delta) + 4);
        }

        Console.WriteLine($"HSL: ({hue}, {saturation}, {lightness})");
    }
    public void ToCMYK()
    {
        double r = _red / 255.0;
        double g = _green / 255.0;
        double b = _blue / 255.0;

        double k = 1 - Math.Max(r, Math.Max(g, b));
        double c = (1 - r - k) / (1 - k);
        double m = (1 - g - k) / (1 - k);
        double y = (1 - b - k) / (1 - k);

        Console.WriteLine($"CMYK: ({c}, {m}, {y}, {k})");
    }
}