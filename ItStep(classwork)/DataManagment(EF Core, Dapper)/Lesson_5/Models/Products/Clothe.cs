namespace Lesson_5.Models.Product
{
    public class Clothe : Product
    {
        public string Material { get; set; }
        public string Season { get; set; }

        public Clothe(string name, string developer, decimal price, string material, string season) : base(name, developer, price)
        {
            Material = material;
            Season = season;
        }

        public override string ToString()
        {
            return base.ToString() + $", Material: {Material}, Season: {Season}";
        }
    }
}
