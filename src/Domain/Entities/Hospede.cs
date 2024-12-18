using Domain.Entities.Base;

namespace Domain.Entities
{
    public class Hospede : EntityBase
    {
        public Hospede()
        {
            
        }
        public string? Nome { get; private set; }
        public string? Documento { get; private set; }
        public int DataNascimento { get; private set; }
        public ICollection<Reserva>? Reservas { get; private set; }

        public Hospede(string? nome, string? documento, int dataNascimento)
        {
            Nome = nome;
            Documento = documento;
            DataNascimento = dataNascimento;

            Reservas = new List<Reserva>();
        }

    }
}
