using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase.Models
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateOnly HireDate { get; set; }
        public string ContactInfo { get; set; }
        public Department Department { get; set; }

        public virtual List<Training>? Trainings { get; set; } = new();

        public Employee() { }
        public Employee(string name, string position, DateOnly hireDate, string contactInfo, Department department)
        {
            Name = name;
            Position = position;
            HireDate = hireDate;
            ContactInfo = contactInfo;
            Department = department;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Position: {Position}, Hire date: {HireDate}, Contact info: {ContactInfo}, Department: {Department.Name}";
        }
    }
}
