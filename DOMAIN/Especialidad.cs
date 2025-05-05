using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DOMAIN.Enums;

namespace DOMAIN
{
    public class Especialidad
    {
        public Guid idEspecialidad { get; set; }
        public TipoEspecialidad tipo { get; set; }
        public string descripcion { get; set; }
        public string prefijo { get; set; }

    }
}
