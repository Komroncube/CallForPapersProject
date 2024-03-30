using MediatR;

namespace CallForPapers.ApplicationLayer.Messaging;
internal interface ICommand<out TResponse> : IRequest<TResponse>
{
}
internal interface ICommandHandler<in TCommand, TResponse>
    : IRequestHandler<TCommand, TResponse>
    where TCommand : ICommand<TResponse>
{ }
