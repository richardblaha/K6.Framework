using K6.Application;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace K6.MediatR;

public class CommandRequestHandler<TCommand>(
    IServiceProvider serviceProvider
) : IRequestHandler<CommandRequest<TCommand>>
    where TCommand : ICommand
{
    public async Task Handle(CommandRequest<TCommand> request, CancellationToken cancellationToken)
    {
        var commandHandler = serviceProvider.GetRequiredService<ICommandHandler<TCommand>>();
        await commandHandler.HandleAsync(request.Command, cancellationToken);
    }
}

public class CommandRequestHandler<TCommand, TResult>(
    IServiceProvider serviceProvider
) : IRequestHandler<CommandRequest<TCommand, TResult>, TResult>
    where TCommand : ICommand<TResult>
{
    public async Task<TResult> Handle(CommandRequest<TCommand, TResult> request, CancellationToken cancellationToken)
    {
        var commandHandler = serviceProvider.GetRequiredService<ICommandHandler<TCommand, TResult>>();
        return await commandHandler.HandleAsync(request.Command, cancellationToken);
    }
}