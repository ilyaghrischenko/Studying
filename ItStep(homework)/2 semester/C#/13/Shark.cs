using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _13
{
    public class Shark : Fish
    {
        public Shark(string name)
        {
            Name = name;
            Species = "Shark";
            Description = "A carnivorous cartilaginous fish, known for its keen sense of smell and immense strength.";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Species: {Species}, Description: {Description}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Shark)) return false;
            var other = (Shark)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
