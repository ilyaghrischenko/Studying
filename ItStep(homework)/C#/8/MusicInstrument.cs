using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8
{
    public abstract class MusicInstrument
    {
        protected string _name;
        protected string _producer;
        protected string _description;
        protected string _history;

        public MusicInstrument(string name, string description, string producer, string history)
        {
            Name = name;
            Description = description;
            Producer = producer;
            History = history;
        }

        protected string Name
        {
            get { return _name; }
            set
            {
                if (value == string.Empty) throw new Exception();
                foreach(var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception();
                }

                _name = value;
            }
        }
        protected string Description
        {
            get { return _description; }
            set
            {
                if (value == string.Empty) throw new Exception();
                _description = value;
            }
        }
        protected string Producer
        {
            get { return _producer; }
            set
            {
                if (value == string.Empty) throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsLetterOrDigit(item)) throw new Exception();
                }

                _producer = value;
            }
        }
        protected string History
        {
            get { return _history; }
            set
            {
                if (value == string.Empty) throw new Exception();
                _history = value;
            }
        }

        protected void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Description: ");
            Description = ReadLine();

            Write("Producer: ");
            Producer = ReadLine();

            Write("History: ");
            History = ReadLine();
        }

        public override string ToString()
        {
            return $"{Name} {Producer}\n\n{Description}\n\n{History}";
        }

        public abstract void Sound();
        public abstract void Show();

        public void Desc()
        {
            WriteLine(Description);
        }
        public void Hist()
        {
            WriteLine(History);
        }
    }
}
