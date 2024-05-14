namespace TrackPrice.Application;

public interface IAlertSubscriptionService
{
    Task CreateAlertSubscriptionAsync(string email, string productUrl, decimal targetPrice);
    Task CheckPriceAndSendAlertsAsync();
}