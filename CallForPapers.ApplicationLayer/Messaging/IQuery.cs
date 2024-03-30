using MediatR;

namespace CallForPapers.ApplicationLayer.Messaging;
internal interface IQuery : IRequest
{
}
internal interface IQuery<out TResponse> : IRequest<TResponse>
{ }

internal interface IQueryHandler<in TQuery, TResponse>
    : IRequestHandler<TQuery, TResponse>
    where TQuery : IQuery<TResponse>
{
}