namespace DataBase.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string ContactInfo { get; set; }

        public Branch() { }
        public Branch(string name, string countryName, string cityName, string contactInfo)
        {
            Name = name;
            CountryName = countryName;
            CityName = cityName;
            ContactInfo = contactInfo;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Country name: {CountryName}, City name: {CityName}, Contact info: {ContactInfo}";
        }
    }
}
