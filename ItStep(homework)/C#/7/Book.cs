using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7
{
    public class Book
    {
        private string _name;
        private string _description;
        private string _author;
        private int _year;

        public Book()
        {
            _name = "NoName";
            _description = "NoDescription";
            _author = "NoAuthor";
            _year = 0;
        }
        public Book(string name, string description, string author, int year)
        {
            Name = name;
            Description = description;
            Author = author;
            Year = year;
        }

        public string Name
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
        public string Description
        {
            get { return _description; }
            set
            {
                if (value == string.Empty) throw new Exception("Description: Invalid value");
                _description = value;
            }
        }
        public string Author
        {
            get { return _author; }
            set
            {
                if (value == string.Empty) throw new Exception("Author: Invalid value");
                foreach (var item in value)
                {
                    if (!char.IsLetter(item)) throw new Exception("Author: Invalid value");
                }
                _author = value;
            }
        }
        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1000 || value > 2024) throw new Exception("Year: Invalid value");
                _year = value;
            }
        }

        public void Show()
        {
            WriteLine($"Name: {Name} || Description: {Description} || Author: {Author} || Year: {Year}");
        }
        public void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Description: ");
            Description = ReadLine();

            Write("Author: ");
            Author = ReadLine();

            Write("Year: ");
            Year = int.Parse(ReadLine());
        }

        public override string ToString()
        {
            return $"Name: {Name} || Description: {Description} || Author: {Author} || Year: {Year}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (GetType() != obj.GetType()) return false;

            var other = (Book)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
