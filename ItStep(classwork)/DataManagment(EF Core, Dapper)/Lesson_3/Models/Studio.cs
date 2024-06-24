namespace Lesson_3.Models
{
    public class Studio
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly FoundingDate { get; set; }
        public virtual List<Game>? Games { get; set; }
    }
}
