using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DOMAIN
{
    public abstract class Componente
    {
        public string Nombre { get; set; }
        public Componente(string nombre)
        {
            Nombre = nombre;
        }
        // Método para obtener todos los permisos individuales (Patentes)
        public abstract List<Patente> ObtenerPatentes();
    }
}
