using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_8
{
    public class Animal
    {
        protected string name;
        protected float weight;
        protected float height;

        public Animal()
        {
            name = "NoName";
            weight = 1.0f;
            height = 1.0f;
        }
        public Animal(string name, float weight, float height)
        {
            this.name = name;
            this.weight = weight;
            this.height = height;
        }

        protected string Name
        {
            get { return name; }
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

                name = value;
            }
        }
        protected virtual float Weight
        {
            get { return weight; }
            set
            {
                if (value < 1) throw new Exception("Invalid value");
                weight = value;
            }
        }
        protected float Height
        {
            get { return height; }
            set
            {
                if (value < 1) throw new Exception("Invalid value");
                height = value;
            }
        }

        public virtual void Show()
        {
            WriteLine($"Name: {name} | Weight: {weight} | Height: {height}");
        }
        public virtual void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Weight: ");
            if (!float.TryParse(ReadLine(), out float num))
            {
                throw new Exception("Invalid Input() argument");
            }
            Weight = num;

            Write("Height: ");
            if (!float.TryParse(ReadLine(), out float num1))
            {
                throw new Exception("Invalid Input() argument");
            }
            Height = num;
        }
        public virtual void Sound()
        {
            WriteLine("");
        }

        public override string ToString()
        {
            return $"{Name} {Weight} {Height}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Animal)obj;
            return this.ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
