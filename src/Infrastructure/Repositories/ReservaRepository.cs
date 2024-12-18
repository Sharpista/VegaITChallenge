using Domain.Entities;
using Domain.Interfaces.Commom;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class ReservaRepository : Repository<Reserva>, IReservaRepository
    {
        public ReservaRepository(AppReservasContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Reserva>> GetReservaPorHospede(int idHospede)
        {
            var contextoHospede = _dbContext.Hospedes;

            return (IEnumerable<Reserva>) await contextoHospede.Where(x => x.Id == idHospede).Select(x => x.Reservas).ToListAsync();
        }

        public async Task<IEnumerable<Reserva>> GetReservaPorPeriodo(DateTime inicio, DateTime fim)
        {
            return await _dbSet.Where(x => inicio >= x.Checkin && fim < x.Checkout).ToListAsync();
        }
    }
}
