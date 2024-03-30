using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW_14
{
    public enum PlayGenre
    {
        Buffoonery,
        Drama,
        Comedy,
        Melodrama,
        Mystery,
        Musical,
        Monodrama,
        Pastoral
    }

    public class Play : IDisposable
    {
        private string _name;
        private string _pib;
        public PlayGenre Genre { get; private set; } = PlayGenre.Comedy;
        public uint _year;

        public Play()
        {
            Name = "NoName";
            Pib = "NoPib";
            Year = 2024;
        }
        public Play(string name, string pib, PlayGenre genre, uint year)
        {
            Name = name;
            Pib = pib;
            Genre = genre;
            Year = year;
        }
        ~Play()
        {
            Dispose();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "") throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsLetterOrDigit(item)) throw new Exception();
                }
                _name = value;
            }
        }
        public string Pib
        {
            get { return _pib; }
            set
            {
                if (value == "") throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsLetterOrDigit(item)) throw new Exception();
                }
                _pib = value;
            }
        }
        public uint Year
        {
            get { return _year; }
            set
            {
                if (value < 1000 || value > 2024) throw new Exception();
                _year = value;
            }
        }

        public void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Pib: ");
            Pib = ReadLine();

            Write("Genre: ");
            Genre = (PlayGenre)Enum.Parse(typeof(PlayGenre), ReadLine());

            Write("Year: ");
            Year = uint.Parse(ReadLine());
        }
        public void Show()
        {
            WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"Name: {Name} || Pib: {Pib} || Genre: {Genre} || Year: {Year}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;

            var other = obj as Play;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            WriteLine("Object deleted");
        }
    }
}
