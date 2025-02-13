using K6.Application;

using MediatR;

namespace K6.MediatR;

public class QueryRequest<TQuery, TResult>(TQuery query)
    : IRequest<TResult>
    where TQuery : IQuery<TResult>
{
    public TQuery Query { get; set; } = query;
}