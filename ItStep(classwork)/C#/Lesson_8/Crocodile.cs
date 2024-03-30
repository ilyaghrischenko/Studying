using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_8
{
    public class Crocodile : Animal
    {
        private int age;
        private int skin_thickness;

        public Crocodile() : base()
        {
            age = 1;
            skin_thickness = 1;
        }
        public Crocodile(string name, float weight, float height, int age, int skin_thickness) : base(name, weight, height)
        {
            this.age = age;
            this.skin_thickness = skin_thickness;
        }

        protected override float Weight
        {
            get { return weight; }
            set
            {
                if (value < 3) throw new Exception("Invalid value");
                weight = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 1) throw new Exception("Invalid value");
                age = value;
            }
        }
        public int SkinThickness
        {
            get { return skin_thickness; }
            set
            {
                if (value < 1) throw new Exception("Invalid value");
                skin_thickness = value;
            }
        }

        public override void Show()
        {
            base.Show();
            WriteLine($"Age: {age} | Skin thickness: {skin_thickness}");
        }
        public override void Input()
        {
            base.Input();

            Write("Age: ");
            if (!int.TryParse(ReadLine(), out int num))
            {
                throw new Exception("Invalid Input() value");
            }
            Age = num;

            Write("Skin thickness: ");
            if (!int.TryParse(ReadLine(), out int num1))
            {
                throw new Exception("Invalid Input() value");
            }
            skin_thickness = num1;
        }
        public override void Sound()
        {
            base.Sound();
            WriteLine("сrocodile");
        }

        public override string ToString()
        {
            return base.ToString() + $"{Age} {SkinThickness}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Crocodile)obj;
            return this.ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
