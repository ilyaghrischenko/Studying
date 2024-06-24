namespace DataBase.Models
{
    public class Manager : Employee
    {
        public BusinessTrip BusinessTrip { get; set; }

        public Manager() { }
        public Manager(string name, string position, DateOnly hireDate, string contactInfo, Department department, BusinessTrip businessTrip, Training? training = null)
            : base(name, position, hireDate, contactInfo, department)
        {
            BusinessTrip = businessTrip;
        }

        public override string ToString()
        {
            return base.ToString() + $", Business trip: {BusinessTrip.Location}";
        }
    }
}
