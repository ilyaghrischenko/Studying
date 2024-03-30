using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_6
{
    internal class Person
    {
        private string name;
        private string surname;
        public DateOnly birth_date;
        
        public Person()
        {
            name = "NoName";
            surname = "NoSurname";
        }
        public Person(string name, string surname, DateOnly birth_date)
        {
            this.name = name;
            this.surname = surname;
            this.birth_date = birth_date;
        }

        public string GetName()
        {
            return name;
        }
        public string GetSurname()
        {
            return surname;
        }
        public DateOnly GetDate()
        {
            return birth_date;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetSurname(string surname)
        {
            this.surname = surname;
        }
        public void SetDate(DateOnly date)
        {
            this.birth_date = date;
        }

        public void input()
        {
            Write("Enter name: ");
            name = ReadLine();
            if (name == "") throw new Exception("Invalid input");

            Write("Enter surname: ");
            surname = ReadLine();
            if (surname == "") throw new Exception("Invalid input");

            WriteLine("Enter day, month, year, one by one: ");
            birth_date.
        }
    }
}
