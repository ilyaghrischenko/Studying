using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace _5
{
    public class InternationalPassport
    {
        private string passport_number;
        private string pib;
        private DateTime date_of_issue;
        
        public InternationalPassport()
        {
            passport_number = "0";
            pib = "0";
            date_of_issue = new DateTime();
        }
        public InternationalPassport(string passport_number, string pib, DateTime date_of_issue)
        {
            this.passport_number = passport_number;
            this.pib = pib;
            this.date_of_issue = date_of_issue;
        }
        public InternationalPassport(string passport_number, string pib, int year, int month, int day)
        {
            this.passport_number = passport_number;
            this.pib = pib;
            date_of_issue = new DateTime(year, month, day);
        }

        public string Passport_Number
        {
            get { return passport_number; }
            set
            {
                if (value == string.Empty) throw new ArgumentException("Invalid set argument!");
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsDigit(value[i]))
                    {
                        throw new ArgumentException("Invalid set argument!");
                    }
                }
                passport_number = value;
            }
        }
        public string Pib
        {
            get { return pib; }
            set
            {
                if (value == string.Empty) throw new ArgumentException("Invalid set argument!");
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("Invalid set argument!");
                    }
                }
                pib = value;
            }
        }
        public DateTime Date_Of_Issue { get; }
        
        public void Show()
        {
            WriteLine($"\nPassport number: {passport_number} || Pib: {pib} || Date of issue: {date_of_issue}");
        }
        public void Input()
        {
            Write("Passport number: ");
            passport_number = ReadLine();
            if (passport_number == string.Empty) throw new Exception("Invalid Input() input!");
            for (int i = 0; i < passport_number.Length; i++)
            {
                if (!char.IsDigit(passport_number[i]))
                {
                    throw new ArgumentException("Invalid Input() argument!");
                }
            }

            Write("Pib: ");
            pib = ReadLine();
            if (pib == string.Empty) throw new Exception("Invalid Input() input!");
            for (int i = 0; i < pib.Length; i++)
            {
                if (!char.IsLetter(pib[i]))
                {
                    throw new ArgumentException("Invalid Input() argument!");
                }
            }

            Write("Date of issue(enter year, month, day one by one):\n");
            int year = int.Parse(ReadLine());
            int month = int.Parse(ReadLine());
            int day = int.Parse(ReadLine());
            date_of_issue = new DateTime(year, month, day);
        }

        public override string ToString()
        {
            return $"{pib} {passport_number} {date_of_issue}";
        }
    }
}
