using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _8
{
    public class Vaporizer : Device
    {
        private int _maxSpeed;
        private int _passengerCapacity;

        public Vaporizer(string name, string description, int maxSpeed, int passengerCapacity) : base(name, description)
        {
            MaxSpeed = maxSpeed;
            PassengerCapacity = passengerCapacity;
        }

        public int MaxSpeed
        {
            get { return _maxSpeed; }
            set
            {
                if (value < 0) throw new Exception("MaxSpeed: Invalid value");
                _maxSpeed = value;
            }
        }
        public int PassengerCapacity
        {
            get { return _passengerCapacity; }
            set
            {
                if (value < 0) throw new Exception("Passenger capacity: Invalid value");
                _passengerCapacity = value;
            }
        }

        public override void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Description: ");
            Description = ReadLine();

            Write("Max speed: ");
            MaxSpeed = int.Parse(ReadLine());

            Write("Passenger capacity: ");
            PassengerCapacity = int.Parse(ReadLine());
        }
        public override void Show()
        {
            WriteLine($"Name: {Name} || Description: {Description} || Max speed: {MaxSpeed} || Passenger capacity: {PassengerCapacity}");
        }
        public override void Sound()
        {
            WriteLine("PPPrrr!");
        }

        public override string ToString()
        {
            return base.ToString() + $"|| Max speed: {MaxSpeed} || Passenger capacity: {PassengerCapacity}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Vaporizer)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
