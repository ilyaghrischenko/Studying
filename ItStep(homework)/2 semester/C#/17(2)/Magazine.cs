using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _17_2_
{
    public class Magazine
    {
        public string Name { get; set; }
        public string Publication { get; set; }
        public DateOnly PublicationDate { get; set; }
        public uint PageCount { get; set; }
        public List<Article> Articles { get; set; }

        public Magazine()
        {
            Name = "NoName";
            Publication = "NoPublication";
            PublicationDate = new DateOnly();
            PageCount = 0;
            Articles = new();
        }
        public Magazine(string name, string publication, DateOnly publicationDate, uint pageCount)
        {
            Name = name;
            Publication = publication;
            PublicationDate = publicationDate;
            PageCount = pageCount;
            Articles = new();
        }
        public Magazine(string name, string publication, DateOnly publicationDate, uint pageCount, List<Article> articles)
        {
            Name = name;
            Publication = publication;
            PublicationDate = publicationDate;
            PageCount = pageCount;
            Articles = articles;
        }

        public void Show()
        {
            WriteLine(this);
        }
        public void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Publication: ");
            Publication = ReadLine();

            Write("Publication date: ");
            PublicationDate = DateOnly.Parse(ReadLine());

            Write("Page count: ");
            PageCount = uint.Parse(ReadLine());

            Write("Articles count: ");
            int count = int.Parse(ReadLine());
            for (int i = 0; i < count; i++)
            {
                WriteLine($"{i + 1})");
                Articles.Add(new Article());
                Articles[i].Input();
            }
        }

        public override string ToString()
        {
            string result = $"Name: {Name}, Publication: {Publication}, Publication date: {PublicationDate}, Page count: {PageCount}\nArticles:\n";
            foreach (var item in Articles)
            {
                result += $"{item.ToString()}\n";
            }
            return result;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Magazine)) return false;
            var other = (Magazine)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
