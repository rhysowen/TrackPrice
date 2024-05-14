using TrackPrice.Infrastructure;

namespace TrackPrice.Application;

public class AlertSubscriptionService(IEmailService emailService) : IAlertSubscriptionService
{
    private readonly IEmailService _emailService = emailService;

    public async Task CreateAlertSubscriptionAsync(string email, string productUrl, decimal targetPrice)
    {
        await Task.CompletedTask;
    }

    public async Task CheckPriceAndSendAlertsAsync()
    {
        await _emailService.SendMailAsync("contact@rhysowen.me");
    }
}