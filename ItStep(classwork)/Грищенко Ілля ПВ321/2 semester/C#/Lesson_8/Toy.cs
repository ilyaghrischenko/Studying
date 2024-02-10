using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_8
{
    public class Toy : Product
    {
        private int age_categoty;
        private string location;

        public Toy() : base()
        {
            age_categoty = 0;
            location = "NoLocation";
        }
        public Toy(string name, string sale_location, decimal price, int age_categoty, string location) : base(name, sale_location, price)
        {
            this.age_categoty = age_categoty;
            this.location = location;
        }

        public int AgeCategory
        {
            get { return age_categoty; }
            set
            {
                if (age_categoty < 0) throw new Exception("Invalid argument");
                age_categoty = value;
            }
        }
        public string Location
        {
            get { return location; }
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

                location = value;
            }
        }

        public override void Show()
        {
            base.Show();
            WriteLine($"Age category: {age_categoty} | Location: {location}");
        }
        public override void Input()
        {
            base.Input();

            Write("Age category: ");
            if (!int.TryParse(ReadLine(), out int num))
            {
                throw new Exception("Invalid Input() value");
            }
            AgeCategory = num;

            Write("Location: ");
            Location = ReadLine();
        }

        public override string ToString()
        {
            return base.ToString() + $"{age_categoty} {location}";
        }
        public override string ToShortString()
        {
            return base.ToShortString() + $"{age_categoty}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Toy)obj;
            return this.ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
