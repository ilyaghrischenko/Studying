using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _7
{
    public class MorseTranslator
    {
        private string _text;
        private static string[] MorseCode =
        {
            ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--",
            "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."
        };

        public MorseTranslator(string text)
        {
            Text = text;
        }

        public string Text
        {
            get { return _text; }
            set
            {
                if (value == string.Empty) throw new Exception("Text: Invalid value");
                foreach (var item in value)
                {
                    if (char.IsDigit(item)) throw new Exception("Text: Invalid value");
                }

                _text = value;
            }
        }

        public void Show()
        {
            WriteLine(ToString());
        }
        public void Input()
        {
            Write("Text: ");
            Text = ReadLine();
        }

        public override string ToString()
        {
            return $"Text: {Text}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not MorseTranslator) return false;

            var other = (MorseTranslator)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public string ToMorse()
        {

            string result = "";

            string copy = Text;
            foreach (var item in copy.ToUpper())
            {
                if (item == ' ') result += "   ";
                else
                {
                    int index = item - 'A';
                    if (index >= 0 && index < 26) result += MorseCode[index] + " ";
                }
            }

            return result.Trim();
        }
        public string ToText() => Text;
    }
}
