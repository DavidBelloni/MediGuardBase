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
        public Guid idPaciente { get; set; }
        public Guid idTriage { get; set; }
        public Guid idEspecialidad { get; set; }    
        public DateTime fechaHoraIngreso { get; set; }
        public DateTime? fechaHoraAusente { get; set; }
        public EstadoVisita estado { get; set; } 
        public GrupoRiesgo grupoRiesgo { get; set; }

        // Propiedad de navegación para el paciente
        public Paciente Paciente { get; set; }

        public Visita()
        {
            estado = EstadoVisita.EsperandoTriage;
        }

    }
}
