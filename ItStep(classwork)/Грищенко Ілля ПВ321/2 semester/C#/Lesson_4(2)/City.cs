using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4_2_
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
        
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetCountry()
        {
            return country;
        }
        public void SetCountry(string country)
        {
            this.country = country;
        }

        public int GetKilkInhabitants()
        {
            return kilk_inhabitants;
        }
        public void SetKilkInhabitants(int kilk_inhabitants)
        {
            this.kilk_inhabitants = kilk_inhabitants;
        }

        public string GetTelCode()
        {
            return tel_code;
        }
        public void SetTelCode(string tel_code)
        {
            this.tel_code = tel_code;
        }

        public string GetNameAres()
        {
            return name_areas;
        }
        public void SetNameAreas(string name_areas)
        {
            this.name_areas = name_areas;
        }

        public void show()
        {
            Console.WriteLine($"Name: {name} || Country: {country} || Kilk inhabitants: {kilk_inhabitants} || Tel code: {tel_code} || Name areas: {name_areas}");
        }
        public void input()
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
    }
}
