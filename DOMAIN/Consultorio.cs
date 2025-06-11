using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DOMAIN.Enums;

namespace DOMAIN
{
    public class Consultorio
    {
        public Guid idConsultorio { get; set; }
        public TipoEspecialidad especialidad { get; set; }
        public string nombre { get; set; }
        public bool estado { get; set; }
        public int numero { get; set; }
    }
}
