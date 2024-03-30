using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _13
{
    public class FootballTeam : IEnumerable<Player>
    {
        public List<Player> Players = new();

        public FootballTeam() { }
        public FootballTeam(List<Player> players)
        {
            Players = players;
        }

        public void Show()
        {
            WriteLine("Football team:");
            Players
                   .ForEach(WriteLine);
        }

        public void AddPlayer(Player player)
        {
            if (!Players.Contains(player)) Players.Add(player);
        }

        public IEnumerator<Player> GetEnumerator()
        {
            return Players.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            List<string> list = new();

            foreach (var item in Players)
            {
                list.Add(item.ToString());
            }

            return string.Join("\n-------------------------------------------------------\n", list);
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is FootballTeam)) return false;
            var other = obj as FootballTeam;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
