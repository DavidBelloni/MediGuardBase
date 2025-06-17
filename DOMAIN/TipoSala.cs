using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class TipoSala
    {
        public Guid IdTipoSala { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool EstaActiva { get; set; }

        public TipoSala(string nombre, string descripcion)
        {
            IdTipoSala = Guid.NewGuid();
            Nombre = nombre;
            Descripcion = descripcion;
            EstaActiva = true;
        }
    }
}
