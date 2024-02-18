using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _11
{
    public class CreditCard
    {
        private string _cardNumber;
        private string _pib;
        public Validity CardValidity { get; set; } = new Validity();
        private string _pin;
        private decimal _creditLimit;
        public decimal Amount { get; set; } = 0;

        public CreditCard()
        {
            _cardNumber = "NoCardNumber";
            _pib = "NoPib";
            _pin = "NoPin";
            _creditLimit = 0;
        }
        public CreditCard(string cardNumber, string pib, Validity cardValidity, string pin, decimal creditLimit, decimal amount)
        {
            CardNumber = cardNumber;
            Pib = pib;
            CardValidity = cardValidity;
            Pin = pin;
            CreditLimit = creditLimit;
            Amount = amount;
        }

        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                if (value == string.Empty) throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsDigit(item)) throw new Exception();
                }
                _cardNumber = value;
            }
        }
        public string Pib
        {
            get { return _pib; }
            set
            {
                if (value == string.Empty) throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsLetter(item) && !char.IsPunctuation(item)) throw new Exception();
                }
                _pib = value;
            }
        }
        public string Pin
        {
            get { return _pin; }
            set
            {
                if (value == string.Empty) throw new Exception();
                foreach (var item in value)
                {
                    if (!char.IsDigit(item)) throw new Exception();
                }
                _pin = value;
            }
        }
        public decimal CreditLimit
        {
            get { return _creditLimit; }
            set
            {
                if (value < 0) throw new Exception();
                _creditLimit = value;
            }
        }

        public void Input()
        {
            Write("Card number: ");
            CardNumber = ReadLine();

            Write("Pib: ");
            Pib = ReadLine();

            WriteLine("Card validity:");
            CardValidity.Input();

            PinChange?.Invoke(this, null);

            Write("Credit limit: ");
            CreditLimit = decimal.Parse(ReadLine());

            Write("Amount: ");
            Amount = decimal.Parse(ReadLine());
        }
        public void Show()
        {
            WriteLine(this);
        }

        public delegate void MyEventHandler(object? sender, decimal money);

        public event MyEventHandler AccountReplenishment;
        public event MyEventHandler AccountCharge;
        public event EventHandler UsingCreditFunds;
        public event EventHandler ReachingLimitAmount;
        public event EventHandler PinChange;
        public void AddMoney(decimal money)
        {
            if (money == 0 || money < 0) throw new Exception();
            AccountReplenishment?.Invoke(this, money);
        }
        public void TakeMoney(decimal money)
        {
            if (money == 0 || money < 0) throw new Exception();
            if (Amount - money < 0) UsingCreditFunds?.Invoke(this, null);
            if (Amount - money <= 0) ReachingLimitAmount?.Invoke(this, null);
            AccountCharge?.Invoke(this, money);
        }

        public override string ToString()
        {
            return $"Card number: {CardNumber} || Pib: {Pib} || Card validity: {CardValidity} || Pin: {Pin} || Credit limit: {CreditLimit} || Amount: {Amount}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not CreditCard) return false;

            var other = obj as CreditCard;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
