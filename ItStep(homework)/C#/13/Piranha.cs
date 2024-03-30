using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _13
{
    public class Piranha : Fish
    {
        public Piranha(string name)
        {
            Name = name;
            Species = "Piranha";
            Description = "A carnivorous freshwater fish, known for its sharp teeth and aggressive behavior.";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Species: {Species}, Description: {Description}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Piranha)) return false;
            var other = (Piranha)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
