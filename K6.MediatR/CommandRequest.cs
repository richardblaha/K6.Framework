using K6.Application;

using MediatR;

namespace K6.MediatR;

public class CommandRequest<TCommand>(TCommand command)
    : IRequest
    where TCommand : ICommand
{
    public TCommand Command { get; set; } = command;
}

public class CommandRequest<TCommand, TResult>(TCommand command)
    : IRequest<TResult>
    where TCommand : ICommand<TResult>
{
    public TCommand Command { get; set; } = command;
}