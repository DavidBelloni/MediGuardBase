using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DOMAIN.Enums;

namespace DOMAIN
{
    public class VisitaPacienteViewModel
    {
        //public Guid idPaciente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string numeroDocumento { get; set; }
        public Sexo sexo { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public GrupoRiesgo grupoRiesgo { get; set; }

        // Propiedad calculada para la edad
        public int Edad
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - fechaNacimiento.Year;
                if (fechaNacimiento > today.AddYears(-age)) age--; // Ajuste si no ha cumplido años este año
                return age;
            }
        }
    }
}
