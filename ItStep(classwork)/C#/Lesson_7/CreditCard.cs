using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_7
{
    internal class CreditCard
    {
        private string card_number;
        private string pib;
        private int cvc;
        private string end_date;
        private float balance;

        public CreditCard()
        {
            card_number = "NoCardNumber";
            pib = "NoPib";
            cvc = 0;
            end_date = "NoEndDate";
            balance = 0f;
        }
        public CreditCard(string card_number, string pib, int cvc, string end_date, float balance)
        {
            this.card_number = card_number;
            this.pib = pib;
            this.cvc = cvc;
            this.end_date = end_date;
            this.balance = balance;
        }

        public string Card_Number
        {
            get { return card_number; }
            set
            {
                if (card_number == "") throw new Exception("Empty string error!");
                for (int i = 0; i < value.Length; ++i)
                {
                    if (!char.IsDigit(value[i])) throw new FormatException("Invalid format!");
                }

                card_number = value;
            }
        }
        public string Pib
        {
            get { return pib; }
            set
            {
                if (pib == "") throw new Exception("Empty string error!");
                if (value.Length != 3) throw new FormatException("Invalid format!");
                for (int i = 0; i < value.Length; ++i)
                {
                    if (!char.IsLetter(value[i])) throw new FormatException("Invalid format!");
                }

                pib = value;
            }
        }
        public int Cvc { get; set; }
        public string End_Date
        {
            get { return  end_date; }
            set
            {
                if (value == "") throw new Exception("Empty string error!");
                string[] tokens = value.Split('.', StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length != 3) throw new FormatException("Invalid format!");
                if (tokens[0].Length != 2 || tokens[1].Length != 2 || tokens[2].Length != 4)
                {
                    throw new FormatException("Invalid format!");
                }

                end_date = value;
            }
        }
        public float Balance { get; set; }

        public void Show()
        {
            WriteLine($"\nCard number: {card_number} || Pib: {pib} || CVC: {cvc} || EndDate: {end_date} || Balance: {balance}");
        }
        public void Input()
        {
            Write("Enter card number: ");
            card_number = ReadLine();
            if (card_number == "") throw new Exception("Empty string error!");
            for (int i = 0; i < card_number.Length; ++i)
            {
                if (!char.IsDigit(card_number[i])) throw new FormatException("Invalid format!");
            }

            Write("Enter Pib: ");
            pib = ReadLine();
            if (pib == "") throw new Exception("Empty string error!");
            if (pib.Length != 3) throw new FormatException("Invalid format!");
            for (int i = 0; i < pib.Length; ++i)
            {
                if (!char.IsLetter(pib[i])) throw new FormatException("Invalid format!");
            }

            Write("CVC: ");
            if (!int.TryParse(ReadLine(), out cvc)) throw new Exception("TryParse error!");

            Write("End date(dd.mm.yyy): ");
            end_date = ReadLine();
            if (end_date == "") throw new Exception("Empty string error!");
            string[] tokens = end_date.Split('.', StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length != 3) throw new FormatException("Invalid format!");
            if (tokens[0].Length != 2 || tokens[1].Length != 2 || tokens[2].Length != 4)
            {
                throw new FormatException("Invalid format!");
            }

            Write("Balance: ");
            if (!float.TryParse(ReadLine(), out balance)) throw new Exception("TryParse error!");
        }

        public override string ToString()
        {
            return $"Credit card: {card_number}, {pib}, {cvc}, {end_date}, {balance}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (CreditCard)obj;
            if (this.ToString() != other.ToString()) return false;
            return true;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static float operator +(CreditCard my, int value)
        {
            my.Balance += value;
            return my.Balance;
        }
        public static CreditCard operator -(CreditCard my, int value)
        {
            if (my.balance < value) throw new Exception("Invalud value to minus!");
            return new CreditCard(my.Card_Number, my.Pib, my.Cvc, my.End_Date, my.Balance - value);
        }
        public static bool operator ==(CreditCard my,CreditCard other)
        {
            return my.Cvc == other.Cvc;
        }
        public static bool operator !=(CreditCard my, CreditCard other)
        {
            return my.Cvc != other.Cvc;
        }
        public static bool operator <(CreditCard my,CreditCard other)
        {
            return my.Balance < other.Balance;
        }
        public static bool operator >(CreditCard my, CreditCard other)
        {
            return my.Balance > other.Balance;
        }
    }
}
