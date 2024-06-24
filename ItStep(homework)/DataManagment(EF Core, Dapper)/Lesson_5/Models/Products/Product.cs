using static System.Console;

namespace Lesson_5.Models.Product
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Developer { get; set; }
        public decimal Price { get; set; }

        public Product(string name, string developer, decimal price)
        {
            Name = name;
            Developer = developer;
            Price = price;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Developer: {Developer}, Price: {Price}";
        }
    }
}
