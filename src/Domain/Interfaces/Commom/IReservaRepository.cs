using Domain.Entities;
using Domain.Interfaces.Commom.Base;

namespace Domain.Interfaces.Commom
{
    public interface IReservaRepository : IRepository<Reserva>
    {
        Task<IEnumerable<Reserva>> GetReservaPorHospede(int idHospede);
        Task<IEnumerable<Reserva>> GetReservaPorPeriodo(DateTime inicio, DateTime fim);
    }
}
