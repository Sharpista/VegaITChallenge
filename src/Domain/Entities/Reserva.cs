using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Reserva : EntityBase
    {
        public Reserva()
        {
            
        }
        public long NumeroReserva { get; private set; }
        public DateTime Checkin { get; private set; }
        public DateTime Checkout { get; private set; }
        public string StatusReserva { get; private set; }
        public bool Ativa { get; private set; }
        public DateTime PeriodoDe { get; private set; }
        public DateTime PeriodoAte { get; private set; }
    }
}
