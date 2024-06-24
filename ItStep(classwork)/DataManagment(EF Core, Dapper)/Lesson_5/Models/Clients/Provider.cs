using Lesson_5.Models.Data;

namespace Lesson_5.Models.Client
{
    public class Provider : Client
    {
        public List<Supply>? NewProducts { get; set; }

        public override string ToString()
        {
            var result = base.ToString();
            if (NewProducts != null)
            {
                result += "\nNewProducts:\n";
                NewProducts.ForEach(x => result += x + "\n");
            }
            return result;
        }
    }
}
