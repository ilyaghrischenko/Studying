using System.Security.Cryptography;
using static System.Console;

namespace Lesson_15
{
    public class Worker
    {
        public string Pib { get; set; } = "NoPib";
        public string Position { get; set; } = "NoPosition";
        public string PhoneNumber { get; set; } = "NoPhoneNumber";
        public string Email { get; set; } = "NoEmail";
        public decimal Salary { get; set; } = 0;

        public Worker() { }
        public Worker(string pib, string position, string phoneNumber, string email, decimal salary)
        {
            Pib = pib;
            Position = position;
            PhoneNumber = phoneNumber;
            Email = email;
            Salary = salary;
        }

        public void Show()
        {
            WriteLine(this);
        }
        public void Input()
        {
            Write("Pib: ");
            Pib = ReadLine();

            Write("Position: ");
            Position = ReadLine();

            Write("Phone number: ");
            PhoneNumber = ReadLine();

            Write("Email: ");
            Email = ReadLine();

            Write("Salary: ");
            Salary = decimal.Parse(ReadLine());
        }

        public override string ToString()
        {
            return $"Pib: {Pib}, Position: {Position}, Phone number: {PhoneNumber}, Email: {Email}, Salary: {Salary}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Worker)) return false;
            var other = obj as Worker;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}