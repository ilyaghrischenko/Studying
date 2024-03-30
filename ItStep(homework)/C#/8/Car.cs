using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8
{
    public class Car : Device
    {
        private string _engineType;
        private string _mark;
        private string _model;
        private int _year;

        public Car(string name, string description, string engineType, string mark, string model, int year) : base(name, description)
        {
            _engineType = engineType;
            _mark = mark;
            _model = model;
            _year = year;
        }

        public string EngineType
        {
            get { return _engineType; }
            set
            {
                if (value == string.Empty) throw new Exception("EngineType: Invalid value");
                _engineType = value;
            }
        }
        public string Mark
        {
            get { return _mark; }
            set
            {
                if (value == string.Empty) throw new Exception("Mark: Invalid value");
                _mark = value;
            }
        }
        public string Model
        {
            get { return _model; }
            set
            {
                if (value == string.Empty) throw new Exception("Model: Invalid value");
                _model = value;
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1000 || value > 2024) throw new Exception("Year: Invalid value");
                _year = value;
            }
        }

        public override void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Description: ");
            Description = ReadLine();

            Write("Engine type: ");
            EngineType = ReadLine();

            Write("Mark: ");
            Mark = ReadLine();

            Write("Model: ");
            Model = ReadLine();

            Write("Year: ");
            Year = int.Parse(ReadLine());
        }
        public override void Show()
        {
            WriteLine($"Name: {Name} || Description: {Description} || Engine type: {EngineType} || Mark: {Mark} || Model: {Model} || Year: {Year}");
        }
        public override void Sound()
        {
            WriteLine("Wrrrr!");
        }

        public override string ToString()
        {
            return base.ToString() + $"|| Engine type: {EngineType} || Mark: {Mark} || Model: {Model} || Year: {Year}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Car)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
