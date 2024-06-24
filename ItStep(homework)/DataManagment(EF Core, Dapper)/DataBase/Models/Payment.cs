namespace DataBase.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public Employee Employee { get; set; }
        public Insurance Insurance { get; set; }
        public DateTime TimePoint { get; set; }

        public Payment() { }
        public Payment(decimal amount, Employee employee, Insurance insurance, DateTime timePoint)
        {
            Amount = amount;
            Employee = employee;
            Insurance = insurance;
            TimePoint = timePoint;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Employee: {Employee.Name}, Insurance: {Insurance.Type}[{Insurance.Date}], Time point: {TimePoint}";
        }
    }
}
