using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase.Models
{
    public enum MeetingType
    {
        Online,
        Offline
    }

    public class Training
    {
        public int Id { get; set; }
        [InverseProperty("TrainingList")]
        public Instructor Instructor { get; set; }
        public string Title { get; set; }
        public MeetingType Type { get; set; }
        public DateTime TrainingDateTime { get; set; }

        public virtual List<Employee>? Employees { get; set; } = new();

        public Training() { }
        public Training(Instructor instructor, string title, MeetingType type, DateTime trainingDateTime)
        {
            Instructor = instructor;
            Title = title;
            Type = type;
            TrainingDateTime = trainingDateTime;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Instructor: {Instructor.Name}, Title: {Title}, Type: {Type}, Training date time: {TrainingDateTime}";
        }
    }
}
