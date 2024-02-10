using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    public class Item
    {
        public string Name {  get; set; } = "NoName";
        public double Weight { get; set; }
        public int Volume { get; set; }

        public override string ToString()
        {
            return $"Name Weight: {Weight} Volume: {Volume}";
        }
    }
}
