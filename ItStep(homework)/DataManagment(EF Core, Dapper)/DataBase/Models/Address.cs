namespace DataBase.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public uint BuildingNumber { get; set; }
        public int PostalCode { get; set; }

        public Address() { }
        public Address(string country, string city, string street, uint buildingNumber, int postalCode)
        {
            Country = country;
            City = city;
            Street = street;
            BuildingNumber = buildingNumber;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Country: {Country}, City: {City}, Street: {Street}, Building number: {BuildingNumber}, Postal code: {PostalCode}";
        }
    }
}
