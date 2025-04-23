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
        public Guid idVisita { get; set; }
        public Paciente paciente { get; set; }
        public Triage triage { get; set; }
        public Guid idEspecialidad { get; set; }    
        public DateTime fechaHoraIngreso { get; set; }
        public DateTime? fechahoraAusente { get; set; }
        public EstadoVisita estadoVisita { get; set; } 
        public GrupoRiesgo grupoRiesgo { get; set; }
     
        public Visita()
        {
            estadoVisita = EstadoVisita.EsperandoTriage;
        }



    }
}
