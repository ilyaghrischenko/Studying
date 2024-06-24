using Lesson_5.Models.Client;
using Lesson_5.Models.Personal;

namespace Lesson_5.Models.Data
{
    public class Supply
    {
        public int Id { get; set; }
        public Provider Provider { get; set; }
        public Product.Product Product { get; set; }
        public Manager Manager { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Provider: {Provider.Name}, Product: {Product}, Manager: {Manager.FirstName} {Manager.LastName}";
        }
    }
}
