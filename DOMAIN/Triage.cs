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
        public Guid IdTriage { get; set; }
        public string MotivoVisita { get; set; }
        public NivelUrgencia NivelTriage { get; set; }
        public string Observaciones { get; set; }
        public Guid EspecialidadAsignada { get; set; }
        public float Temperatura { get; set; }
        public int FrecuenciaCardiaca { get; set; }
        public string PresionArterial { get; set; }
        public float SaturacionOxigeno { get; set; }
        public DateTime FechaHoraTriage { get; set; }

        public Triage()
        {
        }
    }
}
