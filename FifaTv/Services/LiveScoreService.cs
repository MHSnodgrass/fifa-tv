namespace FifaTv.Services;

public class LiveScoreService(IServiceScopeFactory scopeFactory, LiveScoreState state) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                using var scope = scopeFactory.CreateScope();
                var api = scope.ServiceProvider.GetRequiredService<FifaApiClient>();
                var matches = await api.GetMatchesByStatusAsync("IN_PROGRESS");
                state.UpdateMatches(matches);
            }
            catch
            {
                // Don't crash the background service on a transient API error
            }

            await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
        }
    }
}