using K6.Application;

using MassTransit;

using IBus = K6.Application.IBus;
using IMassTransitBus = MassTransit.IBus;

namespace K6.MassTransit;

public class MassTransitBus(
    IMassTransitBus bus
) : IBus
{
    public async Task QueueAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : class, ICommand
    {
        await bus.Send(command, cancellationToken);
    }

    public async Task ExecuteAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : class, ICommand
    {
        await bus.Send(command, cancellationToken);
    }

    public async Task<TCommandResult> ExecuteAsync<TCommand, TCommandResult>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : class, ICommand<TCommandResult>
        where TCommandResult : class
    {
        var response = await bus.Request<TCommand, TCommandResult>(command, cancellationToken);
        return response.Message;
    }

    public async Task<TQueryResult> QueryAsync<TQuery, TQueryResult>(TQuery query, CancellationToken cancellationToken = default)
        where TQuery : class, IQuery<TQueryResult>
        where TQueryResult : class
    {
        var response = await bus.Request<TQuery, TQueryResult>(query, cancellationToken);
        return response.Message;
    }

    public async Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default)
        where TEvent : class, IEvent
    {
        await bus.Publish(@event, cancellationToken);
    }
}