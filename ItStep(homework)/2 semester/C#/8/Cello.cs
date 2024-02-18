using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8
{
    public class Cello : MusicInstrument
    {
        private string _vulture;
        private string _type;

        public Cello(string name, string description, string producer, string history, string vulture, string type) : base(name, description, producer, history)
        {
            Vulture = vulture;
            Type = type;
        }

        public string Vulture
        {
            get { return _vulture; }
            set
            {
                if (value == string.Empty) throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception();
                }

                _vulture = value;
            }
        }
        public string Type
        {
            get { return _type; }
            set
            {
                if (value == string.Empty) throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception();
                }

                _type = value;
            }
        }

        public void Input()
        {
            base.Input();

            Write("Vulture: ");
            Vulture = ReadLine();

            Write("Type: ");
            Type = ReadLine();
        }

        public override void Sound()
        {
            WriteLine("Cello!");
        }
        public override void Show()
        {
            WriteLine($"{base.ToString()}\n{Vulture} {Type}");
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n{Vulture} {Type}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;

            var other = (Cello)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
