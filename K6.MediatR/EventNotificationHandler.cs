using K6.Application;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace K6.MediatR;

public class EventNotificationHandler<TEvent>(IServiceProvider serviceProvider)
    : INotificationHandler<EventNotification<TEvent>>
    where TEvent : IEvent
{
    public async Task Handle(EventNotification<TEvent> notification, CancellationToken cancellationToken)
    {
        var eventHandler = serviceProvider.GetRequiredService<IEventHandler<TEvent>>();
        await eventHandler.HandleAsync(notification.Event, cancellationToken);
    }
}