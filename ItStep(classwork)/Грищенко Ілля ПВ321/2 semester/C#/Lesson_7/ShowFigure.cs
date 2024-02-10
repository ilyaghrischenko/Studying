using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Triangle
{
    public class ShowFigure
    {
        public int Lenght { get; set; } = 5;
        public int Height { get; set; } = 3;
        public char Symbol { get; set; } = '#';

        public void Show()
        {
            for (int i = 0; i < Height; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    Write(Symbol);
                }
                WriteLine();
            }
        }
    }
}

namespace Rectangle
{
    public class ShowFigure
    {
        public int Lenght { get; set; } = 5;
        public int Height { get; set; } = 3;
        public char Symbol { get; set; } = '#';

        public void Show()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Lenght; j++)
                {
                    Write(Symbol);
                }
                WriteLine();
            }
        }
    }
}

namespace Square
{
    public class ShowFigure
    {
        public int Side { get; set; } = 2;
        public char Symbol { get; set; } = '#';

        public void Show()
        {
            for (int i = 0; i < Side; i++)
            {
                for (int j = 0; j < Side; j++)
                {
                    Write(Symbol);
                }
                WriteLine();
            }
        }
    }
}
