namespace K6.Application;

public interface ICommandHandler<in TCommand>
    where TCommand : ICommand
{
    Task HandleAsync(TCommand command, CancellationToken cancellationToken = default);
}

public interface ICommandHandler<in TCommand, TCommandResult>
    where TCommand : ICommand<TCommandResult>
{
    Task<TCommandResult> HandleAsync(TCommand command, CancellationToken cancellationToken = default);
}