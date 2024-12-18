using Domain.Entities;
using MediatR;

namespace Application.Reservas.Commands
{
    public abstract class ReservaCommand : IRequest<Reserva>
    {
        public long NumeroReserva { get; private set; }
        public DateTime Checkin { get; private set; }
        public DateTime Checkout { get; private set; }
        public string? StatusReserva { get; private set; }
        public bool Ativa { get; private set; }
    }
}
