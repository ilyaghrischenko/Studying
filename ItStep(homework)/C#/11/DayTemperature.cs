using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    public record DayTemperature(int highest, int lowest)
    {
        public int Highest { get; set; } = highest;
        public int Lowest { get; set; } = lowest;

        public override string ToString()
        {
            return $"Highest: {Highest} || Lowest: {Lowest}";
        }
    }
}
