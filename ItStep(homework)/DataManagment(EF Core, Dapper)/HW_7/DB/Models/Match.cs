namespace DB.Models;

public class Match
{
    public int Id { get; set; }
    public string Team1 { get; set; }
    public string Team2 { get; set; }
    public int GoalsTeam1 { get; set; }
    public int GoalsTeam2 { get; set; }
    public DateTime MatchDate { get; set; }
}