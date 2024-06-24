using Lesson_5.Models.Data;

namespace Lesson_5.Models.Personal
{
    public class Manager : Personal
    {
        public List<Supply>? Supplies { get; set; }
        public List<Purchase>? Purchases { get; set; }

        public Manager(string firstName, string lastName, uint age) : base(firstName, lastName, age) { }

        public override string ToString()
        {
            var result = base.ToString();
            if (Supplies != null)
            {
                result += "\nSupplies:\n";
                Supplies.ForEach(x => result += x + "\n");
            }
            if (Purchases != null)
            {
                result += "\nPurchases:\n";
                Purchases.ForEach(x => result += x + "\n");
            }
            return result;
        }
    }
}
