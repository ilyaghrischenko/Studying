using Lesson_5.Models.Data;

namespace Lesson_5.Models.Personal
{
    public class Consultant : Personal
    {
        public List<Call>? Calls { get; set; }

        public Consultant(string firstName, string lastName, uint age) : base(firstName, lastName, age) { }

        public override string ToString()
        {
            var result = base.ToString();
            if (Calls != null)
            {
                result += "\nCalls:\n";
                Calls.ForEach(x => result += x + "\n");
            }
            return result;
        }
    }
}