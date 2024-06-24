namespace Lesson_4.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public uint BuildingNumber { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, City: {City}, Street: {Street}, Building number: {BuildingNumber}";
        }
    }
}
