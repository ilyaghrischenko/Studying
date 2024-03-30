using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _13
{
    public class Oceanarium : IEnumerable<Fish>
    {
        public List<Fish> Inhabitants { get; set; }

        public Oceanarium()
        {
            Inhabitants = new();
        }
        public Oceanarium(List<Fish> inhabitants)
        {
            if (inhabitants == null) throw new Exception("Invalid list");
            Inhabitants = inhabitants;
        }

        public void Show()
        {
            WriteLine("Inhabitants:");
            Inhabitants
                      .ForEach(WriteLine);
        }

        public void AddFish(Fish fish)
        {
            if (!Inhabitants.Contains(fish)) Inhabitants.Add(fish);
        }

        public IEnumerator<Fish> GetEnumerator()
        {
            return Inhabitants.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            List<string> list = new();

            foreach (var item in Inhabitants)
            {
                list.Add(item.ToString());
            }

            return string.Join("\n-------------------------------------------------------\n", list);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Oceanarium)) return false;
            var other = obj as Oceanarium;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
