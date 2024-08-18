using MediatR;
using NotificationSystem.Core.Events;

namespace NotificationSystem.Core.Handlers;

public class NotificationEventHandler : INotificationHandler<NotificationEvent>
{
    public Task Handle(NotificationEvent notificationEvent, CancellationToken cancellationToken)
    {
        // Handle the notification
        Console.WriteLine($"Notification Received: {notificationEvent.Message.Title}");
        return Task.CompletedTask;
    }
}