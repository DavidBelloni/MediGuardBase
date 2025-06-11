using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class ConsultaMedica
    {
        public int IdConsultaMedica { get; set; }
        public Paciente paciente { get; set; }
        public Visita visita { get; set; }
        public string tratamiento { get; set; }
        public string diagnostico { get; set; }
        public string alergias { get; set; }    
        public DateTime fechaHoraInicio { get; set; }
        public DateTime? fechaHoraFin { get; set; }  

  

    }
}
