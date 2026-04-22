using FifaTv.Models;

namespace FifaTv.Services;

public class LiveScoreState
{
    private List<MatchEvent> _liveMatches = [];

    public IReadOnlyList<MatchEvent> LiveMatches => _liveMatches;

    public event Action? OnMatchesUpdated;

    public void UpdateMatches(List<MatchEvent> matches)
    {
        _liveMatches = matches;
        OnMatchesUpdated?.Invoke();
    }
}