using System.Net.Http.Json;
using FifaTv.Models;

namespace FifaTv.Services;

public class FifaApiClient(HttpClient http)
{
    public async Task<List<MatchEvent>> GetMatchesByStatusAsync(string status)
        => await http.GetFromJsonAsync<List<MatchEvent>>($"/api/events/status/{status}") ?? [];

    public async Task<List<MatchEvent>> GetAllMatchesAsync()
        => await http.GetFromJsonAsync<List<MatchEvent>>("/api/events") ?? [];

    public async Task<List<MatchEvent>> GetMatchesByStageAsync(string stage)
        => await http.GetFromJsonAsync<List<MatchEvent>>($"/api/events/stage/{stage}") ?? [];

    public async Task<List<Team>> GetAllTeamsAsync()
        => await http.GetFromJsonAsync<List<Team>>("/api/teams") ?? [];

    public async Task<List<GroupStanding>> GetGroupStandingsAsync()
        => await http.GetFromJsonAsync<List<GroupStanding>>("/api/standings/group") ?? [];
}