using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8
{
    public class Ukulele : MusicInstrument
    {
        private int _fretNumber;
        private int _stringsNumber;

        public Ukulele(string name, string description, string producer, string history, int fretNumber, int stringsNumber) : base(name, description, producer, history)
        {
            FretNumber = fretNumber;
            StringsNumber = stringsNumber;
        }

        public int FretNumber
        {
            get { return _fretNumber; }
            set
            {
                if (value < 3) throw new Exception(); 
                _fretNumber = value;
            }
        }
        public int StringsNumber
        {
            get { return _stringsNumber; }
            set
            {
                if (value < 3) throw new Exception();
                _stringsNumber = value;
            }
        }

        public void Input()
        {
            base.Input();

            Write("Fret number: ");
            FretNumber = int.Parse(ReadLine());

            Write("Strings number: ");
            StringsNumber = int.Parse(ReadLine());
        }

        public override void Sound()
        {
            WriteLine("Ukulele!");
        }
        public override void Show()
        {
            WriteLine($"{base.ToString()}\n{FretNumber} {StringsNumber}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n{FretNumber} {StringsNumber}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;

            var other = (Ukulele)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
