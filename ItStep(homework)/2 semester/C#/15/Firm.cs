using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_15
{
    public record Firm
    {
        public string Name { get; set; } = "NoName";
        public DateTime FoundingDate { get; set; } = DateTime.Now;
        public string BusinessProfile { get; set; } = "NoBusinessProfile";
        public string DirectorPib { get; set; } = "NoDirectorPib";
        public uint WorkerKilk { get; set; } = 0;
        public string Address { get; set; } = "NoAddress";
        public List<Worker> Workers { get; set; } = new();

        public override string ToString()
        {
            string result = $"[Name]: {Name}, [Founding date]: {FoundingDate}, [Business profile]: {BusinessProfile}\n[Director pib]: {DirectorPib}, [Worker kilk]: {WorkerKilk}, [Address]: {Address}\nWorkers:\n";
            Workers
                   .ForEach(x => result += x.ToString());
            return result;
        }
    }
}
