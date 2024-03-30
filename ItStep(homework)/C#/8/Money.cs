using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8
{
    public class Money
    {
        private int _whole;
        private int _pennies;

        public Money()
        {
            _whole = 0;
            _pennies = 0;
        }
        public Money(int whole, int pennies)
        {
            Whole = whole;
            Pennies = pennies;
        }

        public int Whole
        {
            get { return _whole; }
            set
            {
                if (value < 0) throw new Exception("Whole: Invalid value");
                _whole = value;
            }
        }
        public int Pennies
        {
            get { return _pennies; }
            set
            {
                if (value < 0F) throw new Exception("Pennies: Invalid value");
                _pennies = value;
            }
        }

        public void Show()
        {
            WriteLine(ToString());
        }
        public void Input()
        {
            Write("Whole: ");
            Whole = int.Parse(ReadLine());

            Write("Pennies: ");
            Pennies = int.Parse(ReadLine());
        }

        public override string ToString()
        {
            return $"{Whole},{Pennies}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;

            var other = (Money)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
