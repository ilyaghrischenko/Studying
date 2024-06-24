namespace DataBase.Models
{
    public class BusinessTrip
    {
        public int Id { get; set; }
        public string Target { get; set; }
        public uint DurationInDays { get; set; }
        public string Location { get; set; }
        public decimal Expense { get; set; }

        public BusinessTrip() { }
        public BusinessTrip(string target, uint durationInDays, string location, decimal expense)
        {
            Target = target;
            DurationInDays = durationInDays;
            Location = location;
            Expense = expense;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Target: {Target}, Duration in days: {DurationInDays}, Location: {Location}, Expense: {Expense}";
        }
    }
}
