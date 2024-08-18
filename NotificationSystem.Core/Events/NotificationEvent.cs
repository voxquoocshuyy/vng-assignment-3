using MediatR;
using NotificationSystem.Core.Models;

namespace NotificationSystem.Core.Events;

public class NotificationEvent : INotification
{
    public NotificationMessage Message { get; set; }

    public NotificationEvent(NotificationMessage message)
    {
        Message = message;
    }
}