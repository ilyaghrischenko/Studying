using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_12
{
    public class Employee
    {
        private string _pib;
        private string _position;
        private double _salary;
        private string _email;

        public Employee()
        {
            Pib = "NoPib";
            Position = "NoPosition";
            Salary = 0;
            Email = "NoEmail";
        }
        public Employee(string pib, string position, double salary, string email)
        {
            Pib = pib;
            Position = position;
            Salary = salary;
            Email = email;
        }

        public string Pib
        {
            get { return _pib; }
            set
            {
                if (value == string.Empty) throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception();
                }

                _pib = value;
            }
        }
        public string Position
        {
            get { return _position; }
            set
            {
                if (value == string.Empty) throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception();
                }

                _position = value;
            }
        }
        public double Salary
        {
            get { return _salary; }
            set
            {
                if (value < 0) throw new Exception();
                _salary = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (value == string.Empty) throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception();
                }

                _email = value;
            }
        }

        public void Show()
        {
            WriteLine(ToString());
        }
        public void Input()
        {
            Write("Pib: ");
            Pib = ReadLine();

            Write("Position: ");
            Position = ReadLine();

            Write("Salary: ");
            Salary = double.Parse(ReadLine() ?? "1");

            Write("Email: ");
            Email = ReadLine();
        }

        public override string ToString()
        {
            return $"Pib: {Pib} || Position: {Position} || Salary: {Salary} || Email: {Email}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Employee)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
