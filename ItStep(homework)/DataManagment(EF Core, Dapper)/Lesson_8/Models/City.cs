namespace Lesson_8.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public Country? Country { get; set; }

        public City() { }
        public City(string name, int countryId)
        {
            Name = name;
            CountryId = countryId;
        }

        public override string ToString()
        => $"Id: {Id}, Name: {Name}, CountryId: {CountryId}";
    }
}
