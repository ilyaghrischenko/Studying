using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Console;

namespace HW_14
{
    public enum ShopType
    {
        Food,
        Economic,
        Clothes,
        Footwear
    }

    public class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public ShopType Type { get; private set; } = ShopType.Food;

        public Shop()
        {
            Name = "NoName";
            Address = "NoAddress";
        }
        public Shop(string name, string address, ShopType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }
        ~Shop()
        {
            Dispose();
        }

        public void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Address: ");
            Address = ReadLine();

            Write("Type: ");
            Type = (ShopType)Enum.Parse(typeof(ShopType), ReadLine());
        }
        public void Show()
        {
            WriteLine(this);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            WriteLine("Object deleted");
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}, Type: {Type}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Shop)) return false;
            var other = (Shop)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
