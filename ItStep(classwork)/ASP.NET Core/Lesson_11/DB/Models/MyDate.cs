namespace DB.Models;

public class MyDate(DateOnly date)
{
    public int Id { get; set; }
    public DateOnly Date { get; set; } = date;
    public virtual ICollection<MyTask> Tasks { get; set; } = new List<MyTask>();

    public override string ToString()
        => $"{Date}";
}