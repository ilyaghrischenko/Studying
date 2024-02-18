using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8
{
    public class Trombone : MusicInstrument
    {
        private string _material;
        private double _bulk;

        public Trombone(string name, string description, string producer, string history, string material, double bulk) : base(name, description, producer, history)
        {
            Material = material;
            Bulk = bulk;
        }

        public string Material
        {
            get { return _material; }
            set
            {
                if (value == string.Empty) throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsLetterOrDigit(item)) throw new Exception();
                }

                _material = value;
            }
        }
        public double Bulk
        {
            get { return _bulk; }
            set
            {
                if (value < 1) throw new Exception();
                _bulk = value;
            }
        }

        public void Input()
        {
            base.Input();

            Write("Material: ");
            Material = ReadLine();

            Write("Bulk: ");
            Bulk = double.Parse(ReadLine());
        }

        public override void Sound()
        {
            WriteLine("Trombone!");
        }
        public override void Show()
        {
            WriteLine($"{base.ToString()}\n{Material} {Bulk}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n{Material} {Bulk}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;

            var other = (Trombone)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}