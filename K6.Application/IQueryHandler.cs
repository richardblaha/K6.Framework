namespace K6.Application;

public interface IQueryHandler<TQuery, TQueryResult>
    where TQuery : IQuery<TQueryResult>
{
    Task<TQueryResult> HandleAsync(TQuery query, CancellationToken cancellationToken = default);
}