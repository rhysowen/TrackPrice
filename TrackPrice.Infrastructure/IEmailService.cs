namespace TrackPrice.Infrastructure;

public interface IEmailService
{
    Task SendMailAsync(string email);
}