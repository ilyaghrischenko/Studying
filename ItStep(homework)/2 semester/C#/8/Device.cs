using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8
{
    public abstract class Device
    {
        protected string _name;
        protected string _description;

        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }

        protected string Name
        {
            get { return _name; }
            set
            {
                if (value == string.Empty) throw new Exception("Name: Invalid value");
                foreach (var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception("Name: Invalid value");
                }

                _name = value;
            }
        }
        protected string Description
        {
            get { return _description; }
            set
            {
                if (value == string.Empty) throw new Exception("Description: Invalid value");

                _description = value;
            }
        }

        public abstract void Sound();
        public abstract void Show();
        public abstract void Input();

        public override string ToString()
        {
            return $"Name: {Name} || Description: {Description} ";
        }

        protected void Desc()
        {
            WriteLine(Description);
        }
    }
}
