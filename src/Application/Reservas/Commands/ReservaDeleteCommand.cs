using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Reservas.Commands
{
    public class ReservaDeleteCommand : ReservaCommand
    {
        public long Id { get; set; }

        public ReservaDeleteCommand(long id)
        {
            Id = id;
        }
    }
}
