using System.Text.RegularExpressions;
using static System.Console;

namespace Quiz
{
    public class User
    {
        private string _name = "NoName";
        private string _surName = "NoSurName";
        private string _phoneNumber = "NoPhoneNumber";
        private string _email = "NoEmail";
        private string _address = "NoAddress";

        public User() { }
        public User(string name, string surName, string phoneNumber, string email, string address)
        {
            Name = name;
            SurName = surName;
            PhoneNumber = phoneNumber;
            Email = email;
            Address = address;
        }

        public string Name
        {
            get => _name;
            set
            {
                string message = "Error: Invalid value for name";
                if (value == string.Empty) throw new ArgumentException(message);
                if (!Regex.IsMatch(value, "^[A-Za-z]+$")) throw new ArgumentException(message);
                _name = value;
            }
        }
        public string SurName
        {
            get => _surName;
            set
            {
                string message = "Error: Invalid value for name";
                if (value == string.Empty) throw new ArgumentException(message);
                if (!Regex.IsMatch(value, "^[A-Za-z]+$")) throw new ArgumentException(message);
                _surName = value;
            }
        }
        public string PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                string message = "Error: Invalid value for phone number";
                if (value == string.Empty) throw new ArgumentException(message);
                if (!Regex.IsMatch(value, @"^\+[0-9]+$")) throw new ArgumentException(message);
                _phoneNumber = value;
            }
        }
        public string Email
        {
            get => _email;
            set
            {
                string message = "Error: Invalid value for email";
                if (value == string.Empty) throw new ArgumentException(message);
                if (!Regex.IsMatch(value, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")) throw new ArgumentException(message);
                _email = value;
            }
        }
        public string Address
        {
            get => _address;
            set
            {
                if (value == string.Empty) throw new ArgumentException("Error: Invalid value for address");
                _address = value;
            }
        }

        public void Show()
        {
            WriteLine(this);
        }
        public void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Surname: ");
            SurName = ReadLine();

            Write("PhoneNumber: ");
            PhoneNumber = ReadLine();

            Write("Email: ");
            Email = ReadLine();

            Write("Address: ");
            Address = ReadLine();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Surname: {SurName}, Phone number: {PhoneNumber}, Email: {Email}, Address: {Address}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (User)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
