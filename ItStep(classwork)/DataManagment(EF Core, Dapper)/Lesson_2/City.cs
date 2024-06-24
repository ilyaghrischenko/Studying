using System;
using System.Collections.Generic;

namespace Lesson_2;

public partial class City
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public bool IsCapital { get; set; }
    public int InhabitansCount { get; set; }
    public int CountryId { get; set; }

    public virtual Country Country { get; set; } = null!;

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}, IsCapital: {IsCapital}, InhabitansCount: {InhabitansCount}, CountryId: {CountryId}";
    }
}
