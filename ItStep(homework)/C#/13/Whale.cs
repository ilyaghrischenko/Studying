using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    public class Whale : Fish
    {
        public Whale(string name)
        {
            Name = name;
            Species = "Whale";
            Description = "A large aquatic mammal that feeds on plankton and small marine creatures.";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Species: {Species}, Description: {Description}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Whale)) return false;
            var other = (Whale)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
