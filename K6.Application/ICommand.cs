namespace K6.Application;

public interface ICommand
{
}

public interface ICommand<TCommandResult> : ICommand
{
}