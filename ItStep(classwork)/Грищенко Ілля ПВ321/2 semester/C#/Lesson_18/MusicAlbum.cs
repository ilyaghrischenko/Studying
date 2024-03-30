using System.Diagnostics.Contracts;
using static System.Console;

namespace Lesson_18
{
    [Serializable]
    public class MusicAlbum
    {
        public string Name { get; set; } = "NoName";
        public string AuthorName { get; set; } = "NoAuthorName";
        public DateOnly IssueDate { get; set; } = new DateOnly();
        public float Duration { get; set; } = 0f;
        public string Studio { get; set; } = "NoStudio";
        public List<Song> Songs { get; set; } = new();

        public MusicAlbum() { }
        public MusicAlbum(string name, string authorName, DateOnly issueDate, float duration, string studio, List<Song> songs)
        {
            Name = name;
            AuthorName = authorName;
            IssueDate = issueDate;
            Duration = duration;
            Studio = studio;
            Songs = songs;
        }
        public MusicAlbum(string name, string authorName, DateOnly issueDate, float duration, string studio)
        {
            Name = name;
            AuthorName = authorName;
            IssueDate = issueDate;
            Duration = duration;
            Studio = studio;
        }

        public void Input()
        {
            Write("Name: ");
            Name = ReadLine();

            Write("Author name: ");
            AuthorName = ReadLine();

            Write("Issue date: ");
            IssueDate = DateOnly.Parse(ReadLine());

            Write("Duration: ");
            Duration = float.Parse(ReadLine());

            Write("Studio: ");
            Studio = ReadLine();

            Write("Songs count: ");
            int size = int.Parse(ReadLine());

            Songs.Clear();
            WriteLine();
            for (int i = 0; i < size; ++i)
            {
                WriteLine($"{i + 1}:");
                Song song = new();
                song.Input();
                WriteLine("\n");
                Songs.Add(song);
            }
        }
        public void Show()
        {
            WriteLine(this);
        }

        public override string ToString()
        {
            string songs = "";
            foreach (var item in Songs)
            {
                songs += item + "\n";
            }
            return $"Name: {Name}, Author name: {Name}, Issue date: {IssueDate}, Duration: {Duration}, Studio: {Studio}\nSongs:\n{songs}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != GetType()) return false;

            var other = (MusicAlbum)obj;
            return ToString() == other.ToString();
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
