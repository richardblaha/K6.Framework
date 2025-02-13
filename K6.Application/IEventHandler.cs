namespace K6.Application;

public interface IEventHandler<in TEvent>
    where TEvent : IEvent
{
    Task HandleAsync(TEvent @event, CancellationToken cancellationToken);
}