using System.Threading.Tasks;

namespace EmployeeManagerEngine.Mediator
{
    public interface IMediatorHandler
    {
        Task<TResponse> SendCommand<TCommand, TResponse>(TCommand command) where TCommand : Command<TResponse>;
        Task RaiseEvent<T>(T @event);
    }
}
