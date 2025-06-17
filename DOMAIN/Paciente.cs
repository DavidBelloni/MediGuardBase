using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DOMAIN.Enums;

namespace DOMAIN
{
    public class Paciente
    {
        public Guid IdPaciente { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public int NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public Sexo Sexo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string CoberturaMedica { get; set; }
        public TipoCobertura TipoCobertura { get; set; }
        public DateTime FechaCreacion { get; set; }

        public Paciente()
        {
        }
    }
}
