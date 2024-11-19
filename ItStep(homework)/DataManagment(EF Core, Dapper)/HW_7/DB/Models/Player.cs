namespace DB.Models;

public class Player
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string Country { get; set; }
    public int PlayerNumber { get; set; }
    public string Position { get; set; }
}