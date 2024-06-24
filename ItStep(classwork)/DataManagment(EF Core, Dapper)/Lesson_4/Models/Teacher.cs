using Microsoft.Identity.Client;

namespace Lesson_4.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Course>? Courses { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, First name: {FirstName}, Last name: {LastName}, Department: {Department.Name}";
        }
    }
}
