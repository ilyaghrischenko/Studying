using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _11
{
    public class Validity
    {
        public string Month { get; set; } = new DateOnly().Month.ToString();
        public string Year { get; set; } = new DateOnly().Year.ToString();

        public Validity() { }
        public Validity(string month, string year)
        {
            Month = month;
            Year = year;
        }

        public void Input()
        {
            WriteLine("Month: ");
            Month = ReadLine();

            WriteLine("Year: ");
            Year = ReadLine();
        }
        public void Show()
        {
            WriteLine(this);
        }

        public override string ToString()
        {
            return $"{Month}/{Year}";
        }
    }
}
