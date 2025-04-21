using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DOMAIN.Enums;

namespace DOMAIN
{
    public class Visita
    {
        public int idVisita { get; set; }
        public int idPaciente { get; set; }
        public DateTime fechaHoraIngreso { get; set; }
        public DateTime fechahoraAusente { get; set; }
        public EstadoVisita estadoVisita { get; set; } 
      



    }
}
