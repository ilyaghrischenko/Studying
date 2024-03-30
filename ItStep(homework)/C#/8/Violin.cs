using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace _8
{
    public class Violin : MusicInstrument
    {
        private int _size;
        private string _color;

        public Violin(string name, string description, string producer, string history, int size, string color) : base(name, description, producer, history)
        {
            Size = size;
            Color = color;
        }

        public int Size
        {
            get { return _size; }
            set
            {
                if (_size < 0) throw new Exception(); 
                _size = value;
            }
        }
        public string Color
        {
            get { return _color; }
            set
            {
                if (value == string.Empty) throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception();
                }

                _color = value;
            }
        }

        public void Input()
        {
            base.Input();

            Write("Size: ");
            Size = int.Parse(ReadLine());

            Write("Color: ");
            Color = ReadLine();
        }

        public override void Sound()
        {
            WriteLine("Violin");
        }
        public override void Show()
        {
            WriteLine($"{base.ToString()}\n{Size} {Color}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n{Size} {Color}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;

            var other = (Violin)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
