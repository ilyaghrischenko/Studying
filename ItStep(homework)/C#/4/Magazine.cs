using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//task 5

namespace _4
{
    internal class Magazine
    {
        private string name;
        private int year;
        private string description;
        private string tel_number;
        private string email;
        private void EnterValue(out int year)
        {
            year = 0;

            bool isRight = false;
            while (!isRight)
            {
                Console.Write("Year: ");
                if (!int.TryParse(Console.ReadLine(), out year))
                {
                    Console.WriteLine("Error!! Try again");
                }
                else isRight = true;
            }
        }

        public Magazine()
        {
            name = new string("NoName");
            year = 0;
            description = new string("NoDescription");
            tel_number = new string("NoTelNumber");
            email = new string("NoEmail");
        }
        public Magazine(string name, int year, string description, string tel_number, string email)
        {
            this.name = name;
            this.year = year;
            this.description = description;
            this.tel_number = tel_number;
            this.email = email;
        }

        public string GetName()
        {
            return name;
        }
        public int GetYear()
        {
            return year;
        }
        public string GetDescription()
        {
            return description;
        }
        public string GetTelNumber()
        {
            return tel_number;
        }
        public string GetEmail()
        {
            return email;
        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetYear(int year)
        {
            this.year = year;
        }
        public void SetDescription(string description)
        {
            this.description = description;
        }
        public void SetTelNumber(string tel_number)
        {
            this.tel_number = tel_number;
        }
        public void SetEmail(string email)
        {
            this.email = email;
        }

        public void input()
        {
            Console.Write("Name: ");
            name = Console.ReadLine();

            EnterValue(out year);

            Console.Write("Description: ");
            description = Console.ReadLine();

            Console.Write("Phone Number: ");
            tel_number = Console.ReadLine();

            Console.Write("Email: ");
            email = Console.ReadLine();
        }
        public void show()
        {
            Console.WriteLine($"\nName: {name} || Year: {year} || Description: {description} || Phone number: {tel_number} || Email: {email}\n");
        }
    }
}
