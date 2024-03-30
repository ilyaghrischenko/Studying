using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8
{
    public class Microwave : Device
    {
        private string _coatingType;
        private double _volume;

        public Microwave(string name, string description, string coatingType, double volume) : base(name, description)
        {
            Name = name;
            Description = description;
            CoatingType = coatingType;
            Volume = volume;
        }

        public string CoatingType
        {
            get { return _coatingType; }
            set
            {
                if (value == string.Empty) throw new Exception("CoatingType: Invalid value");
                foreach (var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception("CoatingType: Invalid value");
                }

                _coatingType = value;
            }
        }
        public double Volume
        {
            get { return _volume; }
            set
            {
                if (value < 0) throw new Exception("Volume: Invalid value");
                _volume = value;
            }
        }

        public override void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Description: ");
            Description = ReadLine();

            Write("Coating type: ");
            CoatingType = ReadLine();

            Write("Volume: ");
            Volume = double.Parse(ReadLine());
        }
        public override void Show()
        {
            WriteLine($"Name: {Name} || Description: {Description} || Coating type: {CoatingType} || Volume: {Volume}");
        }
        public override void Sound()
        {
            WriteLine("humming!");
        }

        public override string ToString()
        {
            return base.ToString() + $"|| Coating type: {CoatingType} || Volume: {Volume}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Microwave)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
