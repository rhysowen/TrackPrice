using TrackPrice.Infrastructure.Dtos;

namespace TrackPrice.Infrastructure;

public class EmailService(ISmtpClient smtpClient) : IEmailService
{
    private readonly ISmtpClient _smtpClient = smtpClient;

    public async Task SendMailAsync(string email)
    {
        var mailMessage = new MailMessageDTO("noreply@rhysowen.me", email, "Test Subject", "Test Body");

        // Send the email using the injected SMTP client
        await _smtpClient.SendMailAsync(mailMessage);
    }
}