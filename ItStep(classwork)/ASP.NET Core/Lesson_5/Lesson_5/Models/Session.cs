namespace Lesson_5.Models;

public class Session
{
    public uint TicketsCount { get; set; }
    public Film Film { get; set; }
    public DateTime DateTime { get; set; }
    
    public Session() {}

    public Session(uint ticketsCount, Film film, DateTime dateTime)
    {
        TicketsCount = ticketsCount;
        Film = film;
        DateTime = dateTime;
    }

    public override string ToString()
        => $"Tickets count: {TicketsCount}, Date time: {DateTime}";
}