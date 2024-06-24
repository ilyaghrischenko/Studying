namespace Lesson_3.Models
{
    public enum GameMode
    {
        SingleUser,
        MultiUser
    }

    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Studio Studio { get; set; }
        public Genre Genre { get; set; }
        public DateOnly ReleaseDate { get; set; }

        public GameMode? Mode { get; set; }
        public uint CountSold { get; set; }

        public override string ToString()
        {
            string result = $"Id: {Id}, Name: {Name}, Studio: {Studio.Name}, Genre: {Genre.Name}, " +
                $"Release date: {ReleaseDate}, Count sold: {CountSold}";
            return Mode != null ? result + $", Mode{Mode}" : result;
        }
    }
}
