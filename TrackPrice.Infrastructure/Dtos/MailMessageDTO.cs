namespace TrackPrice.Infrastructure.Dtos;

public record MailMessageDTO(string From, string To, string Subject, string Body);
