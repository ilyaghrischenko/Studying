using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    public class Dolphin : Fish
    {
        public Dolphin(string name)
        {
            Name = name;
            Species = "Dolphin";
            Description = "An intelligent, social, and graceful marine mammal, known for its agility and communication.";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Species: {Species}, Description: {Description}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Dolphin)) return false;
            var other = (Dolphin)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
