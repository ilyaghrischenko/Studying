using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _6
{
    public struct RGB
    {
        private byte _red;
        private byte _green;
        private byte _blue;

        public RGB()
        {
            _red = 10;
            _green = 10;
            _blue = 10;
        }
        public RGB(byte red, byte green, byte blue)
        {
            if ((red < 1 || red > 99) || (green < 1 || green > 99) || (blue < 1 || blue > 99))
            {
                throw new Exception("Constructor: Invalid arguments");
            }
            int kilk_num = (red.ToString() + green.ToString() + blue.ToString()).Length;
            if (kilk_num != 3 && kilk_num != 6) throw new Exception("Constructor: Invalid arguments");

            _red = red;
            _green = green;
            _blue = blue;
        }

        public byte Red
        {
            get { return _red; }
            set
            {
                if (value < 1 || value > 99) throw new Exception("Red: Invalid value");
                _red = value;
            }
        }
        public byte Green
        {
            get { return _green; }
            set
            {
                if (value < 1 || value > 99) throw new Exception("Green: Invalid value");
                _green = value;
            }
        }
        public byte Blue
        {
            get { return _blue; }
            set
            {
                if (value < 1 || value > 99) throw new Exception("Blue: Invalid value");
                _blue = value;
            }
        }

        public void Show()
        {
            WriteLine($"RGB: ({_red},{_green},{_blue})");
        }
        public void Input()
        {
            Write("Red: ");
            if (!byte.TryParse(ReadLine(), out byte red))
            {
                throw new Exception("Input(): Invalid value for red");
            }
            Red = red;

            Write("Green: ");
            if (!byte.TryParse(ReadLine(), out byte green))
            {
                throw new Exception("Input(): Invalid value for green");
            }
            Green = green;

            Write("Blue: ");
            if (!byte.TryParse(ReadLine(), out byte blue))
            {
                throw new Exception("Input(): Invalid value for blue");
            }
            Blue = blue;

            if ((red < 1 || red > 99) || (green < 1 || green > 99) || (blue < 1 || blue > 99))
            {
                throw new Exception("Constructor: Invalid arguments");
            }
            int kilk_num = (red.ToString() + green.ToString() + blue.ToString()).Length;
            if (kilk_num != 3 && kilk_num != 6) throw new Exception("Input(): Invalid arguments");
        }

        public override string ToString()
        {
            return $"({Red},{Green},{Blue})";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (RGB)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public void ToHex()
        {
            WriteLine($"Hex: ({Red:X2},{Green:X2},{Blue:X2})");
        }
    }
}
