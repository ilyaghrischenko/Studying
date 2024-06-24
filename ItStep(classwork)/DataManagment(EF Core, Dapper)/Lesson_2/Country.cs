using System;
using System.Collections.Generic;

namespace Lesson_2;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public double Area { get; set; }

    public string WorldPart { get; set; } = null!;

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, Area: {Area}, WorldPart: {WorldPart}";
    }
}
