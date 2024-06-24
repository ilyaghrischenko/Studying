namespace Lesson_5.Models.Personal
{
    public class Personal
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public uint Age { get; set; }

        public Personal(string firstName, string lastName, uint age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return $"Id: {Id}, First name: {FirstName}, Last name: {LastName}, Age: {Age}";
        }
    }
}
