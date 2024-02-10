using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_8
{
    public class Product
    {
        protected string name;
        protected string sale_location;
        protected decimal price;

        public Product()
        {
            name = "NoName";
            sale_location = "NoSaleLocation";
            price = 0;
        }
        public Product(string name, string sale_location, decimal price)
        {
            this.name = name;
            this.sale_location = sale_location;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "") throw new Exception("Invalid value");
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        throw new Exception("Invalid value");
                    }
                }

                name = value;
            }
        }
        public string SaleLocation
        {
            get { return sale_location; }
            set
            {
                if (value == "") throw new Exception("Invalid value");
                sale_location = value;
            }
        }
        public decimal Price
        {
            get { return price; }
            set
            {
                if (value < 0) throw new Exception("Invalid value");
                price = value;
            }
        }

        public virtual void Show()
        {
            WriteLine($"Name: {name} | Sale location: {sale_location} | Price: {price}");
        }
        public virtual void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Sale location: ");
            SaleLocation = ReadLine();

            Write("Price: ");
            if (!int.TryParse(ReadLine(), out int num))
            {
                throw new Exception("Invalid Input() value");
            }
            Price = num;
        }

        public override string ToString()
        {
            return $"{Name} {SaleLocation} {Price}";
        }
        public virtual string ToShortString()
        {
            return $"{Name} {Price}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Product)obj;
            return this.ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static decimal operator +(Product my, int value)
        {
            return my.Price + value;
        }
        public static decimal operator -(Product my,int value)
        {
            if (my.Price < value) throw new Exception("Invalid value");
            return my.Price - value;
        }
        public static bool operator >(Product my,Product other)
        {
            return my.Price > other.Price;
        }
        public static bool operator <(Product my, Product other)
        {
            return my.Price < other.Price;
        }
        public static bool operator ==(Product my,Product other)
        {
            return my.Equals(other);
        }
        public static bool operator !=(Product my, Product other)
        {
            return !(my == other);
        }
    }
}
