using MediatR;
using NotificationSystem.Core.Events;
using NotificationSystem.Core.Models;

namespace NotificationSystem.Core.Publishers;

public class NotificationPublisher
{
    private readonly IMediator _mediator;

    public NotificationPublisher(IMediator mediator)
    {
        _mediator = mediator;
    }

    public async Task PublishNotification(NotificationMessage message)
    {
        var notificationEvent = new NotificationEvent(message);
        await _mediator.Publish(notificationEvent);
    }
}