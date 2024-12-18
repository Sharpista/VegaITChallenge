using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class AppReservasContext : DbContext
    {
        public AppReservasContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Hospede> Hospedes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
