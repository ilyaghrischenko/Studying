namespace DataBase.Models
{
    public class Insurance
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public DateOnly Date { get; set; }

        public virtual List<Payment> Payments { get; set; } = new();

        public Insurance() { }
        public Insurance(string type, DateOnly date)
        {
            Type = type;
            Date = date;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Type: {Type}, Date: {Date}";
        }
    }
}
