namespace DataBase.Models
{
    public class Instructor : Employee
    {
        public uint QualificationLevel { get; set; }

        public virtual List<Training>? TrainingList { get; set; } = new();

        public Instructor() { }
        public Instructor(string name, string position, DateOnly hireDate, string contactInfo, uint qualificationLevel, Department department, Training? training = null)
            : base(name, position, hireDate, contactInfo, department)
        {
            QualificationLevel = qualificationLevel;
        }

        public override string ToString()
        {
            return base.ToString() + $", Qualification level: {QualificationLevel}";
        }
    }
}
