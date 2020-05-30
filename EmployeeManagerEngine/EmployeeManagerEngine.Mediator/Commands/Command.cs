using MediatR;

namespace EmployeeManagerEngine.Mediator
{
    public class Command<TResponse> : IRequest<TResponse>
    {
    }
}
