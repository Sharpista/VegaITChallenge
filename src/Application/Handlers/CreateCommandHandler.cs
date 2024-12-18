using Application.Commands;
using Domain.Interfaces.Commom.Base;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Handlers
{
    public class CreateCommandHandler<T> : IRequestHandler<Command<T>, T> where T : class
    {
        private readonly IRepository<T> _repository;
        private readonly ILogger<CreateCommandHandler<T>> _logger;
        public CreateCommandHandler(IRepository<T> repository, ILogger<CreateCommandHandler<T>> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public Task<T> Handle(Command<T> request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
