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
        public Guid IdEspecialidad { get; set; }
        public string Nombre { get; set; }
        public string Prefijo { get; set; }

    }
}
