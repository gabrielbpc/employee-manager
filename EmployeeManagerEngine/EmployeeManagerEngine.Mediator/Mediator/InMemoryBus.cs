using MediatR;
using System.Threading.Tasks;

namespace EmployeeManagerEngine.Mediator
{
    public class InMemoryBus : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public InMemoryBus(IMediator mediator) => _mediator = mediator;
        
        public Task<TResponse> SendCommand<TCommand, TResponse>(TCommand command) where TCommand : Command<TResponse>
        {
            return _mediator.Send(command);
        }

        public Task RaiseEvent<T>(T @event) //where T : Event
        {
            return _mediator.Publish(@event);
        }
    }
}
