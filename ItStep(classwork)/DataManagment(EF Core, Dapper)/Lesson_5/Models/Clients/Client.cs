namespace Lesson_5.Models.Client
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public uint Age { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Email: {Email}, Phone number: {PhoneNumber}";
        }
    }
}
