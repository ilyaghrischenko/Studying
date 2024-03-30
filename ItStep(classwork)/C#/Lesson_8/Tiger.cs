using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_8
{
    public class Tiger : Animal
    {
        private float max_speed;
        private string color;

        public Tiger() : base()
        {
            max_speed = 1.0f;
            color = "gold";
        }
        public Tiger(string name, float weight, float height, float max_speed, string color) : base(name, weight, height)
        {
            this.max_speed = max_speed;
            this.color = color;
        }

        protected override float Weight
        {
            get { return weight; }
            set
            {
                if (value < 2) throw new Exception("Invalid value");
                weight = value;
            }
        }

        public float MaxSpeed
        {
            get { return max_speed; }
            set
            {
                if (value < 1f) throw new Exception("Invalid argument");
                max_speed = value;
            }
        }
        public string Color
        {
            get { return color; }
            set
            {
                if (value == "") throw new Exception("Invalid value");
                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsLetter(value[i]))
                    {
                        throw new Exception("Invalid value");
                    }
                }

                color = value;
            }
        }

        public override void Show()
        {
            base.Show();
            WriteLine($"Max speed: {max_speed} | Color: {color}");
        }
        public override void Input()
        {
            base.Input();

            Write("Max speed: ");
            if (!float.TryParse(ReadLine(), out float num))
            {
                throw new Exception("Invalid Input() value");
            }
            MaxSpeed = num;

            Write("Color: ");
            Color = ReadLine();
        }
        public override void Sound()
        {
            base.Sound();
            WriteLine("Rar!");
        }

        public override string ToString()
        {
            return base.ToString() + $"{MaxSpeed} {Color}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Tiger)obj;
            return this.ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
