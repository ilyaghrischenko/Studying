using Lesson_5.Models.Personal;

namespace Lesson_5.Models.Data
{
    public class Call
    {
        public int Id { get; set; }
        public Consultant Consultant { get; set; }
        public Client.Client Client { get; set; }
        public DateTime CallTime { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nConsultant: {Consultant.FirstName} {Consultant.LastName}\nClient: {Client}\nCall time: {CallTime}";
        }
    }
}
