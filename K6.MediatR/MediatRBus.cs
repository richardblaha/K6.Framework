using K6.Application;

using MediatR;

namespace K6.MediatR;

public class MediatRBus(
    IMediator mediator
) : IBus
{
    public Task QueueAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : class, ICommand
    {
        throw new NotImplementedException();
    }

    public async Task ExecuteAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : class, ICommand
    {
        await mediator.Send(new CommandRequest<TCommand>(command), cancellationToken);
    }

    public async Task<TCommandResult> ExecuteAsync<TCommand, TCommandResult>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : class, ICommand<TCommandResult>
        where TCommandResult : class
    {
        return await mediator.Send(new CommandRequest<TCommand, TCommandResult>(command), cancellationToken);
    }

    public async Task<TQueryResult> QueryAsync<TQuery, TQueryResult>(TQuery query, CancellationToken cancellationToken = default)
        where TQuery : class, IQuery<TQueryResult>
        where TQueryResult : class
    {
        return await mediator.Send(new QueryRequest<TQuery, TQueryResult>(query), cancellationToken);
    }

    public async Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default)
        where TEvent : class, IEvent
    {
        await mediator.Publish(new EventNotification<TEvent>(@event), cancellationToken);
    }
}