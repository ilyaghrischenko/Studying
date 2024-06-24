namespace DB.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        => $"Name: {Name}";
    }
}
