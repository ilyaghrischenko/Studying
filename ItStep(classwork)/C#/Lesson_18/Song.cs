using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_18
{
    [Serializable]
    public class Song
    {
        public string Name { get; set; } = "NoName";
        public float Duration { get; set; } = 0f;
        
        public Song() { }
        public Song(string name, float duration)
        {
            Name = name;
            Duration = duration;
        }

        public void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Duration: ");
            if (!float.TryParse(ReadLine(), out float value))
            {
                throw new Exception();
            }
            Duration = value;
        }
        public void Show()
        {
            WriteLine(this);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration: {Duration}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Song)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
