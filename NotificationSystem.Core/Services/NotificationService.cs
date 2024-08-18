using NotificationSystem.Core.Models;
using NotificationSystem.Core.Publishers;

namespace NotificationSystem.Core.Services;

public class NotificationService
{
    private readonly NotificationPublisher _publisher;

    public NotificationService(NotificationPublisher publisher)
    {
        _publisher = publisher;
    }

    public async Task SendNotificationAsync(string title, string content)
    {
        var message = new NotificationMessage
        {
            Title = title,
            Content = content,
            Timestamp = DateTime.UtcNow
        };

        await _publisher.PublishNotification(message);
    }
}