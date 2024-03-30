using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_5
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

        public string GetCardNumber()
        {
            return card_number;
        }
        public string GetPib()
        {
            return pib;
        }
        private int GetCvc()
        {
            return cvc;
        }
        public string GetEndDate()
        {
            return end_date;
        }
        public float GetBalance()
        {
            return balance;
        }

        public void SetCardNumber(string card_number)
        {
            if (card_number == "") throw new Exception("Empty string error!");
            for (int i = 0; i < card_number.Length; ++i)
            {
                if (!char.IsDigit(card_number[i])) throw new FormatException("Invalid format!");
            }

            this.card_number = card_number;
        }
        public void SetPib(string pib)
        {
            if (pib == "") throw new Exception("Empty string error!");
            if (pib.Length != 3) throw new FormatException("Invalid format!");
            for (int i = 0; i < pib.Length; ++i)
            {
                if (!char.IsLetter(pib[i])) throw new FormatException("Invalid format!");
            }

            this.pib = pib;
        }
        private void SetCvc(int cvc)
        {
            if (!int.TryParse(ReadLine(), out cvc)) throw new Exception("TryParse error!");

            this.cvc = cvc;
        }
        public void SetEndDate(string endDate)
        {
            if (end_date == "") throw new Exception("Empty string error!");
            string[] tokens = end_date.Split('.', StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length != 3) throw new FormatException("Invalid format!");
            if (tokens[0].Length != 2 || tokens[1].Length != 2 || tokens[2].Length != 4)
            {
                throw new FormatException("Invalid format!");
            }

            this.end_date = endDate;
        }
        public void SetBalance(float balance)
        {
            if (!float.TryParse(ReadLine(), out balance)) throw new Exception("TryParse error!");

            this.balance = balance;
        }

        public void show()
        {
            WriteLine($"\nCard number: {card_number} || Pib: {pib} || CVC: {cvc} || EndDate: {end_date} || Balance: {balance}");
        }
        public void input()
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
    }
}
