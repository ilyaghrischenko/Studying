using Lesson_5.Models.Client;
using Lesson_5.Models.Personal;

namespace Lesson_5.Models.Data
{
    public class Purchase
    {
        public int Id { get; set; }
        public Product.Product Product { get; set; }
        public Customer Customer { get; set; }
        public Consultant? Consultant { get; set; }

        public override string ToString()
        {
            var result = $"Id: {Id}, Product: {Product}";
            if (Consultant != null) result += $", Consultant: {Consultant.FirstName} {Consultant.LastName}";
            return result;
        }
    }
}
