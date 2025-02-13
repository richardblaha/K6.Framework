using K6.Application;

using MediatR;

namespace K6.MediatR;

public class EventNotification<TEvent>(TEvent @event)
    : INotification
    where TEvent : IEvent
{
    public TEvent Event { get; set; } = @event;
}