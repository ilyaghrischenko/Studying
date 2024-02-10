using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7
{
    public class Magazine
    {
        private string _name;
        private int _year;
        private string _description;
        private string _phone;
        private string _email;
        private int _kilk_employees;

        public Magazine()
        {
            _name = "NoName";
            _year = 0;
            _description = "NoDescription";
            _phone = "NoPhone";
            _email = "NoEmail";
            _kilk_employees = 0;
        }
        public Magazine(string name, int year, string description, string phone, string email, int kilk_employees)
        {
            _name = name;
            _year = year;
            _description = description;
            _phone = phone;
            _email = email;
            _kilk_employees = kilk_employees;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == string.Empty) throw new Exception("Name: Invalid value to set");
                foreach(var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception("Name: Invalid value to set");
                }

                _name = value;
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 0) throw new Exception("Year: Invalid value to set");
                _year = value;
            }
        }
        public string Description
        {
            get { return _description; }
            set
            {
                if (value == string.Empty) throw new Exception("Description: Invalid value to set");
                foreach (var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception("Description: Invalid value to set");
                }

                _description = value;
            }
        }
        public string Phone
        {
            get { return _phone; }
            set
            {
                if (value == string.Empty) throw new Exception("Phone: Invalid value to set");
                foreach (var item in value)
                {
                    if (!char.IsDigit(item)) throw new Exception("Phone: Invalid value to set");
                }

                _phone = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (value == string.Empty) throw new Exception("Phone: Invalid value to set");
                _email = value;
            }
        }
        public int KilkEmployees
        {
            get { return _kilk_employees; }
            set
            {
                if (value < 0) throw new Exception("KilkEmployees: Invalid value to set");
                _kilk_employees = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} Year: {Year} Description: {Description} Phone: {Phone} Email: {Email} KilkEmployees: {KilkEmployees}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Magazine)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public void Show()
        {
            WriteLine(ToString());
        }
        public void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Year: ");
            Year = int.Parse(ReadLine());

            Write("Description: ");
            Description = ReadLine();

            Write("Phone: ");
            Phone = ReadLine();

            Write("Email: ");
            Email = ReadLine();

            Write("Kilk employees: ");
            KilkEmployees = int.Parse(ReadLine());
        }

        static public Magazine operator +(Magazine mag, int value)
        {
            return new Magazine(mag.Name, mag.Year, mag.Description, mag.Phone, mag.Email, mag.KilkEmployees + value);
        }
        static public Magazine operator -(Magazine mag, int value)
        {
            return new Magazine(mag.Name, mag.Year, mag.Description, mag.Phone, mag.Email, mag.KilkEmployees - value);
        }
        static public bool operator ==(Magazine left, Magazine right)
        {
            return left.KilkEmployees == right.KilkEmployees;
        }
        static public bool operator !=(Magazine left, Magazine right)
        {
            return left.KilkEmployees != right.KilkEmployees;
        }
        static public bool operator >(Magazine left, Magazine right)
        {
            return left.KilkEmployees > right.KilkEmployees;
        }
        static public bool operator <(Magazine left, Magazine right)
        {
            return left.KilkEmployees < right.KilkEmployees;
        }
    }
}
