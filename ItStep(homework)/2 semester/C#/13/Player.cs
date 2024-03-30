using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _13
{
    public enum FootballPosition
    {
        LeftForward,
        RightForward,
        CenterForward,
        LeftDefender,
        RightDefender,
        CenterDefender,
        GoalKeeper
    }

    public class Player
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public short Number { get; set; }
        public FootballPosition Position { get; set; }

        public Player()
        {
            Name = "NoName";
            SurName = "SurName";
            Number = 0;
            Position = FootballPosition.CenterForward;
        }
        public Player(string name, string surName, short number, FootballPosition position)
        {
            Name = name;
            SurName = surName;
            Number = number;
            Position = position;
        }

        public void Show()
        {
            WriteLine(this);
        }
        public void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("SurName: ");
            SurName = ReadLine();

            Write("Number: ");
            Number = short.Parse(ReadLine());

            Write("Position: ");
            Position = (FootballPosition)Enum.Parse(typeof(FootballPosition), ReadLine());
        }

        public override string ToString()
        {
            return $"Name: {Name}, SurName: {SurName}, Number: {Number}, Position: {Position}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Player)) return false;
            var other = obj as Player;
            return other.ToString() == ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
