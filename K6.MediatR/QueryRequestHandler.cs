using K6.Application;

using MediatR;

using Microsoft.Extensions.DependencyInjection;

namespace K6.MediatR;

public class QueryRequestHandler<TQuery, TResult>(IServiceProvider serviceProvider) : IRequestHandler<QueryRequest<TQuery, TResult>, TResult>
    where TQuery : IQuery<TResult>
{
    public async Task<TResult> Handle(QueryRequest<TQuery, TResult> request, CancellationToken cancellationToken)
    {
        var queryHandler = serviceProvider.GetRequiredService<IQueryHandler<TQuery, TResult>>();
        return await queryHandler.HandleAsync(request.Query, cancellationToken);
    }
}