using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8
{
    public class Kettle : Device
    {
        private string _maker;
        private int _year;

        public Kettle(string name, string description, string maker, int year) : base(name, description)
        {
            Maker = maker;
            Year = year;
        }

        public string Maker
        {
            get { return _maker; }
            set
            {
                if (value == string.Empty) throw new Exception("Maker: Invalid value");
                foreach (var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception("Maker: Invalid value");
                }

                _maker = value;
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

            Write("Maker: ");
            Maker = ReadLine();

            Write("Year: ");
            Year = int.Parse(ReadLine());
        }
        public override void Show()
        {
            WriteLine($"Name: {Name} || Description: {Description} || Maker: {Maker} || Year: {Year}");
        }
        public override void Sound()
        {
            WriteLine("Whistling!!");
        }

        public override string ToString()
        {
            return base.ToString() + $"|| Maker: {Maker} || Year: {Year}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Kettle)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
