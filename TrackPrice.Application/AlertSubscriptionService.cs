namespace TrackPrice.Application;

public class AlertSubscriptionService : IAlertSubscriptionService
{
    public async Task CreateAlertSubscriptionAsync(string email, string productUrl, decimal targetPrice)
    {
        await Task.CompletedTask;
    }

    public async Task CheckPriceAndSendAlertsAsync()
    {
        await Task.CompletedTask;
    }
}