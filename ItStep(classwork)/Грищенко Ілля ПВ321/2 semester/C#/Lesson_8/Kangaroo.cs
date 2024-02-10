using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lesson_8
{
    public class Kangaroo : Animal
    {
        private int arm_span;
        private int jump_height;

        public Kangaroo() : base()
        {
            arm_span = 1;
            jump_height = 1;
        }
        public Kangaroo(string name, float weight, float height, int arm_span, int jump_height) : base(name, weight, height)
        {
            this.arm_span = arm_span;
            this.jump_height = jump_height;
        }

        protected override float Weight
        {
            get { return weight; }
            set
            {
                if (value < 4) throw new Exception("Invalid value");
                weight = value;
            }
        }

        public int ArmSpan
        {
            get { return arm_span; }
            set
            {
                if (value < 1) throw new Exception("Invalid value");
                arm_span = value;
            }
        }
        public int JumpHeight
        {
            get { return jump_height; }
            set
            {
                if (value < 1) throw new Exception("Invalid value");
                jump_height = value;
            }
        }

        public override void Show()
        {
            base.Show();
            WriteLine($"Arm span: {arm_span} | Jump height: {jump_height}");
        }
        public override void Input()
        {
            base.Input();

            Write("Arm span: ");
            if (!int.TryParse(ReadLine(), out int num))
            {
                throw new Exception("Invalid Input() value");
            }
            ArmSpan = num;

            Write("Jump height: ");
            if (!int.TryParse(ReadLine(), out int num1))
            {
                throw new Exception("Invalid Input() value");
            }
            JumpHeight = num;
        }
        public override void Sound()
        {
            base.Sound();
            WriteLine("kangaroo");
        }

        public override string ToString()
        {
            return base.ToString() + $"{ArmSpan} {JumpHeight}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (Kangaroo)obj;
            return this.ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }
}
