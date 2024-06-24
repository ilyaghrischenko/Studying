namespace Lesson_8.Models
{
    public class Continent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Country>? Countries { get; set; }

        public Continent() { }
        public Continent(string name)
        {
            Name = name;
        }

        public override string ToString()
        => $"Id: {Id}, Name: {Name}";
    }
}
