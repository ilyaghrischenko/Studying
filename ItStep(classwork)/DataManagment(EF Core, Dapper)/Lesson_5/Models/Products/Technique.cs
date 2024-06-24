namespace Lesson_5.Models.Product
{
    public class Technique : Product
    {
        public int Warranty { get; set; }

        public Technique(string name, string developer, decimal price, int warranty) : base(name, developer, price)
        {
            Warranty = warranty;
        }

        public override string ToString()
        {
            return base.ToString() + $", Warranty: {Warranty}";
        }
    }
}
