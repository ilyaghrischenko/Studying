using static System.Console;

namespace Server
{
    public enum ComponentType
    {
        CPU,
        GPU,
        RAM,
        HDD,
        SSD
    }

    public class PCComponent
    {
        public ComponentType Type { get; set; } = ComponentType.CPU;
        public string Name { get; set; } = "NoName";
        public string Developer { get; set; } = "NoDeveloper";
        public decimal Price { get; set; } = 0;

        public PCComponent() { }
        public PCComponent(ComponentType type, string name, string developer, decimal price)
        {
            Type = type;
            Name = name;
            Developer = developer;
            Price = price;
        }

        public void Show()
        {
            WriteLine(this);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Developer: {Developer}, Type: {Type}, Price: {Price}";
        }
    }
}
