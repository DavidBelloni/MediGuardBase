using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Turno
    {
        public Guid idTurno { get; set; }
        public DateTime fechaHora { get; set; }
        public string prefijo { get; set; }
        public int numeroTurno { get; set; }
        public Visita visita { get; set; }
    }
}
