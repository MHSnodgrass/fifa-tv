namespace FifaTv.Models;

public class MatchEvent
{
    public int Id { get; set; }
    public int MatchNumber { get; set; }
    public string Stage { get; set; } = string.Empty;
    public string? GroupLetter { get; set; }
    public Team? HomeTeam { get; set; }
    public Team? AwayTeam { get; set; }
    public string? HomeTeamPlaceholder { get; set; }
    public string? AwayTeamPlaceholder { get; set; }
    public string? MatchDate { get; set; }
    public string? KickoffTime { get; set; }
    public string? ArenaName { get; set; }
    public string? City { get; set; }
    public string Status { get; set; } = string.Empty;
    public int? HomeScore { get; set; }
    public int? AwayScore { get; set; }
    // Java Api uses the wrapper Boolean for isDraw, meaning it can be null
    public bool? IsDraw { get; set; }
    public bool HasExtraTime { get; set; }
    public bool HasPenalties { get; set; }
}