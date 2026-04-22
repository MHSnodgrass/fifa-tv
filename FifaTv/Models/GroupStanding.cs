namespace FifaTv.Models;

public class GroupStanding
{
    public string Group { get; set; } = string.Empty;
    public List<TeamStandingEntry> Teams { get; set; } = [];
}

public class TeamStandingEntry
{
    public Team? Team { get; set; }
    public int Points { get; set; }
    public int Played { get; set; }
    public int Won { get; set; }
    public int Drawn { get; set; }
    public int Lost { get; set; }
    public int GoalsFor { get; set; }
    public int GoalsAgainst { get; set; }
    public int GoalDifference { get; set; }
}