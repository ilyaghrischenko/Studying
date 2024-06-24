namespace DB.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CityId { get; set; }
        public int WinCount { get; set; }
        public int DrawCount { get; set; }
        public int GoalsCount { get; set; }
        public int GoalsConcededCount { get; set; }

        public override string ToString()
        => $"Name: {Name}, City id: {CityId}, " +
           $"Win count: {WinCount}, Draw count: {DrawCount}, " +
           $"Goals count: {GoalsCount}, Goals conceded count: {GoalsConcededCount}";
    }
}
