using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _17_2_
{
    public class Article
    {
        public string Name { get; set; }
        public uint SymbolsCount { get; set; }
        public string Summary { get; set; }

        public Article()
        {
            Name = "NoName";
            SymbolsCount = 0;
            Summary = "NoSummary";
        }
        public Article(string name, uint symbolsCount, string articleSummary)
        {
            Name = name;
            SymbolsCount = symbolsCount;
            Summary = articleSummary;
        }

        public void Show()
        {
            WriteLine(this);
        }
        public void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Symbols count: ");
            SymbolsCount = uint.Parse(ReadLine());

            Write("Summary: ");
            Summary = ReadLine();
        }

        public override string ToString()
        {
            return $"Name: {Name}, Symbols count: {SymbolsCount}, Summary: {Summary}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Article)) return false;
            var other = obj as Article;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
