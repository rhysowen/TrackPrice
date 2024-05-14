using System.Net.Mail;
using TrackPrice.Infrastructure.Dtos;

namespace TrackPrice.Infrastructure;

public class SmtpClientWrapper : ISmtpClient
{
    private readonly SmtpClient _smtpClient;

    public SmtpClientWrapper(SmtpClient smtpClient)
    {
        _smtpClient = smtpClient;
    }

    public async Task SendMailAsync(MailMessageDTO mailMessageDTO)
    {
        var message = new MailMessage(
            mailMessageDTO.From,
            mailMessageDTO.To,
            mailMessageDTO.Subject,
            mailMessageDTO.Body
        );

        await _smtpClient.SendMailAsync(message);
    }
}