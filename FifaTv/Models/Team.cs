namespace FifaTv.Models;

public class Team
{
    public int Id { get; set; }
    public string CountryName { get; set; } = string.Empty;
    public string CountryCode { get; set; } = string.Empty;
    public string GroupLetter { get; set; } = string.Empty;
    public int FifaRanking { get; set; }
    public string? ManagerName { get; set; }
    public string? FlagUrl { get; set; }
    public string? LogoUrl { get; set; }
    public TeamStats? Stats { get; set; }
}