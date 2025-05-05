using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DOMAIN.Enums;

namespace DOMAIN
{
    public class Triage
    {
        public Guid idTriage { get; set; }
        public string motivoVisita { get; set; }
        public NivelUrgencia nivelUrgencia { get; set; }
        public string observaciones { get; set; }
        public TipoEspecialidad especialidad { get; set; }
        public float temperatura { get; set; }
        public int frecuenciaCardiaca { get; set; }
        public string presionArterial { get; set; }
        public float saturacionOxigeno { get; set; }
        public DateTime fechaHoraTriage { get; set; }

        public Visita Visita { get; set; }
        public Triage()
        {
        }
    }
}
