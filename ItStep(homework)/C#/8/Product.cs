using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8
{
    public class Product
    {
        public Money Price { get; set; } = new Money();
        private string _name;

        public Product()
        {
            _name = "NoName";
        }
        public Product(Money price, string name)
        {
            Price = price;
            _name = name;
        }
        public Product(int whole, int pennies, string name)
        {
            Price = new Money(whole, pennies);
            _name = name;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == string.Empty) throw new Exception("Name: Invalid value");
                foreach (var item in _name)
                {
                    if (!char.IsLetter(item)) throw new Exception("Name: Invalid value");
                }

                _name = value;
            }
        }

        public void Show()
        {
            WriteLine(ToString());
        }
        public void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Price.Input();
        }

        public override string ToString()
        {
            return $"Name: {Name} Price: {Price}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;

            var other = (Product)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public void DecreasePrice(Money value)
        {
            int whole = value.Whole;
            int pennies = value.Pennies;

            Price = new Money(Price.Whole - whole, Price.Pennies - pennies);
        }
        public void IncreasePrice(Money value)
        {
            int whole = value.Whole;
            int pennies = value.Pennies;

            Price = new Money(Price.Whole + whole, Price.Pennies + pennies);
        }

        static public Product operator -(Product my, Money value)
        {
            int whole = value.Whole;
            int pennies = value.Pennies;

            my.Price = new Money(my.Price.Whole - whole, my.Price.Pennies - pennies);
            return my;
        }
        static public Product operator +(Product my, Money value)
        {
            int whole = value.Whole;
            int pennies = value.Pennies;

            my.Price = new Money(my.Price.Whole + whole, my.Price.Pennies + pennies);
            return my;
        }
    }
}
