namespace Lesson_4.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Teacher>? Teachers { get; set; }
        public virtual Address? Address { get; set; }

        public override string ToString()
        {
            string result = $"Id: {Id}, Name: {Name}";
            if (Address != null)
            {
                result += $", Address: ({Address})";
            }
            if (Teachers != null)
            {
                result += "\nTeachers:\n";
                Teachers
                    .ToList()
                    .ForEach(x => result += $"{x}\n");
            }
            return result;
        }
    }
}
