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
        public Guid IdVisita { get; set; }
        public Guid IdPaciente { get; set; }
        public Guid IdTriage { get; set; }
        public Guid IdEspecialidad { get; set; }    
        public DateTime FechaHoraIngreso { get; set; }
        public DateTime? FechaHoraAusente { get; set; }
        public EstadoVisita Estado { get; set; } 
        public GrupoRiesgo GrupoRiesgo { get; set; }

        // Propiedad de navegación para el paciente
        public Paciente Paciente { get; set; }

        public Visita()
        {
            Estado = EstadoVisita.EsperandoTriage;
        }

    }
}
