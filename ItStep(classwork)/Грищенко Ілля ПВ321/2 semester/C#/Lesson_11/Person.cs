using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    public record Person(string FirstName, string LastName, int Age);

    public static class PersonExtansions
    {
        public static Person GetMaxAge(this Person[] persons)
        {
            Array.IndexOf(persons.Max(Item => Item.Age));
        }
    }
}
