using Moq;
using TrackPrice.Infrastructure;
using TrackPrice.Infrastructure.Dtos;
using Xunit;

namespace TrackPrice.Testing;

public class EmailServiceTests
{
    [Fact]
    public async Task SendMailAsync_CalledAtLeastOnce()
    {
        // Arrange
        var smtpClientMock = new Mock<ISmtpClient>();
        var emailService = new EmailService(smtpClientMock.Object);

        // Act
        await emailService.SendMailAsync("");

        // Assert
        smtpClientMock.Verify(
            c => c.SendMailAsync(It.IsAny<MailMessageDTO>()),
            Times.AtLeastOnce
        );
    }
}
