using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Patente
    {
        public int idPatente { get; set; } // Identificador único del permiso.
        public string nombre { get; set; } // Nombre del permiso, como "Acceso a Historias Clínicas".

        // Constructor para inicializar una Patente
        public Patente(int idPatente, string nombre)
        {
        }

        // Constructor vacío
        public Patente()
        {
        }
    }
}
