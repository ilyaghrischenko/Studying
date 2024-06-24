namespace DataBase.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Branch Branch { get; set; }
        public Address Address { get; set; }
        public string ContactInfo { get; set; }

        public virtual List<Employee>? Employees { get; set; } = new();
        public virtual List<Training> Trainings { get; set; } = new();

        public Department() { }
        public Department(string name, Branch branch, Address address, string contactInfo)
        {
            Name = name;
            Branch = branch;
            Address = address;
            ContactInfo = contactInfo;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Branch: {Branch.Name}, Address: {Address.Country}/{Address.City}/{Address.Street}/{Address.BuildingNumber}, Contact info: {ContactInfo}";
        }
    }
}
