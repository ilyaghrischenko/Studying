using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    public struct BirthDate
    {
        private int day;
        private int month;
        private int year;

        public BirthDate(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }


    }
}
