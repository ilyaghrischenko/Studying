using Lesson_5.Models.Data;

namespace Lesson_5.Models.Client
{
    public class Customer : Client
    {
        public List<Purchase>? Basket { get; set; }

        public override string ToString()
        {
            var result = base.ToString();
            if (Basket != null)
            {
                result += "\nBasket:\n";
                Basket.ForEach(x => result += x + "\n");
            }
            return result;
        }
    }
}
