using TrackPrice.Infrastructure.Dtos;

namespace TrackPrice.Infrastructure;

public interface ISmtpClient
{
    Task SendMailAsync(MailMessageDTO mailMessage);
}
