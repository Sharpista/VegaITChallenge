using MediatR;

namespace Application.Commands
{
    public class Command<T> : IRequest<T> where T : class
    {
    }
}
