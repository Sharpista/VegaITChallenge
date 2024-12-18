using Domain.Entities;
using Domain.Interfaces.Commom;
using Infrastructure.Context;

namespace Infrastructure.Repositories
{
    public class HospedeRepository : Repository<Hospede>, IHospedeRepository
    {
        public HospedeRepository(AppReservasContext context) : base(context)
        {
        }
    }
}
