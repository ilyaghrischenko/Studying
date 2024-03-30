using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    public class Fish
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Species: {Species}, Description: {Description}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Fish)) return false;
            var other = (Fish)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
