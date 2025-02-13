namespace K6.Application;

public interface IBus
{
    /// <summary>
    /// Queue a command to be executed in background.
    /// </summary>
    /// <param name="command"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TCommand"></typeparam>
    /// <returns></returns>
    Task QueueAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : class, ICommand;

    /// <summary>
    /// Execute a command immediately.
    /// </summary>
    /// <param name="command"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TCommand"></typeparam>
    /// <returns></returns>
    Task ExecuteAsync<TCommand>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : class, ICommand;

    /// <summary>
    /// Execute a command immediately and return a result.
    /// </summary>
    /// <param name="command"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TCommand"></typeparam>
    /// <typeparam name="TCommandResult"></typeparam>
    /// <returns></returns>
    Task<TCommandResult> ExecuteAsync<TCommand, TCommandResult>(TCommand command, CancellationToken cancellationToken = default)
        where TCommand : class, ICommand<TCommandResult>
        where TCommandResult : class;

    /// <summary>
    /// Query a query and return a result.
    /// </summary>
    /// <param name="query"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TQuery"></typeparam>
    /// <typeparam name="TQueryResult"></typeparam>
    /// <returns></returns>
    Task<TQueryResult> QueryAsync<TQuery, TQueryResult>(TQuery query, CancellationToken cancellationToken = default)
        where TQuery : class, IQuery<TQueryResult>
        where TQueryResult : class;

    /// <summary>
    /// Publish an event.
    /// </summary>
    /// <param name="event"></param>
    /// <param name="cancellationToken"></param>
    /// <typeparam name="TEvent"></typeparam>
    /// <returns></returns>
    Task PublishAsync<TEvent>(TEvent @event, CancellationToken cancellationToken = default)
        where TEvent : class, IEvent;
}