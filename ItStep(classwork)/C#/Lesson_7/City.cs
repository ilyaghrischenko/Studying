using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_7
{
    internal class City
    {
        private string name;
        private string country;
        private int kilk_inhabitants;
        private string tel_code;
        private string name_areas;

        public City()
        {
            name = "NoName";
            country = "NoCountry";
            kilk_inhabitants = 0;
            tel_code = "NoTelCode";
            name_areas = "NoNameAreas";
        }
        public City(string name, string country, int kilk_inhabitants, string tel_code, string name_areas)
        {
            this.name = name;
            this.country = country;
            this.kilk_inhabitants = kilk_inhabitants;
            this.tel_code = tel_code;
            this.name_areas = name_areas;
        }

        public string Name { get; set; }
        public string Country { get; set; } 
        public int Kilk_Inhabitants { get; set; }
        public string Tel_Code { get; set; }
        public string Name_Areas { get; set; }

        public void Show()
        {
            Console.WriteLine($"Name: {name} || Country: {country} || Kilk inhabitants: {kilk_inhabitants} || Tel code: {tel_code} || Name areas: {name_areas}");
        }
        public void Input()
        {
            Console.Write("Enter name: ");
            name = Console.ReadLine();

            Console.Write("Enter country: ");
            country = Console.ReadLine();

            Console.Write("Enter kilk inhabitants: ");
            if (!int.TryParse(Console.ReadLine(), out kilk_inhabitants))
            {
                Console.WriteLine("Error!");
                return;
            }

            Console.Write("Enter tel code: ");
            tel_code = Console.ReadLine();

            Console.Write("Enter name areas: ");
            name_areas = Console.ReadLine();
        }

        public override string ToString()
        {
            return $"City:{Name}, {Country}, {Kilk_Inhabitants}, {Tel_Code}, {Name_Areas}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (City)obj;
            if (this.ToString() != other.ToString()) return false;
            return true;
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public static City operator +(City my, int value)
        {
            return new City(my.Name, my.Country, my.Kilk_Inhabitants + value, my.Tel_Code, my.Name_Areas);
        }
        public static bool operator ==(City my, City other)
        {
            return my.Equals(other);
        }
        public static bool operator !=(City my, City other)
        {
            return !my.Equals(other);
        }
        public static bool operator <(City my, City other)
        {
            return my.kilk_inhabitants < other.kilk_inhabitants;
        }
        public static bool operator >(City my, City other)
        {
            return my.kilk_inhabitants > other.kilk_inhabitants;
        }
    }
}
