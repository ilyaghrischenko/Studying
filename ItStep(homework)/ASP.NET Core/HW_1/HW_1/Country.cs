namespace HW_1;

public class Country
{
    public string Name { get; set; }
    public string Continent { get; set; }
    public string Region { get; set; }
    public uint Population { get; set; }

    public Country() {}
    public Country(string name, string continent, string region, uint population)
    {
        Name = name;
        Continent = continent;
        Region = region;
        Population = population;
    }

    public override string ToString()
        => $"Name: {Name}, Continent: {Continent}, Region: {Region}, Population: {Population}";
}