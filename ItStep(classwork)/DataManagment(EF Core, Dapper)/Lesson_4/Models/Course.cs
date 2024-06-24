namespace Lesson_4.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual ICollection<Student>? Students { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Teacher: {Teacher.FirstName} {Teacher.LastName}";
        }
    }
}
