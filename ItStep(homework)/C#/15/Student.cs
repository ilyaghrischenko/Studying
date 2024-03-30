using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    public record Student
    {
        public string Name { get; set; } = "NoName";
        public string SurName { get; set; } = "NoSurName";
        public uint Age { get; set; } = 0;
        public string InstitutionName { get; set; } = "NoInstitutionName";

        public override string ToString()
        {
            return $"[Name]: {Name} [Surname]: {SurName} [Age]: {Age} [InstitutionName]: {InstitutionName}";
        }
    }
}
