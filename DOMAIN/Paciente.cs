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
        public Guid idPaciente { get; set; }
        public TipoDocumento tipoDocumento { get; set; }
        public int numeroDocumento { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public Sexo sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string coberturaMedica { get; set; }
        public TipoCobertura tipoCobertura { get; set; }
        public DateTime fechaCreacion { get; set; }

        public Paciente()
        {
        }

        public bool Any()
        {
            throw new NotImplementedException();
        }
    }
}
