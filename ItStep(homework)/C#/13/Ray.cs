using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _13
{
    public class Ray : Fish
    {
        public Ray(string name)
        {
            Name = name;
            Species = "Ray";
            Description = "A flat-bodied cartilaginous fish that lives on the sea floor, known for its immobility and captivating colors.";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Species: {Species}, Description: {Description}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Ray)) return false;
            var other = (Ray)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
